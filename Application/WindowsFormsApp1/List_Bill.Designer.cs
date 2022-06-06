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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Tensp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UUID = new System.Windows.Forms.TextBox();
            this.lb_UUID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_Addr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_SDT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.LV_Data.Size = new System.Drawing.Size(462, 517);
            this.LV_Data.TabIndex = 12;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.SelectedIndexChanged += new System.EventHandler(this.LV_Data_SelectedIndexChanged);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Del.Location = new System.Drawing.Point(205, 428);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 57);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Đã giao hàng";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Visible = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txt_Masp
            // 
            this.txt_Masp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Masp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Masp.ForeColor = System.Drawing.Color.Navy;
            this.txt_Masp.Location = new System.Drawing.Point(238, 157);
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
            this.label5.Location = new System.Drawing.Point(106, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Navy;
            this.txt_Name.Location = new System.Drawing.Point(238, 110);
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
            this.label3.Location = new System.Drawing.Point(106, 113);
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
            this.txt_User.Location = new System.Drawing.Point(238, 59);
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
            this.label2.Location = new System.Drawing.Point(106, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User_UID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tB_SDT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tB_Addr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Date);
            this.panel1.Controls.Add(this.txt_Tensp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_UUID);
            this.panel1.Controls.Add(this.lb_UUID);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.txt_Masp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(462, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 517);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(106, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ngày đặt";
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.ForeColor = System.Drawing.Color.Navy;
            this.txt_Date.Location = new System.Drawing.Point(238, 285);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(190, 25);
            this.txt_Date.TabIndex = 42;
            // 
            // txt_Tensp
            // 
            this.txt_Tensp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Tensp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tensp.ForeColor = System.Drawing.Color.Navy;
            this.txt_Tensp.Location = new System.Drawing.Point(238, 201);
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
            this.label6.Location = new System.Drawing.Point(106, 204);
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
            this.txt_Price.Location = new System.Drawing.Point(238, 244);
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
            this.label4.Location = new System.Drawing.Point(106, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Thành tiền";
            // 
            // txt_UUID
            // 
            this.txt_UUID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_UUID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UUID.ForeColor = System.Drawing.Color.Navy;
            this.txt_UUID.Location = new System.Drawing.Point(238, 15);
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
            this.lb_UUID.Location = new System.Drawing.Point(106, 18);
            this.lb_UUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UUID.Name = "lb_UUID";
            this.lb_UUID.Size = new System.Drawing.Size(93, 17);
            this.lb_UUID.TabIndex = 27;
            this.lb_UUID.Text = "Mã đơn hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(106, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Địa chỉ";
            // 
            // tB_Addr
            // 
            this.tB_Addr.BackColor = System.Drawing.Color.LemonChiffon;
            this.tB_Addr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Addr.ForeColor = System.Drawing.Color.Navy;
            this.tB_Addr.Location = new System.Drawing.Point(238, 325);
            this.tB_Addr.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Addr.Name = "tB_Addr";
            this.tB_Addr.Size = new System.Drawing.Size(190, 25);
            this.tB_Addr.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(106, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Số điện thoại";
            // 
            // tB_SDT
            // 
            this.tB_SDT.BackColor = System.Drawing.Color.LemonChiffon;
            this.tB_SDT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_SDT.ForeColor = System.Drawing.Color.Navy;
            this.tB_SDT.Location = new System.Drawing.Point(238, 367);
            this.tB_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.tB_SDT.Name = "tB_SDT";
            this.tB_SDT.Size = new System.Drawing.Size(190, 25);
            this.tB_SDT.TabIndex = 46;
            // 
            // List_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 517);
            this.Controls.Add(this.LV_Data);
            this.Controls.Add(this.panel1);
            this.Name = "List_Bill";
            this.Text = "List_Bill";
            this.Load += new System.EventHandler(this.List_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txt_Masp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_UUID;
        private System.Windows.Forms.Label lb_UUID;
        private System.Windows.Forms.TextBox txt_Tensp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_Addr;
    }
}