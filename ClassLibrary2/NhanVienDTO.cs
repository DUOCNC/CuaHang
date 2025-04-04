using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHang.DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public decimal LuongCoBan { get; set; }
        public DateTime NgayVaoLam { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sDT, string email, string maCV, string tenCV, decimal luongCoBan, DateTime ngayVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
            MaCV = maCV;
            TenCV = tenCV;
            LuongCoBan = luongCoBan;
            NgayVaoLam = ngayVaoLam;
        }
    }
}
