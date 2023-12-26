using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class svcn:sv
    {
        public int cnh { get; set; }

        public svcn() : base()
        {
            cnh = 0;
        }

        public svcn(int masv1, string ht1, int cn1, int cnh1) : base(masv1,ht1,cn1)
        {
            cnh = cnh1;

        }

        public string ktra()
        {
            string cnh2 = " ";
            switch (cnh)
            {
                case 1:
                    cnh2 = "Java";
                    break;
                case 2:
                    cnh2 = "C#";
                    break;
            }

            return cnh2;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap chuyen nganh hoc (1 or 2): ");
            cnh = int.Parse(Console.ReadLine());

        }

        public override void xuat()
        {
            base.xuat();
            Console.Write("{0,-10}", ktra());
        }

    }
}
