using System;
using System.Collections.Generic;

#nullable disable

namespace KiemTra.Models
{
    public partial class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int? NamXuatBan { get; set; }
        public int? SoTrang { get; set; }
        public string MaTg { get; set; }

        public virtual TacGium MaTgNavigation { get; set; }
    }
}
