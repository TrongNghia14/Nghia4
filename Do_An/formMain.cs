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
	public partial class formMain : Form {
		public formMain() {
			InitializeComponent();
		}

		private void btnNhanVien_Click(object sender, EventArgs e) {
			NhanVien frmNhanVien = new NhanVien();
			frmNhanVien.Show();
			this.Hide();
		}

		private void btnBaiXe_Click(object sender, EventArgs e) {
			BaiXe frmBaiXe = new BaiXe();
			frmBaiXe.Show();
			this.Hide();

		}

		private void btnVeXe_Click(object sender, EventArgs e) {
			Ve frmVe = new Ve();
			frmVe.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e) {
			ThongKe frmThongKe = new ThongKe();
			frmThongKe.Show();
			this.Hide();
		}

		private void btnHeThong_Click(object sender, EventArgs e) {
			HeThong frmHeThong = new HeThong();
			frmHeThong.Show();
			this.Hide();
		}

		private void btnDoanhThu_Click(object sender, EventArgs e) {
			DoanhThu frmDoanhthu = new DoanhThu();
			frmDoanhthu.Show();
			this.Hide();
		}

		private void btnCrystalReport_Click(object sender, EventArgs e) {
			CrystalRPort frmRP = new CrystalRPort();
			frmRP.Show();
			this.Hide();
		}
	}
}
