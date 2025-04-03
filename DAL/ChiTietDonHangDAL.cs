using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class ChiTietDonHangDAL
    {
        // Lấy danh sách chi tiết theo mã đơn hàng
        public List<ChiTietDonHangDTO> GetByMaDH(string maDH)
        {
            List<ChiTietDonHangDTO> list = new List<ChiTietDonHangDTO>();

            string query = @"
                SELECT ctdh.MaDH, ctdh.MaSP, sp.TenSP, ctdh.SoLuong, ctdh.DonGia,
                       (ctdh.SoLuong * ctdh.DonGia) AS ThanhTien
                FROM ChiTietDonHang ctdh
                JOIN SanPham sp ON ctdh.MaSP = sp.MaSP
                WHERE ctdh.MaDH = @MaDH";

            object[] parameters = { maDH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                var ct = new ChiTietDonHangDTO
                {
                    MaDH = row["MaDH"].ToString(),
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    DonGia = Convert.ToDecimal(row["DonGia"]),
                    ThanhTien = Convert.ToDecimal(row["ThanhTien"])
                };

                list.Add(ct);
            }

            return list;
        }

        // Thêm mới một dòng chi tiết đơn hàng
        public bool Insert(ChiTietDonHangDTO ct)
        {
            string query = @"
                INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong, DonGia)
                VALUES (@MaDH, @MaSP, @SoLuong, @DonGia)";

            object[] parameters = {
                ct.MaDH, ct.MaSP, ct.SoLuong, ct.DonGia
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa tất cả chi tiết theo mã đơn hàng (nếu cần)
        public bool DeleteByMaDH(string maDH)
        {
            string query = "DELETE FROM ChiTietDonHang WHERE MaDH = @MaDH";
            object[] parameters = { maDH };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
