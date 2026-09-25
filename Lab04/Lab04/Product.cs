using System;
using System.Security.Principal;

namespace Lab04_QuanLySanPham
{
    public class Product : IEntity
    {
        private string maSP;
        private string tenSP;
        private double price;
        private int quantity;

        public string Id
        {
            get { return maSP; }
        }

        public string MaSP
        {
            get { return maSP; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mã sản phẩm không được để trống!");
                }
                maSP = value;
            }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Đơn giá không được âm!");
                }
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Số lượng không được âm!");
                }
                quantity = value;
            }
        }

        public Product(string maSP, string tenSP, double price, int quantity)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return "Mã SP: " + MaSP + " | Tên SP: " + TenSP + " | Giá: " + Price + " | SL: " + Quantity;
        }
    }
}