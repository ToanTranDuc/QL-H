using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class NCC
    {
        private int id;
        private string NCCName;

        public int Id { get => id; set => id = value; }
        public string NCCName1 { get => NCCName; set => NCCName = value; }

        public NCC(int id,string NCCName)
        {
            this.id = id;
            this.NCCName = NCCName;
        }
        public NCC(DataRow row)
        {
            id = (int)row["MaNCC"];
            NCCName = row["TenNCC"].ToString();
        }
    }
}
