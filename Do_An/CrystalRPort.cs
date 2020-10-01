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
	public partial class CrystalRPort : Form {
		public CrystalRPort() {
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e) {
			formMain frmMain = new formMain();
			frmMain.Show();
			this.Hide();
		}

		private void CrystalRP_Load(object sender, EventArgs e) {
			DataTable dt = new DataTable();
			Control_NhanVien c = new Control_NhanVien();
			dt = c.ShowBang();
			CrystalReport3 rp = new CrystalReport3(); // Khai báo 1 crustal report đã đc tạo ra
			rp.SetDataSource(dt); // đưa data vào cái report
			crystalReportViewer1.ReportSource = rp; // Gán cái dữ liệu đó cho cái viewer dc tạo ra ở bên design.
		}
	}
}
