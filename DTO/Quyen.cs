using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen
    {
        public int ID_Quyen { get; set; }
        public string TenQuyen { get; set; }
        public List<NhanVien_Quyen> NhanVienQuyen { get; set; }
    }
}
