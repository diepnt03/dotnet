using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_deNVD
{
    class SinhVien1
    {
        public string maSV {  get; set; }
        public string hoTen {  get; set; }
        public int solanXS {  get; set; }
        public string khoa {  get; set; }
         public double tienThuong
        {
            get
            {
                if (solanXS >= 5) return 500;
                else if (solanXS < 5 && solanXS > 1) return 200;
                else return 0;
            }
        }
        public SinhVien1() { }
    }
}
