using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        private readonly NhanVienBLL nvBLL = new NhanVienBLL();
        private readonly ChucVuBLL cvBLL = new ChucVuBLL();

        public frmNhanVien()
        {
            InitializeComponent();
            LoadChucVu();
            LoadNhanVien();
        }

        private void LoadChucVu()
        {

        }

        private void LoadNhanVien()
        {
            dataGridViewNhanVien.DataSource = nvBLL.GetAll();
        }

        private void ClearForm()
        {

        }

        private NhanVienDTO GetFormData()
        {
            return new NhanVienDTO
            {
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = GetFormData();
            if (nvBLL.Add(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadNhanVien();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = GetFormData();
            if (nvBLL.Update(nv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewNhanVien.DataSource = nvBLL.SearchByName(keyword);
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
