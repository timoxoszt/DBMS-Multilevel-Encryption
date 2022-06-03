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
    public partial class List_User : Form
    {
        public List_User()
        {

            Connect();
            InitializeComponent();
            LV_Data.Columns.Add("STT", 40);
            LV_Data.Columns.Add("Tên người dùng",165);
            LV_Data.Columns.Add("Số điện thoại", 140);           
        }

        public class Data
        {
            public string uuid { get; set; }
            public string ho_ten { get; set; }
            public string sdt { get; set; }
            public string dia_chi { get; set; }
            public string stk { get; set; }
            public string cmnd { get; set; }
            public string ngay_sinh { get; set; }
            public string email { get; set; }
            public string ngay_dk { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public List<Data> data { get; set; }
            public string message { get; set; }
        }
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        private void Connect()
        {
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/users");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }
        private void List_User_Load(object sender, EventArgs e)
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
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ho_ten);
                    ListViewItem.ListViewSubItem sodt = new ListViewItem.ListViewSubItem(item, data.sdt);
                    item.SubItems.Add(name);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(sodt);
                }
            }
        }
        private int intselectedindex;
        private void LV_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Data.SelectedIndices.Count > 0)
            {
                intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    int i = Int32.Parse(text);
                    txt_Name.Text = dataprofile.data[i - 1].ho_ten.ToString();
                    txt_Email.Text = dataprofile.data[i - 1].email.ToString();
                    txt_SDT.Text = dataprofile.data[i - 1].sdt.ToString();
                    txt_STK.Text = dataprofile.data[i - 1].stk.ToString();
                    txt_DiaChi.Text = dataprofile.data[i - 1].dia_chi.ToString();
                    txt_CMND.Text = dataprofile.data[i - 1].cmnd.ToString();
                    txt_Birth.Text = dataprofile.data[i - 1].ngay_sinh.ToString();
                    txt_NDK.Text = dataprofile.data[i - 1].ngay_dk.ToString();
                }
            }
            
        }
        
        private void Refreshing()
        {
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/users");
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
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.ho_ten);
                    ListViewItem.ListViewSubItem sodt = new ListViewItem.ListViewSubItem(item, data.sdt);
                    item.SubItems.Add(name);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(sodt);
                }
                dataStream.Close();
                response.Close();
            }
            request.Abort();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
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
                DateTime dateTime = DateTime.Parse(txt_Birth.Text);
                string ns = dateTime.ToString("yyyy/MM/dd");
                string s = "https://dbms-abe.f1301.cyou/api/users/" + dataprofile.data[i - 1].uuid.ToString();
                WebRequest request = WebRequest.Create(s);
                request.Headers["Authorization"] = "Bearer " + Login.token;
                request.PreAuthenticate = true;
                request.Method = "PUT";
                string postData = "ho_ten=" + txt_Name.Text
                                + "&stk=" + txt_STK.Text
                                + "&sdt=" + txt_SDT.Text
                                + "&cmnd=" + txt_CMND.Text
                                + "&dia_chi=" + txt_DiaChi.Text
                                + "&ngay_sinh=" + ns
                                + "&email=" + txt_Email.Text;
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
                MessageBox.Show("Chọn user cần sửa", "Thông báo");
            }
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
                string s = "https://dbms-abe.f1301.cyou/api/users/" + dataprofile.data[i - 1].uuid.ToString();
                var request = (HttpWebRequest)WebRequest.Create(s);
                request.Headers["Authorization"] = "Bearer " + Login.token;
                request.PreAuthenticate = true;
                request.Method = "DELETE";
                request.Accept = "*/*";
                response = request.GetResponse();
                HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                request.Abort();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Thông báo"); }
            Refreshing();
        }
    }
}
