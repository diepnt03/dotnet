using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static List<NhanVien> list = new List<NhanVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int c;
            do
            {
                Console.WriteLine($"1. Thêm nhân viên");
                Console.WriteLine($"2. Hiển thị danh sách");
                Console.WriteLine($"3. Sắp xếp");
                Console.WriteLine($"4. Thoát");
                Console.Write($"Nhập lựa chọn: ");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Them();
                        break;
                    case 2:
                        HienThi();
                        break;
                    case 3:
                        SapXep();
                        break;
                    case 4:
                        Console.WriteLine($"Kết thúc trương trình");
                        return;
                    default:
                        Console.WriteLine($"Không có lựa chọn này");
                        break;
                }

            } while (true);

        }

        static void Them()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Nhap();
            foreach (var item in list)
            {
                if (item.MaNV == nhanVien.MaNV)
                {
                    Console.WriteLine($"\nMã nhân viên trùng\n");
                    return;
                }
            }
            list.Add(nhanVien);
        }
        static void HienThi()
        {
            Console.WriteLine($"{"Mã nhân viên",20} {"Họ tên",20} {"Địa chỉ",20} {"Chức vụ",20} {"Lương cơ bản",20} {"Hệ số chức vụ",20}");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.MaNV,20} {item.HoTen,20} {item.DiaChi,20} {item.ChucVu,20} {item.LuongCB,20} {item.tinhHeSo(),20}");
            }
        }
        static void SapXep()
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].tinhHeSo() > list[j].tinhHeSo())
                    {
                        NhanVien temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                    else if (list[i].tinhHeSo() == list[j].tinhHeSo())
                    {
                        if (list[i].LuongCB > list[j].LuongCB)
                        {
                            NhanVien temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
