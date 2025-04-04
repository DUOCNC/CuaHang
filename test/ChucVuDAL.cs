using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class ChucVuDAL
    {
        private static ChucVuDAL instance;

        public static ChucVuDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChucVuDAL();
                return instance;
            }
            private set => instance = value;
        }

        private ChucVuDAL() { }

        public List<ChucVuDTO> GetListChucVu()
        {
            List<ChucVuDTO> list = new List<ChucVuDTO>();

            string query = "SELECT * FROM ChucVu";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ChucVuDTO cv = new ChucVuDTO(
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    float.Parse(row["HeSoLuong"].ToString())
                );
                list.Add(cv);
            }

            return list;
        }

        public ChucVuDTO GetChucVuByMa(string maCV)
        {
            string query = "SELECT * FROM ChucVu WHERE MaCV = @MaCV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCV });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new ChucVuDTO(
                    row["MaCV"].ToString(),
                    row["TenCV"].ToString(),
                    float.Parse(row["HeSoLuong"].ToString())
                );
            }

            return null;
        }

        public bool InsertChucVu(string maCV, string tenCV, float heSoLuong)
        {
            string query = "INSERT INTO ChucVu VALUES ( @MaCV , @TenCV , @HeSoLuong )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCV, tenCV, heSoLuong });
            return result > 0;
        }

        public bool UpdateChucVu(string maCV, string tenCV, float heSoLuong)
        {
            string query = "UPDATE ChucVu SET TenCV = @TenCV , HeSoLuong = @HeSoLuong WHERE MaCV = @MaCV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenCV, heSoLuong, maCV });
            return result > 0;
        }

        public bool DeleteChucVu(string maCV)
        {
            string query = "DELETE FROM ChucVu WHERE MaCV = @MaCV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCV });
            return result > 0;
        }

        public string GenerateNewMaCV()
        {
            string query = "SELECT TOP 1 MaCV FROM ChucVu ORDER BY MaCV DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string lastMaCV = data.Rows[0]["MaCV"].ToString();
                int number = int.Parse(lastMaCV.Substring(2));
                return "CV" + (number + 1).ToString("D3");
            }

            return "CV001";
        }
    }
}