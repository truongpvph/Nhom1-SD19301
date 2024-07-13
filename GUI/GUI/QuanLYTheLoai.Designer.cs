namespace GUI
{
    partial class QuanLYTheLoai
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
            txttentheloai = new TextBox();
            txttheloai = new TextBox();
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
            btnhienthi.Location = new Point(516, 71);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 117;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(880, 200);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 116;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(763, 151);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 115;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(645, 103);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 114;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(600, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Thể Loại";
            txtTimKiem.Size = new Size(395, 27);
            txtTimKiem.TabIndex = 113;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(494, 21);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 112;
            label8.Text = "Tìm Kiếm ";
            // 
            // txttentheloai
            // 
            txttentheloai.Location = new Point(123, 153);
            txttentheloai.Name = "txttentheloai";
            txttentheloai.Size = new Size(315, 27);
            txttentheloai.TabIndex = 111;
            // 
            // txttheloai
            // 
            txttheloai.Location = new Point(123, 14);
            txttheloai.Name = "txttheloai";
            txttheloai.Size = new Size(315, 27);
            txttheloai.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 156);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 109;
            label3.Text = "Tên Thể Loại ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 108;
            label1.Text = "Mã Thể Loại";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(9, 260);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 309);
            dgvquanlynv.TabIndex = 107;
            // 
            // QuanLYTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnhienthi);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(txttentheloai);
            Controls.Add(txttheloai);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvquanlynv);
            Name = "QuanLYTheLoai";
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
        private TextBox txttentheloai;
        private TextBox txttheloai;
        private Label label3;
        private Label label1;
        private DataGridView dgvquanlynv;
    }
}
