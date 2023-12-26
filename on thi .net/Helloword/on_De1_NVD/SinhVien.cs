using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_De1_NVD
{
    class SinhVien
    {
        public string maSV {  get; set; }
        public string hoTen {  get; set; }
        public int solanXS {  get; set; }
        public string khoa {  get; set; }
        public string gTinh {  get; set; }

        public SinhVien() { }
        public SinhVien(string maSV, string hoTen, int solanXS, string khoa, string gTinh)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.solanXS = solanXS;
            this.khoa = khoa;
            this.gTinh = gTinh;
        }

        public double TienThuong
        {
            get
            {
                if (solanXS >= 5)
                {
                    return 500;
                }
                else if (solanXS > 1 && solanXS < 5)
                {
                    return 200;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
