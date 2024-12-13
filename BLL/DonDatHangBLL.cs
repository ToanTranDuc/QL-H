using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonDatHangBLL
    {
        private DonDatHangDAL donDatHangDAL = new DonDatHangDAL();

        public List<DonDatHang> GetListDonDatHang()
        {
            return donDatHangDAL.GetListDonDatHang();
        }
    }
}
