using DTO.Models;

namespace DAL
{
    public class DALThuVien
    {
        QuanLyDuAn1Context db = new QuanLyDuAn1Context();
        public List<Sach> getSachAll()
        {
            var listSach= db.Saches.ToList();
            return listSach;
        }
        public List<TacGium> getTacGiumAll()
        {
            var listTacgia= db.TacGia.ToList();
            return listTacgia;
        }
        public List<TheLoai> GetTheLoaisAll()
        {
            var listTheLoai = db.TheLoais.ToList();
            return listTheLoai;
        }
        public List<NhaXuatBan> GetNhaXuatBansAll()
        {
            var listNXB = db.NhaXuatBans.ToList();
            return listNXB;
        }
        public void AddSach(Sach sach)
        {
            db.Saches.Add(sach);
            db.SaveChanges();
        }
        public void RemoveSach(Sach sach)
        {
            db.Saches.Remove(sach);
            db.SaveChanges();
        }
        public void Update(Sach sach)
        {
            db.Saches.Update(sach);
            db.SaveChanges();
        }
    }
}
