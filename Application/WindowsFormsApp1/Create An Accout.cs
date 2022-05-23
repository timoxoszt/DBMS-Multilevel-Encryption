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

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/register");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "email=" + textBox1.Text + "&password=" + textBox2.Text;
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
                label3.Text = "";
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
                    this.Hide();
                    Menu p = new Menu();
                    p.ShowDialog();
                    this.Show();

                }
                // Close the response.
                response.Close();
            }
            catch (Exception)
            {
                label3.Text = "Đăng kí không thành công.";
            }
        }
    }
}
