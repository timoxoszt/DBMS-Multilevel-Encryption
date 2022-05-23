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
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    
    public partial class Admin : Form
    {
        public static HttpClient client = new HttpClient();
        
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_User p = new List_User();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_HH p = new List_HH();
            p.Show();
        }
    }
}
