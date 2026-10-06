namespace CourseRegistrationApp
{
    partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpHocVien = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiEmail = new System.Windows.Forms.Label();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblDemKyTu = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTieuDeTongTien = new System.Windows.Forms.Label();
            this.lblHocPhi = new System.Windows.Forms.Label();
            this.lblTieuDeHocPhi = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.grpNutBam = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.grpHocVien.SuspendLayout();
            this.grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.grpNutBam.SuspendLayout();
            this.SuspendLayout();

            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Teal;
            this.lblTieuDe.Location = new System.Drawing.Point(300, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(230, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG KÝ KHÓA HỌC";

            this.grpHocVien.BackColor = System.Drawing.Color.AliceBlue;
            this.grpHocVien.Controls.Add(this.lblTrangThaiEmail);
            this.grpHocVien.Controls.Add(this.chkNhanEmail);
            this.grpHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpHocVien.Controls.Add(this.lblNgaySinh);
            this.grpHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpHocVien.Controls.Add(this.lblDemKyTu);
            this.grpHocVien.Controls.Add(this.txtHoTen);
            this.grpHocVien.Controls.Add(this.lblHoTen);
            this.grpHocVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpHocVien.ForeColor = System.Drawing.Color.Teal;
            this.grpHocVien.Location = new System.Drawing.Point(25, 75);
            this.grpHocVien.Name = "grpHocVien";
            this.grpHocVien.Size = new System.Drawing.Size(380, 230);
            this.grpHocVien.TabIndex = 1;
            this.grpHocVien.TabStop = false;
            this.grpHocVien.Text = "Thông tin học viên";

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblHoTen.ForeColor = System.Drawing.Color.DimGray;
            this.lblHoTen.Location = new System.Drawing.Point(35, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";

            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.txtHoTen.Location = new System.Drawing.Point(100, 35);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(210, 24);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);

            this.lblDemKyTu.AutoSize = true;
            this.lblDemKyTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblDemKyTu.ForeColor = System.Drawing.Color.DimGray;
            this.lblDemKyTu.Location = new System.Drawing.Point(320, 38);
            this.lblDemKyTu.Name = "lblDemKyTu";
            this.lblDemKyTu.Size = new System.Drawing.Size(39, 15);
            this.lblDemKyTu.TabIndex = 2;
            this.lblDemKyTu.Text = "0/50";

            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoDienThoai.Location = new System.Drawing.Point(50, 80);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(35, 17);
            this.lblSoDienThoai.TabIndex = 3;
            this.lblSoDienThoai.Text = "SĐT:";

            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.txtSoDienThoai.Location = new System.Drawing.Point(100, 77);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(210, 24);
            this.txtSoDienThoai.TabIndex = 4;

            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.DimGray;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 122);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(68, 17);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";

            this.dtpNgaySinh.CustomFormat = "dd-MMM-yy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 118);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(210, 24);
            this.dtpNgaySinh.TabIndex = 6;

            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.chkNhanEmail.ForeColor = System.Drawing.Color.DimGray;
            this.chkNhanEmail.Location = new System.Drawing.Point(115, 160);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(156, 21);
            this.chkNhanEmail.TabIndex = 7;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            this.chkNhanEmail.CheckedChanged += new System.EventHandler(this.chkNhanEmail_CheckedChanged);

            this.lblTrangThaiEmail.AutoSize = true;
            this.lblTrangThaiEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblTrangThaiEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrangThaiEmail.Location = new System.Drawing.Point(100, 192);
            this.lblTrangThaiEmail.Name = "lblTrangThaiEmail";
            this.lblTrangThaiEmail.Size = new System.Drawing.Size(248, 17);
            this.lblTrangThaiEmail.TabIndex = 8;
            this.lblTrangThaiEmail.Text = "Trạng thái: Không nhận email thông báo";

            this.grpKhoaHoc.BackColor = System.Drawing.Color.AliceBlue;
            this.grpKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpKhoaHoc.Controls.Add(this.lblTieuDeTongTien);
            this.grpKhoaHoc.Controls.Add(this.lblHocPhi);
            this.grpKhoaHoc.Controls.Add(this.lblTieuDeHocPhi);
            this.grpKhoaHoc.Controls.Add(this.numSoThang);
            this.grpKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpKhoaHoc.Controls.Add(this.radOffline);
            this.grpKhoaHoc.Controls.Add(this.radOnline);
            this.grpKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKhoaHoc.ForeColor = System.Drawing.Color.Teal;
            this.grpKhoaHoc.Location = new System.Drawing.Point(425, 75);
            this.grpKhoaHoc.Name = "grpKhoaHoc";
            this.grpKhoaHoc.Size = new System.Drawing.Size(380, 230);
            this.grpKhoaHoc.TabIndex = 2;
            this.grpKhoaHoc.TabStop = false;
            this.grpKhoaHoc.Text = "Thông tin khóa học";

            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblKhoaHoc.ForeColor = System.Drawing.Color.DimGray;
            this.lblKhoaHoc.Location = new System.Drawing.Point(45, 38);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(64, 17);
            this.lblKhoaHoc.TabIndex = 0;
            this.lblKhoaHoc.Text = "Khóa học:";

            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(125, 35);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(210, 25);
            this.cboKhoaHoc.TabIndex = 1;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);

            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblHinhThuc.ForeColor = System.Drawing.Color.DimGray;
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 80);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(89, 17);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình thức học:";

            this.radOnline.AutoSize = true;
            this.radOnline.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.radOnline.ForeColor = System.Drawing.Color.DimGray;
            this.radOnline.Location = new System.Drawing.Point(135, 78);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(64, 21);
            this.radOnline.TabIndex = 3;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            this.radOnline.CheckedChanged += new System.EventHandler(this.radHinhThuc_CheckedChanged);

            this.radOffline.AutoSize = true;
            this.radOffline.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.radOffline.ForeColor = System.Drawing.Color.DimGray;
            this.radOffline.Location = new System.Drawing.Point(220, 78);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(76, 21);
            this.radOffline.TabIndex = 4;
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;
            this.radOffline.CheckedChanged += new System.EventHandler(this.radHinhThuc_CheckedChanged);

            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblSoThang.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoThang.Location = new System.Drawing.Point(48, 120);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(61, 17);
            this.lblSoThang.TabIndex = 5;
            this.lblSoThang.Text = "Số tháng:";

            this.numSoThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.numSoThang.Location = new System.Drawing.Point(135, 118);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(60, 24);
            this.numSoThang.TabIndex = 6;
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);

            this.lblTieuDeHocPhi.AutoSize = true;
            this.lblTieuDeHocPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblTieuDeHocPhi.ForeColor = System.Drawing.Color.DimGray;
            this.lblTieuDeHocPhi.Location = new System.Drawing.Point(12, 160);
            this.lblTieuDeHocPhi.Name = "lblTieuDeHocPhi";
            this.lblTieuDeHocPhi.Size = new System.Drawing.Size(97, 17);
            this.lblTieuDeHocPhi.TabIndex = 7;
            this.lblTieuDeHocPhi.Text = "Học phí / tháng:";

            this.lblHocPhi.AutoSize = true;
            this.lblHocPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHocPhi.ForeColor = System.Drawing.Color.Teal;
            this.lblHocPhi.Location = new System.Drawing.Point(135, 160);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(88, 17);
            this.lblHocPhi.TabIndex = 8;
            this.lblHocPhi.Text = "800,000 VNĐ";

            this.lblTieuDeTongTien.AutoSize = true;
            this.lblTieuDeTongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblTieuDeTongTien.ForeColor = System.Drawing.Color.DimGray;
            this.lblTieuDeTongTien.Location = new System.Drawing.Point(45, 192);
            this.lblTieuDeTongTien.Name = "lblTieuDeTongTien";
            this.lblTieuDeTongTien.Size = new System.Drawing.Size(64, 17);
            this.lblTieuDeTongTien.TabIndex = 9;
            this.lblTieuDeTongTien.Text = "Tổng tiền:";

            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Teal;
            this.lblTongTien.Location = new System.Drawing.Point(135, 192);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 17);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "800,000 VNĐ";

            this.grpNutBam.Controls.Add(this.btnThoat);
            this.grpNutBam.Controls.Add(this.btnLamMoi);
            this.grpNutBam.Controls.Add(this.btnDangKy);
            this.grpNutBam.Location = new System.Drawing.Point(165, 330);
            this.grpNutBam.Name = "grpNutBam";
            this.grpNutBam.Size = new System.Drawing.Size(500, 75);
            this.grpNutBam.TabIndex = 3;
            this.grpNutBam.TabStop = false;

            this.btnDangKy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(25, 25);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 35);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.btnLamMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(190, 25);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 35);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(355, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 435);
            this.Controls.Add(this.grpNutBam);
            this.Controls.Add(this.grpKhoaHoc);
            this.Controls.Add(this.grpHocVien);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khóa học";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHocVien.ResumeLayout(false);
            this.grpHocVien.PerformLayout();
            this.grpKhoaHoc.ResumeLayout(false);
            this.grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.grpNutBam.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpHocVien;
        private System.Windows.Forms.Label lblTrangThaiEmail;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblDemKyTu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grpKhoaHoc;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTieuDeTongTien;
        private System.Windows.Forms.Label lblHocPhi;
        private System.Windows.Forms.Label lblTieuDeHocPhi;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.GroupBox grpNutBam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDangKy;
    }
}