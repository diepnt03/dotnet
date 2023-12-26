using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat r = new HinhChuNhat(7, 8);
            r.Output();
            Console.WriteLine("Area is: " + r.Area());
            Console.WriteLine("perimeter is: " + r.Perimater());

            Console.WriteLine();
            Box b = new Box(3,4,5);
            //b.Input();
            b.Output();
            Console.WriteLine("Volume is: "+b.Volume());

            Console.ReadLine();
        }
    }
}
