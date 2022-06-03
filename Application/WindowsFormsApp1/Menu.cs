using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
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
        public Menu()
        {
            Connect();
            InitializeComponent();
            LV_Data.Columns.Add("STT", 40);
            LV_Data.Columns.Add("Tên sản phẩm", 200);
            LV_Data.Columns.Add("Giá", 150);
        }
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        private void Connect()
        {
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/products");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            List_User p = new List_User();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_HH p = new List_HH();
            p.Show();  
        }

        private int intselectedindex;
        private int i;
        private void LV_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Data.SelectedIndices.Count > 0)
            {
                int intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    i = Int32.Parse(text);
                }
            }
        }
        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = dataprofile.data[i - 1].ma_sp.ToString();
                WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/orders");
                request.Headers["Authorization"] = "Bearer " + Login.token;
                request.PreAuthenticate = true;
                request.Method = "POST";
                string postData = "so_luong=" + txt_SL.Text
                                + "&ma_sp=" + masp;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                request.Abort();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn hàng cần đặt.","Thông báo");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lb_Name.Text = Login.name;
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
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ten_sp);
                    ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem(item, data.gia);
                    LV_Data.Items.Add(item);                    
                    item.SubItems.Add(name);
                    item.SubItems.Add(price);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill p = new Bill();
            p.Show();
        }
        
    }
}
