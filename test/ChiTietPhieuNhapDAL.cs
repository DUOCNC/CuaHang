using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class ChiTietPhieuNhapDAL
    {
        // Lấy danh sách chi tiết theo mã phiếu nhập
        public List<ChiTietPhieuNhapDTO> GetByMaPN(string maPN)
        {
            List<ChiTietPhieuNhapDTO> list = new List<ChiTietPhieuNhapDTO>();

            string query = @"SELECT ctpn.MaPN, ctpn.MaSP, sp.TenSP, ctpn.SoLuong, ctpn.GiaNhap,
	                            (ctpn.SoLuong * ctpn.GiaNhap) AS ThanhTien
                             FROM ChiTietPhieuNhap ctpn
                             JOIN SanPham sp ON ctpn.MaSP = sp.MaSP
                             WHERE ctpn.MaPN = @MaPN";

            object[] parameters = { maPN };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                var ct = new ChiTietPhieuNhapDTO
                {
                    MaPN = row["MaPN"].ToString(),
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    ThanhTien = Convert.ToDecimal(row["ThanhTien"])
                };

                list.Add(ct);
            }

            return list;
        }

        // Thêm một chi tiết phiếu nhập
        public bool Insert(ChiTietPhieuNhapDTO ct)
        {
            string query = @"INSERT INTO ChiTietPhieuNhap (MaPN, MaSP, SoLuong, GiaNhap)
                             VALUES (@MaPN, @MaSP, @SoLuong, @GiaNhap)";

            object[] parameters = {
                ct.MaPN, ct.MaSP, ct.SoLuong, ct.GiaNhap
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa chi tiết theo mã phiếu nhập (dùng khi xóa phiếu nhập)
        public bool DeleteByMaPN(string maPN)
        {
            string query = "DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
            object[] parameters = { maPN };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
