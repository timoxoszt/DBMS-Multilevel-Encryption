namespace WindowsFormsApp1
{
    partial class List_Bill
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
            this.LV_Data = new System.Windows.Forms.ListView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txt_Masp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Tensp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.lb_UUID = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // LV_Data
            // 
            this.LV_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Data.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Data.ForeColor = System.Drawing.Color.Navy;
            this.LV_Data.FullRowSelect = true;
            this.LV_Data.GridLines = true;
            this.LV_Data.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Data.HideSelection = false;
            this.LV_Data.Location = new System.Drawing.Point(0, 0);
            this.LV_Data.Margin = new System.Windows.Forms.Padding(4);
            this.LV_Data.MultiSelect = false;
            this.LV_Data.Name = "LV_Data";
            this.LV_Data.Size = new System.Drawing.Size(491, 715);
            this.LV_Data.TabIndex = 12;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.SelectedIndexChanged += new System.EventHandler(this.LV_Data_SelectedIndexChanged);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Del.Location = new System.Drawing.Point(204, 645);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 39);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_Masp
            // 
            this.txt_Masp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Masp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Masp.ForeColor = System.Drawing.Color.Navy;
            this.txt_Masp.Location = new System.Drawing.Point(204, 155);
            this.txt_Masp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Masp.Name = "txt_Masp";
            this.txt_Masp.Size = new System.Drawing.Size(190, 25);
            this.txt_Masp.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(72, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txt_SL
            // 
            this.txt_SL.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_SL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.ForeColor = System.Drawing.Color.Navy;
            this.txt_SL.Location = new System.Drawing.Point(204, 241);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(190, 25);
            this.txt_SL.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(72, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số Lượng";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Navy;
            this.txt_Name.Location = new System.Drawing.Point(204, 108);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(190, 25);
            this.txt_Name.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(72, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uer_Name";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_User.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Navy;
            this.txt_User.Location = new System.Drawing.Point(204, 57);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(190, 25);
            this.txt_User.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User_UID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Date);
            this.panel1.Controls.Add(this.txt_Tensp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_UUID);
            this.panel1.Controls.Add(this.lb_UUID);
            this.panel1.Controls.Add(this.Image);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.txt_Masp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_SL);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(491, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 715);
            this.panel1.TabIndex = 11;
            // 
            // txt_Tensp
            // 
            this.txt_Tensp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Tensp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tensp.ForeColor = System.Drawing.Color.Navy;
            this.txt_Tensp.Location = new System.Drawing.Point(204, 199);
            this.txt_Tensp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tensp.Name = "txt_Tensp";
            this.txt_Tensp.Size = new System.Drawing.Size(190, 25);
            this.txt_Tensp.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(72, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên sản phẩm";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Price.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.Navy;
            this.txt_Price.Location = new System.Drawing.Point(204, 282);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(190, 25);
            this.txt_Price.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(72, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giá";
            // 
            // txt_UUID
            // 
            this.txt_UUID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_UUID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UUID.ForeColor = System.Drawing.Color.Navy;
            this.txt_UUID.Location = new System.Drawing.Point(204, 13);
            this.txt_UUID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UUID.Name = "txt_UUID";
            this.txt_UUID.Size = new System.Drawing.Size(190, 25);
            this.txt_UUID.TabIndex = 28;
            // 
            // lb_UUID
            // 
            this.lb_UUID.AutoSize = true;
            this.lb_UUID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UUID.ForeColor = System.Drawing.Color.Navy;
            this.lb_UUID.Location = new System.Drawing.Point(72, 16);
            this.lb_UUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UUID.Name = "lb_UUID";
            this.lb_UUID.Size = new System.Drawing.Size(42, 17);
            this.lb_UUID.TabIndex = 27;
            this.lb_UUID.Text = "UUID";
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Image.Location = new System.Drawing.Point(28, 368);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(470, 246);
            this.Image.TabIndex = 26;
            this.Image.TabStop = false;
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.ForeColor = System.Drawing.Color.Navy;
            this.txt_Date.Location = new System.Drawing.Point(204, 323);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(190, 25);
            this.txt_Date.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(72, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ngày đặt";
            // 
            // List_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 715);
            this.Controls.Add(this.LV_Data);
            this.Controls.Add(this.panel1);
            this.Name = "List_Bill";
            this.Text = "List_Bill";
            this.Load += new System.EventHandler(this.List_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_Masp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.Label lb_UUID;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TextBox txt_Tensp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Date;
    }
}