using DTO;
using GUI_QLHSApp;

namespace QLHSApp
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void menuItemQLLOP_Click(object sender, EventArgs e)
        {
            frmQuanLyLop lp = new frmQuanLyLop();
            lp.Show();
        }

        private void menuItemGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaoVien g = new frmGiaoVien();
            g.Show();
            
        }
    }
}