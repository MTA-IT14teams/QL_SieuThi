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

namespace QLSieuThi.GUI
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HD01";
            }
            else
            {
                int k = 0;
                ma = "HD";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }

        public void ShowHH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select MaHH, TenHH from HangHoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboHangHoa.DataSource = dt;
            cboHangHoa.DisplayMember = "TenHH";
            cboHangHoa.ValueMember = "MaHH";
        }

        private void LoadKH()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhachHang where MaKH = @Makh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;
        }

        private void txtMaKH_MouseLeave(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                LoadKH();
            }
        }

        private void XemHoaDon()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from HoaDon where MaHD = @Mahd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Mahd", txtMaHD.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongTin.DataSource = dt;
        }

        private void XemChiTiet()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select MaHH, SoLuong, ThanhTien from ChiTietHoaDon where MaHD = @Mahd";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Mahd", txtMaHD.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvChiTiet.DataSource = dt;
        }

        bool SellFirst = true;
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (SellFirst == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("BanHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    cmd.Parameters.AddWithValue("@MaHH", cboHangHoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
                    int temp = cmd.ExecuteNonQuery();

                    if (temp != 0)
                    {
                        MessageBox.Show("Đã bán!");
                        SellFirst = false;
                        groupBox1.Enabled = false;
                        XemHoaDon();
                        XemChiTiet();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThemCTHD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHH", cboHangHoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
                    int temp = cmd.ExecuteNonQuery();

                    if (temp != 0)
                    {
                        MessageBox.Show("Đã bán!");
                        SellFirst = false;
                        groupBox1.Enabled = false;
                        XemHoaDon();
                        XemChiTiet();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void frmBanHang_Load(object sender, EventArgs e)
        {
            ShowHH();
            txtMaHD.Text = TangMa();
            txtMaHD.ReadOnly = true;
        }


    }
}
