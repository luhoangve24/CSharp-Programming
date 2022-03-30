CREATE TABLE [dbo].[tblHoaDonNH]
(
	[MaHDN] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Manhanvien] NVARCHAR(10) NOT NULL, 
    [Makhach] NVARCHAR(10) NOT NULL, 
    [Ngaynhan] DATETIME NOT NULL, 
    [Tongtien] FLOAT NOT NULL
)

CREATE TABLE [dbo].[tblHoaDonDX]
(
	[MaHDD] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Manhanvien] NVARCHAR(10) NOT NULL, 
    [Maxuong] NVARCHAR(10) NOT NULL, 
    [Ngaydua] DATETIME NOT NULL, 
    [Tongtien] FLOAT NOT NULL
)

CREATE TABLE [dbo].[tblNhanVien]
(
	[Manhanvien] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [Tennhanvien] NVARCHAR(50) NOT NULL, 
    [Gioitinh] NVARCHAR(5) NOT NULL, 
    [Namsinh] DATETIME NOT NULL, 
    [Diachi] NVARCHAR(100) NOT NULL, 
    [Anh] NVARCHAR(300) NOT NULL, 
    [Tencongviec] NVARCHAR(50) NOT NULL, 
    [Luong] FLOAT NOT NULL
)

CREATE TABLE [dbo].[tblKhachHang]
(
	[Makhach] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [Tenkhach] NVARCHAR(50) NOT NULL, 
    [Diachi] NVARCHAR(100) NOT NULL, 
    [Dienthoai] NVARCHAR(20) NOT NULL
)

CREATE TABLE [dbo].[tblSanPham]
(
	[MaSP] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [TenSP] NVARCHAR(50) NOT NULL, 
    [Soluong] FLOAT NOT NULL, 
    [Gianhap] FLOAT NOT NULL, 
    [Giaban] FLOAT NOT NULL
)

CREATE TABLE [dbo].[tblXuong]
(
	[Maxuong] NVARCHAR(10) NOT NULL PRIMARY KEY, 
    [Tenxuong] NVARCHAR(50) NOT NULL, 
    [Diachi] NVARCHAR(100) NOT NULL, 
    [Dienthoai] NVARCHAR(20) NOT NULL
)

CREATE TABLE [dbo].[tblChiTietHDNH]
(
	[MaHDN] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [MaSP] NVARCHAR(10) NOT NULL, 
    [Mausac] NVARCHAR(10) NOT NULL, 
    [Size] FLOAT NOT NULL, 
    [Chatlieu] NVARCHAR(50) NOT NULL, 
    [TGBH] FLOAT NOT NULL, 
    [SLban] FLOAT NOT NULL, 
    [Anh] NVARCHAR(300) NOT NULL, 
    [Khuyenmai] FLOAT NULL, 
    [Thanhtien] FLOAT NOT NULL, 
    [Ghichu] NVARCHAR(300) NULL, 
    [Datrakhach] NVARCHAR(6) NOT NULL, 
    [Yeucaulam] NVARCHAR(300) NOT NULL
)

CREATE TABLE [dbo].[tblChiTietHDDX]
(
	[MaHDD] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [MaSP] NVARCHAR(10) NOT NULL, 
    [Makhach] NVARCHAR(10) NOT NULL, 
    [Size] FLOAT NOT NULL, 
    [Mausac] NVARCHAR(10) NOT NULL, 
    [Yeucaulam] NVARCHAR(300) NOT NULL, 
    [Dongia] FLOAT NOT NULL, 
    [Giamgia] FLOAT NULL, 
    [Thanhtien] FLOAT NOT NULL, 
    [Anh] NVARCHAR(300) NOT NULL, 
    [Ghichu] NVARCHAR(300) NULL, 
    [DatraCH] NVARCHAR(6) NOT NULL
)

-- Khoa ngoai ChiTietHDDX (MaHDD, MaSP, Makhach)
alter table tblChiTietHDDX
add constraint FK_CTHDDX_MaHDD
Foreign key (MaHDD) 
references tblHoaDonDX (MaHDD)

alter table tblChiTietHDDX
add constraint FK_CTHDDX_MaSP 
Foreign key (MaSP) 
references tblSanPham (MaSP)

alter table tblChiTietHDDX
add constraint FK_CTHDDX_Makhach 
Foreign key (Makhach) 
references tblKhachHang (Makhach)


-- Khoa ngoai ChiTietHDNH (MaHDN,MaSP)
alter table tblChiTietHDNH
add constraint FK_CTHDNH_MaHDN
Foreign key (MaHDN)
references tblHoaDonNH (MaHDN)

alter table tblChiTietHDNH
add constraint FK_CTHDNH_MaSP
Foreign key (MaSP)
references tblSanPham (MaSP)


-- Khoa ngoai HoaDonNH (Manhanvien, Makhach)
alter table tblHoaDonNH
add constraint FK_HDNH_Manhanvien
Foreign key (Manhanvien)
references tblNhanVien (Manhanvien)

alter table tblHoaDonNH
add constraint FK_HDNH_Makhach
Foreign key (Makhach)
references tblKhachHang (Makhach)

-- Khoa ngoai HoaDonDX (Manhanvien, Maxuong)
alter table tblHoaDonDX
add constraint FK_HDDX_Manhanvien
Foreign key (Manhanvien)
references tblNhanVien (Manhanvien)

alter table tblHoaDonDX
add constraint FK_HDDX_Maxuong
Foreign key (Maxuong)
references tblXuong (Maxuong)