using System;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmLogin : Form
    {
        public User LoggedInUser { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user == "admin" && pass == "123")
            {
                LoggedInUser = new User { Username = "admin", Password = "123", FullName = "Quản trị viên", Role = "Admin" };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (user == "user" && pass == "123")
            {
                LoggedInUser = new User { Username = "user", Password = "123", FullName = "Nhân viên bán hàng", Role = "User" };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}