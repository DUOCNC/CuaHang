using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class LuongDAL
    {
        // Lấy danh sách bảng lương
        public List<LuongDTO> GetAll()
        {
            List<LuongDTO> list = new List<LuongDTO>();

            string query = @"
                SELECT l.MaLuong, l.MaNV, nv.TenNV, nv.MaCV, cv.TenCV,
                       cv.HeSoLuong, l.LuongCoBan, l.Thang, l.Nam, l.TongLuong
                FROM Luong l
                JOIN NhanVien nv ON l.MaNV = nv.MaNV
                JOIN ChucVu cv ON nv.MaCV = cv.MaCV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                var luong = new LuongDTO
                {
                    MaLuong = row["MaLuong"].ToString(),
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    TenCV = row["TenCV"].ToString(),
                    HeSoLuong = Convert.ToSingle(row["HeSoLuong"]),
                    LuongCoBan = Convert.ToDecimal(row["LuongCoBan"]),
                    Thang = Convert.ToInt32(row["Thang"]),
                    Nam = Convert.ToInt32(row["Nam"]),
                    TongLuong = Convert.ToDecimal(row["TongLuong"])
                };

                list.Add(luong);
            }

            return list;
        }

        // Thêm mới bảng lương
        public bool Insert(LuongDTO l)
        {
            string query = @"
                INSERT INTO Luong (MaLuong, MaNV, LuongCoBan, Thang, Nam, TongLuong)
                VALUES (@MaLuong, @MaNV, @LuongCoBan, @Thang, @Nam, @TongLuong)";

            object[] parameters = {
                l.MaLuong, l.MaNV, l.LuongCoBan, l.Thang, l.Nam, l.TongLuong
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa bảng lương theo mã
        public bool Delete(string maLuong)
        {
            string query = "DELETE FROM Luong WHERE MaLuong = @MaLuong";
            object[] parameters = { maLuong };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
