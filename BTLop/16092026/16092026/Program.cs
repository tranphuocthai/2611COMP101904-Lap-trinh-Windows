using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<NhanVien> danhSach = new List<NhanVien>();
            int luaChon = -1;

            while (luaChon != 0)
            {
                Console.WriteLine("\n BẢNG CHỌN CHỨC NĂNG ");
                Console.WriteLine("1. Tạo danh sách nhân viên mới");
                Console.WriteLine("2. Thêm nhân viên");
                Console.WriteLine("3. Sửa thông tin nhân viên");
                Console.WriteLine("4. Xóa nhân viên");
                Console.WriteLine("5. Xuất danh sách nhân viên");
                Console.WriteLine("6. Tìm nhân viên theo mã");
                Console.WriteLine("7. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("8. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    continue;
                }

                if (luaChon == 1)
                {
                    danhSach.Clear();
                    Console.WriteLine("Đã tạo danh sách mới thành công.");
                }
                else if (luaChon == 2)
                {
                    NhanVien nv = NhapNhanVienMoi();
                    danhSach.Add(nv);
                    Console.WriteLine("Đã thêm nhân viên thành công.");
                }
                else if (luaChon == 3)
                {
                    Console.Write("Nhập mã nhân viên cần sửa: ");
                    string maSua = Console.ReadLine();
                    int viTri = -1;

                    for (int i = 0; i < danhSach.Count; i++)
                    {
                        if (danhSach[i].MaNV == maSua)
                        {
                            viTri = i;
                            break;
                        }
                    }

                    if (viTri != -1)
                    {
                        Console.WriteLine("Nhập thông tin mới cho nhân viên này:");
                        NhanVien nvSua = NhapNhanVienMoi();
                        danhSach[viTri] = nvSua;
                        Console.WriteLine("Đã sửa thông tin thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy nhân viên mã " + maSua);
                    }
                }
                else if (luaChon == 4)
                {
                    Console.Write("Nhập mã nhân viên cần xóa: ");
                    string maXoa = Console.ReadLine();
                    int viTriXoa = -1;

                    for (int i = 0; i < danhSach.Count; i++)
                    {
                        if (danhSach[i].MaNV == maXoa)
                        {
                            viTriXoa = i;
                            break;
                        }
                    }

                    if (viTriXoa != -1)
                    {
                        danhSach.RemoveAt(viTriXoa);
                        Console.WriteLine("Đã xóa nhân viên thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy nhân viên mã " + maXoa);
                    }
                }
                else if (luaChon == 5)
                {
                    if (danhSach.Count == 0)
                    {
                        Console.WriteLine("Danh sách trống!");
                    }
                    else
                    {
                        Console.WriteLine("\n DANH SÁCH NHÂN VIÊN ");
                        for (int i = 0; i < danhSach.Count; i++)
                        {
                            danhSach[i].HienThiThongTin();
                        }
                    }
                }
                else if (luaChon == 6)
                {
                    Console.Write("Nhập mã nhân viên cần tìm: ");
                    string maTim = Console.ReadLine();
                    bool timThay = false;

                    for (int i = 0; i < danhSach.Count; i++)
                    {
                        if (danhSach[i].MaNV == maTim)
                        {
                            danhSach[i].HienThiThongTin();
                            timThay = true;
                            break;
                        }
                    }

                    if (timThay == false)
                    {
                        Console.WriteLine("Không tìm thấy nhân viên mã " + maTim);
                    }
                }
                else if (luaChon == 7)
                {
                    if (danhSach.Count > 0)
                    {
                        double maxLuong = danhSach[0].TinhLuong();
                        int viTriMax = 0;

                        for (int i = 1; i < danhSach.Count; i++)
                        {
                            if (danhSach[i].TinhLuong() > maxLuong)
                            {
                                maxLuong = danhSach[i].TinhLuong();
                                viTriMax = i;
                            }
                        }

                        Console.WriteLine("\n NHÂN VIÊN CÓ LƯƠNG CAO NHẤT ");
                        danhSach[viTriMax].HienThiThongTin();
                    }
                    else
                    {
                        Console.WriteLine("Danh sách trống!");
                    }
                }
                else if (luaChon == 8)
                {
                    double tongLuong = 0;
                    for (int i = 0; i < danhSach.Count; i++)
                    {
                        tongLuong = tongLuong + danhSach[i].TinhLuong();
                    }
                    Console.WriteLine("\nTổng lương công ty phải trả: " + tongLuong);
                }
                else if (luaChon == 0)
                {
                    Console.WriteLine("Chương trình đã thoát.");
                }
                else
                {
                    Console.WriteLine("Lựa chọn không tồn tại.");
                }
            }
        }

        static NhanVien NhapNhanVienMoi()
        {
            Console.WriteLine("  1. Nhân viên văn phòng");
            Console.WriteLine("  2. Nhân viên kinh doanh");
            Console.WriteLine("  3. Nhân viên thời vụ");
            Console.Write("  Chọn loại nhân viên (1/2/3): ");
            string loai = Console.ReadLine();

            Console.Write("  Nhập mã nhân viên: ");
            string maNV = Console.ReadLine();

            Console.Write("  Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            double luongCB = 0;
            Console.Write("  Nhập lương cơ bản: ");
            double.TryParse(Console.ReadLine(), out luongCB);

            if (loai == "1")
            {
                int soNgay = 0;
                Console.Write("  Nhập số ngày làm việc: ");
                int.TryParse(Console.ReadLine(), out soNgay);
                return new NhanVienVanPhong(maNV, hoTen, luongCB, soNgay);
            }
            else if (loai == "2")
            {
                double doanhSo = 0;
                Console.Write("  Nhập doanh số: ");
                double.TryParse(Console.ReadLine(), out doanhSo);
                return new NhanVienKinhDoanh(maNV, hoTen, luongCB, doanhSo);
            }
            else if (loai == "3")
            {
                int soGio = 0;
                Console.Write("  Nhập số giờ làm: ");
                int.TryParse(Console.ReadLine(), out soGio);

                double luongGio = 0;
                Console.Write("  Nhập lương theo giờ: ");
                double.TryParse(Console.ReadLine(), out luongGio);

                return new NhanVienThoiVu(maNV, hoTen, luongCB, soGio, luongGio);
            }
            else
            {
                Console.WriteLine("  Loại không hợp lệ, hệ thống tự động tạo Nhân viên văn phòng mặc định.");
                return new NhanVienVanPhong(maNV, hoTen, luongCB, 0);
            }
        }
    }
}