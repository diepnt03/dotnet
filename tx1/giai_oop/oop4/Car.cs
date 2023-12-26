using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Car : Vehicle
    {
        private string bienSoXe;
        private string dongXe;
        private string phienBan;
        private double giaCoBan;

        public Car() : base()
        {
        }

        public Car(string bienSoXe, string dongXe, string phienBan, double giaCoBan,string hangSanXuat, string mauSac) : base(hangSanXuat,  mauSac)
        {
            this.bienSoXe = bienSoXe;
            this.dongXe = dongXe;
            this.phienBan = phienBan;
            this.giaCoBan = giaCoBan;
        }

        public string BienSoXe
        {
            get { return bienSoXe; }
            set { bienSoXe = value; }
        }

        public string DongXe
        {
            get { return dongXe; }
            set { dongXe = value; }
        }

        public string PhienBan
        {
            get { return phienBan; }
            set { phienBan = value; }
        }

        public double GiaCoBan
        {
            get { return giaCoBan; }
            set { giaCoBan = value; }
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.Nhap();
            Console.Write($"Nhập biển số: ");
            bienSoXe = Console.ReadLine();
            Console.Write($"Nhập dòng xe: ");
            dongXe = Console.ReadLine();
            Console.Write($"Nhập phiên bản: ");
            phienBan = Console.ReadLine();
            Console.Write($"Nhập giá cơ bản: ");
            giaCoBan = double.Parse(Console.ReadLine());
        }

        public double TinhGiaXe()
        {
            double t = 0;
            if (phienBan == "Luxury")
            {
                t = 10000;
            }
            else if (phienBan == "Deluxe")
            {
                t = 5000;
            }
            else if (phienBan == "Premium")
            {
                t = 2000;
            }
            else if (phienBan == "Standard")
            {
                t = 0;
            }
            return giaCoBan + t;
        }
    }
}