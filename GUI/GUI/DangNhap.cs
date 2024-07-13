namespace GUI
{
    public partial class DangNhap : Form
    {
        //BLLDangNhap BLLDangNha = new BLLDangNhap();
        //public string a = "";
        //public string b = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //a = txttaikhoan.Text;
            //b = txtmatkhau.Text;
            //if (BLLDangNha.Dangnhap(a, b))
            //{
            //    MessageBox.Show("??ng Nh?p Thành Cônng ", "Thông Báo");
            //    this.Close();

            //}
            //else if (BLLDangNha.dangnhapnv(a, b))
            //{
            //    MessageBox.Show("??ng Nh?p Thành Cônng ", "Thông Báo");
            //    this.Close();
            //}
            //else if (txttaikhoan.Text == "")
            //{
            //    MessageBox.Show("Vui Lòng Nh?p Tài Kho?n ", "Thông Báo");
            //}
            //else if (txtmatkhau.Text == "")
            //{
            //    MessageBox.Show("Vui Lòng Nh?p M?t Kh?u", "Thông Báo");
            //}
            //else
            //{
            //    MessageBox.Show("Thông tin ho?c m?t kh?u sai!!! Vui Lòng nh?p L?i ", "Thông Báo", MessageBoxButtons.OKCancel);
            //}
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
