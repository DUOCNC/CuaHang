namespace GUI
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewNhanVien = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            TenNV = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            TenCV = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Columns.AddRange(new DataGridViewColumn[] { TenNV, MaNV, TenCV, SDT, DiaChi });
            dataGridViewNhanVien.Location = new Point(25, 188);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.Size = new Size(903, 242);
            dataGridViewNhanVien.TabIndex = 0;
            dataGridViewNhanVien.CellContentClick += dataGridViewNhanVien_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(834, 140);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(25, 141);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm nhân viên";
            txtTimKiem.Size = new Size(794, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // TenNV
            // 
            TenNV.HeaderText = "Họ và tên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.Width = 200;
            // 
            // MaNV
            // 
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 125;
            // 
            // TenCV
            // 
            TenCV.HeaderText = "Chức vụ";
            TenCV.MinimumWidth = 6;
            TenCV.Name = "TenCV";
            TenCV.Width = 125;
            // 
            // SDT
            // 
            SDT.HeaderText = "Điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 150;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 250;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 517);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewNhanVien);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewNhanVien;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenCV;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
    }
}