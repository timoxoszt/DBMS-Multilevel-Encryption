namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DonMua = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_DatHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_DonMua);
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 727);
            this.panel1.TabIndex = 0;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(14, 51);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 20);
            this.lb_Name.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên người dùng:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "List HH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DonMua
            // 
            this.btn_DonMua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DonMua.Location = new System.Drawing.Point(20, 259);
            this.btn_DonMua.Name = "btn_DonMua";
            this.btn_DonMua.Size = new System.Drawing.Size(173, 48);
            this.btn_DonMua.TabIndex = 2;
            this.btn_DonMua.Text = "Đơn Mua";
            this.btn_DonMua.UseVisualStyleBackColor = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Admin.Location = new System.Drawing.Point(20, 334);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(173, 55);
            this.btn_Admin.TabIndex = 8;
            this.btn_Admin.Text = "Trang Quản Trị";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Logout.Location = new System.Drawing.Point(20, 657);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(173, 48);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Đăng Xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Info.Location = new System.Drawing.Point(20, 191);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(173, 46);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Text = "Thông Tin Cá Nhân";
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DatHang.Location = new System.Drawing.Point(636, 667);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(173, 48);
            this.btn_DatHang.TabIndex = 5;
            this.btn_DatHang.Text = "Đặt Hàng";
            this.btn_DatHang.UseVisualStyleBackColor = false;
            this.btn_DatHang.Click += new System.EventHandler(this.btn_DatHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.LV_Data);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_SL);
            this.panel2.Controls.Add(this.btn_DatHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 727);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Lượng";
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(402, 574);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(100, 22);
            this.txt_SL.TabIndex = 8;
            this.txt_SL.Text = "1";
            // 
            // LV_Data
            // 
            this.LV_Data.FullRowSelect = true;
            this.LV_Data.HideSelection = false;
            this.LV_Data.Location = new System.Drawing.Point(29, 12);
            this.LV_Data.Name = "LV_Data";
            this.LV_Data.Size = new System.Drawing.Size(780, 547);
            this.LV_Data.TabIndex = 10;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.SelectedIndexChanged += new System.EventHandler(this.LV_Data_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DatHang;
        private System.Windows.Forms.Button btn_DonMua;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Button button2;
    }
}

