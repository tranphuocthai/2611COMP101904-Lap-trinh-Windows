namespace Test05
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
            lblTieuDe = new Label();
            grpHocVien = new GroupBox();
            lblTrangThaiEmail = new Label();
            chkNhanEmail = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            lblDemKyTu = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            grpKhoaHoc = new GroupBox();
            lblGiaTongTien = new Label();
            lblTongTien = new Label();
            lblGiaHocPhi = new Label();
            lblHocPhi = new Label();
            nudSoThang = new NumericUpDown();
            lblSoThang = new Label();
            radTrucTiep = new RadioButton();
            radOnline = new RadioButton();
            lblHinhThuc = new Label();
            cboKhoaHoc = new ComboBox();
            lblKhoaHoc = new Label();
            grpNutBam = new GroupBox();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnDangKy = new Button();
            grpHocVien.SuspendLayout();
            grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoThang).BeginInit();
            grpNutBam.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(263, 27);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(442, 37);
            lblTieuDe.TabIndex = 3;
            lblTieuDe.Text = "ĐĂNG KÝ KHÓA HỌC NGẮN HẠN";
            // 
            // grpHocVien
            // 
            grpHocVien.BackColor = Color.FromArgb(215, 228, 242);
            grpHocVien.Controls.Add(lblTrangThaiEmail);
            grpHocVien.Controls.Add(chkNhanEmail);
            grpHocVien.Controls.Add(dtpNgaySinh);
            grpHocVien.Controls.Add(lblNgaySinh);
            grpHocVien.Controls.Add(txtSDT);
            grpHocVien.Controls.Add(lblSDT);
            grpHocVien.Controls.Add(lblDemKyTu);
            grpHocVien.Controls.Add(txtHoTen);
            grpHocVien.Controls.Add(lblHoTen);
            grpHocVien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpHocVien.ForeColor = Color.Teal;
            grpHocVien.Location = new Point(29, 100);
            grpHocVien.Margin = new Padding(3, 4, 3, 4);
            grpHocVien.Name = "grpHocVien";
            grpHocVien.Padding = new Padding(3, 4, 3, 4);
            grpHocVien.Size = new Size(434, 307);
            grpHocVien.TabIndex = 2;
            grpHocVien.TabStop = false;
            grpHocVien.Text = "Thông tin học viên";
            // 
            // lblTrangThaiEmail
            // 
            lblTrangThaiEmail.AutoSize = true;
            lblTrangThaiEmail.Font = new Font("Segoe UI", 9.5F);
            lblTrangThaiEmail.ForeColor = Color.DimGray;
            lblTrangThaiEmail.Location = new Point(114, 256);
            lblTrangThaiEmail.Name = "lblTrangThaiEmail";
            lblTrangThaiEmail.Size = new Size(165, 21);
            lblTrangThaiEmail.TabIndex = 0;
            lblTrangThaiEmail.Text = "Nhận email thông báo";
            lblTrangThaiEmail.Click += lblTrangThaiEmail_Click;
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Font = new Font("Segoe UI", 9.5F);
            chkNhanEmail.ForeColor = Color.DimGray;
            chkNhanEmail.Location = new Point(131, 213);
            chkNhanEmail.Margin = new Padding(3, 4, 3, 4);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(187, 25);
            chkNhanEmail.TabIndex = 1;
            chkNhanEmail.Text = "Nhận email thông báo";
            chkNhanEmail.UseVisualStyleBackColor = true;
            chkNhanEmail.CheckedChanged += chkNhanEmail_CheckedChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd-MMM-yy";
            dtpNgaySinh.Font = new Font("Segoe UI", 9.5F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(114, 157);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(239, 29);
            dtpNgaySinh.TabIndex = 2;
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9.5F);
            lblNgaySinh.ForeColor = Color.DimGray;
            lblNgaySinh.Location = new Point(23, 163);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(83, 21);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9.5F);
            txtSDT.Location = new Point(114, 103);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.MaxLength = 10;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(239, 29);
            txtSDT.TabIndex = 4;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9.5F);
            lblSDT.ForeColor = Color.DimGray;
            lblSDT.Location = new Point(57, 107);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(41, 21);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "SĐT:";
            // 
            // lblDemKyTu
            // 
            lblDemKyTu.AutoSize = true;
            lblDemKyTu.Font = new Font("Segoe UI", 9F);
            lblDemKyTu.ForeColor = Color.DimGray;
            lblDemKyTu.Location = new Point(366, 51);
            lblDemKyTu.Name = "lblDemKyTu";
            lblDemKyTu.Size = new Size(39, 20);
            lblDemKyTu.TabIndex = 6;
            lblDemKyTu.Text = "0/50";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9.5F);
            txtHoTen.Location = new Point(114, 47);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(239, 29);
            txtHoTen.TabIndex = 7;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.5F);
            lblHoTen.ForeColor = Color.DimGray;
            lblHoTen.Location = new Point(40, 51);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 21);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ tên:";
            // 
            // grpKhoaHoc
            // 
            grpKhoaHoc.BackColor = Color.FromArgb(215, 228, 242);
            grpKhoaHoc.Controls.Add(lblGiaTongTien);
            grpKhoaHoc.Controls.Add(lblTongTien);
            grpKhoaHoc.Controls.Add(lblGiaHocPhi);
            grpKhoaHoc.Controls.Add(lblHocPhi);
            grpKhoaHoc.Controls.Add(nudSoThang);
            grpKhoaHoc.Controls.Add(lblSoThang);
            grpKhoaHoc.Controls.Add(radTrucTiep);
            grpKhoaHoc.Controls.Add(radOnline);
            grpKhoaHoc.Controls.Add(lblHinhThuc);
            grpKhoaHoc.Controls.Add(cboKhoaHoc);
            grpKhoaHoc.Controls.Add(lblKhoaHoc);
            grpKhoaHoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpKhoaHoc.ForeColor = Color.Teal;
            grpKhoaHoc.Location = new Point(486, 100);
            grpKhoaHoc.Margin = new Padding(3, 4, 3, 4);
            grpKhoaHoc.Name = "grpKhoaHoc";
            grpKhoaHoc.Padding = new Padding(3, 4, 3, 4);
            grpKhoaHoc.Size = new Size(434, 307);
            grpKhoaHoc.TabIndex = 1;
            grpKhoaHoc.TabStop = false;
            grpKhoaHoc.Text = "Thông tin khóa học";
            // 
            // lblGiaTongTien
            // 
            lblGiaTongTien.AutoSize = true;
            lblGiaTongTien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGiaTongTien.ForeColor = Color.Teal;
            lblGiaTongTien.Location = new Point(154, 256);
            lblGiaTongTien.Name = "lblGiaTongTien";
            lblGiaTongTien.Size = new Size(121, 21);
            lblGiaTongTien.TabIndex = 0;
            lblGiaTongTien.Text = "2,700,000 VNĐ";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 9.5F);
            lblTongTien.ForeColor = Color.DimGray;
            lblTongTien.Location = new Point(51, 256);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(78, 21);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // lblGiaHocPhi
            // 
            lblGiaHocPhi.AutoSize = true;
            lblGiaHocPhi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGiaHocPhi.ForeColor = Color.Teal;
            lblGiaHocPhi.Location = new Point(154, 213);
            lblGiaHocPhi.Name = "lblGiaHocPhi";
            lblGiaHocPhi.Size = new Size(108, 21);
            lblGiaHocPhi.TabIndex = 2;
            lblGiaHocPhi.Text = "900,000 VNĐ";
            // 
            // lblHocPhi
            // 
            lblHocPhi.AutoSize = true;
            lblHocPhi.Font = new Font("Segoe UI", 9.5F);
            lblHocPhi.ForeColor = Color.DimGray;
            lblHocPhi.Location = new Point(14, 213);
            lblHocPhi.Name = "lblHocPhi";
            lblHocPhi.Size = new Size(120, 21);
            lblHocPhi.TabIndex = 3;
            lblHocPhi.Text = "Học phí / tháng:";
            // 
            // nudSoThang
            // 
            nudSoThang.Font = new Font("Segoe UI", 9.5F);
            nudSoThang.Location = new Point(154, 157);
            nudSoThang.Margin = new Padding(3, 4, 3, 4);
            nudSoThang.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoThang.Name = "nudSoThang";
            nudSoThang.Size = new Size(69, 29);
            nudSoThang.TabIndex = 4;
            nudSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoThang.ValueChanged += nudSoThang_ValueChanged;
            // 
            // lblSoThang
            // 
            lblSoThang.AutoSize = true;
            lblSoThang.Font = new Font("Segoe UI", 9.5F);
            lblSoThang.ForeColor = Color.DimGray;
            lblSoThang.Location = new Point(55, 160);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(75, 21);
            lblSoThang.TabIndex = 5;
            lblSoThang.Text = "Số tháng:";
            // 
            // radTrucTiep
            // 
            radTrucTiep.AutoSize = true;
            radTrucTiep.Font = new Font("Segoe UI", 9.5F);
            radTrucTiep.ForeColor = Color.DimGray;
            radTrucTiep.Location = new Point(297, 104);
            radTrucTiep.Margin = new Padding(3, 4, 3, 4);
            radTrucTiep.Name = "radTrucTiep";
            radTrucTiep.Size = new Size(90, 25);
            radTrucTiep.TabIndex = 6;
            radTrucTiep.Text = "Trực tiếp";
            radTrucTiep.UseVisualStyleBackColor = true;
            radTrucTiep.CheckedChanged += radHinhThuc_CheckedChanged;
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Font = new Font("Segoe UI", 9.5F);
            radOnline.ForeColor = Color.DimGray;
            radOnline.Location = new Point(171, 104);
            radOnline.Margin = new Padding(3, 4, 3, 4);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(77, 25);
            radOnline.TabIndex = 7;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            radOnline.CheckedChanged += radHinhThuc_CheckedChanged;
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Font = new Font("Segoe UI", 9.5F);
            lblHinhThuc.ForeColor = Color.DimGray;
            lblHinhThuc.Location = new Point(23, 107);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(109, 21);
            lblHinhThuc.TabIndex = 8;
            lblHinhThuc.Text = "Hình thức học:";
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoaHoc.Font = new Font("Segoe UI", 9.5F);
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(143, 47);
            cboKhoaHoc.Margin = new Padding(3, 4, 3, 4);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(239, 29);
            cboKhoaHoc.TabIndex = 9;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Font = new Font("Segoe UI", 9.5F);
            lblKhoaHoc.ForeColor = Color.DimGray;
            lblKhoaHoc.Location = new Point(51, 51);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(77, 21);
            lblKhoaHoc.TabIndex = 10;
            lblKhoaHoc.Text = "Khóa học:";
            // 
            // grpNutBam
            // 
            grpNutBam.Controls.Add(btnThoat);
            grpNutBam.Controls.Add(btnLamMoi);
            grpNutBam.Controls.Add(btnDangKy);
            grpNutBam.Location = new Point(178, 440);
            grpNutBam.Margin = new Padding(3, 4, 3, 4);
            grpNutBam.Name = "grpNutBam";
            grpNutBam.Padding = new Padding(3, 4, 3, 4);
            grpNutBam.Size = new Size(604, 100);
            grpNutBam.TabIndex = 0;
            grpNutBam.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(409, 33);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 47);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.SteelBlue;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(237, 33);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(137, 47);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.SeaGreen;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(67, 33);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(137, 47);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 240, 245);
            ClientSize = new Size(949, 580);
            Controls.Add(grpNutBam);
            Controls.Add(grpKhoaHoc);
            Controls.Add(grpHocVien);
            Controls.Add(lblTieuDe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký khóa học";
            Load += Form1_Load;
            grpHocVien.ResumeLayout(false);
            grpHocVien.PerformLayout();
            grpKhoaHoc.ResumeLayout(false);
            grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoThang).EndInit();
            grpNutBam.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpHocVien;
        private System.Windows.Forms.Label lblTrangThaiEmail;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDemKyTu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox grpKhoaHoc;
        private System.Windows.Forms.Label lblGiaTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiaHocPhi;
        private System.Windows.Forms.Label lblHocPhi;
        private System.Windows.Forms.NumericUpDown nudSoThang;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.RadioButton radTrucTiep;
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