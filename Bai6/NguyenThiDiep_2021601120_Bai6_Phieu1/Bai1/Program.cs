using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai1
{
    internal class Program
    {
        static void title()
        {
            Console.Write($"{"id",8} {"name",20} {"address",14},{"math",6} {"physics",6} {"tong diem",8}\n");

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int choose;
            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("\n____MENU____");
                Console.WriteLine("1. Thêm 1 sinh viên.");
                Console.WriteLine("2. Hiển thị danh sách sinh viên.");
                Console.WriteLine("3. Tìm kiếm sinh viên theo Id");
                Console.WriteLine("4. Tìm kiếm sinh viên theo Adress");
                Console.WriteLine("5. Xóa 1 sinh viên.");
                Console.WriteLine("6. Kết thúc chương trình.");
                Console.Write("\nNhập lựa chọn : ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Student x = new Student();
                        Console.WriteLine("\nNhập thông tin : ");
                        x.Input();
                        if (!students.Contains(x))
                            students.Add(x);
                        else
                            Console.WriteLine("Sinh viên đã tồn tại!");
                        break;

                    case 2:
                        Console.WriteLine("\nDanh sách sinh viên :");
                        title();
                        foreach (var item in students)
                        {
                            item.Output();
                        }
                        break;

                    case 3:
                        int ID;
                        int check3 = 0;
                        Console.Write("\nNhập ID cần tìm : ");
                        ID = int.Parse(Console.ReadLine());
                        title();
                        foreach (var item in students)
                        {
                            if (item.id == ID)
                            {
                                check3 = 1;
                                item.Output();
                            }

                        }
                        if (check3 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên!.");

                        break;

                    case 4:
                        string ADDRESS;
                        int check4 = 0;
                        Console.Write("\nNhập ADDRESS cần tìm : ");
                        ADDRESS = Console.ReadLine();
                        title();
                        foreach (var item in students)
                        {
                            if (item.address == ADDRESS)
                            {
                                check4 = 1;
                                item.Output();
                            }
                        }
                        if (check4 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên!.");
                        break;

                    case 5:
                        int ID5, check5 = 0;
                        Console.WriteLine("\nNhập ID sinh viên cần xóa : ");
                        ID5 = int.Parse(Console.ReadLine());
                        Student temp = new Student();
                        foreach (var item in students)
                        {
                            if (item.id == ID5)
                            {
                                check5 = 1;
                                temp = item;                                
                            }
                        }                        

                        students.Remove(temp);

                        Console.WriteLine("\nDanh sách sau khi xóa : ");
                        title();
                        foreach (var item in students)
                        {
                            item.Output();
                        }

                        if (check5 == 0)
                            Console.WriteLine("Không tìm thấy sinh viên, thao tác lại !");
                        break;

                    case 6:
                        Console.WriteLine("\nChương trình đã kết thúc!");
                        return;

                    default:
                        break;
                }
                Console.ReadLine();
            }
            while (true);
            
        }
    }
}
