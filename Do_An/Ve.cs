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
	public partial class Ve : Form {
		public Ve() {
			InitializeComponent();
		}

		Control_Ve control = new Control_Ve();

		private void button2_Click(object sender, EventArgs e) {
			formMain frmMain = new formMain();
			frmMain.Show();
			this.Hide();
		}

		private void Ve_Load(object sender, EventArgs e) {
			// hiển thị bảng từ sql ra datagridview
			DataTable dt = new DataTable();
			dt = control.ShowBang();
			dataGVVe.DataSource = dt;
		}
	}
}
