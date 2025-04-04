using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class PhieuNhapDAL
    {
        // Lấy tất cả phiếu nhập
        public List<PhieuNhapDTO> GetAll()
        {
            List<PhieuNhapDTO> list = new List<PhieuNhapDTO>();

            string query = @"
                SELECT pn.MaPN, pn.NgayNhap, pn.MaNV, nv.TenNV, pn.TongTien
                FROM PhieuNhap pn
                JOIN NhanVien nv ON pn.MaNV = nv.MaNV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                var pn = new PhieuNhapDTO
                {
                    MaPN = row["MaPN"].ToString(),
                    NgayNhap = Convert.ToDateTime(row["NgayNhap"]),
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    TongTien = Convert.ToDecimal(row["TongTien"]),
                    DSChiTiet = new ChiTietPhieuNhapDAL().GetByMaPN(row["MaPN"].ToString())
                };

                list.Add(pn);
            }

            return list;
        }

        // Thêm phiếu nhập
        public bool Insert(PhieuNhapDTO pn)
        {
            string query = @"INSERT INTO PhieuNhap (MaPN, NgayNhap, MaNV, TongTien)
                             VALUES (@MaPN, @NgayNhap, @MaNV, @TongTien)";

            object[] parameters = {
                pn.MaPN, pn.NgayNhap, pn.MaNV, pn.TongTien
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Thêm chi tiết phiếu nhập (gọi riêng)
        public bool InsertChiTiet(ChiTietPhieuNhapDTO ct)
        {
            string query = @"INSERT INTO ChiTietPhieuNhap (MaPN, MaSP, SoLuong, GiaNhap)
                             VALUES (@MaPN, @MaSP, @SoLuong, @GiaNhap)";

            object[] parameters = {
                ct.MaPN, ct.MaSP, ct.SoLuong, ct.GiaNhap
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xoá phiếu nhập và chi tiết liên quan
        public bool Delete(string maPN)
        {
            string query1 = "DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";
            string query2 = "DELETE FROM PhieuNhap WHERE MaPN = @MaPN";

            object[] parameters = { maPN };

            DataProvider.Instance.ExecuteNonQuery(query1, parameters);
            return DataProvider.Instance.ExecuteNonQuery(query2, parameters) > 0;
        }

        // Kiểm tra trùng mã phiếu nhập
        public bool Exists(string maPN)
        {
            string query = "SELECT COUNT(*) FROM PhieuNhap WHERE MaPN = @MaPN";
            object[] parameters = { maPN };

            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }
    }
}
