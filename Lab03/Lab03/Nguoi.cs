using System;

namespace Lab03_QuanLySinhVien
{
    public class Nguoi
    {
        private string hoTen;
        private DateTime ngaySinh;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        public virtual string LayThongTin()
        {
            return "Họ tên: " + HoTen + " - Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy");
        }
    }
}