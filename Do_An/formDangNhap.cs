using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An {
	public partial class formDangNhap : Form {
		public formDangNhap() {
			InitializeComponent();
		}

		DataAccess a = new DataAccess();
		private void btnDangNhap_Click(object sender, EventArgs e) {
			if(txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
				MessageBox.Show("Không được để trống !!!!");
			else {
				//http://www.hoclaptrinh.xyz/2014/12/code-c-huong-dan-tao-form-ang-nhap-on.html code hướng dẫn làm đăng nhập
				SqlConnection conn = a.getConnect();
				string sql = "SELECT * FROM DANGNHAP WHERE MATAIKHOAN='" + txtTaiKhoan.Text + "'AND MATKHAU = '" + txtMatKhau.Text + "'";
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataReader reader = cmd.ExecuteReader();
				if(reader.Read() == true) {
					formMain frmMain = new formMain();
					frmMain.Show();
					this.Hide();
				} else {
					MessageBox.Show("Tài khoản hoặc mật khẩu bị sai");
					txtTaiKhoan.Clear();
					txtMatKhau.Clear();
					txtTaiKhoan.Focus();
				}
			}						
		}

		private void btnThoat_Click(object sender, EventArgs e) {
			if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				Application.Exit();
		}

		private void formDangNhap_Load(object sender, EventArgs e) {

		}
	}
}
