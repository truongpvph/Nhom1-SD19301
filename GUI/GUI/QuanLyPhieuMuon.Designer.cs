namespace GUI
{
    partial class QuanLyPhieuMuon
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
            cbbmataikhoan = new ComboBox();
            cbbmadocgia = new ComboBox();
            label2 = new Label();
            btnhienthi = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtmaphieumuon = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dgvquanlynv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            SuspendLayout();
            // 
            // cbbmataikhoan
            // 
            cbbmataikhoan.FormattingEnabled = true;
            cbbmataikhoan.Location = new Point(136, 148);
            cbbmataikhoan.Name = "cbbmataikhoan";
            cbbmataikhoan.Size = new Size(315, 28);
            cbbmataikhoan.TabIndex = 131;
            // 
            // cbbmadocgia
            // 
            cbbmadocgia.FormattingEnabled = true;
            cbbmadocgia.Location = new Point(136, 75);
            cbbmadocgia.Name = "cbbmadocgia";
            cbbmadocgia.Size = new Size(315, 28);
            cbbmadocgia.TabIndex = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 129;
            label2.Text = "Mã Độc Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(516, 27);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 128;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(880, 156);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 127;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(763, 107);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 126;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(645, 59);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 125;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtmaphieumuon
            // 
            txtmaphieumuon.Location = new Point(136, 14);
            txtmaphieumuon.Name = "txtmaphieumuon";
            txtmaphieumuon.Size = new Size(315, 27);
            txtmaphieumuon.TabIndex = 124;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 156);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 123;
            label3.Text = "Mã Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 122;
            label1.Text = "Mã Phiếu Mượn";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(9, 217);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 352);
            dgvquanlynv.TabIndex = 121;
            // 
            // QuanLyPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbmataikhoan);
            Controls.Add(cbbmadocgia);
            Controls.Add(label2);
            Controls.Add(btnhienthi);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtmaphieumuon);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvquanlynv);
            Name = "QuanLyPhieuMuon";
            Size = new Size(1020, 583);
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbmataikhoan;
        private ComboBox cbbmadocgia;
        private Label label2;
        private Button btnhienthi;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtmaphieumuon;
        private Label label3;
        private Label label1;
        private DataGridView dgvquanlynv;
    }
}
