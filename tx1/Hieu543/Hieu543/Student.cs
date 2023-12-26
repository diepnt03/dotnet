using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieu543
{
    class Student
    {
        public int studentid { get; set; }
        public string name { get; set; }
        public string mark { get; set; }

        public Student()
        {
            this.studentid = -1;
            this.name = "";
            this.mark = ""; 
        }
        public Student(int studentid, string name, string mark)
        {
            this.studentid = studentid;
            this.name = name;
            this.mark = mark; 

        }
        public override string ToString()
        {
            return "Id SV: " + this.studentid + "\nName: " + this.name + "\nMark: " + this.mark;
        }
        public void InputStudent()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.Write("Nhập id sinh viên: ");
            this.studentid = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên sinh viên: ");
            this.name = Console.ReadLine();
            Console.Write("Nhập điểm sv: ");
            this.mark = Console.ReadLine(); 

        }
        public Student(int id)
        {
            this.studentid = id;
        }
        public override bool Equals(object obj)
        {
            Student s = (Student)obj;
            return (this.studentid.Equals(s.studentid)); 
        }

    }
}
