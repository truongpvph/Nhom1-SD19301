using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class QuanLyDuAn1Context : DbContext
{
    public QuanLyDuAn1Context()
    {
       
    }

    public QuanLyDuAn1Context(DbContextOptions<QuanLyDuAn1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }

    public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TacGium> TacGia { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TheLoai> TheLoais { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-PQPRDCV\\SQLEXPRESS;Database=QuanLyDuAn1;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__ChiTietP__CDF0A114E6FDBEF2");

            entity.ToTable("ChiTietPhieuMuon");

            entity.Property(e => e.MaChiTiet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GhiChu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaPhieuMuon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaPhieuMuonNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaPhieuMuon)
                .HasConstraintName("FK__ChiTietPh__MaPhi__5EBF139D");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaSach)
                .HasConstraintName("FK__ChiTietPh__MaSac__5FB337D6");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F945EB951A52");

            entity.Property(e => e.MaDocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenDocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNhaXuatBan).HasName("PK__NhaXuatB__1AED0BFA6B3E116A");

            entity.ToTable("NhaXuatBan");

            entity.Property(e => e.MaNhaXuatBan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNhaXuatBan)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieuMuon).HasName("PK__PhieuMuo__C4C82222531528B5");

            entity.ToTable("PhieuMuon");

            entity.Property(e => e.MaPhieuMuon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaDocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaDocGia)
                .HasConstraintName("FK__PhieuMuon__MaDoc__5629CD9C");

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaTaiKhoan)
                .HasConstraintName("FK__PhieuMuon__MaTai__571DF1D5");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D09EC864F");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GiaSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HinhAnh).HasColumnType("image");
            entity.Property(e => e.MaNhaXuatBan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTacGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaTheLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MoTa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrangThaiSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ViTri)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MaNhaXuatBanNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaNhaXuatBan)
                .HasConstraintName("FK__Sach__MaNhaXuatB__5BE2A6F2");

            entity.HasOne(d => d.MaTacGiaNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTacGia)
                .HasConstraintName("FK__Sach__MaTacGia__5AEE82B9");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTheLoai)
                .HasConstraintName("FK__Sach__MaTheLoai__59FA5E80");
        });

        modelBuilder.Entity<TacGium>(entity =>
        {
            entity.HasKey(e => e.MaTacGia).HasName("PK__TacGia__F24E675687DB49A0");

            entity.Property(e => e.MaTacGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QuocGia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenTacGia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PK__TaiKhoan__AD7C6529DF892BD2");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaTaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoTen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.SoCccd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SoCCCD");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaiKhoan1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TaiKhoan");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaVaiTro)
                .HasConstraintName("FK__TaiKhoan__MaVaiT__534D60F1");
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34A68867092");

            entity.ToTable("TheLoai");

            entity.Property(e => e.MaTheLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenTheLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CFE4AE255A");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vaitro1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Vaitro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
