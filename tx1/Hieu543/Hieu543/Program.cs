using System;
using System.Collections.Generic;
using System.IO;

namespace Hieu543
{
    class Program
    {
        static void handleAction(ref List<Course> list)
        {
            int choice; 
            Console.Write("1.Thêm một khoá học" +
                "\n2.Hiển thị các khoá học" +
                "\n3.Tìm kiếm khoá học." +
                "\n4.Tìm kiếm sinh viên." +
                "\n5.Xoá một khoá học." +
                "\n6.Kết thúc chương trình." +
                "\nYour choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Course cs = new Course();
                    cs.InputCourse();
                    Console.Write("Nhập số sinh viên: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("-----");
                        Student sm = new Student();
                        sm.InputStudent();
                        cs.listStd.Add(sm);
                    }
                    list.Add(cs);
                    handleAction(ref list); 
                    break;
                case 2:
                    foreach (Course item in list)
                    {
                        item.DisplayCourseAndStudents();
                    }
                    handleAction(ref list);

                    break;
                case 3:
                    Console.Write("Nhap ma khoa hoc: ");
                    string ma = Console.ReadLine();
                    Course sh = new Course(ma); 
                    int index = list.IndexOf(sh);
                    if (index == -1) {
                        Console.WriteLine("Không tìm thấy courseId: "+ma);
                    }
                    else
                    {
                        list[index].DisplayCourseAndStudents(); 
                    }
                    /*foreach (Course item in list)
                    {
                        if (item.courseid == ma) item.DisplayCourseAndStudents(); 
                    }*/
                    handleAction(ref list); 
                    break;
                case 4:
                    Console.Write("Nhap id : ");
                    int id = int.Parse(Console.ReadLine());
                    Student s = new Student(id); 

                    foreach (Course item in list)
                    {

                        int st = item.listStd.IndexOf(s);

                        if (st == -1) Console.WriteLine("Khong tin thay student id: " + id);
                        else Console.WriteLine(item.listStd[st] ); 
                    }
                    handleAction(ref list); 
                    break;
                case 5:
                    list.Sort();
                    foreach (Course item in list)
                    {
                        item.DisplayCourseAndStudents();
                    }
                    handleAction(ref list);
                    break;
                case 6:
                    TextWriter tw = new StreamWriter("SavedList.txt");

                    foreach (Student st in list[0].listStd)
                        tw.WriteLine(st);

                    tw.Close();
                    break;
                case 7:
                    var logFile = File.ReadAllLines("SavedList.txt");
                    var logList = new List<string>(logFile);
                    Console.WriteLine(logList);
                    break; 
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
           
            List<Course> list = new List<Course>();
            handleAction(ref list); 
            
        }
    }
}
