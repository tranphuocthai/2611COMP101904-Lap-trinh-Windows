using System;

namespace QuanLyNhanVien
{
    public class NhanVienKinhDoanh : NhanVien
    {
        private double doanhSo;

        public double DoanhSo
        {
            get { return doanhSo; }
            set
            {
                if (value >= 0)
                {
                    doanhSo = value;
                }
                else
                {
                    doanhSo = 0;
                }
            }
        }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + 0.05 * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine(" - Doanh số: " + DoanhSo + " - Tổng lương: " + TinhLuong());
        }
    }
}