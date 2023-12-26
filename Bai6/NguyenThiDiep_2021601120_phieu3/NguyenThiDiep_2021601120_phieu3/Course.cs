using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiDiep_2021601120_phieu3
{
    internal class Course
    {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }
        public List<Student> li { get; set; }

        public Course()
        {
            li = new List<Student>();
            courseID = "DEFAULT_COURSE_ID";
            courseName = "DEFAULT_COURSE_NAME";
            fee = 0;
        }

        public void InputCourse()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Mã Môn Học: ");
            courseID = Console.ReadLine();
            Console.Write("Nhập Tên Môn Học: ");
            courseName = Console.ReadLine();
            Console.Write("Nhập Học Phí: ");
            fee = int.Parse(Console.ReadLine());

            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Nhập Thông Tin Học Sinh Thứ {i}: ");
                Student student = new Student();
                student.InputStudent();
                li.Add(student);
            }
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"Mã Môn Học: {courseID}" +
                $"\nTên Môn Học: {courseName}" +
                $"\nHọc Phí: {fee}");

            Console.WriteLine("Danh Sách Sinh Viên Lớp Học: ");


            title();
            foreach (var student in li)
            {
                
                Console.WriteLine(student);
            }
        }
        
    public static void title()
    {
        Console.WriteLine($"{"sid",-8} {"name",-25} {"mark",-5}");

    }

    public List<Student> GetAllStudents()
        {
            return li;
        }
    }
}