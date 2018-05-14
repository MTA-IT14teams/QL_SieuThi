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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from HangHoa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);

                dgvHangHoa.DataSource = dv;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from HangHoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HH01";
            }
            else
            {
                int k = 0;
                ma = "HH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
           // MessageBox.Show("" + ma);
            return ma;

        }
        public void LoadData()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "MaHH");

            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenHH");

            txtChungLoai.DataBindings.Clear();
            txtChungLoai.DataBindings.Add("Text", dgvHangHoa.DataSource, "ChungLoai");

            txtDonVT.DataBindings.Clear();
            txtDonVT.DataBindings.Add("Text", dgvHangHoa.DataSource, "DonViTinh");

            txtTrongLuong.DataBindings.Clear();
            txtTrongLuong.DataBindings.Add("Text", dgvHangHoa.DataSource, "TrongLuong");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dgvHangHoa.DataSource, "GiaBan");

            txtNoiSX.DataBindings.Clear();
            txtNoiSX.DataBindings.Add("Text", dgvHangHoa.DataSource, "NoiSX");

            dtpHSD.DataBindings.Clear();
            dtpHSD.DataBindings.Add("Text", dgvHangHoa.DataSource, "HSD");


        }
        public void LockControl()
        {
            txtMaHH.Enabled = false;
            txtChungLoai.Enabled = false;
            txtDonVT.Enabled = false;
            txtGiaBan.Enabled = false;
            txtTenHH.Enabled = false;
            txtNoiSX.Enabled = false;
            dtpHSD.Enabled = false;
            txtTrongLuong.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

        }
        public void unLockControl()
        {
            txtMaHH.Enabled = true;
            txtChungLoai.Enabled = true;
            txtDonVT.Enabled = true;
            txtGiaBan.Enabled = true;
            txtTenHH.Enabled = true;
            txtNoiSX.Enabled = true;
            dtpHSD.Enabled = true;
            txtTrongLuong.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            LockControl();

        }
        public void setnull()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtNoiSX.Text = "";
            txtChungLoai.Text = "";
            txtDonVT.Text = "";
            txtGiaBan.Text = "";
            txtTrongLuong.Text = "";
            dtpHSD.Text = "";


        }
        bool tmp = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            tmp = true;
            setnull();
            //txtMaHH.Text = TangMa();
            unLockControl();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaHH.Text = TangMa();

            dgvHangHoa.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tmp = false;
            unLockControl();
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa " + txtTenHH.Text.Trim() + " hàng hóa không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Delete HangHoa where MaHH = @MaHH", conn);
                       
                        cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa!");
                        KetNoi();
                        LoadData();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không xóa được! " + ex.Message);
                }
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            txtTimKiem.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(tmp==true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThemHH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChungLoai", txtChungLoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonVT.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrongLuong",txtTrongLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaBan", txtGiaBan.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoiSX", txtNoiSX.Text.Trim());
                    cmd.Parameters.AddWithValue("@HSD", dtpHSD.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm!");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnXoa.Enabled = true;
                    dgvHangHoa.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thêm được!" + ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaHH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChungLoai", txtChungLoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDonVT.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrongLuong", txtTrongLuong.Text.Trim());
                    cmd.Parameters.AddWithValue("@GiaBan", txtGiaBan.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoiSX", txtNoiSX.Text.Trim());
                    cmd.Parameters.AddWithValue("@HSD", dtpHSD.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnXoa.Enabled = true;
                    dgvHangHoa.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không sửa được!" + ex.Message);
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setnull();
            LockControl();
            dgvHangHoa.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
           
            string sql = "";
            if(cbbKieuTK.Text=="Theo mã hàng hóa")
            {
                sql = "select *from HangHoa Where MaHH='" + txtTimKiem.Text.Trim() + "'";
            }
            if (cbbKieuTK.Text == "Theo tên hàng hóa")
            {
                sql = "select *from HangHoa Where TenHH like N'%" + txtTimKiem.Text.Trim() + "'";
            }
            if (cbbKieuTK.Text == "Theo chủng loại")
            {
                sql = "select *from HangHoa Where ChungLoai like N'%" + txtTimKiem.Text.Trim() + "'";
            }
            if (cbbKieuTK.Text == "Theo nơi sản xuất")
            {
                sql = "select *from HangHoa Where NoiSX like N'%" + txtTimKiem.Text.Trim() + "'";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHangHoa.DataSource = dt;
        }

        private void dgvHangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHangHoa.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;

        }
    }
}
