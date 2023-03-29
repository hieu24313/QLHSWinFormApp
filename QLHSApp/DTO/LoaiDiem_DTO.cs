using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDiem_DTO
    {
        private string maLoaiDiem;
        private string loai;
        private float heSo;

        public LoaiDiem_DTO() { }

        public LoaiDiem_DTO(string maLoaiDiem, string loai, float heSo)
        {
            this.maLoaiDiem = maLoaiDiem;
            this.loai = loai;
            this.heSo = heSo;
        }

        public string MaLoaiDiem { get => maLoaiDiem; set => maLoaiDiem = value; }
        public string Loai { get => loai; set => loai = value; }
        public float HeSo { get => heSo; set => heSo = value; }
    }
}
