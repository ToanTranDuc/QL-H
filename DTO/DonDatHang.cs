using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHang
    {
        public int ID_DonDatHang { get; set; }
        public DateTime NgayDat { get; set; }
        public int MaNCC { get; set; }
        public int MaSP { get; set; }
        public int SoLuong {  get; set; }
        public string TenNCC { get; set; }
        public float TongGia { get; set; }
        public string TrangThai { get; set; }
        public SanPham SanPham { get; set; }
    }
}
