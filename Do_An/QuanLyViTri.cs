using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An {
	public partial class QuanLyViTri : Form {
		public QuanLyViTri() {
			InitializeComponent();
		}

		Control_QLViTri control = new Control_QLViTri();
		string ma1;

		private void button2_Click(object sender, EventArgs e) {
			BaiXe frmBaiXe = new BaiXe();
			frmBaiXe.Show();
			this.Hide();
		}

		private void QuanLyViTri_Load(object sender, EventArgs e) {
			// hiển thị bảng từ sql ra datagridview
			DataTable dt = new DataTable();
			dt = control.ShowBang();
			dataGVQLViTri.DataSource = dt;
		}


			//int dong;
			//dong = e.RowIndex;
			//ma1 = dataGVQLViTri.Rows[dong].Cells[0].Value.ToString(); // Biến này dùng để lưu mã cũ  khi update mã mới 
			//this.txtMaViTri.Text = dataGVQLViTri.Rows[dong].Cells[0].Value.ToString();
			//this.txtTenViTri.Text = dataGVQLViTri.Rows[dong].Cells[1].Value.ToString();
			//this.txtTrangThai.Text = dataGVQLViTri.Rows[dong].Cells[2].Value.ToString();
		

		private void btnNhapLai_Click(object sender, EventArgs e) {
			txtMaViTri.Clear();
			txtTenViTri.Clear();
			txtTrangThai.Clear();
			txtMaKhuVuc.Clear();
			txtMaViTri.Focus();
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				control.InsertViTri(this.txtMaViTri.Text, this.txtTenViTri.Text, this.txtTrangThai.Text, this.txtMaKhuVuc.Text);
				MessageBox.Show("Thêm thành công");
				QuanLyViTri_Load(sender, e);
			} catch {
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e) {
			try {
				control.UpdateViTri(ma1, this.txtMaViTri.Text, this.txtTenViTri.Text, this.txtTrangThai.Text, this.txtMaKhuVuc.Text);
				MessageBox.Show("Sửa thành công");
				QuanLyViTri_Load(sender, e);
			} catch {
				MessageBox.Show("Không sửa được");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e) {
			if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa " + txtTenViTri.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
				control.DeleteViTri(ma1);
				MessageBox.Show("Đã xóa thành công");
				QuanLyViTri_Load(sender, e);
			}
		}

		private void btnTim_Click(object sender, EventArgs e) {
			if(this.txtTimKiem.TextLength == 0)
				MessageBox.Show("Vui lòng nhập mã vị trí hoặc tên vị trí cần tìm kiếm");
			else {
				DataTable dt = new DataTable();
				dt = control.LookViTri(this.txtTimKiem.Text);
				dataGVQLViTri.DataSource = dt;
				if(dt.Rows.Count == 0)
					MessageBox.Show("Không tìm thấy");
			}
		}

		private void txtTimKiem_MouseClick(object sender, MouseEventArgs e) {
			MessageBox.Show("Vui lòng nhập mã vị trí hoặc tên vị trí cần tìm kiếm");
		}
	}
}
