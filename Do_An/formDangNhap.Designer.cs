namespace Do_An {
	partial class formDangNhap {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTaiKhoan = new System.Windows.Forms.Label();
			this.lblMatKhau = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Do_An.Properties.Resources.log_in__1___1_;
			this.pictureBox1.Location = new System.Drawing.Point(164, 173);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 59);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.UseWaitCursor = true;
			// 
			// lblTaiKhoan
			// 
			this.lblTaiKhoan.AutoSize = true;
			this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaiKhoan.Location = new System.Drawing.Point(264, 173);
			this.lblTaiKhoan.Name = "lblTaiKhoan";
			this.lblTaiKhoan.Size = new System.Drawing.Size(84, 21);
			this.lblTaiKhoan.TabIndex = 1;
			this.lblTaiKhoan.Text = "Tài khoản";
			this.lblTaiKhoan.UseWaitCursor = true;
			// 
			// lblMatKhau
			// 
			this.lblMatKhau.AutoSize = true;
			this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatKhau.Location = new System.Drawing.Point(264, 208);
			this.lblMatKhau.Name = "lblMatKhau";
			this.lblMatKhau.Size = new System.Drawing.Size(79, 21);
			this.lblMatKhau.TabIndex = 2;
			this.lblMatKhau.Text = "Mật khẩu";
			this.lblMatKhau.UseWaitCursor = true;
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaiKhoan.Location = new System.Drawing.Point(373, 167);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(204, 29);
			this.txtTaiKhoan.TabIndex = 3;
			this.txtTaiKhoan.UseWaitCursor = true;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(373, 203);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(204, 29);
			this.txtMatKhau.TabIndex = 4;
			this.txtMatKhau.UseSystemPasswordChar = true;
			this.txtMatKhau.UseWaitCursor = true;
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Location = new System.Drawing.Point(373, 257);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(128, 37);
			this.btnDangNhap.TabIndex = 5;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.UseWaitCursor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Location = new System.Drawing.Point(507, 257);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(70, 37);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.UseWaitCursor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// formDangNhap
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(816, 489);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.lblMatKhau);
			this.Controls.Add(this.lblTaiKhoan);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "formDangNhap";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.formDangNhap_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTaiKhoan;
		private System.Windows.Forms.Label lblMatKhau;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnThoat;
	}
}

