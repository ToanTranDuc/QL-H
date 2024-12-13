using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_Quyen
    {
        public int ID_NhanVien { get; set; }
        public int ID_Quyen { get; set; }

        // Navigation properties
        public NhanVien NhanVien { get; set; }
        public Quyen Quyen { get; set; }
    }
}
