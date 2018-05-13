namespace QLSieuThi.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnMơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.hệThồngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.dữLiệuThốngKêToolStripMenuItem,
            this.btnHelp,
            this.btnGioiThieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // hệThồngToolStripMenuItem
            // 
            this.hệThồngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangNhap,
            this.toolStripMenuItem2,
            this.btnXemTaiKhoan,
            this.btnXoaThongTin});
            this.hệThồngToolStripMenuItem.Name = "hệThồngToolStripMenuItem";
            this.hệThồngToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.hệThồngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(238, 22);
            this.btnDangNhap.Text = "Đăng nhập";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(235, 6);
            // 
            // btnXemTaiKhoan
            // 
            this.btnXemTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.thêmTàiKhoảnMơiToolStripMenuItem});
            this.btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            this.btnXemTaiKhoan.Size = new System.Drawing.Size(238, 22);
            this.btnXemTaiKhoan.Text = "Xem tài khoản";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            // 
            // thêmTàiKhoảnMơiToolStripMenuItem
            // 
            this.thêmTàiKhoảnMơiToolStripMenuItem.Name = "thêmTàiKhoảnMơiToolStripMenuItem";
            this.thêmTàiKhoảnMơiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thêmTàiKhoảnMơiToolStripMenuItem.Text = "Thêm tài khoản mới";
            // 
            // btnXoaThongTin
            // 
            this.btnXoaThongTin.Name = "btnXoaThongTin";
            this.btnXoaThongTin.Size = new System.Drawing.Size(238, 22);
            this.btnXoaThongTin.Text = "Xóa thông tin mật khẩu đã lưu ";
            this.btnXoaThongTin.Click += new System.EventHandler(this.btnXoaThongTin_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnBanHang,
            this.btnKhoHang,
            this.btnHangHoa});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(152, 22);
            this.btnNhanVien.Text = "Nhân Viên";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(152, 22);
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.QLKhachHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(152, 22);
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(152, 22);
            this.btnKhoHang.Text = "Kho Hàng";
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(152, 22);
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // dữLiệuThốngKêToolStripMenuItem
            // 
            this.dữLiệuThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độcGiảToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.dữLiệuThốngKêToolStripMenuItem.Name = "dữLiệuThốngKêToolStripMenuItem";
            this.dữLiệuThốngKêToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.dữLiệuThốngKêToolStripMenuItem.Text = "Dữ liệu thống kê";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.độcGiảToolStripMenuItem.Text = "Thống Kê";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // btnHelp
            // 
            this.btnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.feedBackToolStripMenuItem});
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(64, 20);
            this.btnHelp.Text = "Trợ Giúp";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewHelpToolStripMenuItem.Text = "Xem hướng dẫn";
            // 
            // feedBackToolStripMenuItem
            // 
            this.feedBackToolStripMenuItem.Name = "feedBackToolStripMenuItem";
            this.feedBackToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.feedBackToolStripMenuItem.Text = "FeedBack";
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềChúngTôiToolStripMenuItem,
            this.thôngTinPhiênBảnToolStripMenuItem,
            this.toolStripMenuItem1,
            this.checkUpdateToolStripMenuItem});
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(73, 20);
            this.btnGioiThieu.Text = "Giới Thiệu";
            // 
            // vềChúngTôiToolStripMenuItem
            // 
            this.vềChúngTôiToolStripMenuItem.Name = "vềChúngTôiToolStripMenuItem";
            this.vềChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.vềChúngTôiToolStripMenuItem.Text = "Về Chúng Tôi";
            // 
            // thôngTinPhiênBảnToolStripMenuItem
            // 
            this.thôngTinPhiênBảnToolStripMenuItem.Name = "thôngTinPhiênBảnToolStripMenuItem";
            this.thôngTinPhiênBảnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.thôngTinPhiênBảnToolStripMenuItem.Text = "Thông tin phiên bản";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // checkUpdateToolStripMenuItem
            // 
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            this.checkUpdateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.checkUpdateToolStripMenuItem.Text = "Check Update";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(670, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 16);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 607);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý siêu thị";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnXemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnMơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnXoaThongTin;
        private System.Windows.Forms.ToolStripMenuItem btnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem btnBanHang;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem vềChúngTôiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhiênBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem btnKhoHang;
        private System.Windows.Forms.ToolStripMenuItem btnHangHoa;
    }
}