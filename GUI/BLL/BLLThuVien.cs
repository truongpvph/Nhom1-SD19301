using DAL;
using DTO.Models;
using System.Linq;
using System.Reflection.Emit;

namespace BLL
{
    public class BLLThuVien
    {
        DALThuVien db=new DALThuVien();
        public List<Sach> getAllSach()
        {
            var listSach=db.getSachAll().ToList();
            return listSach;
        }

        public List<TacGium> getAllTacGium() 
        { 
            var listTacGia=db.getTacGiumAll().ToList();
            return listTacGia;
        }
        public List<TheLoai> GetTheLoais()
        {
            var listTheLoai = db.GetTheLoaisAll().ToList();
            return listTheLoai;
        }
        public List<NhaXuatBan> GetNhaXuatBans()
        {
            var listNXB = db.GetNhaXuatBansAll().ToList();
            return listNXB;
        }
        public TacGium GetTacGiumByName(string name)
        {
            foreach (var i in db.getTacGiumAll().ToList())
            {
                if (i.TenTacGia.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }
                
            }
            return null;
        }
        public TacGium GetTacGiaById(string a)
        {
            foreach (var i in db.getTacGiumAll().ToList())
            {
                if (i.MaTacGia.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public TheLoai GetTheLoaiById(string a)
        {
            foreach (var i in db.GetTheLoaisAll().ToList())
            {
                if (i.MaTheLoai.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public Sach GetSachById(string a)
        {
            foreach (var i in db.getSachAll().ToList())
            {
                if (i.MaSach.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public NhaXuatBan GetNXBByID(string a)
        {
            foreach (var i in db.GetNhaXuatBansAll().ToList())
            {
                if (i.MaNhaXuatBan.Equals(a))
                {
                    return i;
                }
            }
            return null;
        }
        public TheLoai GetTheLoaiByName(string name)
        {
            foreach (var i in db.GetTheLoaisAll().ToList())
            {
                if (i.TenTheLoai.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }

            }
            return null;
        }
        public NhaXuatBan GetNhaXuatBanByName(string name)
        {
            foreach (var i in db.GetNhaXuatBansAll().ToList())
            {
                if (i.TenNhaXuatBan.ToLower().Contains(name.ToLower()))
                {
                    return i;
                }

            }
            return null;
        }
        public void AddSach(string a,string b, string c, string d, string e, string f, string g, string h,string i ,string k, string l)
        {
            var MaSach = a;
            var MaTacGia = GetTacGiumByName(b).MaTacGia.ToString();
            var MaTheLoai = GetTheLoaiByName(c).MaTheLoai.ToString();
            var TenSach = d;
            var MaNhaXuatBan =GetNhaXuatBanByName(e).MaNhaXuatBan.ToString();
            var GiaSach = f;
            var SoLuong = Convert.ToInt32(g);
            var TrangThaiSach = h;
            var NgayXuatBan = DateOnly.Parse(i);
            var MoTa = k;
            var ViTri = l;
            Sach sach= new Sach()
            {
                MaSach = MaSach,
                MaTacGia= MaTacGia,
                MaTheLoai= MaTheLoai,
                TenSach= TenSach,
                MaNhaXuatBan= MaNhaXuatBan,
                GiaSach= GiaSach,
                SoLuong=SoLuong,
                TrangThaiSach= TrangThaiSach,
                NgayXuatBan= NgayXuatBan,
                MoTa= MoTa,
                ViTri= ViTri,

            };
            db.AddSach(sach);
        }
        public void Update(string a, string b, string c, string d, string e, string f, string g, string h, string i, string k, string l)
        {
            var maSach = a;
            var maTacGia = GetTacGiumByName(b).MaTacGia.ToString();
            var maTheLoai = GetTheLoaiByName(c).MaTheLoai.ToString();
            var tenSach = d;
            var maNhaXuatBan = GetNhaXuatBanByName(e).MaNhaXuatBan.ToString();
            var giaSach = f;
            var soLuong = Convert.ToInt32(g);
            var trangThaiSach = h;
            var ngayXuatBan = DateOnly.Parse(i);
            var moTa = k;
            var viTri = l;
            Sach sach = GetSachById(maSach);

            sach.MaSach = maSach;
            sach.MaTacGia = maTacGia;
            sach.MaTheLoai = maTheLoai;
            sach.TenSach = tenSach;
            sach.MaNhaXuatBan = maNhaXuatBan;
            sach.GiaSach = giaSach;
            sach.SoLuong = soLuong;
            sach.TrangThaiSach = trangThaiSach;
            sach.NgayXuatBan = ngayXuatBan;
            sach.MoTa = moTa;
            sach.ViTri = viTri;

            
            db.Update(sach);
        }
        public void Remove(string a)
        {
            var maSach = a.ToString();
            Sach sach= GetSachById(maSach);
            db.RemoveSach(sach);

        }
        //public List<Sach> search(string a)
        //{
        //    var listTheLoai = db.getSachAll().ToList().Join(db.getTacGiumAll().ToList(), x => x.MaTacGia, y => y.MaTacGia, (x, y) => new
        //    {
        //        y.TenTacGia,
        //        x.MaSach,
        //        x.MaTacGia,
        //        x.MaTheLoai,
        //        x.TenSach,
        //        x.MaNhaXuatBan,
        //        x.GiaSach,
        //        x.SoLuong,
        //        x.TrangThaiSach,
        //        x.NgayXuatBan,
        //        x.MoTa,
        //        x.ViTri

        //    }).Where(p=> p.TenTacGia.ToLower().Contains(a.ToString().ToLower()) 
        //    || p.TenSach.ToLower().Contains(a.ToString().ToLower())).ToList();

        //}
        //public TheLoai GetTheLoaiById()
        //{
        //    var listTacGia= db.getSachAll().ToList().Join(db.GetTheLoaisAll().ToList(), x => x.MaTheLoai, y => y.MaTheLoai, (x, y) => new
        //    {
        //        y.TenTheLoai,
        //        x.MaSach,
        //        x.MaTacGia,
        //        x.MaTheLoai,
        //        x.TenSach,
        //        x.MaNhaXuatBan,
        //        x.GiaSach,
        //        x.SoLuong,
        //        x.TrangThaiSach,
        //        x.NgayXuatBan,
        //        x.MoTa,
        //        x.ViTri

        //    });
        //    foreach (var item in listTacGia)
        //    {

        //            return item;

        //    }
        //    return null;
        //}
    }
}
