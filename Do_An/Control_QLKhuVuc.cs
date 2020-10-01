using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An {
	class Control_QLKhuVuc {
		DataAccess da = new DataAccess();

		// Hàm lấy thông tin  Lớp đổ ra 1 datagridview 
		public DataTable ShowBang() {
			string sql = "SELECT * FROM KHUVUC";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}

		// Thêm
		public void InsertKhuVuc(string ma, string ten, string trangthai) {
			string sql = "INSERT KHUVUC VALUES('" + ma + "',N'" + ten + "', N'" + trangthai + "')";
			da.ExcuteNonQuery(sql); // Lệnh thực thi không trả về bảng đã viết bên lớp 1
		}

		// Sửa 
		public void UpdateKhuVuc(string ma1, string ma, string ten, string trangthai) {
			string sql = "UPDATE KHUVUC set MAKHUVUC = '" + ma + "', TENKHUVUC = N'" + ten + "', TRANGTHAI = N'" + trangthai + "' WHERE MAKHUVUC = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Xóa
		public void DeleteKhuVuc(string ma1) {
			string sql = "DELETE KHUVUC WHERE MAKHUVUC = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Tìm kiếm 
		public DataTable LookKhuVuc(string dk) {

			string sql = "SELECT * FROM KHUVUC WHERE MAKHUVUC LIKE '%" + dk + "%' OR TENKHUVUC LIKE N'%" + dk + "%'";
			//string sql = "SELECT * FROM KHUVUC WHERE MAKHUVUC LIKE '%" + dk + "%' OR TENKHUVUC LIKE N'%" + dk + "%' OR GIOITINH N'%" + dk + "%' OR DIENTHOAI LIKE '%" + dk + "%' OR DIACHI LIKE N'%" + dk + "%'";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}
	}
}
