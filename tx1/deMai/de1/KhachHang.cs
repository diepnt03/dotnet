using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    internal class KhachHang
    {
        private string hoTen;
        private bool gioiTinh;
        private float soLuongMua;
        private float donGia;

        public KhachHang()
        {
            hoTen = "";
            gioiTinh = false;
            soLuongMua = 0;
            donGia = 0;
        }

        public KhachHang(string hoTen, bool gioiTinh, float soLuongMua, float donGia)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.soLuongMua = soLuongMua;
            this.donGia = donGia;
        }

        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public bool GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public float SoLuongMua { get { return soLuongMua; } set { soLuongMua = value; } }
        public float DonGia { get { return donGia; } set { donGia = value; } }

       
        public virtual float tongTien()
        {
            return soLuongMua * donGia;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is KhachHang hang &&
                   hoTen == hang.hoTen &&
                   gioiTinh == hang.gioiTinh &&
                   soLuongMua == hang.soLuongMua &&
                   donGia == hang.donGia &&
                   HoTen == hang.HoTen &&
                   GioiTinh == hang.GioiTinh &&
                   SoLuongMua == hang.SoLuongMua &&
                   DonGia == hang.DonGia;
        }


        /*public virtual void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            gioiTinh = bool.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng mua: ");
            soLuongMua = float.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            donGia = float.Parse(Console.ReadLine());
        }              

        public virtual void title()
        {
            Console.Write($"\n{"Họ Tên",-20}{"Giới tính",-10}{"SL mua",-10}{"Đơn giá",-15}");
        }

        public virtual void xuat()
        {
            string gt;
            if (gioiTinh == true) gt = "Nam";
            else
            {
                gt = "Nữ";
            }
            Console.Write($"\n{hoTen,-20}{gt,-10}{soLuongMua,-10}{donGia,-15}");
        }*/
    }
}

















