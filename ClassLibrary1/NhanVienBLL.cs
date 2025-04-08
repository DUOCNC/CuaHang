using System;
using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class NhanVienBLL
    {
        private readonly NhanVienDAL dal = NhanVienDAL.Instance;

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetListNhanVien();
        }

        public List<NhanVienDTO> SearchByName(string hoTen)
        {
            return dal.SearchNhanVienByName(hoTen);
        }

        public NhanVienDTO GetByMaNV(string maNV)
        {
            return dal.GetNhanVienByMa(maNV);
        }

        public bool Add(NhanVienDTO nv)
        {
            //validate sdt từ 9 đến 10 ký tự
            if (nv.SDT !=null && (nv.SDT.Length > 9 || nv.SDT.Length > 10))
                return false;

            return dal.InsertNhanVien(nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi,
                                      nv.SDT, nv.Email, nv.MaCV, nv.LuongCoBan, nv.NgayVaoLam);
        }

        public bool Update(NhanVienDTO nv)
        {
            return dal.UpdateNhanVien(nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi,
                                      nv.SDT, nv.Email, nv.MaCV, nv.LuongCoBan, nv.NgayVaoLam);
        }

        public bool Delete(string maNV)
        {
            return dal.DeleteNhanVien(maNV);
        }

        public string GenerateNewMaNV()
        {
            return dal.GenerateNewMaNV();
        }
    }
}
