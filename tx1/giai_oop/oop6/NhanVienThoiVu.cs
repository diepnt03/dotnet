using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class NhanVienThoiVu : NhanVien
    {
        private int soNgayLamViec;
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set { soNgayLamViec = value; }
        }

        public NhanVienThoiVu() : base()
        {
        }
        public NhanVienThoiVu(string hoTen, bool gioiTinh, DateTime ngayTuyenDung, int soNgay)
            : base(hoTen, gioiTinh, ngayTuyenDung)
        {
            this.SoNgayLamViec = soNgay;
        }

        public int TinhTienLuong()
        {
            if (soNgayLamViec > 10)
            {
                return 2000000 + (soNgayLamViec - 10) * 400000;
            }
            else
            {
                return soNgayLamViec * 200000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{SoNgayLamViec,20}{TinhTienLuong(),20}";
        }
    }
}