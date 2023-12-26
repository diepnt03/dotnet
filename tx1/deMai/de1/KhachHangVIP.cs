using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class KhachHangVIP : KhachHang
    {
        private string loaiKhachHang;
        private int t;

        public string LoaiKhachHang { get { return loaiKhachHang; } set { loaiKhachHang = value; } }
        public KhachHangVIP() : base()
        {
            loaiKhachHang = "";
        }

        public KhachHangVIP(string hoTen, bool gioiTinh, float soLuongMua, float donGia, string loaiKhachHang) : base(hoTen, gioiTinh, soLuongMua, donGia)
        {
            this.loaiKhachHang = loaiKhachHang;
        }

        
        public override float tongTien()
        {
            float tongTien = base.tongTien();

            if (loaiKhachHang == "VIP")
            {
                tongTien *= 0.95f;
            }
            else if (loaiKhachHang == "Vang")
            {
                tongTien *= 0.8f;
            }
            else if (loaiKhachHang == "Bac")
            {
                tongTien *= 0.9f;
            }

            return tongTien;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }



        /*public override void nhap()
        {
            base.nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            base.nhap();
            Console.Write("Nhập loại  khách hàng: ");
            loaiKhachHang = Console.ReadLine();
        }

        public override void title()
        {
            base.title();
            Console.Write($"{"Loại KH",-15}");
        }

        public override void xuat()
        {
            base.xuat();
            Console.Write($"{loaiKhachHang,-20}");
        }*/

    }

}
