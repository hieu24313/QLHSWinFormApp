using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon_DTO
    {
        private string maMon;
        private string tenMon;

        public Mon_DTO() { }

        public Mon_DTO(string maMon, string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
    }
}
