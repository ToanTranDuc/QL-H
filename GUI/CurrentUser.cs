using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class CurrentUser
    {
        public static TaiKhoan User { get; set; }
        public static string TenChucVu { get; set; }

        public static void Clear()
        {
            User = null;
            TenChucVu = null;
        }
    }
}
