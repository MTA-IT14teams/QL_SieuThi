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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        public string TangMa()
        {
            SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
            conn.Open();
            string sql = "select *from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KH01";
            }
            else
            {
                int k = 0;
                ma = "kh";
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

        public void KetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "select *from KhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);

                dgvKhachHang.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dgvKhachHang.DataSource, "GioiTinh");     
            txtTuoiKH.DataBindings.Clear();
            txtTuoiKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "TuoiKH");
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
            LockControl();
        }

        public void LockControl()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtTuoiKH.Enabled = false;
            cboGioiTinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        public void unLockControl()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtTuoiKH.Enabled = true;
            cboGioiTinh.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        public void setnull()
        {           
            txtTenKH.Text = "";
            txtTuoiKH.Text = "";
            cboGioiTinh.Text = "";
        }

        bool state = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            state = true;
            TangMa();
            unLockControl();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaKH.Text = TangMa();
            setnull();
            dgvKhachHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = false;
            unLockControl();
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa " + txtTenKH.Text.Trim() + " khỏi danh sách không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete KhachHang where MaKH = @Makh", conn);
                   // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Đã xóa!");
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
            cboGioiTinh.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setnull();
            LockControl();
            dgvKhachHang.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private bool DemDong()
        {
            if (dgvKhachHang.RowCount > 1)
                return true;
            else 
                return false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try { 
                SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                conn.Open();
                string sql = "";

                if (cbbKieuTK.Text == "Theo Mã Khách Hàng")
                {
                    sql = "select *from KhachHang where MaKH = '" + txtTimKiem.Text.Trim() + "'";
                }
                else if (cbbKieuTK.Text == "Theo Tên Khách Hàng")
                {
                    sql = "select *from KhachHang where TenKH like N'%" + txtTimKiem.Text.Trim() + "%'";
                }
                else if (cbbKieuTK.Text == "Theo Giới Tính")
                {
                    sql = "select *from KhachHang where GioiTinh = N'" + txtTimKiem.Text.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;

                if (DemDong() == false)
                    MessageBox.Show("Không có khách hàng bạn cần tìm");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKhachHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Proc_ThemKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tenkh", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tuoi", txtTuoiKH.Text.Trim());
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Đã thêm!");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnXoa.Enabled = true;
                    dgvKhachHang.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được khách hàng" + ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DataAccess.ConnectionString.connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SuaKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Makh", txtMaKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tenkh", txtTenKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tuoi", txtTuoiKH.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Đã sửa");
                    KetNoi();
                    LoadData();
                    LockControl();
                    btnXoa.Enabled = true;
                    dgvKhachHang.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được khách hàng!" + ex.Message);
                }
            }
        }
        public static void ExportToExcel(DataGridView dtgr)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = -1; i < dtgr.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgr.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgr.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgr.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                worksheet.Columns.AutoFit();
                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvKhachHang);
        }
    }
}
