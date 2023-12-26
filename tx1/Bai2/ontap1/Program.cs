using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1 so x=");
            //string temp = Console.ReadLine();
            int x = 0;
            try
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("x^2= " + x*x );
            }

            catch (FormatException e)
            {
                Console.WriteLine("So nguyen nhap vao khong dung dinh dang!");
                Console.WriteLine("Error: " + e.ToString());
            }
            Console.ReadLine();


            }
        }
}
