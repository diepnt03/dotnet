using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
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
                    GiaiPTB2 phuongTrinhBac2 = new GiaiPTB2(2, 4, 2);
                    Console.WriteLine("Kết quả là: {0}", phuongTrinhBac2.Giai());
                    Console.ReadLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Không được sai định dạng số");
                    continue;
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
