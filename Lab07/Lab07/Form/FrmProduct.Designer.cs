namespace Lab07
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.txtProductId.Location = new System.Drawing.Point(20, 20); this.txtProductId.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.Location = new System.Drawing.Point(140, 20); this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.cboCategory.Location = new System.Drawing.Point(360, 20); this.cboCategory.Size = new System.Drawing.Size(150, 24);
            this.txtPrice.Location = new System.Drawing.Point(20, 60); this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.Location = new System.Drawing.Point(140, 60); this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.Location = new System.Drawing.Point(360, 60); this.txtSearch.Size = new System.Drawing.Size(150, 22);

            this.btnAdd.Location = new System.Drawing.Point(20, 100); this.btnAdd.Text = "Thêm"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Location = new System.Drawing.Point(120, 100); this.btnEdit.Text = "Sửa"; this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Location = new System.Drawing.Point(220, 100); this.btnDelete.Text = "Xóa"; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Location = new System.Drawing.Point(320, 100); this.btnClear.Text = "Mới"; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnSearch.Location = new System.Drawing.Point(530, 58); this.btnSearch.Text = "Tìm"; this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.dgvProducts.Location = new System.Drawing.Point(20, 150); this.dgvProducts.Size = new System.Drawing.Size(650, 250);
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);

            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.dgvProducts); this.Controls.Add(this.btnSearch); this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete); this.Controls.Add(this.btnEdit); this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch); this.Controls.Add(this.txtQuantity); this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboCategory); this.Controls.Add(this.txtProductName); this.Controls.Add(this.txtProductId);
            this.Name = "FrmProduct"; this.Text = "Quản lý Sản phẩm";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}