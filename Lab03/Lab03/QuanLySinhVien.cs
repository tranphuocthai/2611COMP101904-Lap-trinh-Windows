using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03_QuanLySinhVien
{
    public class QuanLySinhVien
    {
        private List<SinhVien> danhSach;

        public QuanLySinhVien()
        {
            danhSach = new List<SinhVien>();
        }

        public List<SinhVien> LayDanhSach()
        {
            return danhSach;
        }

        public bool KiemTraTrungMa(string maSinhVien)
        {
            return danhSach.Any(sv => sv.MaSinhVien == maSinhVien);
        }

        public void Them(SinhVien sv)
        {
            danhSach.Add(sv);
        }

        public SinhVien TimTheoMa(string maSinhVien)
        {
            return danhSach.FirstOrDefault(sv => sv.MaSinhVien == maSinhVien);
        }

        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            return danhSach.Where(sv => sv.HoTen.ToLower().Contains(tuKhoa.ToLower())).ToList();
        }

        public bool Sua(string maSinhVien, double diemMoi)
        {
            SinhVien sv = TimTheoMa(maSinhVien);
            if (sv != null)
            {
                sv.DiemTrungBinh = diemMoi;
                return true;
            }
            return false;
        }

        public bool Xoa(string maSinhVien)
        {
            SinhVien sv = TimTheoMa(maSinhVien);
            if (sv != null)
            {
                danhSach.Remove(sv);
                return true;
            }
            return false;
        }

        public List<SinhVien> SapXepTheoDiem()
        {
            return danhSach.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public List<SinhVien> LocSinhVienDat()
        {
            return danhSach.Where(sv => sv.DiemTrungBinh >= 5).ToList();
        }
    }
}