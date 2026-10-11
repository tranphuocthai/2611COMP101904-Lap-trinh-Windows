using System;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "ỨNG DỤNG QUẢN LÝ CỬA HÀNG MINI\n\n" +
                           "Sinh viên thực hiện: [Điền tên bạn vào đây]\n" +
                           "Lớp học phần: COMP1019\n" +
                           "Phiên bản: 1.0 (Lưu trữ In-Memory Data)";
        }
    }
}