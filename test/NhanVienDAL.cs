using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return instance;
            }
            private set => instance = value;
        }

        private NhanVienDAL() { }

        public List<NhanVienDTO> GetListNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            string query = "SELECT nv.*, cv.TenCV FROM NhanVien nv JOIN ChucVu cv ON nv.MaCV = cv.MaCV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(
                    row["MaNV"].ToString(),
                    row["HoTen"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["GioiTinh"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SDT"].ToString(),
                    row["Email"].ToString(),
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    decimal.Parse(row["LuongCoBan"].ToString()),
                    DateTime.Parse(row["NgayVaoLam"].ToString())
                );
                list.Add(nv);
            }

            return list;
        }

        /// <summary>
        /// Tìm kiếm nhân viên theo tên
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<NhanVienDTO> SearchNhanVienByName(string name)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            string truyvan = "SELECT nv.*, cv.TenCV FROM NhanVien nv JOIN ChucVu cv ON nv.MaCV = cv.MaCV WHERE nv.HoTen LIKE N'%' + @HoTen + '%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(truyvan, new object[] { name });

            foreach (DataRow row in data.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(
                    row["MaNV"].ToString(),
                    row["HoTen"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["GioiTinh"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SDT"].ToString(),
                    row["Email"].ToString(),
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    decimal.Parse(row["LuongCoBan"].ToString()),
                    DateTime.Parse(row["NgayVaoLam"].ToString())
                );

                list.Add(nv);
            }

            return list;
        }

        /// <summary>
        /// Lấy thông tin nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public NhanVienDTO GetNhanVienByMa(string maNV)
        {
            string query = "SELECT nv.*, cv.TenCV FROM NhanVien nv JOIN ChucVu cv ON nv.MaCV = cv.MaCV WHERE nv.MaNV = @MaNV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new NhanVienDTO(
                    row["MaNV"].ToString(),
                    row["HoTen"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["GioiTinh"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SDT"].ToString(),
                    row["Email"].ToString(),
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    decimal.Parse(row["LuongCoBan"].ToString()),
                    DateTime.Parse(row["NgayVaoLam"].ToString())
                );
            }

            return null;
        }

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="sdt"></param>
        /// <param name="email"></param>
        /// <param name="maCV"></param>
        /// <param name="luongCoBan"></param>
        /// <param name="ngayVaoLam"></param>
        /// <returns></returns>
        public bool InsertNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sdt, string email, string maCV, decimal luongCoBan, DateTime ngayVaoLam)
        {
            string query = "INSERT INTO NhanVien VALUES ( @MaNV , @HoTen , @NgaySinh , @GioiTinh , @DiaChi , @SDT , @Email , @MaCV , @LuongCoBan , @NgayVaoLam )";
            
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                maNV, hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, maCV, luongCoBan, ngayVaoLam
            });
            return result > 0;
        }

        /// <summary>
        /// Cập nhật thông tin nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="sdt"></param>
        /// <param name="email"></param>
        /// <param name="maCV"></param>
        /// <param name="luongCoBan"></param>
        /// <param name="ngayVaoLam"></param>
        /// <returns></returns>
        public bool UpdateNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string sdt, string email, string maCV, decimal luongCoBan, DateTime ngayVaoLam)
        {
            string query = "UPDATE NhanVien SET HoTen = @HoTen , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , DiaChi = @DiaChi , " +
                "SDT = @SDT , Email = @Email , MaCV = @MaCV , LuongCoBan = @LuongCoBan , NgayVaoLam = @NgayVaoLam WHERE MaNV = @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, maCV, luongCoBan, ngayVaoLam, maNV
            });
            return result > 0;
        }

        /// <summary>
        /// Xóa nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public bool DeleteNhanVien(string maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV });
            return result > 0;
        }

        /// <summary>
        /// Tạo mã nhân viên mới tự động tăng
        /// </summary>
        public string GenerateNewMaNV()
        {
            string query = "SELECT TOP 1 MaNV FROM NhanVien ORDER BY MaNV DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string lastMaNV = data.Rows[0]["MaNV"].ToString();
                int number = int.Parse(lastMaNV.Substring(2));
                return "NV" + (number + 1).ToString("D3");
            }

            return "NV001";
        }
    }
}