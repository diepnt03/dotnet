using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX2
{
    class NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public string phong { get; set; }
        public DateTime ngaySinh { get; set; }
        public double heSoLuong { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoTen, string gioiTinh, string phong, DateTime ngaySinh, double heSoLuong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.phong = phong;
            this.ngaySinh = ngaySinh;
            this.heSoLuong = heSoLuong;
        }

        public int tuoi
        {
            get
            {
                return DateTime.Now.Year - ngaySinh.Year;
            }
        }
    }
}