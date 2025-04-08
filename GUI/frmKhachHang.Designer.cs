namespace GUI
{
    partial class frmKhachHang
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
            dataGridViewKhachHang = new DataGridView();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewKhachHang
            // 
            dataGridViewKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKhachHang.Location = new Point(39, 143);
            dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            dataGridViewKhachHang.RowHeadersWidth = 51;
            dataGridViewKhachHang.Size = new Size(700, 188);
            dataGridViewKhachHang.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(358, 76);
            btnTimKiem.Margin = new Padding(4, 6, 4, 6);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(86, 36);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(109, 62);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(231, 50);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewKhachHang);
            Name = "frmKhachHang";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewKhachHang;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
    }
}