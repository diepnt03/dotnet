using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class Box : HinhChuNhat
    {
        protected int depth { get; set; }

        public Box() : base()
        {
        }

        public Box(int depth)
        {
            this.depth = depth;
        }

        public Box(int height, int width, int depth) : base(height, width)
        {
            this.depth = depth;
        }

        public int Volume()
        {
            return base.Area() * depth;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap depth: ");
            depth = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Depth: " + depth);

        }
    }
}
