using System;
using System.Data;
using System.Data.SqlClient;

namespace quanlyhocsinh
{
   public class ClassSinhVien
    {

        public static void ExecSQL(string SQL)
        {

            SqlConnection con;

            String cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYHOCSINH;Integrated Security=true";
            con = new SqlConnection(cn);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = SQL;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            

        }
        public static string TimGiaTriText(string fieldname,int id)
        {
            string retVal = "";
            SqlDataAdapter da = new SqlDataAdapter();
            String cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYHOCSINH;Integrated Security=true";

            string SQL = "SELECT " + fieldname + " FROM DANHSACHSINHVIEN WHERE ID=" + id;
            da = new SqlDataAdapter(SQL, cn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                if (ds.Rows[0][0] != DBNull.Value) retVal = (string)Convert.ToString(ds.Rows[0][0]);
            }
            return retVal;
        }
    }
}
