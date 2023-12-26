using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class NhanVien
    {
        private string hoTen;
        private bool gioiTinh;
        private DateTime ngayTuyenDung;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgayTuyenDung
        {
            get { return ngayTuyenDung; }
            set { ngayTuyenDung = value; }
        }

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, bool gioiTinh, DateTime ngayTuyenDung)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngayTuyenDung = ngayTuyenDung;
        }

        public override string ToString()
        {
            return $"\n{hoTen,20}{gioiTinh,20}{ngayTuyenDung.ToString("dd-MM-yyyy"),20}";
        }
    }
}