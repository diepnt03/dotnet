using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx13
{
    class student
    {
        public int msv { get; set; }
        public string tensv { get; set; }
        public string khoa { get; set; }
        public float dtb { get; set; }

        public student()
        {
            msv = 0;
            tensv = "";
            khoa = "";
            dtb = 0;
        }

        public student(int msv1, string tensv1, string khoa1, float dtb1)
        {
            msv = msv1;
            tensv = tensv1;
            khoa = khoa1;
            dtb = dtb1;
        }

        public void nhap()
        {
            Console.Write("Nhap ma so sinh vien = ");
            msv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten sinh vien: ");
            tensv = Console.ReadLine();
            Console.Write("Nhap khoa cua sinh vien: ");
            khoa = Console.ReadLine();
            Console.Write("Nhap diem trung binh = ");
            dtb = float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", msv, tensv, khoa, dtb);

        }

        public void sapx(List<student> dssv)
        {
            dssv.Sort((nv1, nv2) => nv1.dtb.CompareTo(nv2.dtb));//tang
            dssv.Sort((nv1, nv2) => nv1.dtb.CompareTo(nv2.dtb));
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            List<student> dssv = new List<student>();
            student sv0 = new student();

            Console.Write("Nhap so luong sinh vien n = ");
            int n = int.Parse(Console.ReadLine());
            int i ;
            int j ;
            
            
            for ( i = 0; i < n; i++)
            {
                student sv1 = new student();
                Console.WriteLine();
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                sv1.nhap();
                dssv.Add(sv1);
                  
            }
            /*
            for ( i = 0; i < dssv.Count; i++)
            {
                for ( j = 1; j < dssv.Count; j++)
                {
                    if(dssv[i].msv == dssv[j].msv)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Khong duoc nhap 2 sinh vien cung ma. Moi nhap lai");
                        dssv.RemoveAt(i);
                            
                    }
                }
                    
            }
                
                
            student sv5 = new student();
            Console.WriteLine("Nhap sinh vien ");
            sv5.nhap();
            dssv.Add(sv5);
             */   


            Console.WriteLine("------------DANH SACH VUA NHAP-----------");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}","Ma sv", "Ten sv", "Khoa sv", "Dtb");
            foreach (var item in dssv)
            {
                item.xuat();
               
            }

            
            Console.WriteLine("------------DANH SACH VUA SAP XEP-----------");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", "Ma sv", "Ten sv", "Khoa sv", "Dtb");
            sv0.sapx(dssv);
            foreach (var item in dssv)
            {
                item.xuat();

            }


            Console.Read();



        }
    }
}
