using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class PhieuXuat
    {
        private string id;
        private DateTime? DateXuat;

        public string Id { get => id; set => id = value; }
        public DateTime? DateXuat1 { get => DateXuat; set => DateXuat = value; }

        public PhieuXuat(int id, DateTime? DateXuat)
        {
            this.id = id.ToString();
            this.DateXuat = DateXuat;
        }
        public PhieuXuat(DataRow row)
        {
            this.id = row["id"].ToString();
            this.DateXuat = (DateTime?)row["DateCreate"];
        }
    }
}
