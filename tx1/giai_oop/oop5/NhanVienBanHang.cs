using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    internal class NhanVienBanHang : NhanVien
    {
        private int soLuongBan;
        public int SoLuongBan
        {
            get { return soLuongBan; }
        }

        public NhanVienBanHang() : base()
        {
        }
        public NhanVienBanHang(string hoTen, DateTime ngayTuyenDung, int soLuongBan)
            : base(hoTen, ngayTuyenDung)
        {
            this.soLuongBan = soLuongBan;
        }

        public int TinhTienHoaHong()
        {
            if (soLuongBan > 500)
            {
                return 3000;
            }
            else if (soLuongBan >= 100)
            {
                return 2000;
            }
            else
            {
                return 1000;
            }
        }
    }
}