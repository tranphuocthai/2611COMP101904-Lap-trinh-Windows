using System;

namespace Lab06
{
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool ConKinhDoanh { get; set; }
        public string DuongDanAnh { get; set; }

        public Product()
        {
            MaSP = string.Empty;
            TenSP = string.Empty;
            LoaiSP = string.Empty;
            DuongDanAnh = string.Empty;
        }

        public decimal ThanhTien
        {
            get { return DonGia * SoLuong; }
        }
    }
}