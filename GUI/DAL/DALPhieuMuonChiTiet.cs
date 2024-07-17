using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuMuonChiTiet
    {
        QuanLyDuAn1Context db = new QuanLyDuAn1Context();
        public List<Sach> GetAllSach()
        {
            var a=db.Saches.ToList();
            return a;
        }
        public List<ChiTietPhieuMuon> GetAllPhieuMuonChiTiet()
        {
            var a=db.ChiTietPhieuMuons.ToList();
            return a.ToList();
        }

    }
}
