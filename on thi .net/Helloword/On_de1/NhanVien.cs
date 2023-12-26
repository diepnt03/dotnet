using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_de1
{
    class NhanVien
    {
        public string maNV {  get; set; }
        public string hoTen {  get; set; }
        public DateTime ngSinh {  get; set; }
        public string gTinh { get; set; }
        public string phongBan {  get; set; }
        public double HSL {  get; set; }
        public int tuoi
        {
            get
            {
                return DateTime.Now.Year - ngSinh.Year;
            }
        }
        public NhanVien() { }
        public NhanVien(string maNV, string hoTen, DateTime ngSinh, string gTinh, string phongBan, double HSL)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngSinh = ngSinh;
            this.gTinh = gTinh;
            this.phongBan = phongBan;
            this.HSL = HSL;
        }
    }
}
