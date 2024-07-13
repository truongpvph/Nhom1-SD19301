using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ADMIN : Form
    {

        public ADMIN()
        {
            InitializeComponent();
        }
        private void panel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ADMIN_Load(object sender, EventArgs e)
        {

            //menuqlnhanvien.Enabled = false;
            //đăngXuấtToolStripMenuItem.Enabled = false;
            //danhMụcToolStripMenuItem.Enabled = false;
            //quảnLýMượnTrảToolStripMenuItem.Enabled = false;
            //quảnLýSáchToolStripMenuItem.Enabled = false;
            //độcGiảToolStripMenuItem.Enabled=false;
            //thểLoạiToolStripMenuItem.Enabled = false;
            //nhàXuấtBảnToolStripMenuItem.Enabled = false;
            //tácGiảToolStripMenuItem.Enabled = false;
            //lậpPhiếuMượnToolStripMenuItem.Enabled = false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            //    //var taikhoan = dangnhap.a;
            //    //var matkau = dangnhap.b;
            //    //if (BLLDangNha.Dangnhap(taikhoan, matkau))
            //    //{
            //    //    menuqlnhanvien.Enabled = true;
            //    //    đăngXuấtToolStripMenuItem.Enabled = true;
            //    //    quảnLýTácGiảToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnToolStripMenuItem.Enabled = true;
            //    //    quảnLýĐộcGiảToolStripMenuItem.Enabled = true;
            //    //    quảnLýSáchToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnTrảToolStripMenuItem.Enabled = true;
            //    //    quảnLýTrảToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnToolStripMenuItem.Enabled = true;

            //    //}
            //    //else if (BLLDangNha.dangnhapnv(taikhoan, matkau))
            //    //{
            //    //    đăngXuấtToolStripMenuItem.Enabled = true;
            //    //    menuqlnhanvien.Enabled = false;
            //    //    quảnLýTácGiảToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnToolStripMenuItem.Enabled = true;
            //    //    quảnLýSáchToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnTrảToolStripMenuItem.Enabled = true;
            //    //    quảnLýTrảToolStripMenuItem.Enabled = true;
            //    //    quảnLýMượnToolStripMenuItem.Enabled = true;

            //    //}
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            //    //menuqlnhanvien.Enabled = false;
            //    //quảnLýĐộcGiảToolStripMenuItem.Enabled = false;
            //    //đăngXuấtToolStripMenuItem.Enabled = false;
            //    //quảnLýMượnToolStripMenuItem.Enabled = false;
            //    //quảnLýTácGiảToolStripMenuItem.Enabled = false;
            //    //quảnLýSáchToolStripMenuItem.Enabled = false;
            //    //quảnLýMượnTrảToolStripMenuItem.Enabled = false;
            //    //quảnLýTrảToolStripMenuItem.Enabled = false;
            //    //quảnLýMượnToolStripMenuItem.Enabled = false;
            //    //panel1.Controls.Clear();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia quanLyDocGia = new QuanLyDocGia();
            panel(quanLyDocGia);
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLYTheLoai quanLYTheLoai = new QuanLYTheLoai();
            panel(quanLYTheLoai);
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhaXuatBan quanLyNhaXuatBan = new QuanLyNhaXuatBan();
            panel(quanLyNhaXuatBan);
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTacGia quanLyTacGia = new QuanLyTacGia();
            panel(quanLyTacGia);
        }

        private void menuqlnhanvien_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            panel(quanLyTaiKhoan);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanLySach = new QuanLySach();
            panel(quanLySach);
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lậpPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhieuMuon quanLyPhieuMuon = new QuanLyPhieuMuon();
            panel(quanLyPhieuMuon);
        }

        private void chiTiếtMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMuonTraSach quanLyMuonTraSach = new QuanLyMuonTraSach();
            panel(quanLyMuonTraSach);
        }
    }
}
