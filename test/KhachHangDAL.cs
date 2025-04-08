using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class KhachHangDAL
    {
        private static KhachHangDAL instance;

        public static KhachHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAL();
                return instance;
            }
            private set => instance = value;
        }

        private KhachHangDAL() { }

        public List<KhachHangDTO> GetListKhachHang()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();

            string query = "SELECT * FROM dbo.KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    row["SDT"].ToString(),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString()
                );
                list.Add(kh);
            }

            return list;
        }

        public List<KhachHangDTO> SearchKhachHangByName(string name)
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();

            string query = "SELECT * FROM KhachHang WHERE TenKH LIKE N'%' + @TenKH + '%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    row["SDT"].ToString(),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString()
                );
                list.Add(kh);
            }

            return list;
        }

        public KhachHangDTO GetKhachHangByMa(string maKH)
        {
            string query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKH });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new KhachHangDTO(
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    row["SDT"].ToString(),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString()
                );
            }

            return null;
        }

        public bool InsertKhachHang(string maKH, string tenKH, string sdt, string diaChi, string email)
        {
            string query = "INSERT INTO KhachHang VALUES ( @MaKH , @TenKH , @SDT , @DiaChi , @Email )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH, tenKH, sdt, diaChi, email });
            return result > 0;
        }

        public bool UpdateKhachHang(string maKH, string tenKH, string sdt, string diaChi, string email)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH , SDT = @SDT , DiaChi = @DiaChi , Email = @Email WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKH, sdt, diaChi, email, maKH });
            return result > 0;
        }

        public bool DeleteKhachHang(string maKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH });
            return result > 0;
        }

        public string GenerateNewMaKH()
        {
            string query = "SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string lastMaKH = data.Rows[0]["MaKH"].ToString();
                int number = int.Parse(lastMaKH.Substring(2));
                return "KH" + (number + 1).ToString("D3");
            }

            return "KH001";
        }
    }
}