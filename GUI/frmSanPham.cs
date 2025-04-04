using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmSanPham : Form
    {
        private readonly SanPhamBLL nvBLL = new SanPhamBLL();

        public frmSanPham()
        {
            InitializeComponent();
            LoadSanPham();
        }


        private void LoadSanPham()
        {
            dataGridViewSanPham.DataSource = nvBLL.GetAll();
        }

        private void ClearForm()
        {

        }

        private SanPhamDTO GetFormData()
        {
            return new SanPhamDTO
            {
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = GetFormData();
            if (nvBLL.Add(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadSanPham();
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
                LoadSanPham();
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
            dataGridViewSanPham.DataSource = nvBLL.GetAll();
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
