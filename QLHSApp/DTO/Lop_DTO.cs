using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        private string maLop;
        private string tenLop;
        private string maGV;
        private string namHoc;

        public Lop_DTO() { }

        public Lop_DTO(string maLop, string tenLop, string maGV, string namHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maGV = maGV;
            this.namHoc = namHoc;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
    }
}
