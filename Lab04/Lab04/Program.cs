using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_QuanLySanPham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ProductService service = new ProductService();

            service.OnDataChanged += HienThiThongBaoHeThong;

            int luaChon = -1;

            while (luaChon != 0)
            {
                Console.WriteLine("\n    PRODUCT MANAGER    ");
                Console.WriteLine("1. Thêm sản phẩm");
                Console.WriteLine("2. Xuất danh sách");
                Console.WriteLine("3. Tìm theo mã sản phầm");
                Console.WriteLine("4. Tìm theo tên sản phầm");
                Console.WriteLine("5. Lọc theo giá");
                Console.WriteLine("6. Xóa sản phẩm");
                Console.WriteLine("7. Tính tổng giá trong kho");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                try
                {
                    luaChon = int.Parse(Console.ReadLine());

                    if (luaChon == 1)
                    {
                        Console.Write("Nhập mã SP: ");
                        string ma = Console.ReadLine();
                        Console.Write("Nhập tên SP: ");
                        string ten = Console.ReadLine();
                        Console.Write("Nhập đơn giá: ");
                        double gia = double.Parse(Console.ReadLine());
                        Console.Write("Nhập số lượng: ");
                        int sl = int.Parse(Console.ReadLine());

                        Product spMoi = new Product(ma, ten, gia, sl);
                        service.AddProduct(spMoi);
                    }
                    else if (luaChon == 2)
                    {
                        List<Product> ds = service.GetAllProducts();
                        if (ds.Count == 0)
                        {
                            Console.WriteLine("Danh sách sản phẩm trống!");
                        }
                        else
                        {
                            Console.WriteLine("    DANH SÁCH SẢN PHẨM   ");
                            foreach (Product p in ds)
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                    }
                    else if (luaChon == 3)
                    {
                        Console.Write("Nhập mã sản phẩm cần tìm: ");
                        string maTim = Console.ReadLine();
                        Product kq = service.SearchById(maTim);
                        if (kq != null)
                        {
                            Console.WriteLine(kq.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sản phẩm!");
                        }
                    }
                    else if (luaChon == 4)
                    {
                        Console.Write("Nhập tên sản phẩm cần tìm: ");
                        string tenTim = Console.ReadLine();
                        List<Product> kqTen = service.SearchByName(tenTim);
                        if (kqTen.Count > 0)
                        {
                            foreach (Product p in kqTen)
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không có sản phẩm nào khớp tên!");
                        }
                    }
                    else if (luaChon == 5)
                    {
                        Console.Write("Nhập giá nhỏ nhất: ");
                        double min = double.Parse(Console.ReadLine());
                        Console.Write("Nhập giá lớn nhất: ");
                        double max = double.Parse(Console.ReadLine());

                        List<Product> kqGia = service.FilterByPrice(min, max);
                        if (kqGia.Count > 0)
                        {
                            foreach (Product p in kqGia)
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sản phẩm trong khoảng giá này!");
                        }
                    }
                    else if (luaChon == 6)
                    {
                        Console.Write("Nhập mã sản phầm cần xóa: ");
                        string maXoa = Console.ReadLine();
                        service.RemoveProduct(maXoa);
                    }
                    else if (luaChon == 7)
                    {
                        double tong = service.CalculateTotalValue();
                        Console.WriteLine("Tổng giá trị kho: " + tong);
                    }
                    else if (luaChon == 0)
                    {
                        Console.WriteLine("Đã thoát chương trình.");
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Dữ liệu nhập vào phải là số hợp lệ!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Lỗi dữ liệu: " + ex.Message);
                }
                catch (DuplicateProductException ex)
                {
                    Console.WriteLine("Lỗi nghiệp vụ: " + ex.Message);
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine("Lỗi nghiệp vụ: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        static void HienThiThongBaoHeThong(string thongBao)
        {
            Console.WriteLine("[EVENT] " + thongBao);
        }
    }
}