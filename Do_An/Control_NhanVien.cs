using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An {
	class Control_NhanVien {
		DataAccess da = new DataAccess();

		//Hàm lấy thông tin  Lớp đổ ra 1 datagridview 
		public DataTable ShowBang() {
			string sql = "SELECT * FROM NHANVIEN";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}

		// Thêm
		public void InsertNhanVien(string ma, string hoten, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi) {
			string sql = "INSERT NHANVIEN VALUES('" + ma + "',N'" + hoten + "', N'" + gioitinh + "', '" + dienthoai+ "'," +
				"'" + ngaysinh.ToShortDateString() + "',N'" + diachi + "')";
			da.ExcuteNonQuery(sql); // Lệnh thực thi không trả về bảng đã viết bên lớp 1
		}

		// Sửa 
		public void UpdateNhanVien(string ma1, string ma, string hoten, string gioitinh, string dienthoai, DateTime ngaysinh, string diachi) {
			string sql = "UPDATE NHANVIEN set MANHANVIEN = '" + ma + "', TENNHANVIEN = N'" + hoten + "', GIOITINH = N'" + gioitinh+ 
				"', DIENTHOAI = '" + dienthoai + "', NGAYSINH = '" + ngaysinh.ToShortDateString() + "', DIACHI = N'" + diachi +
				"' WHERE MANHANVIEN = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Xóa
		public void DeleteNhanVien(string ma1) {
			string sql = "DELETE NHANVIEN WHERE MANHANVIEN = '" + ma1 + "'";
			da.ExcuteNonQuery(sql);
		}

		// Tìm kiếm 
		public DataTable lookNhanVien(string dk) {

			string sql = "SELECT * FROM NHANVIEN WHERE MANHANVIEN LIKE '%" + dk + "%' OR TENNHANVIEN LIKE N'%" + dk + "%'";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}
	}
}
