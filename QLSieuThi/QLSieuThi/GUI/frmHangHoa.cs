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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

       

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            KetNoi();
           // LoadDaTa();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        public void KetNoi()
        {
            //SqlConnection conn = new SqlConnection(DataAccess.ConnectDatabase.ConnectionString);
        }
            
    }
}
