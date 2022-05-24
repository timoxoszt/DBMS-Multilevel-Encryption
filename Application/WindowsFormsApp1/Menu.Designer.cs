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
            this.btn_DonMua = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_DatHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_DonMua);
            this.panel1.Controls.Add(this.btn_Admin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 727);
            this.panel1.TabIndex = 0;
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
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Name);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 143);
            this.panel3.TabIndex = 7;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(5, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(105, 16);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Tên Người Dùng";
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_DatHang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Left);
            this.panel2.Controls.Add(this.btn_Right);
            this.panel2.Controls.Add(this.Image);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 727);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Lượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 574);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "DV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên";
            // 
            // btn_Left
            // 
            this.btn_Left.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Left.Location = new System.Drawing.Point(17, 259);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(78, 57);
            this.btn_Left.TabIndex = 4;
            this.btn_Left.Text = "<<";
            this.btn_Left.UseVisualStyleBackColor = false;
            // 
            // btn_Right
            // 
            this.btn_Right.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Right.Location = new System.Drawing.Point(748, 259);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(75, 57);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = ">>";
            this.btn_Right.UseVisualStyleBackColor = false;
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Image.Location = new System.Drawing.Point(114, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(613, 539);
            this.Image.TabIndex = 2;
            this.Image.TabStop = false;
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
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DatHang;
        private System.Windows.Forms.Button btn_DonMua;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

