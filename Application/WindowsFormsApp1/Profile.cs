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
using System.Text.RegularExpressions;
using System.Globalization;

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
        int check = 0;
        int count = 0;
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


            if (txt_HoVaTen.Text != "")
            {
                // ++check;
                lb_NC.Text = "";
            }
            else
            {
                check--;
                lb_NC.Text = "Họ và tên không hợp lệ";
            }

            if (txt_SoDienThoai.Text.Length >= 10 && txt_SoDienThoai.Text.Length <= 11)
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
            DateTimePicker dtBDay = new DateTimePicker();
            if(count >= 1) dtBDay.Value = dateTimePicker2.Value;
            else dtBDay.Value = DateTime.ParseExact(txt_NgaySinh.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            DateTimePicker dtJoin = new DateTimePicker();
            dtJoin.Value = DateTime.ParseExact(txt_NgayDangKy.Text,"dd/MM/yyyy", CultureInfo.InvariantCulture);
            
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
            response.Close();
            count = 0;
            if(Valid())
            {
                DateTime dateTime = DateTime.Parse(txt_NgaySinh.Text);
                string ns = dateTime.ToString("yyyy/MM/dd");
                WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/update-profile");
                request.Headers["Authorization"] = "Bearer " + Login.token;
                
                request.PreAuthenticate = true;
                request.Method = "PUT";
                string postData = "ho_ten=" + txt_HoVaTen.Text
                                + "&stk=" + txt_STK.Text
                                + "&sdt=" + txt_SoDienThoai.Text
                                + "&cmnd=" + txt_SoChungMinh.Text
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
                try
                {
                    Root datajson = null;
                    WebResponse Response = request.GetResponse();
                    using (var streamReader = new StreamReader(Response.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        datajson = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(result);
                        lbl_ThongBao.Text = "Cập nhật thành công.";
                        btn_CapNhat.FlatAppearance.MouseOverBackColor = BackColor;
                        btn_CapNhat.FlatAppearance.MouseDownBackColor = BackColor;
                        btn_CapNhat.Enabled = false;
                    }
                    // Close the response.
                    response.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "Thong bao");
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            count++;
            string ns = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            txt_NgaySinh.Text = ns;
        }
    }
}
