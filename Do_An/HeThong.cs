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
	public partial class HeThong : Form {
		public HeThong() {
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e) {
			formMain frmMain = new formMain();
			frmMain.Show();
			this.Hide();
		}

		private void btnDangXuat_Click(object sender, EventArgs e) {
			if(DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
				formDangNhap frmDangNhap = new formDangNhap();
				frmDangNhap.Show();
				this.Hide();
			}			
		}

		private void btnDoiMatKhau_Click(object sender, EventArgs e) {
			DoiMatKhau frmDoiMatKhau = new DoiMatKhau();
			frmDoiMatKhau.Show();
			this.Hide();
		}
	}
}
