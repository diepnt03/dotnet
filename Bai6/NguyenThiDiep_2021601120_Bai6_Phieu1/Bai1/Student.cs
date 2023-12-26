using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Student : Person
    {
        public float math { get; set; }
        public float physics { get; set; }

        public Student():base()
        {
        }

        public Student(int id, string name, string address,float math, float physics):base(id,name,address)
        {

            this.math = math;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Math : ");
            math = float.Parse(Console.ReadLine());
            Console.Write("Physics : ");
            physics = float.Parse(Console.ReadLine());
        }

        public float Total()
        {
            return math + physics;
        }

        public override void Output()
        {
            base.Output();
            Console.Write($"{math,6} {physics,6} {this.Total(),8}\n");
        }

        public override bool Equals(object obj)
        {
            Student x = (Student)obj;
            return x.id.Equals(this.id);
        }
    }
}
