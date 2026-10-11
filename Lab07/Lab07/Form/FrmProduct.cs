using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> productList = new BindingList<Product>();

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productList;
            cboCategory.Items.AddRange(new string[] { "Đồ uống", "Thực phẩm", "Gia dụng" });

            productList.Add(new Product { ProductId = "SP01", ProductName = "Coca Cola", Category = "Đồ uống", Price = 10000, Quantity = 50 });
            productList.Add(new Product { ProductId = "SP02", ProductName = "Mì Hảo Hảo", Category = "Thực phẩm", Price = 5000, Quantity = 150 });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Nhập mã và tên sản phẩm!"); return;
            }
            if (productList.Any(p => p.ProductId == id))
            {
                MessageBox.Show("Mã trùng!"); return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0 || !int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Giá và số lượng phải hợp lệ!"); return;
            }

            productList.Add(new Product { ProductId = id, ProductName = txtProductName.Text.Trim(), Category = cboCategory.Text, Price = price, Quantity = qty });
            btnClear_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var product = productList.FirstOrDefault(p => p.ProductId == txtProductId.Text.Trim());
            if (product != null && decimal.TryParse(txtPrice.Text, out decimal price) && int.TryParse(txtQuantity.Text, out int qty))
            {
                product.ProductName = txtProductName.Text;
                product.Category = cboCategory.Text;
                product.Price = price;
                product.Quantity = qty;
                dgvProducts.Refresh();
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = productList.FirstOrDefault(p => p.ProductId == txtProductId.Text.Trim());
            if (product != null && MessageBox.Show("Xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productList.Remove(product);
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductId.Clear(); txtProductName.Clear(); txtPrice.Clear(); txtQuantity.Clear();
            cboCategory.SelectedIndex = -1; txtSearch.Clear();
            dgvProducts.DataSource = productList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim().ToLower();
            dgvProducts.DataSource = productList.Where(p => p.ProductName.ToLower().Contains(kw) || p.ProductId.ToLower().Contains(kw)).ToList();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productList.Count)
            {
                var row = dgvProducts.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                cboCategory.Text = row.Cells["Category"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
            }
        }
    }
}