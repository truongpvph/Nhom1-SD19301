namespace GUI
{
    partial class QuanLyMuonTraSach
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
            txtghichu = new TextBox();
            groupBox1 = new GroupBox();
            txtsoluong = new TextBox();
            label9 = new Label();
            cbbmataikhoan = new ComboBox();
            cbbmasach = new ComboBox();
            rdochuatra = new RadioButton();
            rdodatra = new RadioButton();
            datengaytra = new DateTimePicker();
            label4 = new Label();
            btnhienthi = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnxoa = new Button();
            dateNgaymuon = new DateTimePicker();
            btnsua = new Button();
            btnthem = new Button();
            txttongtien = new TextBox();
            txtmaphieumuon = new TextBox();
            label7 = new Label();
            label6 = new Label();
            laba = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvquanlynv = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            SuspendLayout();
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(6, 24);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(443, 113);
            txtghichu.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtghichu);
            groupBox1.Location = new Point(502, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 143);
            groupBox1.TabIndex = 96;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghi Chú ";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(608, 8);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(349, 27);
            txtsoluong.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(502, 16);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 94;
            label9.Text = "Số Lượng";
            // 
            // cbbmataikhoan
            // 
            cbbmataikhoan.FormattingEnabled = true;
            cbbmataikhoan.Location = new Point(136, 85);
            cbbmataikhoan.Name = "cbbmataikhoan";
            cbbmataikhoan.Size = new Size(295, 28);
            cbbmataikhoan.TabIndex = 93;
            // 
            // cbbmasach
            // 
            cbbmasach.FormattingEnabled = true;
            cbbmasach.Location = new Point(137, 51);
            cbbmasach.Name = "cbbmasach";
            cbbmasach.Size = new Size(295, 28);
            cbbmasach.TabIndex = 92;
            // 
            // rdochuatra
            // 
            rdochuatra.AutoSize = true;
            rdochuatra.Location = new Point(309, 212);
            rdochuatra.Name = "rdochuatra";
            rdochuatra.Size = new Size(88, 24);
            rdochuatra.TabIndex = 91;
            rdochuatra.TabStop = true;
            rdochuatra.Text = "Chưa Trả";
            rdochuatra.UseVisualStyleBackColor = true;
            // 
            // rdodatra
            // 
            rdodatra.AutoSize = true;
            rdodatra.Location = new Point(159, 212);
            rdodatra.Name = "rdodatra";
            rdodatra.Size = new Size(73, 24);
            rdodatra.TabIndex = 90;
            rdodatra.TabStop = true;
            rdodatra.Text = "Đã Trả";
            rdodatra.UseVisualStyleBackColor = true;
            // 
            // datengaytra
            // 
            datengaytra.Location = new Point(136, 165);
            datengaytra.Name = "datengaytra";
            datengaytra.Size = new Size(296, 27);
            datengaytra.TabIndex = 89;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(11, 163);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 88;
            label4.Text = "Ngày Ngày trả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(487, 251);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 87;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(136, 251);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(296, 27);
            txtTimKiem.TabIndex = 86;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(11, 254);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 85;
            label8.Text = "TimKiem";
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(891, 251);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 84;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // dateNgaymuon
            // 
            dateNgaymuon.Location = new Point(136, 118);
            dateNgaymuon.Name = "dateNgaymuon";
            dateNgaymuon.Size = new Size(296, 27);
            dateNgaymuon.TabIndex = 83;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(733, 254);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 82;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(608, 251);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 81;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(608, 51);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(349, 27);
            txttongtien.TabIndex = 80;
            // 
            // txtmaphieumuon
            // 
            txtmaphieumuon.Location = new Point(136, 17);
            txtmaphieumuon.Name = "txtmaphieumuon";
            txtmaphieumuon.Size = new Size(296, 27);
            txtmaphieumuon.TabIndex = 79;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(502, 59);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 78;
            label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 123);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 77;
            label6.Text = "Ngày Mượn";
            // 
            // laba
            // 
            laba.AutoSize = true;
            laba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            laba.Location = new Point(11, 212);
            laba.Name = "laba";
            laba.Size = new Size(119, 20);
            laba.TabIndex = 76;
            laba.Text = "Trạng Thái Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 90);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 75;
            label3.Text = "Mã Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 74;
            label2.Text = "Mã Độc Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 73;
            label1.Text = "Mã Phiếu Mượn";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(9, 289);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 286);
            dgvquanlynv.TabIndex = 72;
            // 
            // QuanLyMuonTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(txtsoluong);
            Controls.Add(label9);
            Controls.Add(cbbmataikhoan);
            Controls.Add(cbbmasach);
            Controls.Add(rdochuatra);
            Controls.Add(rdodatra);
            Controls.Add(datengaytra);
            Controls.Add(label4);
            Controls.Add(btnhienthi);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(btnxoa);
            Controls.Add(dateNgaymuon);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txttongtien);
            Controls.Add(txtmaphieumuon);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(laba);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvquanlynv);
            Name = "QuanLyMuonTraSach";
            Size = new Size(1020, 583);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtghichu;
        private GroupBox groupBox1;
        private TextBox txtsoluong;
        private Label label9;
        private ComboBox cbbmataikhoan;
        private ComboBox cbbmasach;
        private RadioButton rdochuatra;
        private RadioButton rdodatra;
        private DateTimePicker datengaytra;
        private Label label4;
        private Button btnhienthi;
        private TextBox txtTimKiem;
        private Label label8;
        private Button btnxoa;
        private DateTimePicker dateNgaymuon;
        private Button btnsua;
        private Button btnthem;
        private TextBox txttongtien;
        private TextBox txtmaphieumuon;
        private Label label7;
        private Label label6;
        private Label laba;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvquanlynv;
    }
}
