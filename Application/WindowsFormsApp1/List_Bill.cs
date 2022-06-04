﻿using System;
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

namespace WindowsFormsApp1
{
    public partial class List_Bill : Form
    {
        WebResponse response { get; set; }
        Root dataprofile { get; set; }
        public class Data
        {
            public string uuid { get; set; }
            public string user_uuid { get; set; }
            public string user_name { get; set; }
            public string ma_sp { get; set; }
            public string ten_sp { get; set; }
            public string so_luong { get; set; }
            public object gia { get; set; }
            public string ngay_dat { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public List<Data> data { get; set; }
            public string message { get; set; }
        }
        private void Connect()
        {
            WebRequest request = HttpWebRequest.Create("https://dbms-abe.f1301.cyou/api/orders");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
        }
        public List_Bill()
        {
            Connect();
            InitializeComponent();
            LV_Data.Columns.Add("STT", 50);
            LV_Data.Columns.Add("UUID", 150);
            LV_Data.Columns.Add("User name", 205);
        }
        private int i;
        private void List_Bill_Load(object sender, EventArgs e)
        {
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string datajson = reader.ReadToEnd();
                dataprofile = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datajson);
                i = 0;
                foreach (Data data in dataprofile.data)
                {
                    i++;
                    ListViewItem item = new ListViewItem(i.ToString());
                    ListViewItem.ListViewSubItem uuid = new ListViewItem.ListViewSubItem(item, data.uuid);
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.user_name);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(uuid);
                    item.SubItems.Add(name);
                }
            }
        }

        private void LV_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Data.SelectedIndices.Count > 0)
            {
                int intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    int i = Int32.Parse(text);
                    txt_UUID.Text = dataprofile.data[i - 1].uuid.ToString();
                    txt_User.Text = dataprofile.data[i - 1].user_uuid.ToString();
                    txt_Price.Text = dataprofile.data[i - 1].gia.ToString();
                    txt_Name.Text = dataprofile.data[i - 1].user_name.ToString();
                    txt_Masp.Text = dataprofile.data[i - 1].ma_sp.ToString();
                    txt_Tensp.Text = dataprofile.data[i - 1].ten_sp.ToString();
                    txt_SL.Text = dataprofile.data[i - 1].so_luong.ToString();
                    txt_Date.Text = dataprofile.data[i - 1].ngay_dat.ToString();
                }
            }
        }
        private int intselectedindex;
        private void btn_Del_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (LV_Data.SelectedIndices.Count > 0)
            {
                intselectedindex = LV_Data.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = LV_Data.Items[intselectedindex].Text;
                    i = Int32.Parse(text);
                }
            }
            string s = "https://dbms-abe.f1301.cyou/api/orders/" + dataprofile.data[i - 1].uuid.ToString();
            var request = (HttpWebRequest)WebRequest.Create(s);
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            request.Method = "DELETE";
            request.Accept = "*/*";
            response = request.GetResponse();
            HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
            request.Abort();
        }

        private void Refreshing()
        {
            WebRequest request = WebRequest.Create("https://dbms-abe.f1301.cyou/api/orders");
            request.Headers["Authorization"] = "Bearer " + Login.token;
            request.PreAuthenticate = true;
            //phần response
            response = request.GetResponse();
            LV_Data.Items.Clear();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string datajson = reader.ReadToEnd();
                dataprofile = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datajson);
                i = 0;
                foreach (Data data in dataprofile.data)
                {
                    i++;
                    ListViewItem item = new ListViewItem(i.ToString());
                    ListViewItem.ListViewSubItem uuid = new ListViewItem.ListViewSubItem(item, data.uuid);
                    ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem(item, data.user_name);
                    LV_Data.Items.Add(item);
                    item.SubItems.Add(uuid);
                    item.SubItems.Add(name);
                }
            }
            request.Abort();
        }
    }
}