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
	public partial class QuanLiKhuVuc : Form {
		public QuanLiKhuVuc() {
			InitializeComponent();
		}

		Control_QLKhuVuc control = new Control_QLKhuVuc();
		string ma1;

		private void button2_Click(object sender, EventArgs e) {
			BaiXe frmBaiXe = new BaiXe();
			frmBaiXe.Show();
			this.Hide();
		}

		private void QuanLiKhuVuc_Load(object sender, EventArgs e) {
			// hiển thị bảng từ sql ra datagridview
			DataTable dt = new DataTable();
			dt = control.ShowBang();
			dataGVQLKhuVuc.DataSource = dt;
		}

		private void dataGVQLKhuVuc_RowEnter(object sender, DataGridViewCellEventArgs e) {
			int dong;
			dong = e.RowIndex;
			ma1 = dataGVQLKhuVuc.Rows[dong].Cells[0].Value.ToString(); // Biến này dùng để lưu mã cũ  khi update mã mới 
			this.txtMaKhuVuc.Text = dataGVQLKhuVuc.Rows[dong].Cells[0].Value.ToString();
			this.txtTenKhuVuc.Text = dataGVQLKhuVuc.Rows[dong].Cells[1].Value.ToString();
			this.txtTrangThai.Text = dataGVQLKhuVuc.Rows[dong].Cells[2].Value.ToString();
		}

		private void btnNhapLai_Click(object sender, EventArgs e) {
			txtMaKhuVuc.Clear();
			txtTenKhuVuc.Clear();
			txtTrangThai.Clear();
			txtMaKhuVuc.Focus();
		}

		private void btnThem_Click(object sender, EventArgs e) {
			try {
				control.InsertKhuVuc(this.txtMaKhuVuc.Text, this.txtTenKhuVuc.Text, this.txtTrangThai.Text);
				MessageBox.Show("Thêm thành công");
				QuanLiKhuVuc_Load(sender, e);
			} catch {
				MessageBox.Show("Thêm thất bại");
			}
		}

		private void btnSua_Click(object sender, EventArgs e) {
			try {
				control.UpdateKhuVuc(ma1, this.txtMaKhuVuc.Text, this.txtTenKhuVuc.Text, this.txtTrangThai.Text);
				MessageBox.Show("Sửa thành công");
				QuanLiKhuVuc_Load(sender, e);
			} catch {
				MessageBox.Show("Không sửa được");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e) {
			if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa " + txtTenKhuVuc.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
				control.DeleteKhuVuc(ma1);
				MessageBox.Show("Đã xóa thành công");
				QuanLiKhuVuc_Load(sender, e);
			}
		}

		private void btnTim_Click(object sender, EventArgs e) {
			if(this.txtTimKiem.TextLength == 0)
				MessageBox.Show("Bạn chưa nhập mã khu vực hoặc tên khu vực cần tìm kiếm");
			else {
				DataTable dt = new DataTable();
				dt = control.LookKhuVuc(this.txtTimKiem.Text);
				dataGVQLKhuVuc.DataSource = dt;
				if(dt.Rows.Count == 0)
					MessageBox.Show("Không tìm thấy");
			}
		}

		private void txtTimKiem_MouseClick(object sender, MouseEventArgs e) {
			MessageBox.Show("Vui lòng nhập mã khu vực hoặc tên khu vực cần tìm kiếm");
		}
	}
}
