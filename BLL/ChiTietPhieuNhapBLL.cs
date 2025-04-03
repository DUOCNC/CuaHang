using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class ChiTietPhieuNhapBLL
    {
        private ChiTietPhieuNhapDAL dal = new ChiTietPhieuNhapDAL();

        public List<ChiTietPhieuNhapDTO> GetByMaPN(string maPN) => dal.GetByMaPN(maPN);

        public bool Add(ChiTietPhieuNhapDTO ct) => dal.Insert(ct);

        public bool DeleteByMaPN(string maPN) => dal.DeleteByMaPN(maPN);
    }
}
