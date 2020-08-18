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

namespace quanlyhocsinh
{
    public partial class AddNewSinhVien : Form
    {
        public AddNewSinhVien()
        {
            InitializeComponent();
        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            string SQL = "";
            SQL = "INSERT INTO DANHSACHSINHVIEN (MASINHVIEN,TENSINHVIEN,GIOITINH,QUEQUAN)";
            SQL += "VALUES (N'" + MaSinhVien.Text + "',N'" + TenSinhVien.Text + "',N'" + GioiTinh.Text + "',N'" + QueQuan.Text + "')";
            ExecSQL(SQL);
        }

        private void ExecSQL(string SQL)
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
            this.Dispose();

        }

        private void MaSinhVien_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
