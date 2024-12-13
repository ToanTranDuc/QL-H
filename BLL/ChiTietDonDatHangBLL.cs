using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDonDatHangBLL
    {
        private ChiTietDonDatHangDAL ct = new ChiTietDonDatHangDAL();
        public List<ChiTietDonDatHang> GetChiTietDonDatHang(int idDonDatHang)
        {
            return ct.GetChiTietDonDatHang(idDonDatHang);
        }
    }
}
