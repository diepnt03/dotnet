using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieu543
{
    class Course:ICourse, IComparable
    {
        public string courseid { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }
        public List<Student> listStd { get; set; }

        public Course()
        {
            this.listStd = new List<Student>();
        }
        public Course(string id)
        {
            this.courseid = id;
        }
        public void InputCourse()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Course id: ");
            this.courseid = Console.ReadLine();
            Console.Write("Course name: ");
            this.courseName = Console.ReadLine();
            Console.Write("Fee: ");
            this.fee = int.Parse(Console.ReadLine());

        }
        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("==========Course Information==========");
            Console.WriteLine("Course Id: {0,-10}\nCourse Name: {1,-20} \nFee: {2,-20}", this.courseid, this.courseName, this.fee);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Student Id", "Student Name", "Mark");
            foreach (Student s in this.listStd)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", s.studentid, s.name, s.mark);
            }
        }

        public List<Student> GetAllStudent()
        {
            return this.listStd;
        }
        public override bool Equals(object obj)
        {
            Course cs = (Course)obj;
            return (this.courseid.Equals(cs.courseid));

        }

        public int CompareTo(object obj)
        {
            Course cs = (Course)obj;
            return (this.fee.CompareTo(cs.fee)); 
        }
    }
    
    
}
