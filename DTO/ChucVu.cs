using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        public int ID_ChucVu { get; set; }
        public string Ma_ChucVu { get; set; }
        public string Ten_ChucVu { get; set; }
        public string Ghi_Chu { get; set; }
        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
