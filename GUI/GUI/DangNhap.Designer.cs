namespace GUI
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnthoat = new Button();
            label1 = new Label();
            btndangnhap = new Button();
            groupBox2 = new GroupBox();
            txtmatkhau = new TextBox();
            groupBox1 = new GroupBox();
            txttaikhoan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhdangnhap;
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.FromArgb(192, 255, 255);
            btnthoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(525, 427);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(118, 43);
            btnthoat.TabIndex = 19;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(290, 31);
            label1.Name = "label1";
            label1.Size = new Size(463, 40);
            label1.TabIndex = 15;
            label1.Text = "HỆ THỐNG ĐĂNG NHẬP THƯ vIỆN ";
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.FromArgb(192, 255, 255);
            btndangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangnhap.ForeColor = Color.Red;
            btndangnhap.Location = new Point(376, 427);
            btndangnhap.Margin = new Padding(1);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(117, 43);
            btndangnhap.TabIndex = 18;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtmatkhau);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(376, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 56);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật Khẩu ";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmatkhau.Location = new Point(0, 26);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(262, 27);
            txtmatkhau.TabIndex = 5;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txttaikhoan);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(376, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 58);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài Khoản ";
            // 
            // txttaikhoan
            // 
            txttaikhoan.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttaikhoan.Location = new Point(6, 26);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(256, 27);
            txttaikhoan.TabIndex = 4;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 565);
            Controls.Add(btnthoat);
            Controls.Add(label1);
            Controls.Add(btndangnhap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 255, 255);
            Name = "DangNhap";
            Text = "Đăng Nhập ";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnthoat;
        private Label label1;
        private Button btndangnhap;
        private GroupBox groupBox2;
        private TextBox txtmatkhau;
        private GroupBox groupBox1;
        private TextBox txttaikhoan;
    }
}
