using System;
using System.Collections.Generic;
using QLCuaHang.DAL;
using QLCuaHang.DTO;

namespace QLCuaHang.BLL
{
    public class DonHangBLL
    {
        private readonly DonHangDAL dal = DonHangDAL.Instance;

        // Lấy tất cả đơn hàng
        public List<DonHangDTO> GetAll()
        {
            return dal.GetListDonHang();
        }

        // Lấy đơn hàng theo mã
        public DonHangDTO GetByMaDH(string maDH)
        {
            return dal.GetDonHangByMa(maDH);
        }

        // Thêm đơn hàng mới
        public bool Add(DonHangDTO dh)
        {
            // Thêm đơn hàng chính
            bool isSuccess = dal.InsertDonHang(dh.MaDH, dh.NgayDH, dh.MaKH, dh.MaNV, dh.TongTien);

            if (!isSuccess) return false;

            // Thêm từng dòng chi tiết
            foreach (var ct in dh.DSChiTiet)
            {
                bool result = dal.InsertChiTietDonHang(ct.MaDH, ct.MaSP, ct.SoLuong, ct.DonGia, ct.ThanhTien);
                if (!result) return false;
            }

            return true;
        }

        // Xoá đơn hàng và chi tiết
        public bool Delete(string maDH)
        {
            return dal.DeleteDonHang(maDH);
        }

        // Sinh mã tự động
        public string GenerateNewMaDH()
        {
            return dal.GenerateNewMaDH();
        }
    }
}
