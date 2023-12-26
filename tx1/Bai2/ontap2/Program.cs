using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap2
{
    class Program
    {
        public static void nhap(List<double> st)
        {
            Console.WriteLine("Nhap cac phan tu cua day so (nhap *** de dung) : ");
            string num = "";
            while (true)
            {
                num = Console.ReadLine();
                if (num == "***")
                {
                    break;
                }
                st.Add(Convert.ToDouble(num));
            }

        }


        public static void hienthi(List<double> st)
        {
            
            for (int i=0; i<st.Count; i++)
            {
                Console.Write(st[i] + " ");

            }
        }

        public static void sapxeptang(List<double> st)
        {
            st.Sort();
            Console.Write("Danh sach sau khi sap xep tang: ");
            hienthi(st);
        }

        public static void sapxepgiam(List<double> st)
        {
            double temp;
            for (int i = 0; i < st.Count; i++)
            {
                for (int j = i + 1; j < st.Count; j++)
                {
                    if (st[i] < st[j])
                    {
                        temp = st[i];
                        st[i] = st[j];
                        st[j] = temp;
                    }
                }
            }
            Console.Write("Danh sach sau khi sap xep giam: ");
            hienthi(st);
        }

        public static void xoasoam(List<double> st)
        {
            for (int i = 0; i < st.Count; i++)
                for (int j = 1; j < st.Count; j++)
                {
                    if (st[j] < 0)
                    {
                        st.RemoveAt(j);
                    }
                }
            Console.Write("Danh sach sau khi xoa so am: ");
            hienthi(st);
        }

        public static void chen(List<double> st)
        {
            double x;
            Console.Write("Nhap so chen x= ");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < st.Count; i++)
            {
                if (st[0] < x)
                {
                    st.Insert(0, x);
                    break;
                }
                else if (st[st.Count-1] > x)
                {
                    st.Insert(st.Count, x);
                    break;
                }
                else if (st[i] < x)
                {
                    st.Insert(i, x);
                    break;
                }

                Console.Write("Danh sach sau khi chen: ");
                hienthi(st);
            }
        }


        static void ghiFile(List<double> st)
        {
            StreamWriter w = new StreamWriter("C:\\DotNet\\Bai2\\list_num.txt");
            foreach (var i in st)
                w.Write(i + " ");
            w.Close();
            Console.WriteLine("Da ghi vao file");
        }

        static void docFile(string path)
        {
            StreamReader read = new StreamReader(path);
            Console.WriteLine("Da doc tu file");
            while (read.Peek() != -1)
            {
                Console.Write(read.ReadLine());
            }
            read.Close();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<double> st = new List<double>();
            nhap(st);
            Console.Write("Danh sach vua nhap: ");
            hienthi(st);
            Console.WriteLine();
            sapxeptang(st);
            Console.WriteLine();
            sapxepgiam(st);
            Console.WriteLine();
            xoasoam(st);
            Console.WriteLine();
            chen(st);
            Console.WriteLine();
            ghiFile(st);
            docFile("C:\\DotNet\\Bai2\\list_num.txt");


            Console.ReadLine();

        }
    }
}
