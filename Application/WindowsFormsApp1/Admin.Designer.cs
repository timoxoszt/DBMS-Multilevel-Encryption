namespace WindowsFormsApp1
{
    partial class Admin
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
            this.btn_DSNguoiDung = new System.Windows.Forms.Button();
            this.btn_DanhSachHangHoa = new System.Windows.Forms.Button();
            this.btn_DanhSachDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DSNguoiDung
            // 
            this.btn_DSNguoiDung.Location = new System.Drawing.Point(26, 106);
            this.btn_DSNguoiDung.Name = "btn_DSNguoiDung";
            this.btn_DSNguoiDung.Size = new System.Drawing.Size(129, 64);
            this.btn_DSNguoiDung.TabIndex = 0;
            this.btn_DSNguoiDung.Text = "Danh Sách Người Dùng ";
            this.btn_DSNguoiDung.UseVisualStyleBackColor = true;
            this.btn_DSNguoiDung.Click += new System.EventHandler(this.btn_DanhSachNguoiDung_Click);
            // 
            // btn_DanhSachHangHoa
            // 
            this.btn_DanhSachHangHoa.Location = new System.Drawing.Point(210, 106);
            this.btn_DanhSachHangHoa.Name = "btn_DanhSachHangHoa";
            this.btn_DanhSachHangHoa.Size = new System.Drawing.Size(127, 64);
            this.btn_DanhSachHangHoa.TabIndex = 1;
            this.btn_DanhSachHangHoa.Text = "Danh Sách Hàng Hóa";
            this.btn_DanhSachHangHoa.UseVisualStyleBackColor = true;
            this.btn_DanhSachHangHoa.Click += new System.EventHandler(this.btn_DanhSachHangHoa_Click);
            // 
            // btn_DanhSachDonHang
            // 
            this.btn_DanhSachDonHang.Location = new System.Drawing.Point(404, 106);
            this.btn_DanhSachDonHang.Name = "btn_DanhSachDonHang";
            this.btn_DanhSachDonHang.Size = new System.Drawing.Size(127, 64);
            this.btn_DanhSachDonHang.TabIndex = 2;
            this.btn_DanhSachDonHang.Text = "Danh Sách Đơn Hàng";
            this.btn_DanhSachDonHang.UseVisualStyleBackColor = true;
            this.btn_DanhSachDonHang.Click += new System.EventHandler(this.btn_DanhSachDonHang_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 305);
            this.Controls.Add(this.btn_DanhSachDonHang);
            this.Controls.Add(this.btn_DanhSachHangHoa);
            this.Controls.Add(this.btn_DSNguoiDung);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DSNguoiDung;
        private System.Windows.Forms.Button btn_DanhSachHangHoa;
        private System.Windows.Forms.Button btn_DanhSachDonHang;
    }
}