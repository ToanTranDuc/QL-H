using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL TK = new TaiKhoanDAL();
        public TaiKhoan CheckLogin(string usename, string pass)
        {
            return TK.CheckLogin(usename, pass);
        }

        public List<NhanVien_Quyen> GetUserPermissions(int idNhanVien)
        {
            return TK.GetUserPermissions(idNhanVien);
        }

        public int InsertAccount(TaiKhoan taiKhoan)
        {
            return TK.InsertAccount(taiKhoan);
        }
        public bool CheckAccountExists(string username)
        {
            return TK.CheckAccountExists(username);
        }
        public List<TaiKhoan> GetAllAccounts()
        {
            return TK.GetAllAccounts();
        }
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            return TK.UpdateTaiKhoan(taiKhoan);
        }
    }
}
