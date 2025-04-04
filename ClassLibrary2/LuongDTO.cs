using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class LuongDTO
    {
        public string MaLuong { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public float HeSoLuong { get; set; }
        public decimal LuongCoBan { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal TongLuong { get; set; }

        public LuongDTO() { }

        public LuongDTO(string maLuong, string maNV, string tenNV, string maCV, string tenCV,
            float heSoLuong, decimal luongCoBan, int thang, int nam, decimal tongLuong)
        {
            MaLuong = maLuong;
            MaNV = maNV;
            TenNV = tenNV;
            MaCV = maCV;
            TenCV = tenCV;
            HeSoLuong = heSoLuong;
            LuongCoBan = luongCoBan;
            Thang = thang;
            Nam = nam;
            TongLuong = tongLuong;
        }
    }
}
