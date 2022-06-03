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
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
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
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Del.Location = new System.Drawing.Point(380, 644);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 39);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(39, 644);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 39);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Cập Nhật";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // txt_DVT
            // 
            this.txt_DVT.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_DVT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVT.ForeColor = System.Drawing.Color.Navy;
            this.txt_DVT.Location = new System.Drawing.Point(204, 155);
            this.txt_DVT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(190, 25);
            this.txt_DVT.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(72, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Price.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.Navy;
            this.txt_Price.Location = new System.Drawing.Point(204, 241);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(190, 25);
            this.txt_Price.TabIndex = 19;
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
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_ID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.Navy;
            this.txt_ID.Location = new System.Drawing.Point(204, 57);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(190, 25);
            this.txt_ID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(72, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Image);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.txt_DVT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(491, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 715);
            this.panel1.TabIndex = 11;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Refresh.Location = new System.Drawing.Point(208, 644);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(108, 39);
            this.btn_Refresh.TabIndex = 41;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Navy;
            this.textBox3.Location = new System.Drawing.Point(204, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 25);
            this.textBox3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(72, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Giá";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(204, 282);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 25);
            this.textBox2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(72, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Thành tiền";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(204, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 25);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Image.Location = new System.Drawing.Point(28, 331);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(470, 283);
            this.Image.TabIndex = 26;
            this.Image.TabStop = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Refresh;
    }
}