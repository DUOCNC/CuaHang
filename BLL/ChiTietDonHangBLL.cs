using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class ChiTietDonHangBLL
    {
        private ChiTietDonHangDAL dal = new ChiTietDonHangDAL();

        public List<ChiTietDonHangDTO> GetByMaDH(string maDH) => dal.GetByMaDH(maDH);

        public bool Add(ChiTietDonHangDTO ct) => dal.Insert(ct);

        public bool DeleteByMaDH(string maDH) => dal.DeleteByMaDH(maDH);
    }
}
