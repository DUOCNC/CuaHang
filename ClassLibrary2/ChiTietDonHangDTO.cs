using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class ChiTietDonHangDTO
    {
        public string MaDH { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietDonHangDTO() { }

        public ChiTietDonHangDTO(string maDH, string maSP, string tenSP, int soLuong, decimal donGia, decimal thanhTien)
        {
            MaDH = maDH;
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
