using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class ChiTietPhieuNhapDTO
    {
        public string MaPN { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietPhieuNhapDTO() { }

        public ChiTietPhieuNhapDTO(string maPN, string maSP, string tenSP, int soLuong, decimal giaNhap, decimal thanhTien)
        {
            MaPN = maPN;
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            ThanhTien = thanhTien;
        }
    }
}
