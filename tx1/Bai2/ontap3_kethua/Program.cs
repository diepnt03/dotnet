using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap3_kethua
{
    class person
    {
        public string ht { get; set; }
        public string gt { get; set; }
        public int ns { get; set; }

        //khoi tao
        public person()
        {
            ht = "";
            gt = "";
            ns = 0;

        }
        public person(string ht1, string gt1, int ns1)
        {
            ht = ht1;
            gt = gt1;
            ns = ns1;

        }
        
        public virtual void input()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            ht = Console.ReadLine();
            Console.Write("Nhap gioi tinh nhan vien: ");
            gt = Console.ReadLine();
            Console.Write("Nhap nam sinh nhan vien: ");
            ns =int.Parse( Console.ReadLine());
        }
        public virtual void output()
        {
            Console.Write("{0,-20}{1,-10}{2,-10}", ht, gt, ns);
        }

    }

    class congnhan : person
    {

        public string tenct { get; set; }
        public int hsl { get; set; }

        //khoi tao
        public congnhan() : base()
        {
            tenct = "";
            hsl = 0;
        }
        public congnhan(string ht1, string gt1, int ns1, string tenct1, int hsl1) : base(ht1, gt1, ns1)
        {
            tenct = tenct1;
            hsl = hsl1;
        }

        public override void input()
        {
            base.input();
            Console.Write("Nhap ten cong ty: ");
            tenct = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            hsl = int.Parse(Console.ReadLine());

        }

        public override void output()
        {
            base.output();
            int thunhap=hsl*850000;
            Console.Write("{0,-15}{1,-10}{2,-10}", tenct, hsl, thunhap+"VND");

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            congnhan cn1 = new congnhan();
            cn1.input();
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-15}{4,-10}{5,-10}", "Ho ten", "Gioi tinh", "Nam sinh", "Ten cty", "Hsl", "Thu nhap");
            Console.WriteLine();
            cn1.output();
            Console.Read();
            */
            //ds cong nhap

            List<congnhan> dscn = new List<congnhan>();
            int n;
            Console.Write("Nhap so luong cong nhan n = ");
            n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Nhap Cong Nhan Thu {i + 1}");
                congnhan cn = new congnhan();
                cn.input();
                dscn.Add(cn);

            }

            Console.WriteLine();
            Console.WriteLine("********************Danh sach cong nhan********************");
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-15}{4,-10}{5,-10}", "Ho ten", "Gioi tinh", "Nam sinh", "Ten cty", "Hsl", "Thu nhap");
            Console.WriteLine();
            
            for(int i=0; i<n; i++)
            {
                dscn[i].output();
                Console.WriteLine();
            }
            //Console.Read();

            int max = dscn[0].hsl;
            for(int i=1; i<n; i++)
            {
                if (dscn[i].hsl > max)
                {
                    max = dscn[i].hsl;
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("********************Danh sach cong nhan co hsl max********************");
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-15}{4,-10}{5,-10}", "Ho ten", "Gioi tinh", "Nam sinh", "Ten cty", "Hsl", "Thu nhap");
            Console.WriteLine();

            for (int i=0; i<n; i++)
            {
                if (dscn[i].hsl == max)
                {
                    dscn[i].output();
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
