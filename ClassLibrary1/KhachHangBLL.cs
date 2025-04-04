using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class KhachHangBLL
    {
        private readonly KhachHangDAL dal = KhachHangDAL.Instance;

        // Lấy toàn bộ khách hàng
        public List<KhachHangDTO> GetAll()
        {
            return dal.GetListKhachHang();
        }

        // Tìm kiếm theo tên
        public List<KhachHangDTO> SearchByName(string tenKH)
        {
            return dal.SearchKhachHangByName(tenKH);
        }

        // Lấy chi tiết khách theo mã
        public KhachHangDTO GetByMaKH(string maKH)
        {
            return dal.GetKhachHangByMa(maKH);
        }

        // Thêm mới khách hàng
        public bool Add(KhachHangDTO kh)
        {
            return dal.InsertKhachHang(kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email);
        }

        // Cập nhật thông tin khách hàng
        public bool Update(KhachHangDTO kh)
        {
            return dal.UpdateKhachHang(kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, kh.Email);
        }

        // Xoá khách hàng
        public bool Delete(string maKH)
        {
            return dal.DeleteKhachHang(maKH);
        }

        // Sinh mã khách hàng mới
        public string GenerateNewMaKH()
        {
            return dal.GenerateNewMaKH();
        }
    }
}
