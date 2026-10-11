using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmCustomer : Form
    {
        private BindingList<Customer> customerList = new BindingList<Customer>();

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customerList;
            cboCustomerType.Items.AddRange(new string[] { "Thường", "VIP" });

            // Thêm dữ liệu mẫu
            customerList.Add(new Customer { CustomerId = "KH01", FullName = "Nguyễn Văn A", Phone = "0901234567", CustomerType = "VIP" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Mã và Tên khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (customerList.Any(c => c.CustomerId == id))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customerList.Add(new Customer
            {
                CustomerId = id,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                CustomerType = cboCustomerType.Text
            });

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng form sau khi thêm
            txtCustomerId.Clear(); txtFullName.Clear(); txtPhone.Clear(); cboCustomerType.SelectedIndex = -1;
            txtCustomerId.Focus();
        }
    }
}