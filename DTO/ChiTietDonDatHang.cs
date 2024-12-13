using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonDatHang
    {
        public int ID_ChiTiet { get; set; }
        public int ID_DonDatHang { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public float GiaNhap { get; set; }
        public float ThanhTien => SoLuong * GiaNhap; // Tính tổng tiền
    }
}

