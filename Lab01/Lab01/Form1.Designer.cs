namespace Lab01
{
    partial class Form1
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
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblEmail = new Label();
            lblGioiTinh = new Label();
            lblKhoa = new Label();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtEmail = new TextBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(30, 30);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 20);
            lblHoTen.TabIndex = 14;
            lblHoTen.Text = "Họ và tên:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(30, 80);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(175, 20);
            lblNgaySinh.TabIndex = 12;
            lblNgaySinh.Text = "Ngày sinh (dd/mm/yyyy):";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(30, 180);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(30, 230);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(77, 20);
            lblKhoa.TabIndex = 5;
            lblKhoa.Text = "Khoa/Lớp:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(200, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 13;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(200, 77);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(250, 27);
            txtNgaySinh.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 9;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(180, 178);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 7;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(260, 178);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 6;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(180, 227);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(250, 28);
            cboKhoa.TabIndex = 4;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(60, 290);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 3;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(180, 290);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(300, 290);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(30, 350);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(420, 200);
            txtKetQua.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 580);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(lblKhoa);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập Thông Tin Sinh Viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}