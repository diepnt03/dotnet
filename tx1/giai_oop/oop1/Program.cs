using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class Program
    {
        static List<NhanVien> nhanViens = new List<NhanVien>();
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose;
            
            do
            {
                Console.WriteLine($"-------------------Menu--------------------");
                Console.WriteLine($"1. Thêm");
                Console.WriteLine($"2. Hiển thị danh sách");
                Console.WriteLine($"3. Sắp xếp");
                Console.WriteLine($"4. Thoát");

                Console.WriteLine($"Nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        AddNhanVien();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Sort();
                        break;
                    case 4:
                        Console.WriteLine($"Kết thúc");
                        return;
                    default:
                        Console.WriteLine($"Không có lựa chọn này");
                        break;
                }
            } while (true);

        }

        static bool trungMaNV(NhanVien x)
        {
            foreach (NhanVien nhanVien in nhanViens)
            {
                if (nhanVien.MaNV == x.MaNV)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddNhanVien()
        {
            Console.WriteLine("Nhập thông tin nhân viên:");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.Write("Hệ số lương: ");
            float heSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Mã nhân viên: ");
            string maNV = Console.ReadLine();
            Console.Write("Chức vụ (Giám đốc/Trưởng phòng/Phó giám đốc/Phó phòng): ");
            string chucVu = Console.ReadLine();
            NhanVien nv = new NhanVien(hoTen, diaChi, heSoLuong, maNV, chucVu);

            if (!trungMaNV(nv))
            {
                nhanViens.Add(nv);
                Console.WriteLine("Nhân viên đã được thêm vào danh sách.");
            }
            else
            {
                Console.WriteLine("Mã nhân viên đã tồn tại. Không thêm được.");
            }

        }

        public static void Title()
        {
            Console.WriteLine($"{"Họ tên",-20} {"Địa chỉ",-20} {"Hệ số lương",-15} {"Mã nhân viên",-15} {"Chức vụ",-20} {"Lương",-20}");
        }
        public static void Show()
        {
            Title();
            foreach (var item in nhanViens)
            {
                Console.WriteLine($"{item.HoTen,-20} {item.DiaChi,-20} {item.HeSoLuong,-15} {item.MaNV,-15} {item.ChucVu,-20} {item.GetLuong(),-20}");
            }
        }
        public static void Sort()
        {
            for (int i = 0; i < nhanViens.Count - 1; i++)
            {
                for (int j = i + 1; j < nhanViens.Count; j++)
                {
                    if (nhanViens[j - 1].GetLuong() > nhanViens[j].GetLuong())
                    {
                        NhanVien temp = nhanViens[j - 1];
                        nhanViens[j - 1] = nhanViens[j];
                        nhanViens[j] = temp;
                    }
                }
            }
            Show();
        }


    }
}
