using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GUI.DTO;

namespace GUI.DAO
{
    public class NCCDAO
    {
        private static NCCDAO instance;
        public static NCCDAO Instance
        {
            get { if (instance == null) instance = new NCCDAO(); return instance; }
            set { instance = value; }
        }
        private NCCDAO() { }
        public List<NCC> GetNCC()
        {
            List<NCC> NCCList = new List<NCC>();
            string query = "Select * from NCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow ncc in data.Rows)
            {
                NCC N = new NCC(ncc);
                NCCList.Add(N);
            }
            return NCCList;
        }
        public NCC GetNCCByID(int id)
        {
            List<NCC> NCCList = new List<NCC>();
            string query = "Select * from NCC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow NCC in data.Rows)
            {
                NCC ncc = new NCC(NCC);
                return ncc;
            }
            return null;

        }
    }
    
}
