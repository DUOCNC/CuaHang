using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class PhieuNhapBLL
    {
        private PhieuNhapDAL dal = new PhieuNhapDAL();

        public List<PhieuNhapDTO> GetAll() => dal.GetAll();

        public bool Add(PhieuNhapDTO pn)
        {
            if (dal.Exists(pn.MaPN))
                return false;

            return dal.Insert(pn);
        }

        public bool AddChiTiet(ChiTietPhieuNhapDTO ct) => dal.InsertChiTiet(ct);

        public bool Delete(string maPN) => dal.Delete(maPN);
    }
}
