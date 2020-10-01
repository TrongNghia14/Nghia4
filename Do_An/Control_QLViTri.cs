using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An {
	class Control_QLViTri {
		DataAccess da = new DataAccess();

		// Ta viết thử 1 hàm lấy thông tin  Lớp đổ ra 1 datagridview 
		public DataTable ShowBang() {
			string sql = "SELECT * FROM VITRI";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}

		// Thêm
		public void InsertViTri(string ma, string ten, string trangthai, string makhuvuc) {
			string sql = "INSERT VITRI VALUES('" + ma + "',N'" + ten + "', N'" + trangthai + "', '" + makhuvuc + "')";
			da.ExcuteNonQuery(sql); // Lệnh thực thi không trả về bảng đã viết bên lớp 1
		}

		// Sửa 
		public void UpdateViTri(string ma1, string ma, string ten, string trangthai, string makhuvuc) {
			string sql = "UPDATE VITRI set MAVITRI = '" + ma + "', TENVITRI = N'" + ten + "', TRANGTHAI = N'" + trangthai + "', MAKHUVUC = '" + makhuvuc + "' WHERE MAVITRI = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Xóa
		public void DeleteViTri(string ma1) {
			string sql = "DELETE VITRI WHERE MAVITRI = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Tìm kiếm 
		public DataTable LookViTri(string dk) {

			string sql = "SELECT * FROM VITRI WHERE MAVITRI LIKE '%" + dk + "%' OR TENVITRI LIKE N'%" + dk + "%'";
			//string sql = "SELECT * FROM VITRI WHERE MAVITRI LIKE '%" + dk + "%' OR TENVITRI LIKE N'%" + dk + "%' OR GIOITINH N'%" + dk + "%' OR DIENTHOAI LIKE '%" + dk + "%' OR DIACHI LIKE N'%" + dk + "%'";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}
	}
}
