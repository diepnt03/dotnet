using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static List<ThiSinhA> list = new List<ThiSinhA>();

        public static void title()
        {
            Console.WriteLine($"{"SBD",5} {"Họ tên",25} {"Địa chỉ",15} {"Điểm toán",15} {"Điểm lý",15} {"Điểm hóa",15} {"Điểm ưu tiên",15} {"Tổng điểm",15}");
        }

        public static void addThiSinh()
        {
            ThiSinhA thiSinhA = new ThiSinhA();
            thiSinhA.nhapThiSinh();
            list.Add(thiSinhA);
        }

        public static void show()
        {
            title();
            foreach (ThiSinhA thiSinh in list)
            {
                thiSinh.xuatThiSinh();
            }
        }

        public static void showByKey(String key, double tongDiem, String diaChi, int soBaoDanh)
        {
            title();
            foreach (ThiSinhA thiSinh in list)
            {
                if (key == "tongdiem" && thiSinh.tongDiem() >= tongDiem)
                {
                    thiSinh.xuatThiSinh();
                }
                else if (key == "diachi" && thiSinh.diaChi.Equals(diaChi))
                {
                    thiSinh.xuatThiSinh();
                }
                else if (key == "SBD" && thiSinh.soBaoDanh == soBaoDanh)
                {
                    thiSinh.xuatThiSinh();
                }
            }
        }

        public static int choose()
        {
            int choose;
            do
            {
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                    return choose;
                }
                catch (Exception)
                {
                    Console.Write("Dữ liệu không hợp lệ! Nhập lại: ");
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            do
            {
                Console.WriteLine("------------Menu-------------");
                Console.WriteLine("1. Nhập thông tin 1 thí sinh");
                Console.WriteLine("2. Hiển thị danh sách các thí sinh");
                Console.WriteLine("3. Hiển thị danh sách các sinh viên theo tổng điểm");
                Console.WriteLine("4. Hiển thị danh sách các sinh viên theo địa chỉ");
                Console.WriteLine("5. Tìm kiếm theo số bao danh");
                Console.WriteLine("6. Thoát chương trình");
                Console.Write("Chọn chức năng để sử dụng: ");
                switch (choose())
                {
                    case 1:
                        addThiSinh();
                        break;
                    case 2:
                        show();
                        break;
                    case 3:
                        Console.Write("Nhập tổng điểm cần tìm: ");
                        double tongDiem = Convert.ToDouble(Console.ReadLine());
                        showByKey("tongdiem", tongDiem, null, 0);
                        break;
                    case 4:
                        Console.Write("Nhập địa chỉ cần tìm: ");
                        String diaChi = Convert.ToString(Console.ReadLine());
                        showByKey("diachi", 0, diaChi, 0);
                        break;
                    case 5:
                        Console.Write("Nhập số báo danh cần tìm: ");
                        int soBaoDanh = Convert.ToInt32(Console.ReadLine());
                        showByKey("SBD", 0, null, soBaoDanh);
                        break;
                    case 6:
                        Console.WriteLine("Đã thoát khỏi trương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (true);

        }
    }
}
