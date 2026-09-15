using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Toán");
            cboKhoa.Items.Add("Ngữ văn");
            cboKhoa.Items.Add("Vật lý");
            cboKhoa.Items.Add("Hóa học");
            cboKhoa.Items.Add("Lịch sử");
            cboKhoa.Items.Add("Địa lý");
            cboKhoa.Items.Add("Tin học");
            cboKhoa.Items.Add("GDQP");
            cboKhoa.Items.Add("Tiếng Anh");
            cboKhoa.Items.Add("Tiếng Trung");
            cboKhoa.Items.Add("Tiếng Hàn");
            cboKhoa.Items.Add("Tiếng Nhật");
            cboKhoa.Items.Add("Tiếng Pháp");
            cboKhoa.Items.Add("Tiếng Nga");
            cboKhoa.Items.Add("Công nghệ thông tin");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                MessageBox.Show("Họ tên không được để trống!");
                txtHoTen.Focus();
                return;
            }

            for (int i = 0; i < hoTen.Length; i++)
            {
                if (!char.IsLetter(hoTen[i]) && hoTen[i] != ' ')
                {
                    MessageBox.Show("Tên không được chứa số hay ký tự đặc biệt.");
                    txtHoTen.Focus();
                    return;
                }
            }

            string ngaySinhRaw = txtNgaySinh.Text.Trim();
            string[] mangNgaySinh = ngaySinhRaw.Split('/');

            if (mangNgaySinh.Length != 3)
            {
                MessageBox.Show("Ngày sinh phải nhập theo định dạng ngày/tháng/năm!");
                txtNgaySinh.Focus();
                return;
            }

            int ngay, thang, nam;
            if (!int.TryParse(mangNgaySinh[0], out ngay) || !int.TryParse(mangNgaySinh[1], out thang) || !int.TryParse(mangNgaySinh[2], out nam))
            {
                MessageBox.Show("Ngày, tháng, năm phải là số!");
                txtNgaySinh.Focus();
                return;
            }

            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ (không được có tháng " + thang + ")!");
                txtNgaySinh.Focus();
                return;
            }

            if (ngay < 1 || ngay > 31)
            {
                MessageBox.Show("Ngày không hợp lệ (không được có ngày " + ngay + ")!");
                txtNgaySinh.Focus();
                return;
            }

            if ((thang == 4 || thang == 6 || thang == 9 || thang == 11) && ngay > 30)
            {
                MessageBox.Show("Tháng " + thang + " chỉ có 30 ngày!");
                txtNgaySinh.Focus();
                return;
            }

            if (thang == 2 && ngay > 29)
            {
                MessageBox.Show("Tháng 2 chỉ có 29 ngày!");
                txtNgaySinh.Focus();
                return;
            }

            string email = txtEmail.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Email không được để trống!");
                txtEmail.Focus();
                return;
            }

            bool coCong = false;
            bool coCham = false;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@') coCong = true;
                if (email[i] == '.') coCham = true;
            }

            if (coCong == false || coCham == false)
            {
                MessageBox.Show("Email không đúng!");
                txtEmail.Focus();
                return;
            }

            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính!");
                return;
            }

            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn khoa!");
                return;
            }

            string gioiTinh = "";
            if (radNam.Checked) gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";

            string khoa = cboKhoa.SelectedItem.ToString();

            txtKetQua.Text = "Thông tin của sinh viên:" + "\r\n" +
                             "Họ và tên: " + hoTen + "\r\n" +
                             "Ngày sinh: " + ngay + "/" + thang + "/" + nam + "\r\n" +
                             "Email: " + email + "\r\n" +
                             "Giới tính: " + gioiTinh + "\r\n" +
                             "Khoa: " + khoa;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtEmail.Text = "";
            txtKetQua.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhoa.SelectedIndex = -1;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn chắc muốn thoát không?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}