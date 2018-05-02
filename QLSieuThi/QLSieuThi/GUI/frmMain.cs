using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace QLSieuThi.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            Thread.Sleep(1500);
            t.Abort();
            this.ShowDialog();
        }

        void Splash()
        {
            GUI.flash f = new GUI.flash();
            f.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            GUI.Intro it = new Intro();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();

            //lblTen.Text = "Chào bạn: " +DTO.ConnectDatabase.NameLogin;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Intro it = new Intro();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();
        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thông tin tài khoản đã lưu? \nBạn sẽ phải thiết đặt lại thông tin trong lần đăng nhập tới!", "Xóa thông tin đã lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete("config");
                File.Delete("info.ini");
                MessageBox.Show("Đã xóa thông tin tài khoản!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void QLKhachHang_Click(object sender, EventArgs e)
        {
            GUI.frmKhachHang it = new frmKhachHang();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            GUI.frmBanHang it = new frmBanHang();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> ffe2e398d8e1b9b222f4187d921755bfcfef8e9a
=======
>>>>>>> ffe2e398d8e1b9b222f4187d921755bfcfef8e9a

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            GUI.frmNhanVien it = new frmNhanVien();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            GUI.frmKhoHang it = new frmKhoHang();
            it.MdiParent = this;
            it.WindowState = FormWindowState.Maximized;
            it.Show();

        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 0d82fcd47885fd23fad8cbd52ba989827305b79a
>>>>>>> ffe2e398d8e1b9b222f4187d921755bfcfef8e9a
=======
=======
>>>>>>> 0d82fcd47885fd23fad8cbd52ba989827305b79a
>>>>>>> ffe2e398d8e1b9b222f4187d921755bfcfef8e9a
    }
}
