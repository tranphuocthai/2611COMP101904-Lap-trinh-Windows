using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace COMP1019_Buoi11_Lab11
{
    public partial class FrmLop : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True";

        public FrmLop()
        {
            InitializeComponent();
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string sql = @"SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoSinhVien
                               FROM LOP l
                               LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
                               GROUP BY l.MaLop, l.TenLop
                               ORDER BY l.MaLop";

                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(sql, conn);
                using SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp!");
                txtMaLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp!");
                txtTenLop.Focus();
                return false;
            }
            return true;
        }

        private bool IsMaLopExists(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM LOP WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maLop);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private int CountSinhVienByLop(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM SINHVIEN WHERE MaLop = @ma";
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", maLop);
            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string ma = txtMaLop.Text.Trim();
            string ten = txtTenLop.Text.Trim();

            try
            {
                if (IsMaLopExists(ma))
                {
                    MessageBox.Show("Mã lớp đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "INSERT INTO LOP(MaLop, TenLop) VALUES(@ma, @ten)";
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm lớp thành công!");
                    LoadData();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string ma = txtMaLop.Text.Trim();
            string ten = txtTenLop.Text.Trim();

            try
            {
                string sql = "UPDATE LOP SET TenLop = @ten WHERE MaLop = @ma";
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thông tin lớp thành công!");
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLop.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng chọn một lớp cần xóa trên danh sách!");
                return;
            }

            try
            {
                // Kiểm tra ràng buộc khóa ngoại (Không cho xóa nếu có sinh viên)
                int soSinhVien = CountSinhVienByLop(ma);
                if (soSinhVien > 0)
                {
                    MessageBox.Show($"Không thể xóa! Lớp này hiện đang có {soSinhVien} sinh viên theo học.", "Cảnh báo khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp [{ma}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                string sql = "DELETE FROM LOP WHERE MaLop = @ma";
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Đã xóa lớp thành công!");
                    LoadData();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                string sql = @"SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoSinhVien
                               FROM LOP l
                               LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
                               WHERE l.MaLop LIKE @kw OR l.TenLop LIKE @kw
                               GROUP BY l.MaLop, l.TenLop
                               ORDER BY l.MaLop";

                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLop.Rows[e.RowIndex];
            txtMaLop.Text = row.Cells["MaLop"].Value?.ToString() ?? "";
            txtTenLop.Text = row.Cells["TenLop"].Value?.ToString() ?? "";
        }

        private void ClearInput()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();
            txtMaLop.Focus();
        }
    }
}