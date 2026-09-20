using System;

namespace Lab03_QuanLySinhVien
{
    public class SinhVien : Nguoi
    {
        private string maSinhVien;
        private double diemTrungBinh;
        private string maLop;

        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemTrungBinh = value;
                }
                else
                {
                    diemTrungBinh = 0;
                }
            }
        }

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string maLop, double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 8)
                return "Giỏi";
            if (DiemTrungBinh >= 6.5)
                return "Khá";
            if (DiemTrungBinh >= 5)
                return "Đạt";

            return "Không đạt";
        }

        public override string LayThongTin()
        {
            return "Mã SV: " + MaSinhVien + " - " + base.LayThongTin() + " - Lớp: " + MaLop + " - Điểm TB: " + DiemTrungBinh + " - Xếp loại: " + XepLoai();
        }
    }
}