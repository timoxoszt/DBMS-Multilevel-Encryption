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
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/users");
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

        private void LV_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Data.SelectedIndices.Count > 0)
            {
                int intselectedindex = LV_Data.SelectedIndices[0];
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
    }
}
