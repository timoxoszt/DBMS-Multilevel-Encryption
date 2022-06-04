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
    public partial class DB : Form
    {
        public DB()
        {
            InitializeComponent();
            check();
        }
        private void check()
        {
            string o = "Order";
            string p = "Product";
            string u = "User";
            if (Login.section.Contains(o) 
                && (Login.utype.Contains("Employee")
                || (Login.utype.Contains("Manage") && !Login.urole.Contains("ThuKho"))
                || Login.utype.Contains("Owner")))
            {
                btn_O.Visible = true;
            }
                

            if (Login.section.Contains(p)
                && (Login.utype.Contains("Customer")
                || Login.utype.Contains("Manage")
                || Login.utype.Contains("Owner")))  
                btn_P.Visible = true;

            if (Login.section.Contains(u) 
                && (Login.utype.Contains("Owner")
                || Login.utype.Contains("Manage"))) 
                btn_U.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List_User p = new List_User();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_HH p = new List_HH();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List_Bill p = new List_Bill();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }
    }
}
