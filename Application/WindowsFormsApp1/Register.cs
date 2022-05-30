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
using System.Globalization;

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
        private int check = 0;
        private static bool isValidName(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z' ']+$");
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool Valid()
        {
            check = 0;
            if (IsValidEmail(txt_Email.Text)
                    && txt_Email.Text.Length <= 40
                    && txt_Email.Text.Length >= 11)
            {
                lb_EC.Text = "";
               // ++check;
            }
            else
            {
                lb_EC.Text = "Email không hợp lệ";
                check--;
            }

            if (txt_MatKhau.Text.Length >= 8)
            {
                lb_PC.Text = "";
               // ++check;
            }
            else
            {
                lb_PC.Text = "Phải nhập mật khẩu từ 8 kí tự trở lên";
                check--;
            }

            if (txt_MatKhau.Text == txt_XNMatKhau.Text)
            {
               // ++check;
                lb_CPC.Text = "";
            }
            else
            {
                check--;
                lb_CPC.Text = "Mật khẩu xác nhận không giống.";
            }

            //if (isValidName(txt_HoVaTen.Text))
                if(txt_HoVaTen.Text != "")
            {
               // ++check;
                lb_NC.Text = "";
            }
            else
            {
                check--;
                lb_NC.Text = "Họ và tên không hợp lệ";
            }

            if (txt_SDT.Text.Length >= 10 && txt_SDT.Text.Length <= 11)
            {
              //  ++check;
                lb_PNC.Text = "";
            }
            else
            {
                check--;
                lb_PNC.Text = "Số điện thoại không hợp lệ";
            }

            if (txt_SoChungMinh.Text.Length > 8 && txt_SoChungMinh.Text.Length <= 20)
            {
              //  ++check;
                lb_SCMC.Text = "";
            }
            else
            {
                check--;
                lb_SCMC.Text = "Số chứng minh không hợp lệ";
            }

            if (txt_STK.Text.Length > 9 && txt_STK.Text.Length <= 20)
            {
                lb_STKC.Text = "";
               // ++check;
            }
            else
            {
                check--;
                lb_STKC.Text = "Số tài khoản không hợp lệ";
            }
            DateTimePicker dtJoin = new DateTimePicker();
            dtJoin.Value = DateTime.Now;
            DateTimePicker dtBDay = new DateTimePicker();
            dtBDay.Value = dateTimePicker1.Value;
            if (dtBDay.Value >= dtJoin.Value)
            {
                lb_BC.Text = "Ngày sinh không hợp lệ";
                check--;
            }
            else
            {
              //  ++check;
                lb_BC.Text = "";
            }
            if (check == 0) return true;
            else return false;
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            lbl_ThongBao.Text = "";
            if (Valid())
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
                        btn_DangKy.FlatStyle = FlatStyle.Flat;
                        btn_DangKy.FlatAppearance.BorderColor = BackColor;
                        btn_DangKy.FlatAppearance.MouseOverBackColor = BackColor;
                        btn_DangKy.FlatAppearance.MouseDownBackColor = BackColor;
                        btn_DangKy.Enabled = false;

                    }
                    // Close the response.
                    response.Close();
                }
                catch (Exception)
                {
                    lbl_ThongBao.Text = "Email đã tồn tại."; 
                }
                request.Abort();
            }
            else 
                lbl_ThongBao.Text = "Đăng kí không thành công.";
        }
        private void Create_An_Accout_Load(object sender, EventArgs e)
        {
            txt_SoChungMinh.Text = "968573921";
            txt_HoVaTen.Text = "Do Xuan Long";
            txt_Email.Text = "long234234@gmail.com";
            txt_DiaChi.Text = "80/3 dia chi";
            txt_MatKhau.Text = "12345678";
            txt_SDT.Text = "0987677899";
            txt_STK.Text = "23847584357334";
            txt_XNMatKhau.Text = "12345678";
        }
    }
}
