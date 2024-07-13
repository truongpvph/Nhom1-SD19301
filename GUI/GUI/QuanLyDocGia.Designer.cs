namespace GUI
{
    partial class QuanLyDocGia
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
            btnhienthi = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtmadocgia = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvquanlynv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            SuspendLayout();
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(515, 76);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 115;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(879, 205);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 114;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(762, 156);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 113;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(644, 108);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 112;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(618, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Độc Giả ";
            txtTimKiem.Size = new Size(395, 27);
            txtTimKiem.TabIndex = 111;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(512, 21);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 110;
            label8.Text = "Tìm Kiếm ";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(124, 143);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(315, 27);
            txtSoDienThoai.TabIndex = 109;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 82);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(315, 27);
            txtHoTen.TabIndex = 108;
            // 
            // txtmadocgia
            // 
            txtmadocgia.Location = new Point(124, 14);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(315, 27);
            txtmadocgia.TabIndex = 107;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(8, 150);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 106;
            label5.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 105;
            label3.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 104;
            label1.Text = "Mã Độc Giả";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(10, 260);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 309);
            dgvquanlynv.TabIndex = 103;
            // 
            // QuanLyDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnhienthi);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(txtmadocgia);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvquanlynv);
            Name = "QuanLyDocGia";
            Size = new Size(1020, 583);
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhienthi;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtTimKiem;
        private Label label8;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtmadocgia;
        private Label label5;
        private Label label3;
        private Label label1;
        private DataGridView dgvquanlynv;
    }
}
