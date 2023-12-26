using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Car : Vehicles
    {
        public string color { get; set; }

        public Car() : base()
        {
            color = "DEFAULT_COLOR";
        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Màu Sắc: ");
            color = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Màu sắc: {color}");
        }
    }
}
