using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiDiep_2021601120_phieu3
{
    internal class Student
    {
        public int studentID { get; set; }
        public string name { get; set; }
        public string mark { get; set; }

        public void InputStudent()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Mã Học Sinh: ");
            studentID = int.Parse(Console.ReadLine());
            Console.Write("Nhập Tên Học Sinh: ");
            name = Console.ReadLine();
            Console.Write("Nhập Điểm Thi: ");
            mark = Console.ReadLine();
        }
        public override string ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;

            return $"{studentID,-8} {name,-25} {mark,-5}";
        }
    }
}
