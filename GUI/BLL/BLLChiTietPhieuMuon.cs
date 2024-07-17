using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLChiTietPhieuMuon
    {
        DALPhieuMuonChiTiet db=new DALPhieuMuonChiTiet();
        public List<Sach> GetAllSach()
        {
            var a=db.GetAllSach();
            return a.ToList(); 
        }
        public List<ChiTietPhieuMuon> GetAllChiTietPhieuMuon()
        {
            var a = db.GetAllPhieuMuonChiTiet();
            return a.ToList();
        }
    
    }
}
