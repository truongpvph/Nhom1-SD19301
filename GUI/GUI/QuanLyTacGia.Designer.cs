namespace GUI
{
    partial class QuanLyTacGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnhienthi = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtMaTaiKhoan = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvquanlynv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(106, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 28);
            comboBox1.TabIndex = 115;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 114;
            label1.Text = "Mã Tác Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(540, 81);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 113;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(590, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo tên Tác giả ";
            txtTimKiem.Size = new Size(422, 27);
            txtTimKiem.TabIndex = 112;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(491, 29);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 111;
            label8.Text = "Tìm Kiếm ";
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(904, 210);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 110;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(787, 161);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 109;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(669, 113);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 108;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(103, 170);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(299, 27);
            txtSoDienThoai.TabIndex = 107;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(106, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(296, 27);
            txtHoTen.TabIndex = 106;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Location = new Point(106, 13);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(296, 27);
            txtMaTaiKhoan.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 170);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 104;
            label6.Text = "Quốc Tịch ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 113);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 103;
            label3.Text = "Giới Tính ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 102;
            label2.Text = "Tên Tác Giả";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(9, 261);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 309);
            dgvquanlynv.TabIndex = 101;
            // 
            // QuanLyTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnhienthi);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaTaiKhoan);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvquanlynv);
            Name = "QuanLyTacGia";
            Size = new Size(1020, 583);
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button btnhienthi;
        private TextBox txtTimKiem;
        private Label label8;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtMaTaiKhoan;
        private Label label6;
        private Label label3;
        private Label label2;
        private DataGridView dgvquanlynv;
    }
}
