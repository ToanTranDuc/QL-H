using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Quản_lý_đồng_hồ.DTO;
using System.Collections;

namespace Quản_lý_đồng_hồ.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            set { instance = value; }
        }
        private SanPhamDAO() { }

        public List<SanPham> GetSanPhamByNCCID(int id)
        {
            List<SanPham> SPList = new List<SanPham>();
            string query = "SELECT * FROM SanPham Where MaNCC = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow SP in data.Rows)
            {
                SanPham S = new SanPham(SP);
                SPList.Add(S);
            }
            return SPList;


        }
        public SanPham GetSanPham(int id)
        {
            string query = "SELECT * FROM SanPham where MaSP =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow SP in data.Rows)
            {
                SanPham S = new SanPham(SP);
                return S;
            }
            return null;
            
           
        }
    }
}
