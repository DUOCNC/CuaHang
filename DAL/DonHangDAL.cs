using System;
using System.Collections.Generic;
using System.Data;
using QLCuaHang.DTO;

namespace QLCuaHang.DAL
{
    public class DonHangDAL
    {
        private static DonHangDAL instance;

        public static DonHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonHangDAL();
                return instance;
            }
            private set => instance = value;
        }

        private DonHangDAL() { }

        public List<DonHangDTO> GetListDonHang()
        {
            List<DonHangDTO> list = new List<DonHangDTO>();

            string query = "SELECT dh.*, kh.TenKH, nv.HoTen AS TenNV " +
                          "FROM DonHang dh " +
                          "JOIN KhachHang kh ON dh.MaKH = kh.MaKH " +
                          "JOIN NhanVien nv ON dh.MaNV = nv.MaNV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DonHangDTO dh = new DonHangDTO(
                    row["MaDH"].ToString(),
                    DateTime.Parse(row["NgayDH"].ToString()),
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    row["MaNV"].ToString(),
                    row["TenNV"].ToString(),
                    decimal.Parse(row["TongTien"].ToString())
                );

                // Lấy chi tiết đơn hàng
                dh.DSChiTiet = GetChiTietDonHangByMaDH(dh.MaDH);

                list.Add(dh);
            }

            return list;
        }

        public List<ChiTietDonHangDTO> GetChiTietDonHangByMaDH(string maDH)
        {
            List<ChiTietDonHangDTO> list = new List<ChiTietDonHangDTO>();

            string query = "SELECT ct.*, sp.TenSP " +
                          "FROM ChiTietDonHang ct " +
                          "JOIN SanPham sp ON ct.MaSP = sp.MaSP " +
                          "WHERE ct.MaDH = @MaDH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maDH });

            foreach (DataRow row in data.Rows)
            {
                ChiTietDonHangDTO ct = new ChiTietDonHangDTO(
                    row["MaDH"].ToString(),
                    row["MaSP"].ToString(),
                    row["TenSP"].ToString(),
                    int.Parse(row["SoLuong"].ToString()),
                    decimal.Parse(row["DonGia"].ToString()),
                    decimal.Parse(row["ThanhTien"].ToString())
                );
                list.Add(ct);
            }

            return list;
        }

        public DonHangDTO GetDonHangByMa(string maDH)
        {
            string query = "SELECT dh.*, kh.TenKH, nv.HoTen AS TenNV " +
                          "FROM DonHang dh " +
                          "JOIN KhachHang kh ON dh.MaKH = kh.MaKH " +
                          "JOIN NhanVien nv ON dh.MaNV = nv.MaNV " +
                          "WHERE dh.MaDH = @MaDH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maDH });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                DonHangDTO dh = new DonHangDTO(
                    row["MaDH"].ToString(),
                    DateTime.Parse(row["NgayDH"].ToString()),
                    row["MaKH"].ToString(),
                    row["TenKH"].ToString(),
                    row["MaNV"].ToString(),
                    row["TenNV"].ToString(),
                    decimal.Parse(row["TongTien"].ToString())
                );

                // Lấy chi tiết đơn hàng
                dh.DSChiTiet = GetChiTietDonHangByMaDH(dh.MaDH);

                return dh;
            }

            return null;
        }

        public bool InsertDonHang(string maDH, DateTime ngayDH, string maKH, string maNV, decimal tongTien)
        {
            string query = "INSERT INTO DonHang(MaDH, NgayDH, MaKH, MaNV, TongTien) VALUES ( @MaDH , @NgayDH , @MaKH , @MaNV , @TongTien )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDH, ngayDH, maKH, maNV, tongTien });
            return result > 0;
        }

        public bool InsertChiTietDonHang(string maDH, string maSP, int soLuong, decimal donGia, decimal thanhTien)
        {
            string query = "INSERT INTO ChiTietDonHang VALUES ( @MaDH , @MaSP , @SoLuong , @DonGia , @ThanhTien )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDH, maSP, soLuong, donGia, thanhTien });
            return result > 0;
        }

        public bool DeleteDonHang(string maDH)
        {
            // Xóa chi tiết đơn hàng trước
            string deleteChiTietQuery = "DELETE FROM ChiTietDonHang WHERE MaDH = @MaDH";
            DataProvider.Instance.ExecuteNonQuery(deleteChiTietQuery, new object[] { maDH });

            // Sau đó xóa đơn hàng
            string deleteDonHangQuery = "DELETE FROM DonHang WHERE MaDH = @MaDH";
            int result = DataProvider.Instance.ExecuteNonQuery(deleteDonHangQuery, new object[] { maDH });

            return result > 0;
        }

        public string GenerateNewMaDH()
        {
            string query = "SELECT TOP 1 MaDH FROM DonHang ORDER BY MaDH DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string lastMaDH = data.Rows[0]["MaDH"].ToString();
                int number = int.Parse(lastMaDH.Substring(2));
                return "DH" + (number + 1).ToString("D3");
            }

            return "DH001";
        }
    }
}