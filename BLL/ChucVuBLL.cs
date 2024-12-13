using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ChucVuBLL
    {
        private ChucVuDAL cv = new ChucVuDAL();
        public List<ChucVu> GetAllChucVu()
        {
            return cv.GetAllChucVu();
        }
        public bool InsertChucVu( ChucVu chucVu)
        {
            return cv.InsertChucVu(chucVu);
        }
        public bool UpdateChucVu(ChucVu chucVu)
        {
            return cv.UpdateChucVu(chucVu);
        }
        public bool DeleteChucVu(int Id)
        {
            return cv.DeleteChucVu(Id);
        }

    }
}
