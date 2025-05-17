namespace QLSINHVIEN.GUI
{
    partial class QuanLiThongTinFrm
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
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Enabled = false;
            this.txbMatKhau.Location = new System.Drawing.Point(140, 97);
            this.txbMatKhau.MaxLength = 100;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(196, 22);
            this.txbMatKhau.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu:";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Enabled = false;
            this.txbTenDangNhap.Location = new System.Drawing.Point(140, 68);
            this.txbTenDangNhap.MaxLength = 100;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(196, 22);
            this.txbTenDangNhap.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại Tài khoản:";
            // 
            // txbLoaiTaiKhoan
            // 
            this.txbLoaiTaiKhoan.Enabled = false;
            this.txbLoaiTaiKhoan.Location = new System.Drawing.Point(140, 41);
            this.txbLoaiTaiKhoan.MaxLength = 100;
            this.txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            this.txbLoaiTaiKhoan.Size = new System.Drawing.Size(196, 22);
            this.txbLoaiTaiKhoan.TabIndex = 12;
            // 
            // QuanLiThongTinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 143);
            this.Controls.Add(this.txbLoaiTaiKhoan);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLiThongTinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLiThongTinFrm";
            this.Load += new System.EventHandler(this.QuanLiThongTinFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLoaiTaiKhoan;
    }
}