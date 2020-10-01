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
	public partial class BaiXe : Form {
		public BaiXe() {
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e) {
			formMain frmMain = new formMain();
			frmMain.Show();
			this.Hide();
		}

		private void btnQuanLiKhuVuc_Click(object sender, EventArgs e) {
			QuanLiKhuVuc frmQuanLiKhuVuc = new QuanLiKhuVuc();
			frmQuanLiKhuVuc.Show();
			this.Hide();
		}

		private void btnQuanLyViTri_Click(object sender, EventArgs e) {
			QuanLyViTri frmQuanLiViTri = new QuanLyViTri();
			frmQuanLiViTri.Show();
			this.Hide();
		}
	}
}
