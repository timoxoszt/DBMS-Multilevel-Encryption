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
            textBox2.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 8;
            textBox8.Text = "";
            textBox8.PasswordChar = '*';
            textBox8.MaxLength = 8;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string selectDateAsString = dateTimePicker1.Value.ToString("yyyyMMdd");

            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/register");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "email=" + textBox1.Text
                        + "&password=" + textBox2.Text
                        + "&confirm_password=" + textBox8.Text
                        + "&ho_ten=" + textBox3.Text
                        + "&sdt=" + textBox4.Text
                        + "&stk=" + textBox5.Text
                        + "&cmnd=" + textBox6.Text
                        + "&dia_chi=" + textBox7.Text
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
                label9.Text = "";
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

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

                    label9.Text = "Đăng kí thành công.";
                    MessageBox.Show(datajson.data.ToString());

                }
                // Close the response.
                response.Close();
            }
            catch (Exception)
            {
                label9.Text = "";
                label9.Text = "Đăng kí không thành công.";
            }
        }
    }
}
