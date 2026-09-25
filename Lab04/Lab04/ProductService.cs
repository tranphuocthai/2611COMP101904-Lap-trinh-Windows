using System;
using System.Collections.Generic;

namespace Lab04_QuanLySanPham
{
    public class ProductService
    {
        private Repository<Product> repo;

        public event Action<string> OnDataChanged;

        public ProductService()
        {
            repo = new Repository<Product>();
        }

        public void AddProduct(Product sp)
        {
            repo.Add(sp);
            if (OnDataChanged != null)
            {
                OnDataChanged("Thêm thành công sản phẩm: " + sp.TenSP);
            }
        }

        public void RemoveProduct(string id)
        {
            repo.Remove(id);
            if (OnDataChanged != null)
            {
                OnDataChanged("Đã xóa sản phẩm có mã: " + id);
            }
        }

        public List<Product> GetAllProducts()
        {
            return repo.GetAll();
        }

        public Product SearchById(string id)
        {
            return repo.FindById(id);
        }

        public List<Product> SearchByName(string keyword)
        {
            return repo.Find(p => p.TenSP.ToLower().Contains(keyword.ToLower()));
        }

        public List<Product> FilterByPrice(double min, double max)
        {
            return repo.Find(p => p.Price >= min && p.Price <= max);
        }

        public double CalculateTotalValue()
        {
            double tong = 0;
            List<Product> ds = repo.GetAll();
            for (int i = 0; i < ds.Count; i++)
            {
                tong = tong + (ds[i].Price * ds[i].Quantity);
            }
            return tong;
        }
    }
}