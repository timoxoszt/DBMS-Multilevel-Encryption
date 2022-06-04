using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;
using System.IO;
using System.Net.Http.Formatting;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public static string token;
        public static string section;
        public static string utype;
        public static string urole;
        public class Data
        {
            public string token { get; set; }
            public string user_type { get; set; }
            public string user_role { get; set; }
            public string section { get; set; }
            public string time { get; set; }
            public string ho_ten { get; set; }
            public string email { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
        }

        public Login()
        {
            InitializeComponent();
            InitializeMyControl();
        }
        private void InitializeMyControl()
        {
            // Set to no text.
            txt_MatKhau.Text = "";
            // The password character is an asterisk.
            txt_MatKhau.PasswordChar = '*';
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
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            Create_An_Accout p = new Create_An_Accout();
            p.Show();
        }
        public static string name;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txt_Email.Text))
            {
                // Create a request using a URL that can receive a post.
                WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/login");
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "email=" + txt_Email.Text 
                            + "&password=" + txt_MatKhau.Text;
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

                    Root datajson;
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
                        this.Hide();
                        token = datajson.data.token;
                        name = datajson.data.ho_ten;
                        section = datajson.data.section;
                        utype = datajson.data.user_type;
                        urole = datajson.data.user_role;
                        Menu p = new Menu();
                        p.ShowDialog();
                        this.Show();
                    }
                    // Close the response.
                    response.Close();
                }
                catch (Exception)
                {
                    lbl_ThongBao.Text = "Đăng nhập không thành công.";
                }
            }
            else lbl_ThongBao.Text = "Email không hợp lệ.";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Email.Text = "shipper@gmail.com";
            txt_MatKhau.Text = "9a9hC]RA)LsvnU~w<";
        }
    }
}
