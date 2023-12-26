using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace deMau
{
    internal class NhanVien : Person
    {
        private string maNV;
        private string chucVu;
        private float luongCB;

        public string MaNV
        {
            get { return maNV; }
        }

        public string ChucVu
        {
            get { return chucVu; }
        }

        public float LuongCB
        {
            get { return luongCB; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập mã nhân viên: ");
            maNV = Console.ReadLine();
            Console.Write("Nhập chức vụ(Giám đốc/Trưởng phòng/Phó giám đốc/Phó phòng): ");
            chucVu = Console.ReadLine();
            Console.Write("Nhập lương cơ bản: ");
            luongCB = float.Parse(Console.ReadLine());
        }

        public int heSoChucVu()
        {
            if (chucVu == "Giám đốc") return 10;
            else if (chucVu == "Trưởng phòng" || chucVu == "Phó giám đốc") return 6;
            else if (chucVu == "Phó phòng") return 4;
            else return 2;
        }
    }
}























