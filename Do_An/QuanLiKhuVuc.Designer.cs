namespace Do_An {
	partial class QuanLiKhuVuc {
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnNhapLai = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
			this.txtTrangThai = new System.Windows.Forms.TextBox();
			this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
			this.lblTenKhuVuc = new System.Windows.Forms.Label();
			this.lblTrangThai = new System.Windows.Forms.Label();
			this.lblMaKhuVuc = new System.Windows.Forms.Label();
			this.dataGVQLKhuVuc = new System.Windows.Forms.DataGridView();
			this.makhuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenkhuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGVQLKhuVuc)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(912, 70);
			this.panel1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Teal;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = global::Do_An.Properties.Resources.imgTroVe_50x50;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(798, 6);
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
			this.label1.Size = new System.Drawing.Size(146, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quản lý khu vực";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Do_An.Properties.Resources.icons8_flag_filled_522;
			this.pictureBox1.Location = new System.Drawing.Point(6, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 64);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnNhapLai);
			this.groupBox2.Controls.Add(this.txtTimKiem);
			this.groupBox2.Controls.Add(this.btnTim);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(3, 234);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(910, 89);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// btnNhapLai
			// 
			this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhapLai.ForeColor = System.Drawing.Color.White;
			this.btnNhapLai.Image = global::Do_An.Properties.Resources.icon_reload;
			this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhapLai.Location = new System.Drawing.Point(53, 26);
			this.btnNhapLai.Name = "btnNhapLai";
			this.btnNhapLai.Size = new System.Drawing.Size(106, 47);
			this.btnNhapLai.TabIndex = 7;
			this.btnNhapLai.Text = "Nhập lại";
			this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNhapLai.UseVisualStyleBackColor = false;
			this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
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
			this.btnXoa.Location = new System.Drawing.Point(492, 26);
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
			this.btnSua.Location = new System.Drawing.Point(353, 26);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(84, 47);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
			this.groupBox1.Controls.Add(this.txtTenKhuVuc);
			this.groupBox1.Controls.Add(this.txtTrangThai);
			this.groupBox1.Controls.Add(this.txtMaKhuVuc);
			this.groupBox1.Controls.Add(this.lblTenKhuVuc);
			this.groupBox1.Controls.Add(this.lblTrangThai);
			this.groupBox1.Controls.Add(this.lblMaKhuVuc);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(3, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(911, 149);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin khu vực";
			// 
			// txtTenKhuVuc
			// 
			this.txtTenKhuVuc.Location = new System.Drawing.Point(223, 92);
			this.txtTenKhuVuc.Name = "txtTenKhuVuc";
			this.txtTenKhuVuc.Size = new System.Drawing.Size(205, 27);
			this.txtTenKhuVuc.TabIndex = 12;
			// 
			// txtTrangThai
			// 
			this.txtTrangThai.Location = new System.Drawing.Point(627, 53);
			this.txtTrangThai.Name = "txtTrangThai";
			this.txtTrangThai.Size = new System.Drawing.Size(205, 27);
			this.txtTrangThai.TabIndex = 11;
			// 
			// txtMaKhuVuc
			// 
			this.txtMaKhuVuc.Location = new System.Drawing.Point(223, 49);
			this.txtMaKhuVuc.Name = "txtMaKhuVuc";
			this.txtMaKhuVuc.Size = new System.Drawing.Size(205, 27);
			this.txtMaKhuVuc.TabIndex = 6;
			// 
			// lblTenKhuVuc
			// 
			this.lblTenKhuVuc.AutoSize = true;
			this.lblTenKhuVuc.Location = new System.Drawing.Point(85, 97);
			this.lblTenKhuVuc.Name = "lblTenKhuVuc";
			this.lblTenKhuVuc.Size = new System.Drawing.Size(99, 20);
			this.lblTenKhuVuc.TabIndex = 5;
			this.lblTenKhuVuc.Text = "Tên khu vực";
			// 
			// lblTrangThai
			// 
			this.lblTrangThai.AutoSize = true;
			this.lblTrangThai.Location = new System.Drawing.Point(489, 56);
			this.lblTrangThai.Name = "lblTrangThai";
			this.lblTrangThai.Size = new System.Drawing.Size(84, 20);
			this.lblTrangThai.TabIndex = 4;
			this.lblTrangThai.Text = "Trạng thái";
			// 
			// lblMaKhuVuc
			// 
			this.lblMaKhuVuc.AutoSize = true;
			this.lblMaKhuVuc.Location = new System.Drawing.Point(85, 56);
			this.lblMaKhuVuc.Name = "lblMaKhuVuc";
			this.lblMaKhuVuc.Size = new System.Drawing.Size(94, 20);
			this.lblMaKhuVuc.TabIndex = 0;
			this.lblMaKhuVuc.Text = "Mã khu vực";
			// 
			// dataGVQLKhuVuc
			// 
			this.dataGVQLKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVQLKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhuvuc,
            this.tenkhuvuc,
            this.trangthai});
			this.dataGVQLKhuVuc.Location = new System.Drawing.Point(32, 331);
			this.dataGVQLKhuVuc.Name = "dataGVQLKhuVuc";
			this.dataGVQLKhuVuc.Size = new System.Drawing.Size(862, 191);
			this.dataGVQLKhuVuc.TabIndex = 6;
			this.dataGVQLKhuVuc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVQLKhuVuc_RowEnter);
			// 
			// makhuvuc
			// 
			this.makhuvuc.DataPropertyName = "MAKHUVUC";
			this.makhuvuc.HeaderText = "Mã khu vực";
			this.makhuvuc.Name = "makhuvuc";
			this.makhuvuc.ReadOnly = true;
			this.makhuvuc.Width = 270;
			// 
			// tenkhuvuc
			// 
			this.tenkhuvuc.DataPropertyName = "TENKHUVUC";
			this.tenkhuvuc.HeaderText = "Tên khu vực";
			this.tenkhuvuc.Name = "tenkhuvuc";
			this.tenkhuvuc.ReadOnly = true;
			this.tenkhuvuc.Width = 270;
			// 
			// trangthai
			// 
			this.trangthai.DataPropertyName = "TRANGTHAI";
			this.trangthai.HeaderText = "Trạng thái";
			this.trangthai.Name = "trangthai";
			this.trangthai.ReadOnly = true;
			this.trangthai.Width = 270;
			// 
			// QuanLiKhuVuc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(918, 534);
			this.Controls.Add(this.dataGVQLKhuVuc);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "QuanLiKhuVuc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuanLiKhuVuc";
			this.Load += new System.EventHandler(this.QuanLiKhuVuc_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGVQLKhuVuc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTenKhuVuc;
		private System.Windows.Forms.TextBox txtTrangThai;
		private System.Windows.Forms.TextBox txtMaKhuVuc;
		private System.Windows.Forms.Label lblTenKhuVuc;
		private System.Windows.Forms.Label lblTrangThai;
		private System.Windows.Forms.Label lblMaKhuVuc;
		private System.Windows.Forms.DataGridView dataGVQLKhuVuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhuvuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenkhuvuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
		private System.Windows.Forms.Button btnNhapLai;
	}
}