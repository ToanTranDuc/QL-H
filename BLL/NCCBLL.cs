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
        private NCCDAL ncc = new NCCDAL();
        public List<NCC> GetListNCC()
        {
            return ncc.GetListNCC();
        }
    }
}
