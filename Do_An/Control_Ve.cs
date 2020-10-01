using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An {
	class Control_Ve {
		DataAccess da = new DataAccess();

		// Ta viết thử 1 hàm lấy thông tin  Lớp đổ ra 1 datagridview 
		public DataTable ShowBang() {
			string sql = "SELECT * FROM VE";
			DataTable dt = new DataTable();
			dt = da.GetTable(sql);
			return dt;
		}
	}
}
