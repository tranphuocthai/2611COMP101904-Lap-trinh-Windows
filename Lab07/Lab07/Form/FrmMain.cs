using System;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmMain : Form
    {
        private User currentUser;

        public FrmMain(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblStatusUser.Text = $"Người dùng: {currentUser.FullName} | Vai trò: {currentUser.Role}";
            timerTime.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuProduct_Click(object sender, EventArgs e) => OpenChildForm(new FrmProduct());
        private void menuCustomer_Click(object sender, EventArgs e) => OpenChildForm(new FrmCustomer());
        private void menuAbout_Click(object sender, EventArgs e) => OpenChildForm(new FrmAbout());

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Restart();
        }

        private void menuExit_Click(object sender, EventArgs e) => this.Close();

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}