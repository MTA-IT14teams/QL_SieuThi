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
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                string sql = "select * from KhoHang";
                SqlCommand commandsql = new SqlCommand(sql, kn);//thuc thi cac cau lenh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql);//van chuyen du lieu
                DataTable table = new DataTable();//tao 1 bang ao trong he thong 
                com.Fill(table);//do du lieu vao bang ao
                dgvKhoHang.DataSource = table;//bang ao nay duoc do vao datagrirdview
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối! Vui lòng kiểm tra lại !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
            }
        }


        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dgvKhoHang_Click(object sender, EventArgs e)
        {
            index = dgvKhoHang.CurrentRow.Index;
            txtMaKho.Text = dgvKhoHang.Rows[index].Cells[0].Value.ToString();
            txtTenKho.Text = dgvKhoHang.Rows[index].Cells[1].Value.ToString();
            txtMaThuKho.Text = dgvKhoHang.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvKhoHang.Rows[index].Cells[3].Value.ToString();

        }

        // thêm
        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                them = "insert into KhoHang values('" + txtMaKho.Text + "',N'" + txtTenKho.Text + "',N'" + txtMaThuKho.Text + "',N'" + txtDiaChi.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được! Vui lòng thử lại");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
            }
        }

        // sửa
        string sua;
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                sua = "update  KhoHang set TenKho=N'" + txtTenKho.Text + "',DiaChi=N'" + txtDiaChi.Text + "' where MaKho='" + txtMaKho.Text + "'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được! Vui lòng thử lại!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();             
            }
        }

        // xóa
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Open();
                xoa = "delete  KhoHang where MaKho='" + txtMaKho.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
        
                commandxoa.ExecuteNonQuery();
           
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được! Vui lòng thử lại");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
            }
        }

        //refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ketnoi();
            dgvKhoHang_Click(sender, e);
        }

        // tìm kiếm
        string sqlTimKiem;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                conn.Open();

                sqlTimKiem = "SELECT *FROM KhoHang where MaKho = '" + txtTimKiem.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("MaKho", txtTimKiem.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvKhoHang.DataSource = dt;
            }
            catch
            {
                MessageBox.Show(" Không tìm thấy!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DataAccess.ThamSoKetNoi.stringConnect);
                kn.Close();
            }
        }
       
    }
}
