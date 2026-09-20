using System;

namespace QuanLyNhanVien
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double luongCoBan;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if (value > 0)
                {
                    luongCoBan = value;
                }
                else
                {
                    luongCoBan = 1;
                }
            }
        }

        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public virtual double TinhLuong()
        {
            return 0;
        }

        public virtual void HienThiThongTin()
        {
            Console.Write("Mã NV: " + MaNV + " - Họ tên: " + HoTen + " - Lương CB: " + LuongCoBan);
        }
    }
}