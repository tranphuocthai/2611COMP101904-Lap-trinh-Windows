using System;
using System.Collections.Generic;
using System.Text;
namespace Lab03_QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            QuanLySinhVien qlsv = new QuanLySinhVien();
            int luaChon = -1;

            while (luaChon != 0)
            {
                Console.WriteLine("\n     QUẢN LÝ SINH VIÊN     ");
                Console.WriteLine("1. Thêm sinh viên vào danh sách");
                Console.WriteLine("2. Xuất danh sách sinh viên");
                Console.WriteLine("3. Tìm thông tin sinh viên bằng MSV");
                Console.WriteLine("4. Tìm thông tin sinh viên bằng tên");
                Console.WriteLine("5. Sửa điểm trung bình");
                Console.WriteLine("6. Xóa sinh viên khỏi danh sách");
                Console.WriteLine("7. Sắp xếp theo điểm giảm dần");
                Console.WriteLine("8. Lọc các sinh viên đạt");
                Console.WriteLine("0. Thoát");
                Console.Write(" Chọn chức năng: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ.Hãy nhập số!");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        Console.Write("Nhập mã sinh viên: ");
                        string ma = Console.ReadLine();

                        if (qlsv.KiemTraTrungMa(ma))
                        {
                            Console.WriteLine("Mã sinh viên đã tồn tại!");
                            break;
                        }

                        Console.Write("Nhập họ tên: ");
                        string ten = Console.ReadLine();

                        DateTime ngaySinh;
                        while (true)
                        {
                            Console.Write("Nhập ngày sinh: ");
                            if (DateTime.TryParse(Console.ReadLine(), out ngaySinh))
                            {
                                break;
                            }
                            Console.WriteLine("Ngày sinh không hợp lệ. Hãy nhập lại!");
                        }

                        Console.Write("Nhập mã lớp: ");
                        string lop = Console.ReadLine();

                        double diem;
                        while (true)
                        {
                            Console.Write("Nhập điểm trung bình: ");
                            if (double.TryParse(Console.ReadLine(), out diem) && diem >= 0 && diem <= 10)
                            {
                                break;
                            }
                            Console.WriteLine("Điểm không hợp lệ. Hãy nhập số từ 0 đến 10!");
                        }

                        SinhVien svMoi = new SinhVien(ma, ten, ngaySinh, lop, diem);
                        qlsv.Them(svMoi);
                        Console.WriteLine("Thêm sinh viên thành công!");
                        break;

                    case 2:
                        List<SinhVien> danhSach = qlsv.LayDanhSach();
                        if (danhSach.Count == 0)
                        {
                            Console.WriteLine("Danh sách trống!");
                        }
                        else
                        {
                            Console.WriteLine("\n    DANH SÁCH SINH VIÊN    ");
                            foreach (SinhVien sv in danhSach)
                            {
                                Console.WriteLine(sv.LayThongTin());
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Nhập mã sinh viên cần tìm: ");
                        string maTim = Console.ReadLine();
                        SinhVien svTim = qlsv.TimTheoMa(maTim);

                        if (svTim != null)
                        {
                            Console.WriteLine("Thông tin sinh viên: ");
                            Console.WriteLine(svTim.LayThongTin());
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên có mã: " + maTim);
                        }
                        break;

                    case 4:
                        Console.Write("Nhập từ khóa tên cần tìm: ");
                        string tenTim = Console.ReadLine();
                        List<SinhVien> dsTim = qlsv.TimTheoTen(tenTim);

                        if (dsTim.Count > 0)
                        {
                            Console.WriteLine("Kết quả tìm kiếm:");
                            foreach (SinhVien sv in dsTim)
                            {
                                Console.WriteLine(sv.LayThongTin());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên nào chứa tên: " + tenTim);
                        }
                        break;

                    case 5:
                        Console.Write("Nhập mã sinh viên cần sửa điểm: ");
                        string maSua = Console.ReadLine();

                        if (qlsv.TimTheoMa(maSua) != null)
                        {
                            double diemMoi;
                            while (true)
                            {
                                Console.Write("Nhập điểm trung bình mới: ");
                                if (double.TryParse(Console.ReadLine(), out diemMoi) && diemMoi >= 0 && diemMoi <= 10)
                                {
                                    break;
                                }
                                Console.WriteLine("Điểm không hợp lệ. Hãy nhập số từ 0 đến 10!");
                            }

                            if (qlsv.Sua(maSua, diemMoi))
                            {
                                Console.WriteLine("Cập nhật điểm thành công!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên có mã: " + maSua);
                        }
                        break;

                    case 6:
                        Console.Write("Nhập mã sinh viên cần xóa: ");
                        string maXoa = Console.ReadLine();

                        if (qlsv.Xoa(maXoa))
                        {
                            Console.WriteLine("Đã xóa sinh viên thành công!");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên có mã: " + maXoa);
                        }
                        break;

                    case 7:
                        List<SinhVien> dsSapXep = qlsv.SapXepTheoDiem();
                        if (dsSapXep.Count > 0)
                        {
                            Console.WriteLine("Danh sách sau khi sắp xếp giảm dần theo điểm:");
                            foreach (SinhVien sv in dsSapXep)
                            {
                                Console.WriteLine(sv.LayThongTin());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Danh sách trống!");
                        }
                        break;

                    case 8:
                        List<SinhVien> dsDat = qlsv.LocSinhVienDat();
                        if (dsDat.Count > 0)
                        {
                            Console.WriteLine("Danh sách sinh viên đạt (Điểm >= 5):");
                            foreach (SinhVien sv in dsDat)
                            {
                                Console.WriteLine(sv.LayThongTin());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không có sinh viên nào đạt!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;

                    default:
                        Console.WriteLine("Chức năng không tồn tại. Hãy chọn lại!");
                        break;
                }
            }
        }
    }
}