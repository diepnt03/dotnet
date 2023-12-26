using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMau
{
    internal class Program
    {
        static List<NhanVien> list = new List<NhanVien>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int choose;
            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Sắp xếp");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Sửa");
                Console.WriteLine("6. Xóa");
                Console.WriteLine("7. Thoát");
                Console.Write("Mời nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Sort();
                        Show();
                        break;
                    case 4:
                        Search();
                        break;
                    case 5:
                        Sua();
                        Show();
                        break;
                    case 6:
                        Delete();
                        Show();
                        break;
                    case 7:
                        Console.WriteLine("Kết thúc chương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }

            } while (true);
        }

        public static bool checkID(NhanVien nv)
        {
            foreach(var item in list)
            {
                if(item.MaNV == nv.MaNV)
                    return true;
            }
            return false;

        }
        public static void Add()
        {
            NhanVien nv = new NhanVien();
            nv.Nhap();
            if (!checkID(nv))
            {
                list.Add(nv);
                Console.WriteLine("Thêm thành công!");
            }
            else
            {
                Console.WriteLine("Trùng mã nhân viên!");
                return;
            }
        }

        public static void Title() {
            Console.WriteLine($"\n{"Họ tên", -20} {"Địa chỉ", -20}{"Mã NV",-20}{"Chức vụ",-20}{"Lương CB",-15}{"Hệ số CV",-15}");
        }

        public static void Show()
        {
            Title();
            foreach(var item in list)
            {
                Console.WriteLine($"\n{item.HoTen,-20} {item.DiaChi,-20}{item.MaNV,-20}{item.ChucVu,-20}{item.LuongCB,-15}{item.heSoChucVu(),-15}");
            }
        }

        public static void Sort()
        {
            for(int i = 0;i< list.Count-1; i++)
            {
                for(int j = i+1;j< list.Count;j++) 
                {
                    if (list[i].heSoChucVu() > list[j].heSoChucVu())
                    {
                        NhanVien temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                    else if(list[i].heSoChucVu() == list[j].heSoChucVu())
                    {
                        if(list[i].LuongCB > list[j].LuongCB)
                        {
                            NhanVien temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }

        //tìm kiếm nhân viên theo mã nhân viên
        public static void Search()
        {
            string ma;
            Console.Write("Nhập mã nhân viên muốn tìm kiếm: ");
            ma = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaNV == ma)
                {
                    Title();
                    Console.WriteLine($"\n{list[i].HoTen,-20} {list[i].DiaChi,-20}{list[i].MaNV,-20}{list[i].ChucVu,-20}{list[i].LuongCB,-15}{list[i].heSoChucVu(),-15}");
                    return;
                }
            }
            Console.WriteLine("Không tồn tại nhân viên có mã muốn tìm");

        }
        
        //sửa thông tin nhân viên theo tên được nhập vào
        public static void Sua()
        {
            string ten;
            Console.Write("Nhập tên nhân viên muốn sửa: ");
            ten = Console.ReadLine();
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhập thông tin nhân viên mới: ");
            nv.Nhap();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].HoTen == ten)
                {
                    list[i] = nv;
                    return;
                }
            }
            Console.WriteLine("Không tồn tại tên nhân viên muốn sửa");
        }

        //xóa nhân viên với mã nhân viên đươc nhập vào
        public static void Delete()
        {
            string ma;
            Console.Write("Nhập mã nhân viên muốn xóa: ");
            ma = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaNV == ma)
                {
                    list.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Không tồn tại nhân viên có mã muốn xóa");
        }

    }
}
