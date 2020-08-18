using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlyhocsinh
{
    public partial class EditSinhVien : Form
    {
        public int id;
        string msv = "";
        public EditSinhVien()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            msv = TimGiaTriText("MASINHVIEN");
            MaSinhVien.Text = TimGiaTriText("MASINHVIEN");
            TenSinhVien.Text = TimGiaTriText("TENSINHVIEN");
            GioiTinh.Text = TimGiaTriText("GIOITINH");
            QueQuan.Text = TimGiaTriText("QUEQUAN");

        }

        string TimGiaTriText( string fieldname)
        {
            string retVal = "";
            SqlDataAdapter da = new SqlDataAdapter();
            String cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYHOCSINH;Integrated Security=true";
        
            string SQL = "SELECT "+ fieldname+" FROM DANHSACHSINHVIEN WHERE ID="+id;
            da = new SqlDataAdapter(SQL, cn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                if (ds.Rows[0][0] != DBNull.Value) retVal = (string)Convert.ToString(ds.Rows[0][0]);
            }
            return retVal;
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            string SQL = "";
            SQL = "UPDATE DANHSACHSINHVIEN  SET MASINHVIEN=N'" + MaSinhVien.Text + "',TENSINHVIEN=N'" + TenSinhVien.Text + "',GIOITINH=N'" + GioiTinh.Text + "',QUEQUAN=N'" + QueQuan.Text + "' WHERE ID="+id;
             
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

        private void EditSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool KiemTraCoHayKhong(string txt)
        {
            bool retVal = false;
            SqlDataAdapter da = new SqlDataAdapter();
            String cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYHOCSINH;Integrated Security=true";

            string SQL = "SELECT * FROM DANHSACHSINHVIEN WHERE MASINHVIEN=N'" + txt + "'";
            da = new SqlDataAdapter(SQL, cn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                retVal = true;
            }
            return retVal;
        }

        
            private void MaSinhVien_TextChanged(object sender, EventArgs e)
            {
                if (msv != MaSinhVien.Text)
                {
                    if (KiemTraCoHayKhong(MaSinhVien.Text) == true)
                    {
                        MessageBox.Show("Mã này đã có rồi");
                    }
                }
            }
        }
    }

