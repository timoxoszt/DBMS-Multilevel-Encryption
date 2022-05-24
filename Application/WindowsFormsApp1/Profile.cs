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
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    public partial class Profile : Form
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
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
            public Data data { get; set; }
            public string message { get; set; }
        }


        public Profile()
        {
            Connect();
            InitializeComponent();
        }
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        public void Connect()
        {
            dataprofile = null;
            //phần request
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/profile");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }

        private void Profile_Load(object sender, EventArgs e)
        {            
            
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string datajson = reader.ReadToEnd();
                dataprofile = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datajson);
                txt_HoVaTen.Text = dataprofile.data.ho_ten.ToString();
                txt_Email.Text = dataprofile.data.email.ToString();
                txt_STK.Text = dataprofile.data.stk.ToString();
                txt_SoDienThoai.Text = dataprofile.data.sdt.ToString();
                txt_SoChungMinh.Text = dataprofile.data.cmnd.ToString();
                txt_DiaChi.Text = dataprofile.data.dia_chi.ToString();
                txt_NgaySinh.Text = dataprofile.data.ngay_sinh.ToString();
                txt_NgayDangKy.Text = dataprofile.data.ngay_dk.ToString();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            using (Stream dataStream = response.GetResponseStream())
            {

            }
        }
    }
}
