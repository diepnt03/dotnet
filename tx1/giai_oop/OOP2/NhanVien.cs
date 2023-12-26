using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class NhanVien : Nguoi
    {
        private string maNV;
        private string chucVu;
        private float luongCB;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }  
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public float LuongCB
        {
            get { return luongCB; }
            set { luongCB = value; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write($"Nhập mã nhân viên: ");
            maNV = Console.ReadLine();
            Console.Write($"Nhập chức vụ (Giám đốc/Trưởng phòng/Phó giám đốc/Phó phòng): ");
            chucVu = Console.ReadLine();
            Console.Write($"Nhập lương cơ bản: ");
            luongCB = float.Parse(Console.ReadLine());
        }

        public int tinhHeSo()
        {
            if (ChucVu == "Giám đốc")
            {
                return 10;
            }
            else if (ChucVu == "Trưởng phòng" || ChucVu == "Phó giám đốc")
            {
                return 6;
            }
            else if (ChucVu == "Phó phòng")
            {
                return 4;
            }
            else return 2;
        }

    }
}