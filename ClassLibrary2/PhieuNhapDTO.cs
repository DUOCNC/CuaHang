using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class PhieuNhapDTO
    {
        public string MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietPhieuNhapDTO> DSChiTiet { get; set; }

        public PhieuNhapDTO()
        {
            DSChiTiet = new List<ChiTietPhieuNhapDTO>();
        }

        public PhieuNhapDTO(string maPN, DateTime ngayNhap, string maNV, string tenNV, decimal tongTien)
        {
            MaPN = maPN;
            NgayNhap = ngayNhap;
            MaNV = maNV;
            TenNV = tenNV;
            TongTien = tongTien;
            DSChiTiet = new List<ChiTietPhieuNhapDTO>();
        }
    }
}
