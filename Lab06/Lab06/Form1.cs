using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab06
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private BindingSource productSource = new BindingSource();
        private string selectedImagePath = string.Empty;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboLoaiSP.Items.AddRange(new object[]
            {
                "Điện tử", "Văn phòng", "Gia dụng", "Thời trang"
            });
            cboLoaiSP.SelectedIndex = 0;

            products.Add(new Product
            {
                MaSP = "GAM01",
                TenSP = "Bàn phím cơ Leopold",
                LoaiSP = "Điện tử",
                DonGia = 3200000,
                SoLuong = 15,
                NgayNhap = DateTime.Today.AddDays(-10),
                ConKinhDoanh = true
            });

            products.Add(new Product
            {
                MaSP = "FUR02",
                TenSP = "Bàn làm việc nâng hạ Ergonomic",
                LoaiSP = "Văn phòng",
                DonGia = 5500000,
                SoLuong = 8,
                NgayNhap = DateTime.Today.AddDays(-5),
                ConKinhDoanh = true
            });

            products.Add(new Product
            {
                MaSP = "APP03",
                TenSP = "Robot hút bụi Roborock",
                LoaiSP = "Gia dụng",
                DonGia = 8900000,
                SoLuong = 5,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true
            });

            productSource.DataSource = products;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = productSource;

            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;

            UpdateStatus("Sẵn sàng");
        }

        private bool ValidateInput(bool isEdit = false)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được rỗng");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được rỗng");
                isValid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
                isValid = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn hôm nay");
                isValid = false;
            }

            string ma = txtMaSP.Text.Trim();
            bool isDuplicate = products.Any(p => p.MaSP.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (!isEdit && isDuplicate)
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại");
                isValid = false;
            }

            return isValid;
        }

        private Product GetSelectedProduct()
        {
            if (productSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return productSource.Current as Product;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Product p = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = selectedImagePath
            };

            products.Add(p);
            ClearInput();
            UpdateStatus("Đã thêm sản phẩm mới");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product p = productSource.Current as Product;
            if (p == null) return;

            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.Text = p.LoaiSP;
            numDonGia.Value = p.DonGia;
            numSoLuong.Value = p.SoLuong;
            dtpNgayNhap.Value = p.NgayNhap;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;
            selectedImagePath = p.DuongDanAnh;

            if (!string.IsNullOrWhiteSpace(p.DuongDanAnh) && File.Exists(p.DuongDanAnh))
            {
                picSanPham.Image = Image.FromFile(p.DuongDanAnh);
            }
            else
            {
                picSanPham.Image = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;
            if (!ValidateInput(true)) return;

            p.TenSP = txtTenSP.Text.Trim();
            p.LoaiSP = cboLoaiSP.Text;
            p.DonGia = numDonGia.Value;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayNhap = dtpNgayNhap.Value.Date;
            p.ConKinhDoanh = chkConKinhDoanh.Checked;
            p.DuongDanAnh = selectedImagePath;

            productSource.ResetBindings(false);
            UpdateStatus("Đã cập nhật sản phẩm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + p.TenSP + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                products.Remove(p);
                ClearInput();
                UpdateStatus("Đã xóa sản phẩm");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var result = products.Where(p => p.MaSP.ToLower().Contains(keyword) || p.TenSP.ToLower().Contains(keyword)).ToList();

            dgvProducts.DataSource = result;
            UpdateStatus("Tìm thấy " + result.Count + " sản phẩm");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productSource;
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";
                dialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    picSanPham.Image = Image.FromFile(selectedImagePath);
                    UpdateStatus("Đã chọn ảnh sản phẩm");
                }
            }
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 1;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            txtTimKiem.Clear();
            picSanPham.Image = null;
            selectedImagePath = string.Empty;
            errorProvider1.Clear();
            txtMaSP.Focus();
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message + " | Số lượng sản phẩm: " + products.Count;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void tsbLamMoi_Click(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void cmsSua_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void cmsChiTiet_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            MessageBox.Show("Mã SP: " + p.MaSP + "\r\nTên SP: " + p.TenSP + "\r\nLoại SP: " + p.LoaiSP + "\r\nTổng tiền (Tồn kho): " + p.ThanhTien.ToString("N0") + " VNĐ", "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}