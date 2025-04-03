using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class ChucVuDTO
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public float HeSoLuong { get; set; }

        public ChucVuDTO() { }

        public ChucVuDTO(string maCV, string tenCV, float heSoLuong)
        {
            MaCV = maCV;
            TenCV = tenCV;
            HeSoLuong = heSoLuong;
        }
    }
}
