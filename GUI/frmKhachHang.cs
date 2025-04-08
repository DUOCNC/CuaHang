using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLCuaHang.BLL;
using QLCuaHang.DTO;

namespace GUI
{
    public partial class frmKhachHang : Form
    {
        private readonly KhachHangBLL KhachHangBLL = new KhachHangBLL();

        public frmKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
        }


        private void LoadKhachHang()
        {
            dataGridViewKhachHang.DataSource = KhachHangBLL.GetAll();
        }

        private void ClearForm()
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridViewKhachHang.DataSource = KhachHangBLL.GetAll();
        }

        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
