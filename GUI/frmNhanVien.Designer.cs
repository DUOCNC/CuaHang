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
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNhanVien.Location = new Point(25, 188);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.RowHeadersWidth = 51;
            dataGridViewNhanVien.Size = new Size(896, 242);
            dataGridViewNhanVien.TabIndex = 0;
            dataGridViewNhanVien.CellContentClick += dataGridViewNhanVien_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(765, 132);
            btnTimKiem.Margin = new Padding(4, 6, 4, 6);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(86, 36);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(25, 132);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(724, 50);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.TextChanged += materialTextBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(26, 17);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += materialButton1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(134, 15);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(64, 36);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += materialButton1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(251, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 593);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
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
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private Button btnDelete;
    }
}