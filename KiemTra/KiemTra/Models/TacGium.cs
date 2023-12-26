using System;
using System.Collections.Generic;

#nullable disable

namespace KiemTra.Models
{
    public partial class TacGium
    {
        public TacGium()
        {
            Saches = new HashSet<Sach>();
        }

        public string MaTg { get; set; }
        public string TenTacGia { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
