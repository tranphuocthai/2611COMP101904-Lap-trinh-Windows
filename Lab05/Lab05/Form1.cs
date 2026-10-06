using System;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Add("C# WinForms cơ bản");
            cboKhoaHoc.Items.Add("SQL Server cơ bản");
            cboKhoaHoc.Items.Add("Web Frontend cơ bản");
            cboKhoaHoc.Items.Add("Lập trình Python cơ bản");

            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            chkNhanEmail.Checked = false;
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            CapNhatTien();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            int soKyTu = txtHoTen.Text.Length;
            lblDemKyTu.Text = soKyTu + "/50";
        }

        private void chkNhanEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhanEmail.Checked)
            {
                lblTrangThaiEmail.Text = "Trạng thái: Có nhận email thông báo";
            }
            else
            {
                lblTrangThaiEmail.Text = "Trạng thái: Không nhận email thông báo";
            }
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void radHinhThuc_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void CapNhatTien()
        {
            double hocPhiThang = 0;

            if (cboKhoaHoc.SelectedIndex == 0)
            {
                hocPhiThang = 800000;
            }
            else if (cboKhoaHoc.SelectedIndex == 1)
            {
                hocPhiThang = 700000;
            }
            else if (cboKhoaHoc.SelectedIndex == 2)
            {
                hocPhiThang = 750000;
            }
            else if (cboKhoaHoc.SelectedIndex == 3)
            {
                hocPhiThang = 650000;
            }

            if (radOffline.Checked)
            {
                hocPhiThang = hocPhiThang + 100000;
            }

            int soThang = (int)numSoThang.Value;
            double tongTien = hocPhiThang * soThang;

            lblHocPhi.Text = hocPhiThang.ToString("N0") + " VNĐ";
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            string sdt = txtSoDienThoai.Text.Trim();
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!");
                txtSoDienThoai.Focus();
                return;
            }

            for (int i = 0; i < sdt.Length; i++)
            {
                if (!char.IsDigit(sdt[i]))
                {
                    MessageBox.Show("Số điện thoại chỉ được phép nhập số!");
                    txtSoDienThoai.Focus();
                    return;
                }
            }

            string hinhThuc = radOffline.Checked ? "Trực tiếp" : "Online";
            string thongTin = "KẾT QUẢ ĐĂNG KÝ\r\n\r\n" +
                              "Họ tên: " + hoTen + "\r\n" +
                              "SĐT: " + sdt + "\r\n" +
                              "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\r\n" +
                              "Email: " + lblTrangThaiEmail.Text + "\r\n" +
                              "Khóa học: " + cboKhoaHoc.Text + "\r\n" +
                              "Hình thức: " + hinhThuc + "\r\n" +
                              "Số tháng: " + numSoThang.Value + "\r\n" +
                              "Học phí mỗi tháng: " + lblHocPhi.Text + "\r\n" +
                              "Tổng tiền: " + lblTongTien.Text;

            MessageBox.Show(thongTin, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSoDienThoai.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = 0;
            radOnline.Checked = true;
            numSoThang.Value = 1;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}