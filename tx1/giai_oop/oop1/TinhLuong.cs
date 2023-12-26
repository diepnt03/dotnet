using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class TinhLuong
    {
        private string hoTen;
        private string diaChi;
        private float heSoLuong;
        private static int luongCoBan { get; set; } = 1000000;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public float HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }

        public static int LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public TinhLuong()
        {
        }

        public TinhLuong(string hoTen, string diaChi, float heSoLuong)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.heSoLuong = heSoLuong;
        }

        public virtual float GetLuong()
        {
            return heSoLuong * luongCoBan;
        }
    }
}