using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSieuThi.GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Open();
                string sql = "select * from NhanVien";
                SqlCommand commandsql = new SqlCommand(sql, kn);//thuc thi cac cau lenh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql);//van chuyen du lieu
                DataTable table = new DataTable();//tao 1 bang ao trong he thong 
                com.Fill(table);//do du lieu vao bang ao
                dgvNhanVien.DataSource = table;//bang ao nay duoc do vao datagrirdview
            }
            catch
            {
                MessageBox.Show("Loi Ket Noi Vui Long Kiem Tra Lai !");

            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Close();
            }
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            index = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            cbxGioiTinh.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
        }
        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Open();
                them = "insert into NhanVien values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtChucVu.Text + "',N'" + cbxGioiTinh.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Close();
            }
        }
        string sua;
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Open();
                sua = "update  NhanVien set TenNV=N'" + txtTenNV.Text + "',ChucVu=N'" + txtChucVu.Text + "',GioiTinh=N'" + cbxGioiTinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT=N'" + txtSDT.Text + "' where MaNV='" + txtMaNV.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Close();
            }
        }
        string xoa1;
        string xoa2;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                // SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Open();
                xoa1 = "delete  HoaDon where MaNV='" + txtMaNV.Text + "'";
                xoa2 = "delete  NhanVien where MaNV='" + txtMaNV.Text + "'";
                SqlCommand commandxoa1 = new SqlCommand(xoa1, kn);
                SqlCommand commandxoa2 = new SqlCommand(xoa2, kn);
                commandxoa1.ExecuteNonQuery();
                commandxoa2.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
                // SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ketnoi();
            dgvNhanVien_Click(sender, e);
        }
        string sqlTimKiem;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                conn.Open();
                //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // conn.Open();
                sqlTimKiem = "SELECT *FROM NhanVien where MaNV = '" + txtTimKiem.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("MaNV", txtTimKiem.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvNhanVien.DataSource = dt;
            }
            catch
            {
                MessageBox.Show(" không tìm thấy!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
