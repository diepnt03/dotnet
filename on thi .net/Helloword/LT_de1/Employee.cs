using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_de1
{
    internal class Employee
    {
        public string HoTen {  get; set; }
        public bool IsGT {  get; set; }
        public int soNgCong {  get; set; }
        public double luong { get; set; }

        public Employee()
        {
        }
        public Employee(string hoTen, bool isGT, int soNgCong, double luong)
        {
            HoTen = hoTen;
            IsGT = isGT;
            this.soNgCong = soNgCong;
            this.luong = luong;
        }

        public override string ToString()
        {
            return HoTen + " - " + (IsGT ? "Nam" : "Nữ") + " - " + soNgCong + " - " + luong + " - " + Thuong;
        }

        public double Thuong
        {
            get
            {
                if (soNgCong >= 27)
                {
                    return (luong * 10) / 100;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
