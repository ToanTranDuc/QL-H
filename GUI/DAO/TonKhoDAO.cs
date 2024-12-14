using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;

namespace GUI.DAO
{
    public class TonKhoDAO
    {
        private static TonKhoDAO instance;
        public static TonKhoDAO Instance
        {
            get { if (instance == null) instance = new TonKhoDAO(); return instance; }
            set { instance = value; }
        }
        private TonKhoDAO() { }

        public List<Tonkho> GetTonKho()
        {
            string query = "Select * from ton_kho ";
            List<Tonkho> list = TonKhoDAO.instance.GetTonKho();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows) 
                {
                    Tonkho TK = new Tonkho(row);
                    list.Add(TK);

                }
                return list;
        }
        public DataTable GetTonkho()
        {
            string query = "Select TK.MaSP , SP.TenSP , TK.SoLuong from ton_kho as TK , SanPham as SP where TK.MaSP = SP.MaSP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }
        public void UpdateTK(int MaSP, int SoLuong)
        {
            string query = "Update dbo.ton_kho Set SoLuong =" + SoLuong + " Where MaSP =" + MaSP;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
