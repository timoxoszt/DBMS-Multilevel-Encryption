namespace WindowsFormsApp1
{
    partial class List_User
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_STK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_NDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Birth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(88, 557);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 39);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Cập Nhật";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_STK
            // 
            this.txt_STK.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_STK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STK.ForeColor = System.Drawing.Color.Navy;
            this.txt_STK.Location = new System.Drawing.Point(152, 155);
            this.txt_STK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_STK.Name = "txt_STK";
            this.txt_STK.Size = new System.Drawing.Size(276, 25);
            this.txt_STK.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "STK";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Navy;
            this.txt_Email.Location = new System.Drawing.Point(152, 94);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(276, 25);
            this.txt_Email.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txt_NDK);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Birth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_CMND);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.txt_STK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(486, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 622);
            this.panel1.TabIndex = 9;
            // 
            // txt_NDK
            // 
            this.txt_NDK.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_NDK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NDK.ForeColor = System.Drawing.Color.Navy;
            this.txt_NDK.Location = new System.Drawing.Point(152, 398);
            this.txt_NDK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NDK.Name = "txt_NDK";
            this.txt_NDK.ReadOnly = true;
            this.txt_NDK.Size = new System.Drawing.Size(276, 25);
            this.txt_NDK.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(31, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ngày Đăng Ký ";
            // 
            // txt_Birth
            // 
            this.txt_Birth.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Birth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Birth.ForeColor = System.Drawing.Color.Navy;
            this.txt_Birth.Location = new System.Drawing.Point(152, 355);
            this.txt_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Birth.Name = "txt_Birth";
            this.txt_Birth.Size = new System.Drawing.Size(276, 25);
            this.txt_Birth.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(31, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ngày Sinh";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_DiaChi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Navy;
            this.txt_DiaChi.Location = new System.Drawing.Point(152, 310);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(276, 25);
            this.txt_DiaChi.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(32, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Địa Chỉ";
            // 
            // txt_CMND
            // 
            this.txt_CMND.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_CMND.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.ForeColor = System.Drawing.Color.Navy;
            this.txt_CMND.Location = new System.Drawing.Point(152, 265);
            this.txt_CMND.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(276, 25);
            this.txt_CMND.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(39, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số Chứng Minh";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_SDT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.Navy;
            this.txt_SDT.Location = new System.Drawing.Point(152, 220);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(276, 25);
            this.txt_SDT.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(37, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số Điện Thoại";
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Del.Location = new System.Drawing.Point(268, 557);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 39);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Visible = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Navy;
            this.txt_Name.Location = new System.Drawing.Point(152, 55);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(276, 25);
            this.txt_Name.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(37, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Họ Và Tên";
            // 
            // LV_Data
            // 
            this.LV_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Data.FullRowSelect = true;
            this.LV_Data.GridLines = true;
            this.LV_Data.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Data.HideSelection = false;
            this.LV_Data.Location = new System.Drawing.Point(0, 0);
            this.LV_Data.MultiSelect = false;
            this.LV_Data.Name = "LV_Data";
            this.LV_Data.Size = new System.Drawing.Size(486, 622);
            this.LV_Data.TabIndex = 39;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.SelectedIndexChanged += new System.EventHandler(this.LV_Data_SelectedIndexChanged);
            // 
            // List_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 622);
            this.Controls.Add(this.LV_Data);
            this.Controls.Add(this.panel1);
            this.Name = "List_User";
            this.Text = "List_User";
            this.Load += new System.EventHandler(this.List_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_STK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_NDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Birth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Button btn_Del;
    }
}