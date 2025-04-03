using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class DonHangDTO
    {
        public string MaDH { get; set; }
        public DateTime NgayDH { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietDonHangDTO> DSChiTiet { get; set; }

        public DonHangDTO()
        {
            DSChiTiet = new List<ChiTietDonHangDTO>();
        }

        public DonHangDTO(string maDH, DateTime ngayDH, string maKH, string tenKH, string maNV, string tenNV, decimal tongTien)
        {
            MaDH = maDH;
            NgayDH = ngayDH;
            MaKH = maKH;
            TenKH = tenKH;
            MaNV = maNV;
            TenNV = tenNV;
            TongTien = tongTien;
            DSChiTiet = new List<ChiTietDonHangDTO>();
        }
    }
}
