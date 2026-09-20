using System;

namespace QuanLyNhanVien
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayLamViec;

        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set
            {
                if (value >= 0 && value <= 31)
                {
                    soNgayLamViec = value;
                }
                else
                {
                    soNgayLamViec = 0;
                }
            }
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine(" - Số ngày làm: " + SoNgayLamViec + " - Tổng lương: " + TinhLuong());
        }
    }
}