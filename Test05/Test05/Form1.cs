using System;
using System.Windows.Forms;

namespace Test05
{
    public partial class Form1 : Form
    {
        private double hocPhiThang = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Add("C# WinForms cơ bản");
            cboKhoaHoc.Items.Add("Lập trình Web ASP.NET");
            cboKhoaHoc.Items.Add("Cơ sở dữ liệu SQL Server");

            cboKhoaHoc.SelectedIndex = 0;
            radTrucTiep.Checked = true;
            chkNhanEmail.Checked = true;
            nudSoThang.Value = 3;

            CapNhatTien();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            int soKyTu = txtHoTen.Text.Length;
            lblDemKyTu.Text = soKyTu + "/50";
        }

        private void chkNhanEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhanEmail.Checked == true)
            {
                lblTrangThaiEmail.Text = "Đã đăng ký nhận email";
            }
            else
            {
                lblTrangThaiEmail.Text = "Chưa đăng ký nhận email";
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

        private void nudSoThang_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }

        private void CapNhatTien()
        {
            if (cboKhoaHoc.SelectedIndex == 0)
            {
                hocPhiThang = 900000;
            }
            else if (cboKhoaHoc.SelectedIndex == 1)
            {
                hocPhiThang = 1200000;
            }
            else if (cboKhoaHoc.SelectedIndex == 2)
            {
                hocPhiThang = 800000;
            }

            if (radOnline.Checked == true)
            {
                hocPhiThang = hocPhiThang - 100000;
            }

            int soThang = (int)nudSoThang.Value;
            double tongTien = hocPhiThang * soThang;

            lblGiaHocPhi.Text = hocPhiThang.ToString("N0") + " VNĐ";
            lblGiaTongTien.Text = tongTien.ToString("N0") + " VNĐ";
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

            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!");
                txtSDT.Focus();
                return;
            }

            for (int i = 0; i < sdt.Length; i++)
            {
                if (!char.IsDigit(sdt[i]))
                {
                    MessageBox.Show("Số điện thoại chỉ được phép nhập số!");
                    txtSDT.Focus();
                    return;
                }
            }

            string hinhThuc = radTrucTiep.Checked ? "Trực tiếp" : "Online";
            string thongTin = "ĐĂNG KÝ THÀNH CÔNG!\r\n" +
                              "Họ tên: " + hoTen + "\r\n" +
                              "SĐT: " + sdt + "\r\n" +
                              "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\r\n" +
                              "Trạng thái Email: " + lblTrangThaiEmail.Text + "\r\n" +
                              "Khóa học: " + cboKhoaHoc.Text + "\r\n" +
                              "Hình thức: " + hinhThuc + "\r\n" +
                              "Số tháng: " + nudSoThang.Value + "\r\n" +
                              "Tổng tiền: " + lblGiaTongTien.Text;

            MessageBox.Show(thongTin, "Kết quả đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = 0;
            radTrucTiep.Checked = true;
            nudSoThang.Value = 1;
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

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTrangThaiEmail_Click(object sender, EventArgs e)
        {

        }
    }
}