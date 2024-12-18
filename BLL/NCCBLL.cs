using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class NCCBLL
    {
        private NCCDAL nCC = new NCCDAL();
        public List<NCC> GetListNCC()
        {
            return nCC.GetListNCC();
        }
        public List<SanPham> GetProductsBySupplier(int maNCC)
        {
            return nCC.GetProductsBySupplier(maNCC);
        }
    }
    
}
