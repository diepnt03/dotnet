using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_co_thanh_vien_la_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.bid = "b01";
            b1.bname = "Lập trình viên";
            b1.numberPage = 300;
            b1.price = 300;
            Console.WriteLine(b1);
            Console.WriteLine("Number of books: " + Book.GetNumberOfBook());

            Book b2 = new Book("b02","Lập trình php", 300, 250);
            Console.WriteLine();
            Console.WriteLine(b2);
            Console.WriteLine("Number of books: " + Book.GetNumberOfBook());

            Console.ReadKey();
        }
    }
}
