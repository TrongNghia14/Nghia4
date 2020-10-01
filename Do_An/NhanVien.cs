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
	public partial class NhanVien : Form {
		public NhanVien() {
			InitializeComponent();
		}

		Control_NhanVien control = new Control_NhanVien();
		string ma1;

		private void button2_Click(object sender, EventArgs e) {
			formMain frmMain = new formMain();
			frmMain.Show();
			this.Hide();
		}

		private void NhanVien_Load(object sender, EventArgs e) {
			// hiển thị bảng từ sql ra datagridview
			DataTable dt = new DataTable();
			dt = control.ShowBang();
			dataGVNhanVien.DataSource = dt;
		}

		private void btnLuu_Click(object sender, EventArgs e) {
			txtMaNhanVien.Clear();
			txtHoTen.Clear();
			txtGioiTinh.Clear();
			txtDiaChi.Clear();
			txtDienThoai.Clear();
			txtMaNhanVien.Focus();
		}

		private void dataGVNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e) {
			int dong;
			dong = e.RowIndex;
			ma1 = dataGVNhanVien.Rows[dong].Cells[0].Value.ToString(); // Biến này dùng để lưu mã lớp cũ  khi update mã lớp mới 
			this.txtMaNhanVien.Text = dataGVNhanVien.Rows[dong].Cells[0].Value.ToString();
			this.txtHoTen.Text = dataGVNhanVien.Rows[dong].Cells[1].Value.ToString();
			this.txtGioiTinh.Text = dataGVNhanVien.Rows[dong].Cells[2].Value.ToString();
			this.txtDienThoai.Text = dataGVNhanVien.Rows[dong].Cells[3].Value.ToString();
			this.txtDiaChi.Text = dataGVNhanVien.Rows[dong].Cells[5].Value.ToString();
		}

		//Thêm
		private void btnThem_Click(object sender, EventArgs e) {
			try {
				control.InsertNhanVien(this.txtMaNhanVien.Text, this.txtHoTen.Text, this.txtGioiTinh.Text, this.txtDienThoai.Text, dtNgaySinh.Value, this.txtDiaChi.Text);
				MessageBox.Show("Thêm thành công");
				NhanVien_Load(sender, e);
			} catch {
				MessageBox.Show("Thêm thất bại");
			}
		}

		//Xóa
		private void btnXoa_Click(object sender, EventArgs e) {
			if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa tên " + txtHoTen.Text + "hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
				control.DeleteNhanVien(ma1);
				MessageBox.Show("Đã xóa thành công");
				NhanVien_Load(sender, e);
			}
		}

		//Sửa
		private void btnSua_Click(object sender, EventArgs e) {
			try {
				control.UpdateNhanVien(ma1, this.txtMaNhanVien.Text, this.txtHoTen.Text, this.txtGioiTinh.Text, this.txtDienThoai.Text, dtNgaySinh.Value, this.txtDiaChi.Text);
				MessageBox.Show("Sửa thành công");
				NhanVien_Load(sender, e);
			} catch {
				MessageBox.Show("Không sửa được");
			}
		}

		//Tìm kiếm
		private void btnTim_Click(object sender, EventArgs e) {
			if(this.txtTimKiem.TextLength == 0)
				MessageBox.Show("Bạn chưa nhập mã nhân viên hoặc tên nhân viên cần tìm kiếm");
			else {
				DataTable dt = new DataTable();
				dt = control.lookNhanVien(this.txtTimKiem.Text);
				dataGVNhanVien.DataSource = dt;
				if(dt.Rows.Count == 0)
					MessageBox.Show("Không tìm thấy");
			}
		}

		private void txtTimKiem_MouseClick(object sender, MouseEventArgs e) {
			MessageBox.Show("Vui lòng nhập mã nhân viên hoặc tên nhân viên cần tìm kiếm");
		}

	}
}
