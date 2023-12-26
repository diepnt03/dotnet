using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx11
{
    class nhanvien : tinhluong
    {
        public string mnv { get; set; }
        private string chucvu { get; set; }



        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ma nhan vien: ");
            mnv = Console.ReadLine();
            Console.Write("Nhap chuc vu nhan vien: ");
            chucvu = Console.ReadLine();
        }

        public override void xuat()
        {
            base.xuat();
            Console.Write("{0,-15}{1,-15}", mnv, chucvu);
        }

        public void nhapds(List<nhanvien> dsnv, ref int n)
        {

            Console.Write("Nhap so luong nhan vien n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                nhanvien nv1 = new nhanvien();
                Console.WriteLine("Nhap nhan vien thu " + (i + 1));

                Console.WriteLine();
                nv1.nhap();
                dsnv.Add(nv1);

                Console.WriteLine();

            }
        }

        public void xuatds(List<nhanvien> dsnv)
        {
            Console.WriteLine();

            Console.WriteLine("{0,-20}{1,-20}{2,-10}{3,-10}{4,-15}{5,-15}", "Ho ten", "Dia chi", "Hsl", "Luong", "Ma nhan vien", "Chuc vu");

            foreach (var item in dsnv)
            {
                item.xuat();
                Console.WriteLine();
            }

        }

        public void sapx(List<nhanvien> dsnv)
        {

            for (int i = 0; i < dsnv.Count - 1; i++)
            {
                for (int j = i; j < dsnv.Count; j++)
                {
                    if (dsnv[i].hsl > dsnv[j].hsl)
                    {
                        nhanvien temp = dsnv[i];
                        dsnv[i] = dsnv[j];
                        dsnv[j] = temp;

                    }
                }

            }


        }


        public int maxhsl(List<nhanvien> dsnv)
        {
            int max = dsnv[0].hsl;
            for (int i = 1; i < dsnv.Count; i++)
            {
                if (dsnv[i].hsl > max)
                {
                    max = dsnv[i].hsl;

                }
            }
            return max;
        }

        //hien thi nhan vien co hsl max
        public void hienthimax(List<nhanvien> dsnv)
        {

            for (int i = 0; i < dsnv.Count; i++)
            {
                if (dsnv[i].hsl == maxhsl(dsnv))
                {
                    dsnv[i].xuat();
                    Console.WriteLine();
                }

            }

        }

        //xoa nhan vien co hsl max
        public void xoa(List<nhanvien> dsnv)
        {
            for (int i = 0; i < dsnv.Count; i++)
            {
                for (int j = 1; j < dsnv.Count; j++)
                {
                    if (dsnv[i].hsl == maxhsl(dsnv))
                    {
                        dsnv.RemoveAt(i);
                    }
                }
                
            }
        }

        //them 1 nhan vien
        public void themnv(List<nhanvien> dsnv)
        {
            nhanvien nv3 = new nhanvien();
            Console.WriteLine("Nhap thong tin nhan vien moi ");
            nv3.nhap();

            for (int i = 0; i < dsnv.Count; i++)
            {
                if (dsnv[0].hsl > nv3.hsl)
                {
                    dsnv.Insert(0, nv3);
                    break;
                }
                else if (dsnv[dsnv.Count - 1].hsl < nv3.hsl || dsnv[dsnv.Count - 1].hsl == nv3.hsl)
                {
                    dsnv.Insert(dsnv.Count, nv3);
                    break;
                }
                else if (dsnv[i].hsl > nv3.hsl)
                {
                    dsnv.Insert(i, nv3);
                    break;
                }
                


            }
        }
    }
}
