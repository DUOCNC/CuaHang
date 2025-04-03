using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class LuongBLL
    {
        private LuongDAL dal = new LuongDAL();

        public List<LuongDTO> GetAll() => dal.GetAll();

        public bool Add(LuongDTO l) => dal.Insert(l);

        public bool Delete(string maLuong) => dal.Delete(maLuong);
    }
}
