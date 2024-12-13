using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_đồng_hồ.DTO
{
    public class PhieuNhap
    {
        private int MaNCC;
        private string TenNCC;
        private DateTime? DateNhap;

    
        public DateTime? DateNhap1 { get => DateNhap; set => DateNhap = value; }
        public int MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }

        public PhieuNhap(int MaNCC , DateTime? DateNhap , string TenNCC)
        { 
                this.MaNCC = MaNCC;
                this.DateNhap = DateNhap;
                this.TenNCC1 = TenNCC;
            }
        public PhieuNhap(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];
            this.DateNhap = (DateTime?)row["DateCreate"];
            this.TenNCC = row["TenNCC"].ToString();
        }
    }
}
