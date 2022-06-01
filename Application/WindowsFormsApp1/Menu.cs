using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            List_User p = new List_User();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_HH p = new List_HH();
            p.Show();  
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            Bill p = new Bill();
            p.Show();
        }
    }
}
