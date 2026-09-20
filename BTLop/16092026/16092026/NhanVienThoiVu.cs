using System;

namespace QuanLyNhanVien
{
    public class NhanVienThoiVu : NhanVien
    {
        private int soGioLam;
        private double luongTheoGio;

        public int SoGioLam
        {
            get { return soGioLam; }
            set
            {
                if (value >= 0)
                {
                    soGioLam = value;
                }
                else
                {
                    soGioLam = 0;
                }
            }
        }

        public double LuongTheoGio
        {
            get { return luongTheoGio; }
            set
            {
                if (value >= 0)
                {
                    luongTheoGio = value;
                }
                else
                {
                    luongTheoGio = 0;
                }
            }
        }

        public NhanVienThoiVu(string maNV, string hoTen, double luongCoBan, int soGioLam, double luongTheoGio)
            : base(maNV, hoTen, luongCoBan)
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine(" - Số giờ làm: " + SoGioLam + " - Lương theo giờ: " + LuongTheoGio + " - Tổng lương: " + TinhLuong());
        }
    }
}