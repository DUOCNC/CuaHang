using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class ChucVuBLL
    {
        private readonly ChucVuDAL dal = ChucVuDAL.Instance;

        // Lấy danh sách chức vụ
        public List<ChucVuDTO> GetAll()
        {
            return dal.GetListChucVu();
        }

        // Lấy theo mã
        public ChucVuDTO GetByMaCV(string maCV)
        {
            return dal.GetChucVuByMa(maCV);
        }

        // Thêm chức vụ mới
        public bool Add(ChucVuDTO cv)
        {
            return dal.InsertChucVu(cv.MaCV, cv.TenCV, cv.HeSoLuong);
        }

        // Cập nhật
        public bool Update(ChucVuDTO cv)
        {
            return dal.UpdateChucVu(cv.MaCV, cv.TenCV, cv.HeSoLuong);
        }

        // Xoá
        public bool Delete(string maCV)
        {
            return dal.DeleteChucVu(maCV);
        }

        // Sinh mã chức vụ mới
        public string GenerateNewMaCV()
        {
            return dal.GenerateNewMaCV();
        }
    }
}
