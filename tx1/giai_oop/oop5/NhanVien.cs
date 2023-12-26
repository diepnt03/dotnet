using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    internal class NhanVien
    {
        private string hoTen;
        private DateTime ngayTuyenDung;

        public string HoTen
        {
            get { return hoTen; }
            
        }

        public DateTime NgayTuyenDung
        {
            get { return ngayTuyenDung; }
            
        }

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, DateTime ngayTuyenDung)
        {
            this.hoTen = hoTen;
            this.ngayTuyenDung = ngayTuyenDung;
        }
    }
}