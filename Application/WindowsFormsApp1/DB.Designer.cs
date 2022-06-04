namespace WindowsFormsApp1
{
    partial class DB
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
            this.btn_U = new System.Windows.Forms.Button();
            this.btn_P = new System.Windows.Forms.Button();
            this.btn_O = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_U
            // 
            this.btn_U.Location = new System.Drawing.Point(38, 100);
            this.btn_U.Name = "btn_U";
            this.btn_U.Size = new System.Drawing.Size(117, 52);
            this.btn_U.TabIndex = 0;
            this.btn_U.Text = "Users";
            this.btn_U.UseVisualStyleBackColor = true;
            this.btn_U.Visible = false;
            this.btn_U.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_P
            // 
            this.btn_P.Location = new System.Drawing.Point(190, 100);
            this.btn_P.Name = "btn_P";
            this.btn_P.Size = new System.Drawing.Size(117, 52);
            this.btn_P.TabIndex = 1;
            this.btn_P.Text = "Products";
            this.btn_P.UseVisualStyleBackColor = true;
            this.btn_P.Visible = false;
            this.btn_P.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_O
            // 
            this.btn_O.Location = new System.Drawing.Point(352, 100);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(117, 52);
            this.btn_O.TabIndex = 2;
            this.btn_O.Text = "Bills";
            this.btn_O.UseVisualStyleBackColor = true;
            this.btn_O.Visible = false;
            this.btn_O.Click += new System.EventHandler(this.button3_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 306);
            this.Controls.Add(this.btn_O);
            this.Controls.Add(this.btn_P);
            this.Controls.Add(this.btn_U);
            this.Name = "DB";
            this.Text = "DB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_U;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.Button btn_O;
    }
}