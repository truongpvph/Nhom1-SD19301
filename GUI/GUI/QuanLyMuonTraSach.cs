using BLL;
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
    public partial class QuanLyMuonTraSach : UserControl
    {
        BLLChiTietPhieuMuon db=new BLLChiTietPhieuMuon();
        DataTable dt=new DataTable();
        public QuanLyMuonTraSach()
        {
            InitializeComponent();
        }
        public void getValue()
        {
            foreach (var i in db.GetAllChiTietPhieuMuon().ToList()) 
            {

            }
        }

        private void QuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Ma phieu muon", typeof(string));
            dt.Columns.Add("Ma doc gia", typeof(string));
            dt.Columns.Add("Ma tai khoan",  typeof(string));
            dt.Columns.Add("Ngay muon", typeof(DateOnly));
            dt.Columns.Add("Ngay tra", typeof(DateOnly));
            dt.Columns.Add("Trang thai tra", typeof(bool));
            dt.Columns.Add("So luong", typeof(int));
            dt.Columns.Add("Tong tien", typeof(double));
            dt.Columns.Add("Ghi chu", typeof(string));
        }

    }
}
