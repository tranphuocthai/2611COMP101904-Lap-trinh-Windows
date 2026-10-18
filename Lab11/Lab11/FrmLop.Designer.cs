namespace COMP1019_Buoi11_Lab11
{
    partial class FrmLop
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();

            this.lblMaLop.Location = new System.Drawing.Point(30, 30);
            this.lblMaLop.Text = "Mã Lớp:";
            this.lblMaLop.AutoSize = true;

            this.txtMaLop.Location = new System.Drawing.Point(100, 27);
            this.txtMaLop.Size = new System.Drawing.Size(200, 22);
            this.txtMaLop.Name = "txtMaLop";

            this.lblTenLop.Location = new System.Drawing.Point(30, 70);
            this.lblTenLop.Text = "Tên Lớp:";
            this.lblTenLop.AutoSize = true;

            this.txtTenLop.Location = new System.Drawing.Point(100, 67);
            this.txtTenLop.Size = new System.Drawing.Size(200, 22);
            this.txtTenLop.Name = "txtTenLop";

            this.btnThem.Location = new System.Drawing.Point(30, 110);
            this.btnThem.Text = "Thêm";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(120, 110);
            this.btnSua.Text = "Sửa";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(210, 110);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Location = new System.Drawing.Point(300, 110);
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.txtTimKiem.Location = new System.Drawing.Point(420, 114);
            this.txtTimKiem.Size = new System.Drawing.Size(180, 22);
            this.txtTimKiem.Name = "txtTimKiem";

            this.btnTimKiem.Location = new System.Drawing.Point(610, 110);
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.dgvLop.Location = new System.Drawing.Point(30, 160);
            this.dgvLop.Size = new System.Drawing.Size(670, 250);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);

            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvLop);
            this.Name = "FrmLop";
            this.Text = "Quản lý Lớp học";
            this.Load += new System.EventHandler(this.FrmLop_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
    }
}