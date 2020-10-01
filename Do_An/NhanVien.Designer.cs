namespace Do_An {
	partial class NhanVien {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGVNhanVien = new System.Windows.Forms.DataGridView();
			this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtGioiTinh = new System.Windows.Forms.TextBox();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtMaNhanVien = new System.Windows.Forms.TextBox();
			this.lblHoTen = new System.Windows.Forms.Label();
			this.lblGioiTinh = new System.Windows.Forms.Label();
			this.lblNgaySinh = new System.Windows.Forms.Label();
			this.lblDiaChi = new System.Windows.Forms.Label();
			this.lblDienThoai = new System.Windows.Forms.Label();
			this.lblMaNhanVien = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGVNhanVien)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(944, 58);
			this.panel1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Teal;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = global::Do_An.Properties.Resources.imgTroVe_50x50;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(825, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 47);
			this.button2.TabIndex = 3;
			this.button2.Text = "Back";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(67, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách nhân viên";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Do_An.Properties.Resources.imgHopDongNV_50x50_1;
			this.pictureBox1.Location = new System.Drawing.Point(6, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// dataGVNhanVien
			// 
			this.dataGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhanvien,
            this.hoten,
            this.gioitinh,
            this.dienthoai,
            this.ngaysinh,
            this.diachi});
			this.dataGVNhanVien.Location = new System.Drawing.Point(12, 326);
			this.dataGVNhanVien.Name = "dataGVNhanVien";
			this.dataGVNhanVien.Size = new System.Drawing.Size(923, 305);
			this.dataGVNhanVien.TabIndex = 1;
			this.dataGVNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVNhanVien_RowEnter);
			// 
			// manhanvien
			// 
			this.manhanvien.DataPropertyName = "MANHANVIEN";
			this.manhanvien.HeaderText = "Mã nhân viên";
			this.manhanvien.Name = "manhanvien";
			this.manhanvien.ReadOnly = true;
			// 
			// hoten
			// 
			this.hoten.DataPropertyName = "TENNHANVIEN";
			this.hoten.HeaderText = "Họ tên";
			this.hoten.Name = "hoten";
			this.hoten.ReadOnly = true;
			this.hoten.Width = 150;
			// 
			// gioitinh
			// 
			this.gioitinh.DataPropertyName = "GIOITINH";
			this.gioitinh.HeaderText = "Giới tính";
			this.gioitinh.Name = "gioitinh";
			this.gioitinh.ReadOnly = true;
			// 
			// dienthoai
			// 
			this.dienthoai.DataPropertyName = "DIENTHOAI";
			this.dienthoai.HeaderText = "Điện thoại";
			this.dienthoai.Name = "dienthoai";
			this.dienthoai.ReadOnly = true;
			// 
			// ngaysinh
			// 
			this.ngaysinh.DataPropertyName = "NGAYSINH";
			this.ngaysinh.HeaderText = "Ngày sinh";
			this.ngaysinh.Name = "ngaysinh";
			this.ngaysinh.ReadOnly = true;
			// 
			// diachi
			// 
			this.diachi.DataPropertyName = "DIACHI";
			this.diachi.HeaderText = "Địa chỉ";
			this.diachi.Name = "diachi";
			this.diachi.ReadOnly = true;
			this.diachi.Width = 330;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.dataGVNhanVien);
			this.panel2.Location = new System.Drawing.Point(2, 60);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(944, 650);
			this.panel2.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTimKiem);
			this.groupBox2.Controls.Add(this.btnTim);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnLuu);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(18, 222);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(910, 89);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(642, 36);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(159, 27);
			this.txtTimKiem.TabIndex = 6;
			this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.ForeColor = System.Drawing.Color.White;
			this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTim.Location = new System.Drawing.Point(807, 31);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(84, 37);
			this.btnTim.TabIndex = 5;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Image = global::Do_An.Properties.Resources.icons8_trash_26;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(348, 26);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(84, 47);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.White;
			this.btnSua.Image = global::Do_An.Properties.Resources.icons8_edit_26__1_;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(482, 26);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(84, 47);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Image = global::Do_An.Properties.Resources.icon_reload;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(58, 26);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(106, 47);
			this.btnLuu.TabIndex = 1;
			this.btnLuu.Text = "Nhập lại";
			this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Image = global::Do_An.Properties.Resources.icons8_plus_26;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(214, 26);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(84, 47);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtNgaySinh);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.txtGioiTinh);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.txtMaNhanVien);
			this.groupBox1.Controls.Add(this.lblHoTen);
			this.groupBox1.Controls.Add(this.lblGioiTinh);
			this.groupBox1.Controls.Add(this.lblNgaySinh);
			this.groupBox1.Controls.Add(this.lblDiaChi);
			this.groupBox1.Controls.Add(this.lblDienThoai);
			this.groupBox1.Controls.Add(this.lblMaNhanVien);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(18, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(911, 199);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin nhân viên";
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Location = new System.Drawing.Point(608, 51);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(204, 27);
			this.dtNgaySinh.TabIndex = 13;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(223, 92);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(205, 27);
			this.txtHoTen.TabIndex = 12;
			// 
			// txtGioiTinh
			// 
			this.txtGioiTinh.Location = new System.Drawing.Point(223, 135);
			this.txtGioiTinh.Name = "txtGioiTinh";
			this.txtGioiTinh.Size = new System.Drawing.Size(205, 27);
			this.txtGioiTinh.TabIndex = 11;
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(607, 99);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(205, 27);
			this.txtDienThoai.TabIndex = 10;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(607, 147);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(205, 27);
			this.txtDiaChi.TabIndex = 9;
			// 
			// txtMaNhanVien
			// 
			this.txtMaNhanVien.Location = new System.Drawing.Point(223, 49);
			this.txtMaNhanVien.Name = "txtMaNhanVien";
			this.txtMaNhanVien.Size = new System.Drawing.Size(205, 27);
			this.txtMaNhanVien.TabIndex = 6;
			// 
			// lblHoTen
			// 
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Location = new System.Drawing.Point(85, 97);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(59, 20);
			this.lblHoTen.TabIndex = 5;
			this.lblHoTen.Text = "Họ tên";
			// 
			// lblGioiTinh
			// 
			this.lblGioiTinh.AutoSize = true;
			this.lblGioiTinh.Location = new System.Drawing.Point(85, 138);
			this.lblGioiTinh.Name = "lblGioiTinh";
			this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
			this.lblGioiTinh.TabIndex = 4;
			this.lblGioiTinh.Text = "Giới tính";
			// 
			// lblNgaySinh
			// 
			this.lblNgaySinh.AutoSize = true;
			this.lblNgaySinh.Location = new System.Drawing.Point(505, 56);
			this.lblNgaySinh.Name = "lblNgaySinh";
			this.lblNgaySinh.Size = new System.Drawing.Size(83, 20);
			this.lblNgaySinh.TabIndex = 3;
			this.lblNgaySinh.Text = "Ngày sinh";
			// 
			// lblDiaChi
			// 
			this.lblDiaChi.AutoSize = true;
			this.lblDiaChi.Location = new System.Drawing.Point(505, 150);
			this.lblDiaChi.Name = "lblDiaChi";
			this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
			this.lblDiaChi.TabIndex = 2;
			this.lblDiaChi.Text = "Địa chỉ";
			// 
			// lblDienThoai
			// 
			this.lblDienThoai.AutoSize = true;
			this.lblDienThoai.Location = new System.Drawing.Point(505, 103);
			this.lblDienThoai.Name = "lblDienThoai";
			this.lblDienThoai.Size = new System.Drawing.Size(84, 20);
			this.lblDienThoai.TabIndex = 1;
			this.lblDienThoai.Text = "Điện thoại";
			// 
			// lblMaNhanVien
			// 
			this.lblMaNhanVien.AutoSize = true;
			this.lblMaNhanVien.Location = new System.Drawing.Point(85, 56);
			this.lblMaNhanVien.Name = "lblMaNhanVien";
			this.lblMaNhanVien.Size = new System.Drawing.Size(108, 20);
			this.lblMaNhanVien.TabIndex = 0;
			this.lblMaNhanVien.Text = "Mã nhân viên";
			// 
			// NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 712);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NhanVien";
			this.Load += new System.EventHandler(this.NhanVien_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGVNhanVien)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGVNhanVien;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtGioiTinh;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtMaNhanVien;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblGioiTinh;
		private System.Windows.Forms.Label lblNgaySinh;
		private System.Windows.Forms.Label lblDiaChi;
		private System.Windows.Forms.Label lblDienThoai;
		private System.Windows.Forms.Label lblMaNhanVien;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
	}
}