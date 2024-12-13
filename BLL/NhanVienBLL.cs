using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nv = new NhanVienDAL();
        public List<NhanVien> GetAllEmployees()
        {
            return nv.GetAllEmployees();
        }
        public bool UpdateEmployee(NhanVien nhanVien)
        {
            return nv.UpdateEmployee(nhanVien);
        }
        public int InsertEmployee(NhanVien nhanVien)
        {
            return nv.InsertEmployee(nhanVien);
        }
        public bool UpdatePermissions(int nhanVienId, List<NhanVien_Quyen> nhanVienQuyen)
        {
            return nv.UpdatePermissions(nhanVienId, nhanVienQuyen);
        }
        public NhanVien GetNhanVien(int ID)
        {
            return nv.GetNhanVien(ID);
        }
    }
}
