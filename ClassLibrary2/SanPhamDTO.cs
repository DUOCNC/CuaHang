using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonVi { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public int TonKho { get; set; }

        public SanPhamDTO() { }

        public SanPhamDTO(string maSP, string tenSP, string donVi, decimal giaBan, decimal giaNhap, int tonKho)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonVi = donVi;
            GiaBan = giaBan;
            GiaNhap = giaNhap;
            TonKho = tonKho;
        }
    }
}
