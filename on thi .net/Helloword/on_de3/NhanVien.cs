using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_de3
{
    internal class NhanVien
    {
        public string hoTen {  get; set; }
        public string loaNV {  get; set; }
        public DateTime ngSinh { get; set; }
        public double soTien {  get; set; }
        public double hoaHong
        {
            get
            {
                if (soTien < 1000) return 0;
                else if (soTien >= 1000 && soTien <= 5000) return soTien * 10 / 1000;
                else return soTien * 20 / 100;
            }
        }
        public int Tuoi
        {
            get
            {
                return DateTime.Now.Year - ngSinh.Year;
            }
        }
        public NhanVien() { }
        public NhanVien(string hoTen, string loaNV, DateTime ngSinh, double soTien)
        {
            this.hoTen = hoTen;
            this.loaNV = loaNV;
            this.ngSinh = ngSinh;
            this.soTien = soTien;
        }
        public override string ToString()
        {
            return hoTen + " - " + ngSinh + " - " + loaNV + " - Tiền bán hàng: " + soTien + " - Hoa hồng: " + hoaHong;
        }
    }
}
