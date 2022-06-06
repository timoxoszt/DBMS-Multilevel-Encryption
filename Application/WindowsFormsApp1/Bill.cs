using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Bill : Form
    {
        public class Data
        {
            public string uuid { get; set; }
            public string user_uuid { get; set; }
            public string user_name { get; set; }
            public string ma_sp { get; set; }
            public string ten_sp { get; set; }
            public string so_luong { get; set; }
            public string gia { get; set; }
            public string ngay_dat { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public List<Data> data { get; set; }
            public string message { get; set; }
        }

        public Bill()
        {
            Connect();
            InitializeComponent();
            LV_Data.Columns.Add("STT", 40);
            LV_Data.Columns.Add("Tên sản phẩm", 150);
            LV_Data.Columns.Add("Giá", 100);
            LV_Data.Columns.Add("Số lượng", 100);
        }

        private void Refreshing()
        {
            ttp = 0;
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/my-bills");
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
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ten_sp);
                    ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem(item, data.gia);
                    ListViewItem.ListViewSubItem SL = new ListViewItem.ListViewSubItem(item, data.so_luong);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(name);
                    item.SubItems.Add(price);
                    item.SubItems.Add(SL);
                    int s = Int32.Parse(dataprofile.data[i - 1].gia.ToString());
                    int sl = Int32.Parse(dataprofile.data[i - 1].so_luong.ToString());
                    ttp = (s * sl) + ttp;
                }
                lb_TtPrice.Text = ttp.ToString();
            }
            request.Abort();
        }
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        private int i;
        private void Connect()
        {
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/my-bills");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }
        int ttp = 0;
        private void Bill_Load(object sender, EventArgs e)
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
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ten_sp);
                    ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem(item, data.gia);
                    ListViewItem.ListViewSubItem SL = new ListViewItem.ListViewSubItem(item, data.so_luong);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(name);
                    item.SubItems.Add(price);
                    item.SubItems.Add(SL);
                    int s = Int32.Parse(dataprofile.data[i - 1].gia.ToString());
                    int sl = Int32.Parse(dataprofile.data[i - 1].so_luong.ToString());
                    ttp = (s * sl) + ttp;
                }
                lb_TtPrice.Text = ttp.ToString();
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
                    i = Int32.Parse(text);

                    int s = Int32.Parse(dataprofile.data[i - 1].gia.ToString());
                    int sl = Int32.Parse(dataprofile.data[i - 1].so_luong.ToString());
                    int tt = s * sl;

                    txt_Name.Text = dataprofile.data[i - 1].ten_sp.ToString();
                    txt_Price.Text = dataprofile.data[i - 1].gia.ToString();
                    txt_SL.Text = dataprofile.data[i - 1].so_luong.ToString();
                    txt_TtPrice.Text = tt.ToString();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uuid = dataprofile.data[i - 1].uuid.ToString();
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/orders/" + uuid);
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            request.Method = "PUT";
            string postData = "ma_sp=" + dataprofile.data[i - 1].ma_sp.ToString()
                        + "&so_luong=" + txt_SL.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            int s = Int32.Parse(txt_Price.Text);
            int sl = Int32.Parse(txt_SL.Text);
            int tt = s * sl;
            txt_TtPrice.Text = tt.ToString();
            request.Abort();
            Refreshing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công.", "Thông báo");
        }
        private int intselectedindex;
        private void button2_Click(object sender, EventArgs e)
        {
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
            string s = "https://dbms-abe.f1301.cyou/api/orders/" + dataprofile.data[i - 1].uuid.ToString();
            var request = (HttpWebRequest)WebRequest.Create(s);
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            request.Method = "DELETE";
            request.Accept = "*/*";
            try
            {
                response = request.GetResponse();
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                request.Abort();
                Refreshing();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không phải là người sở hữu hóa đơn này.", "Thông báo");
            }
            Refreshing();
        }
    }
    
}
