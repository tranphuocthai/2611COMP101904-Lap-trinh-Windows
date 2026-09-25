using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Lab04_QuanLySanPham
{
    public class Repository<T> where T : IEntity
    {
        private List<T> danhSach = new List<T>();

        public void Add(T entity)
        {
            if (FindById(entity.Id) != null)
            {
                throw new DuplicateProductException("Mã " + entity.Id + " đã tồn tại trong hệ thống!");
            }
            danhSach.Add(entity);
        }

        public void Remove(string id)
        {
            T entity = FindById(id);
            if (entity == null)
            {
                throw new ProductNotFoundException("Không tìm thấy mã " + id + " để thao tác!");
            }
            danhSach.Remove(entity);
        }

        public T FindById(string id)
        {
            return danhSach.FirstOrDefault(item => item.Id == id);
        }

        public List<T> Find(Func<T, bool> dieuKien)
        {
            return danhSach.Where(dieuKien).ToList();
        }

        public List<T> GetAll()
        {
            return danhSach;
        }
    }
}