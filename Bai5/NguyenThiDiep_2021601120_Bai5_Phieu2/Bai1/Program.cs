using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                try
                {
                    Employee employee = new Employee();

                    Console.WriteLine("Nhập Thông Tin Nhân Viên: ");
                    employee.Input();
                    Console.WriteLine("Thông Tin Nhân Viên: ");
                    employee.Output();

                    Console.ReadKey();
                    break;
                }              
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    continue;
                }
            }
        }
    }
}
