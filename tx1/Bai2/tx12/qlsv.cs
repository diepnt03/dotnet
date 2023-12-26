using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class qlsv 
    {
        public void nhapds(List<svcn> dssv)
        {
            Console.Write("Nhap so luong sinh vien n = ");
            int n=0 ;

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("So khong dung dinh dang");
                Console.WriteLine("Error" + e.ToString());
            }
            

            int i = 0;
           
            for (i = 0; i < n; i++)
            {
                svcn sv2 = new svcn();
                Console.WriteLine();
                Console.WriteLine("Nhap sinh vien thu {0}", i+1);
                sv2.nhap();
                dssv.Add(sv2);
            }

            if (i >= n)
            {
                string or = "";
                Console.WriteLine("Co muon nhap tiep khong");
                or = Console.ReadLine();

                switch (or)
                {
                    case "co":
                        svcn sv3 = new svcn();
                        sv3.nhap();
                        dssv.Add(sv3);
                        break;
                    case "khong":
                        break;
                }

            }
        }

        public void xuatds(List<svcn> dssv)
        {
            foreach(var item in dssv)
            {
                item.xuat();
                Console.WriteLine();
            }
        }

        public void timsv(List<svcn> dssv)
        {
            Console.Write("Nhap ma sinh vien can tim:");
            int ma = int.Parse(Console.ReadLine());

            for (int i = 0; i < dssv.Count; i++)
            {
                if(dssv[i].masv == ma)
                { 
                    dssv[i].xuat();
                    Console.WriteLine();
                }
               
            }
        }

        public void xoasv(List<svcn> dssv)
        {
            Console.Write("Nhap ma sinh vien can xoa:");
            int ma = int.Parse(Console.ReadLine());

            for (int i = 0; i < dssv.Count; i++)
            {
                if (dssv[i].masv == ma)
                {
                   dssv.RemoveAt(i);
                }
                
            }
        }


    }
}
