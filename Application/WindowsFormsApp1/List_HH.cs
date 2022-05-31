using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class List_HH : Form
    {
        public List_HH()
        {
            Connect();
            InitializeComponent();
            LV_Data.Columns.Add("STT", 50);
            LV_Data.Columns.Add("Mã sản phẩm", 150);
            LV_Data.Columns.Add("Tên sản phẩm", 205);
        }
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        public class Data
        {
            public string ma_sp { get; set; }
            public string ten_sp { get; set; }
            public string dvt { get; set; }
            public string gia { get; set; }
            public object image { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public List<Data> data { get; set; }
            public string message { get; set; }
        }

        private void Connect()
        {
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/products");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }
        private void Refreshing()
        {
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/products");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
            LV_Data.Items.Clear();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string datajson = reader.ReadToEnd();
                dataprofile = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datajson);
                int i = 0;
                foreach (Data data in dataprofile.data)
                {
                    i++;
                    ListViewItem item = new ListViewItem(i.ToString());
                    ListViewItem.ListViewSubItem masp = new ListViewItem.ListViewSubItem(item, data.ma_sp);
                    ListViewItem.ListViewSubItem tensp = new ListViewItem.ListViewSubItem(item, data.ten_sp);
                    item.SubItems.Add(masp);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(tensp);
                }
                dataStream.Close();
                response.Close();
            }
            request.Abort();
        }

        private void List_HH_Load(object sender, EventArgs e)
        {
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string datajson = reader.ReadToEnd();
                dataprofile = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datajson);
                int i = 0;
                foreach (Data data in dataprofile.data)
                {
                    i++;
                    ListViewItem item = new ListViewItem(i.ToString());
                    ListViewItem.ListViewSubItem masp = new ListViewItem.ListViewSubItem(item, data.ma_sp);
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ten_sp);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(masp);
                    item.SubItems.Add(name);
                }
            }
        }

        private void LV_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Data.SelectedIndices.Count > 0)
            {
                int intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    int i = Int32.Parse(text);
                    txt_Name.Text = dataprofile.data[i - 1].ten_sp.ToString();
                    txt_ID.Text = dataprofile.data[i - 1].ma_sp.ToString();
                    txt_Price.Text = dataprofile.data[i - 1].gia.ToString();
                    txt_DVT.Text = dataprofile.data[i - 1].dvt.ToString();
                    Image B64TI = Base64ToImage(dataprofile.data[i - 1].image.ToString());
                    Image.SizeMode = PictureBoxSizeMode.StretchImage;
                    Image.Image = B64TI;
                }
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] buffer = Convert.FromBase64String(base64String);

            if (buffer != null)
            {
                ImageConverter ic = new ImageConverter();
                return ic.ConvertFrom(buffer) as Image;
            }
            else
                return null;
        }
        private int intselectedindex;
        string path;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
            }
            byte[] imageArray = System.IO.File.ReadAllBytes(@path);
            string base64Image = Convert.ToBase64String(imageArray);

            string postData = "ten_sp=" + txt_Name.Text
                            + "&dvt=" + txt_DVT.Text
                            + "&masp=" + txt_ID.Text
                            + "&gia=" + txt_Price.Text
                            + "&image=" + base64Image;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/products");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            // Set the Method property of the request to POST.
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            Refreshing();
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            response.Close();
            int i = 0;
            if (LV_Data.SelectedIndices.Count > 0)
            {
                intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    i = Int32.Parse(text);
                }
            }
            try
            {
                string s = "https://dbms-abe.f1301.cyou/api/products/" + dataprofile.data[i - 1].ma_sp.ToString();
                var request = (HttpWebRequest)WebRequest.Create(s);
                request.Headers["Authorization"] = "Bearer " + Login.token;
                request.PreAuthenticate = true;
                request.Method = "DELETE";
                request.Accept = "*/*";
                response = request.GetResponse();
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                request.Abort();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo"); }
            Refreshing();
        }
    }
}
