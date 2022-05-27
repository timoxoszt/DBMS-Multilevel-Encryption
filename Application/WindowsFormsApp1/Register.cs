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
using System.Text.RegularExpressions;

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
        private bool check = false;
        private static bool isValidName(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z' ']+$");
        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private bool Valid()
        {
            if (IsValidEmail(txt_Email.Text)
                    && txt_Email.Text.Length <= 40
                    && txt_Email.Text.Length >= 11)
            {
                lb_EC.Text = "";
                check = true;
            }
            else
            {
                lb_EC.Text = "Không hợp lệ";
                check = false;
            }

            if (txt_MatKhau.Text.Length >= 8)
            {
                lb_PC.Text = "";
                check = true;
            }
            else
            {
                lb_PC.Text = "Không hợp lệ";
                check = false;
            }

            if (txt_MatKhau.Text == txt_XNMatKhau.Text)
            {
                check = true;
                lb_CPC.Text = "";
            }
            else
            {
                check = false;
                lb_CPC.Text = "Mật khẩu xác nhận không giống.";
            }

            if (isValidName(txt_HoVaTen.Text))
            {
                check = true;
                lb_NC.Text = "";
            }
            else
            {
                check = false;
                lb_NC.Text = "Không hợp lệ";
            }

            if (txt_SDT.Text.Length >= 10 && txt_SDT.Text.Length <= 11)
            {
                check = true;
                lb_PNC.Text = "";
            }
            else
            {
                check = false;
                lb_PNC.Text = "Không hợp lệ";
            }

            if (txt_SoChungMinh.Text.Length > 8 && txt_SoChungMinh.Text.Length <= 20)
            {
                check = true;
                lb_SCMC.Text = "";
            }
            else
            {
                check = false;
                lb_SCMC.Text = "Không hợp lệ";
            }
            if (check)
            {
                if (txt_STK.Text.Length > 9 && txt_STK.Text.Length <= 20)
                    lb_STKC.Text = "";
                else
                {
                    check = false;
                    lb_STKC.Text = "Không hợp lệ";
                }
            }
            else check = false;
            return check;
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
                        + "&stk=" + txt_STK.Text
                        + "&cmnd=" + txt_SoChungMinh.Text
                        + "&dia_chi=" + txt_DiaChi.Text
                        + "&ngay_sinh=2022/05/23" + selectDateAsString;
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
            if (Valid())
            {
                lbl_ThongBao.Text = "";
                // Get the response.
                try
                {
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
                catch (Exception) { lbl_ThongBao.Text = "Không thể kết nối đến server."; }
            }
        }
        private void Create_An_Accout_Load(object sender, EventArgs e)
        {
            txt_SoChungMinh.Text = "968573921";
            txt_HoVaTen.Text = "Do Xuan Long";
            txt_Email.Text = "long@gmail.co";
            txt_DiaChi.Text = "80/3 dia chi";
            txt_MatKhau.Text = "12345678";
            txt_SDT.Text = "0987677899";
            txt_STK.Text = "238475843573394";
            txt_XNMatKhau.Text = "12345678";
        }
    }
}
