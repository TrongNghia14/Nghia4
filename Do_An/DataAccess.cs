using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An {
	class DataAccess {
		public SqlConnection getConnect() {
			return new SqlConnection(@"Data Source=DESKTOP-KLIV45M;Initial Catalog=QLBaiDoXe;Integrated Security=True");
		}
		// Lệnh SQL trả về 1 bảng 
		public DataTable GetTable(string sql) {
			SqlConnection con = getConnect();
			SqlDataAdapter ad = new SqlDataAdapter(sql, con);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			return dt;
		}

		// Lênh SQL ko trả về 
		public void ExcuteNonQuery(string sql) {
			SqlConnection con = getConnect();
			con.Open();
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			con.Close();
		}
	}
}
