using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    internal class NhanVien : TinhLuong
    {
        private string maNV;
        private string chucVu;

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

        public NhanVien() : base()
        {
        }

        public NhanVien(string hoTen, string diaChi, float heSoLuong, string maNV, string chucVu) : base(hoTen, diaChi, heSoLuong)
        {
            this.maNV = maNV;
            this.chucVu = chucVu;
        }

        public override float GetLuong()
        {
            float pc = 0f;
            if (ChucVu == "Giám đốc")
            {
                pc = 0.5f;
            }
            else if (ChucVu == "Trưởng phòng" || ChucVu == "Phó giám đốc")
            {
                pc = 0.4f;
            }
            else if (ChucVu == "Phó phòng")
            {
                pc = 0.3f;
            }
            return (HeSoLuong + pc) * LuongCoBan;
        }
    }
}