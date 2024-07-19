using BLL;
using DTO.Models;
using Microsoft.Data.SqlClient;
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
    public partial class QuanLySach : UserControl
    {
        BLLThuVien db = new BLLThuVien();
        DataTable dt = new DataTable();
        public QuanLySach()
        {
            InitializeComponent();
        }

        public void GetValue()
        {
            foreach (var i in db.getAllSach().ToList())
            {
                DataRow row = dt.NewRow();
                row["Mã Sách"] = i.MaSach;
                row["Mã Tác giả"] = i.MaTacGia;
                row["Mã Thể loại"] = i.MaTheLoai;
                row["Mã Nhà xuất bản"] = i.MaNhaXuatBan;
                row["Tên Sách"] = i.TenSach;
                row["Giá sách"] = i.GiaSach;
                row["Số Lượng"] = i.SoLuong;
                row["trạng thái sách"] = i.TrangThaiSach;
                row["Ngày Xuất bản"] = i.NgayXuatBan;

                row["Vị trí"] = i.ViTri;
                row["Mô tả"] = i.MoTa;
                dt.Rows.Add(row);

            }
        }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã Sách", typeof(string));
            dt.Columns.Add("Mã Tác giả", typeof(string));
            dt.Columns.Add("Mã Thể loại", typeof(string));
            dt.Columns.Add("Mã Nhà xuất bản", typeof(string));
            dt.Columns.Add("Tên Sách", typeof(string));
            dt.Columns.Add("Giá sách", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("trạng thái sách", typeof(string));
            dt.Columns.Add("Ngày Xuất bản", typeof(DateOnly));
            dt.Columns.Add("Vị trí", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));
            foreach (var i in db.GetTheLoais().ToList())
            {
                ccbtheloai.Items.Add(i.TenTheLoai);
            }
            foreach (var i in db.getAllTacGium().ToList())
            {
                ccbtacgia.Items.Add(i.TenTacGia);
            }
            foreach (var i in db.GetNhaXuatBans().ToList())
            {
                cbbnxb.Items.Add(i.TenNhaXuatBan);
            }

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            GetValue();
            dgvquanlynv.DataSource = dt;
            btnhienthi.Enabled = false;
        }

        private void dgvquanlynv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dr = dgvquanlynv.Rows[e.RowIndex];
            txtMaSach.Text = dr.Cells[0].Value.ToString();
            ccbtacgia.SelectedItem = db.GetTacGiaById((string)dr.Cells[1].Value.ToString()).TenTacGia;
            ccbtheloai.SelectedItem = db.GetTheLoaiById((string)dr.Cells[2].Value.ToString()).TenTheLoai;
            cbbnxb.SelectedItem = db.GetNXBByID((string)dr.Cells[3].Value.ToString()).TenNhaXuatBan;
            txtTenSach.Text = dr.Cells[4].Value.ToString();
            txtGiaSach.Text = dr.Cells[5].Value.ToString();
            txtSoLuong.Text = dr.Cells[6].Value.ToString();
            textBox1.Text = (string)dr.Cells[7].Value.ToString();
            dtpNgayXuatBan.Text = dr.Cells[8].Value.ToString();
            txtVitri.Text = dr.Cells[9].Value.ToString();
            txtMoTa.Text = dr.Cells[10].Value.ToString();


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            dt.Rows.Clear();
            var search = Convert.ToString(txtTimKiem.Text);
            var list = db.getAllSach().ToList().Join(db.getAllTacGium().ToList(), x => x.MaTacGia, y => y.MaTacGia, (x, y) => new
            {
                y.TenTacGia,
                x.MaSach,
                x.MaTacGia,
                x.MaTheLoai,
                x.TenSach,
                x.MaNhaXuatBan,
                x.GiaSach,
                x.SoLuong,
                x.TrangThaiSach,
                x.NgayXuatBan,
                x.MoTa,
                x.ViTri

            }).Where(p => p.TenTacGia.ToLower().Contains(search.ToString().ToLower())
            || p.TenSach.ToLower().Contains(search.ToString().ToLower())).ToList();
            foreach (var i in list)
            {
                DataRow row = dt.NewRow();
                row["Mã Sách"] = i.MaSach;
                row["Mã Tác giả"] = i.MaTacGia;
                row["Mã Thể loại"] = i.MaTheLoai;
                row["Mã Nhà xuất bản"] = i.MaNhaXuatBan;
                row["Tên Sách"] = i.TenSach;
                row["Giá sách"] = i.GiaSach;
                row["Số Lượng"] = i.SoLuong;
                row["trạng thái sách"] = i.TrangThaiSach;
                row["Ngày Xuất bản"] = i.NgayXuatBan;

                row["Vị trí"] = i.ViTri;
                row["Mô tả"] = i.MoTa;
                dt.Rows.Add(row);

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            
            if (txtGiaSach.Text==""||ccbtacgia.SelectedItem==""||ccbtheloai.SelectedItem==""||txtTenSach.Text==""||cbbnxb.SelectedItem==""
                ||txtGiaSach.Text==""||txtSoLuong.Text==""||textBox1.Text==""||txtVitri.Text=="")
            {
                DialogResult tb = MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                
            }
            else
            {
                dt.Rows.Clear();
                var MaSach = txtMaSach.Text;
                var MaTacGia = ccbtacgia.Text;
                var MaTheLoai = ccbtheloai.Text;
                var TenSach = txtTenSach.Text;
                var MaNhaXuatBan = cbbnxb.SelectedItem.ToString();
                var GiaSach = txtGiaSach.Text;
                var SoLuong = txtSoLuong.Text;
                var TrangThaiSach = textBox1.Text;
                var NgayXuatBan = dtpNgayXuatBan.Value.ToShortDateString();
                var MoTa = txtMoTa.Text;
                var ViTri = txtVitri.Text;
                db.AddSach(MaSach, MaTacGia, MaTheLoai, TenSach, MaNhaXuatBan, GiaSach, SoLuong, TrangThaiSach, NgayXuatBan, MoTa, ViTri);
                GetValue();
            }

            }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.Yes)
            {
                dt.Rows.Clear();
                var MaSach = txtMaSach.Text;
                var MaTacGia = ccbtacgia.Text;
                var MaTheLoai = ccbtheloai.Text;
                var TenSach = txtTenSach.Text;
                var MaNhaXuatBan = Convert.ToString(cbbnxb.SelectedItem);
                var GiaSach = txtGiaSach.Text;
                var SoLuong = txtSoLuong.Text;
                var TrangThaiSach = textBox1.Text;
                var NgayXuatBan = dtpNgayXuatBan.Value.ToShortDateString();
                var MoTa = txtMoTa.Text;
                var ViTri = txtVitri.Text;
                db.Update(MaSach, MaTacGia, MaTheLoai, TenSach, MaNhaXuatBan, GiaSach, SoLuong, TrangThaiSach, NgayXuatBan, MoTa, ViTri);
                GetValue();
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ttgg = MessageBox.Show("Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo);
            if (ttgg == DialogResult.Yes)
            {
                dt.Rows.Clear();
                var id = txtMaSach.Text;
                db.Remove(id);
                GetValue();
            }
            

        }
    }
}
