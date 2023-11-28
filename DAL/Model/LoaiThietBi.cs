using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LoaiThietBi
    {
        [Key]
        public string MaLoaiThietBi { get; set; } // Primary Key
        public string TenLoaiThietBi { get; set; }
        public string ChucNang { get; set; }
        public string ViTri { get; set; }

        // Navigation property
        public ICollection<ThietBi> ThietBis { get; set; }
    }
}
