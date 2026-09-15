using System;
using System.Text;

namespace QuanLyMangConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int[] mang = null;
            int luaChon = -1;

            while (luaChon != 0)
            {
                Console.WriteLine("\n  Bảng chọn chức năng");
                Console.WriteLine("1. Nhập mảng");
                Console.WriteLine("2. Xuất mảng và tính tổng");
                Console.WriteLine("3. Tìm giá trị max, min");
                Console.WriteLine("4. Đếm số lượng phần tử chẵn, lẻ");
                Console.WriteLine("5. Sắp xếp mảng tăng dần");
                Console.WriteLine("6. Tìm kiếm vị trí đầu tiên của x");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Hãy chức năng: ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Hãy nhập lại số!");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        mang = NhapMang();
                        break;
                    case 2:
                        if (KiemTraMang(mang))
                        {
                            XuatMang(mang);
                            TinhTong(mang);
                        }
                        break;
                    case 3:
                        if (KiemTraMang(mang))
                        {
                            TimMaxMin(mang);
                        }
                        break;
                    case 4:
                        if (KiemTraMang(mang))
                        {
                            DemChanLe(mang);
                        }
                        break;
                    case 5:
                        if (KiemTraMang(mang))
                        {
                            SapXepTangDan(mang);
                        }
                        break;
                    case 6:
                        if (KiemTraMang(mang))
                        {
                            TimKiem(mang);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Không có chức năng này hãy chọn lại!");
                        break;
                }
            }
        }

        static bool KiemTraMang(int[] a)
        {
            if (a == null)
            {
                Console.WriteLine("Chưa nhập mảng! Hãy chọn lại chức năng 1 để nhập.");
                return false;
            }
            return true;
        }

        static int[] NhapMang()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.Write("Nhập số lượng phần tử của mảng (n > 0): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out n))
                {
                    if (n <= 0)
                    {
                        Console.WriteLine("Số lượng phải là số nguyên dương lớn hơn 0!");
                    }
                }
                else
                {
                    Console.WriteLine("Dữ liệu không hợp lệ. Hãy nhập một số nguyên!");
                    n = 0;
                }
            }

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool nhapDung = false;
                while (!nhapDung)
                {
                    Console.Write("Nhập phần tử thứ " + i + ": ");
                    string giaTri = Console.ReadLine();
                    if (int.TryParse(giaTri, out a[i]))
                    {
                        nhapDung = true;
                    }
                    else
                    {
                        Console.WriteLine("Lỗi hãy thử lại!");
                    }
                }
            }
            Console.WriteLine("Nhập thành công!");
            return a;
        }

        static void XuatMang(int[] a)
        {
            Console.Write("Các phần tử trong mảng là: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void TinhTong(int[] a)
        {
            long tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }
            Console.WriteLine("Tổng các phần tử trong mảng = " + tong);
        }

        static void TimMaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("Giá trị lớn nhất (Max) = " + max);
            Console.WriteLine("Giá trị nhỏ nhất (Min) = " + min);
        }

        static void DemChanLe(int[] a)
        {
            int demChan = 0;
            int demLe = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    demChan++;
                }
                else
                {
                    demLe++;
                }
            }

            Console.WriteLine("Số lượng phần tử chẵn: " + demChan);
            Console.WriteLine("Số lượng phần tử lẻ: " + demLe);
        }

        static void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Đã sắp xếp mảng theo thứ tự tăng dần.");
            XuatMang(a);
        }

        static void TimKiem(int[] a)
        {
            Console.Write("Nhập giá trị x cần tìm: ");
            string input = Console.ReadLine();
            int x;

            if (!int.TryParse(input, out x))
            {
                Console.WriteLine("Dữ liệu nhập vào không hợp lệ!");
                return;
            }

            int viTri = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    viTri = i;
                    break;
                }
            }

            if (viTri != -1)
            {
                Console.WriteLine("Giá trị " + x + " xuất hiện lần đầu tiên tại vị trí: " + viTri);
            }
            else
            {
                Console.WriteLine("Không tìm thấy giá trị " + x + " trong mảng.");
            }
        }
    }
}