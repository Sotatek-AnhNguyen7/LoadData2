using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
 
namespace quanlyhocsinh
{
    public partial class AddNewAndEditSinhVien : Form
    {
    public string MoiOrSua;
        public int id;
        string msv = "";
    public AddNewAndEditSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewAndEditSinhVien_Load(object sender, EventArgs e)
        {
            if (MoiOrSua == "SUA")
            {
                this.Text = "Sửa Danh Mục Sinh Viên";
                LoadData();
            }
            else 
            {
                this.Text = "Thêm Mới Sinh Viên";
             }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string SQL = "";
            if (MoiOrSua == "SUA")
            {
                SQL = "UPDATE DANHSACHSINHVIEN  SET MASINHVIEN=N'" + MaSinhVien.Text + "',TENSINHVIEN=N'" + TenSinhVien.Text + "',GIOITINH=N'" + cobGioiTinh.Text + "',QUEQUAN=N'" + QueQuan.Text + "' WHERE ID=" + id;

                ClassSinhVien.ExecSQL(SQL);
                this.Dispose();
            }
            else
            {
                 
                SQL = "INSERT INTO DANHSACHSINHVIEN (MASINHVIEN,TENSINHVIEN,GIOITINH,QUEQUAN)";
                SQL += "VALUES (N'" + MaSinhVien.Text + "',N'" + TenSinhVien.Text + "',N'" + cobGioiTinh.Text + "',N'" + QueQuan.Text + "')";
                ClassSinhVien.ExecSQL(SQL);
                this.Dispose();
            }
           
        }
      
        private void LoadData()
        {
            msv = ClassSinhVien.TimGiaTriText("MASINHVIEN",id);
            MaSinhVien.Text = ClassSinhVien.TimGiaTriText("MASINHVIEN", id);
            TenSinhVien.Text = ClassSinhVien.TimGiaTriText("TENSINHVIEN", id);
            cobGioiTinh.Text = ClassSinhVien.TimGiaTriText("GIOITINH", id);
            QueQuan.Text = ClassSinhVien.TimGiaTriText("QUEQUAN", id);

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
