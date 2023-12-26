using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFControl
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public int SoTC { get; set; }
        public int Diem { get; set; }
        public string XL { get; set; }

        public string xeploai(int sotc, int diem)
        {
            int tong = sotc * diem;
            if (tong <= 100) return "Pass";
            else return "Kh Pass";
        }

        public SinhVien(string maSV, string hoTen, string gioiTinh, string ngaySinh, int soTC, int diem)
        {
            MaSV = maSV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SoTC = soTC;
            Diem = diem;
            XL = xeploai(soTC,diem);
        }
    }
}
