namespace StudentCardPrinter
{
    partial class FrmStudentCard
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlCardPreview = new System.Windows.Forms.Panel();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.btnPreviewPrint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();

            // Labels
            System.Windows.Forms.Label lblId = new System.Windows.Forms.Label() { Text = "Mã SV:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            System.Windows.Forms.Label lblName = new System.Windows.Forms.Label() { Text = "Họ tên:", Location = new System.Drawing.Point(20, 60), AutoSize = true };
            System.Windows.Forms.Label lblClass = new System.Windows.Forms.Label() { Text = "Lớp:", Location = new System.Drawing.Point(20, 100), AutoSize = true };
            System.Windows.Forms.Label lblFac = new System.Windows.Forms.Label() { Text = "Khoa:", Location = new System.Drawing.Point(20, 140), AutoSize = true };
            System.Windows.Forms.Label lblCourse = new System.Windows.Forms.Label() { Text = "Khóa:", Location = new System.Drawing.Point(20, 180), AutoSize = true };
            System.Windows.Forms.Label lblDob = new System.Windows.Forms.Label() { Text = "Ngày sinh:", Location = new System.Drawing.Point(20, 220), AutoSize = true };
            System.Windows.Forms.Label lblGender = new System.Windows.Forms.Label() { Text = "Giới tính:", Location = new System.Drawing.Point(20, 260), AutoSize = true };

            // Inputs
            this.txtStudentId.Location = new System.Drawing.Point(100, 17); this.txtStudentId.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.Location = new System.Drawing.Point(100, 57); this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.cboClass.Location = new System.Drawing.Point(100, 97); this.cboClass.Size = new System.Drawing.Size(200, 24);
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.Location = new System.Drawing.Point(100, 137); this.cboFaculty.Size = new System.Drawing.Size(200, 24);
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCourse.Location = new System.Drawing.Point(100, 177); this.txtCourse.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.Location = new System.Drawing.Point(100, 217); this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cboGender.Location = new System.Drawing.Point(100, 257); this.cboGender.Size = new System.Drawing.Size(200, 24);
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnChoosePhoto.Location = new System.Drawing.Point(100, 297); this.btnChoosePhoto.Size = new System.Drawing.Size(100, 30); this.btnChoosePhoto.Text = "Chọn Ảnh";
            this.picAvatar.Location = new System.Drawing.Point(100, 337); this.picAvatar.Size = new System.Drawing.Size(100, 130); this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Preview Panel & Buttons
            this.pnlCardPreview.Location = new System.Drawing.Point(340, 20); this.pnlCardPreview.Size = new System.Drawing.Size(560, 350); this.pnlCardPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnPreviewPrint.Location = new System.Drawing.Point(400, 400); this.btnPreviewPrint.Size = new System.Drawing.Size(120, 40); this.btnPreviewPrint.Text = "Xem trước In";
            this.btnPrint.Location = new System.Drawing.Point(540, 400); this.btnPrint.Size = new System.Drawing.Size(120, 40); this.btnPrint.Text = "In thẻ";
            this.btnClear.Location = new System.Drawing.Point(680, 400); this.btnClear.Size = new System.Drawing.Size(120, 40); this.btnClear.Text = "Làm mới";

            // Dialog settings
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;

            this.ClientSize = new System.Drawing.Size(930, 490);
            this.Controls.Add(lblId); this.Controls.Add(lblName); this.Controls.Add(lblClass);
            this.Controls.Add(lblFac); this.Controls.Add(lblCourse); this.Controls.Add(lblDob); this.Controls.Add(lblGender);
            this.Controls.Add(this.txtStudentId); this.Controls.Add(this.txtFullName); this.Controls.Add(this.cboClass);
            this.Controls.Add(this.cboFaculty); this.Controls.Add(this.txtCourse); this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cboGender); this.Controls.Add(this.btnChoosePhoto); this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.pnlCardPreview); this.Controls.Add(this.btnPreviewPrint); this.Controls.Add(this.btnPrint); this.Controls.Add(this.btnClear);
            this.Name = "FrmStudentCard"; this.Text = "Phần mềm Thiết kế và In thẻ sinh viên";

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlCardPreview;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.Button btnPreviewPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}