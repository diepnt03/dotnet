using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<KhachHangVIP> list = new List<KhachHangVIP>();
            int chon;
            do
            {
                Console.WriteLine("-----Quản lí khách hàng-----");
                Console.WriteLine("1.Nhập thông tin");
                Console.WriteLine("2.Hiển thị danh sách");
                Console.WriteLine("3.Xóa khách hàng");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chon: ");
                chon = int.Parse(Console.ReadLine());

                switch(chon)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình");
                        return;
                    default:
                        break;

                }

            } while (true);
            Console.ReadLine();

        }
        public static void nhap(List<KhachHangVIP> list)
        {
            KhachHangVIP kh = new KhachHangVIP();

        }


    }
}
