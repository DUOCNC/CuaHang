using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string query = "SELECT * FROM SanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = row["MaSP"].ToString(),
                    TenSP = row["TenSP"].ToString(),
                    DonVi = row["DonVi"].ToString(),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    TonKho = Convert.ToInt32(row["TonKho"])
                };
                list.Add(sp);
            }

            return list;
        }

        public bool Insert(SanPhamDTO sp)
        {
            string query = @"INSERT INTO SanPham (MaSP, TenSP, DonVi, GiaBan, GiaNhap, TonKho)
                             VALUES (@MaSP, @TenSP, @DonVi, @GiaBan, @GiaNhap, @TonKho)";
            object[] parameters = {
                sp.MaSP, sp.TenSP, sp.DonVi, sp.GiaBan, sp.GiaNhap, sp.TonKho
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(SanPhamDTO sp)
        {
            string query = @"UPDATE SanPham SET 
                             TenSP = @TenSP,
                             DonVi = @DonVi,
                             GiaBan = @GiaBan,
                             GiaNhap = @GiaNhap,
                             TonKho = @TonKho
                             WHERE MaSP = @MaSP";
            object[] parameters = {
                sp.TenSP, sp.DonVi, sp.GiaBan, sp.GiaNhap, sp.TonKho, sp.MaSP
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(string maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            object[] parameters = { maSP };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
