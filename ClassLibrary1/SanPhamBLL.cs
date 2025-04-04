using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public List<SanPhamDTO> GetAll() => dal.GetAll();

        public bool Add(SanPhamDTO sp) => dal.Insert(sp);

        public bool Update(SanPhamDTO sp) => dal.Update(sp);

        public bool Delete(string maSP) => dal.Delete(maSP);
    }
}
