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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            LoadData();




        }
        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdThemMoi_Click(object sender, EventArgs e)
        {
            AddNewAndEditSinhVien Frm1 = new AddNewAndEditSinhVien();
            Frm1.MoiOrSua = "MOI";
            Frm1.ShowDialog();

            Frm1.Dispose();


            LoadData();

        }


        private void LoadData()
        {
         SqlConnection con;
            DataTable dt = new DataTable("tbNhanVien");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();


            String cn = @"Data Source=MACPRO-PC\SQL2008;Initial Catalog=QUANLYHOCSINH;Integrated Security=true";
            con = new SqlConnection();
            //con.Open();

            con.ConnectionString = cn;
            string SQL = "SELECT * FROM DANHSACHSINHVIEN ORDER BY MASINHVIEN";
            da = new SqlDataAdapter(SQL, cn);
            da.Fill(ds, "SINHVIEN");

            DBNoiDung.DataSource = ds;//.Tables("SINHVIEN");
            DBNoiDung.Refresh();

        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            string SQL = "";
            int id = 0;
            //id = DBNoiDung.ActiveRow.Cells("ID").value;

            id = Convert.ToInt32(DBNoiDung.ActiveCell.Value);

            SQL = "DELETE DANHSACHSINHVIEN WHERE ID=" + id;
            ExecSQL(SQL);
            LoadData();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdSua_Click(object sender, EventArgs e)
        {

            AddNewAndEditSinhVien Frm1 = new AddNewAndEditSinhVien();
            int id = 0;
            Frm1.MoiOrSua = "SUA";

            id = Convert.ToInt32(DBNoiDung.ActiveCell.Value);

            Frm1.id = id;
            Frm1.ShowDialog();

            Frm1.Dispose();


            LoadData();

        }

        private void DBNoiDung_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }
    }




}
