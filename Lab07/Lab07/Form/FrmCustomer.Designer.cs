namespace Lab07
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();

            this.txtCustomerId.Location = new System.Drawing.Point(20, 20); this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.Location = new System.Drawing.Point(140, 20); this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.Location = new System.Drawing.Point(20, 60); this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.cboCustomerType.Location = new System.Drawing.Point(140, 60); this.cboCustomerType.Size = new System.Drawing.Size(120, 24);

            this.btnAdd.Location = new System.Drawing.Point(280, 58); this.btnAdd.Text = "Thêm KH"; this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.dgvCustomers.Location = new System.Drawing.Point(20, 100); this.dgvCustomers.Size = new System.Drawing.Size(550, 250);

            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.dgvCustomers); this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCustomerType); this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName); this.Controls.Add(this.txtCustomerId);
            this.Name = "FrmCustomer"; this.Text = "Quản lý Khách hàng";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}