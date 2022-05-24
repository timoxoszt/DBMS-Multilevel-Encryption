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
    public partial class Create_An_Accout : Form
    {
        public Create_An_Accout()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        public class Data
        {
            public string token { get; set; }
            public string ho_ten { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
        }
        private void InitializeMyControl()
        {
            // Set to no text.
            txt_MatKhau.Text = "";
            // The password character is an asterisk.
            txt_MatKhau.PasswordChar = '*';
            txt_XNMatKhau.Text = "";
            txt_XNMatKhau.PasswordChar = '*';
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string selectDateAsString = dateTimePicker1.Value.ToString("yyyyMMdd");

            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/register");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "email=" + txt_Email.Text
                        + "&password=" + txt_MatKhau.Text
                        + "&confirm_password=" + txt_XNMatKhau.Text
                        + "&ho_ten=" + txt_HoVaTen.Text
                        + "&sdt=" + txt_SDT.Text
                        + "&stk=" + txt_SoChungMinh.Text
                        + "&cmnd=" + txt_DiaChi.Text
                        + "&dia_chi=" + txt_STK.Text
                        + "&ngay_sinh=" + selectDateAsString;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            try
            {
                lbl_ThongBao.Text = "";
                // Get the response.
                WebResponse response = request.GetResponse();

                Root datajson = null;
                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    datajson = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(responseFromServer);

                    lbl_ThongBao.Text = "Đăng kí thành công.";
                    MessageBox.Show(datajson.data.ToString());

                }
                // Close the response.
                response.Close();
            }
            catch (Exception)
            {
                lbl_ThongBao.Text = "";
                lbl_ThongBao.Text = "Đăng kí không thành công.";
            }
        }
    }
}
