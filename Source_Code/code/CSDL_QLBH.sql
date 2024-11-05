create database QTBH
go
use QTBH
go
create table NhaCungCap(
	ma_nhacc nchar(5) not null primary key(ma_nhacc),
	ten_ct nvarchar(70) ,
	dia_chi nvarchar(70),
	sdt nchar(10)
)
go
create table SanPham(
	ma_sp nchar(5) not null primary key(ma_sp),
	ma_nhacc nchar(5),
	ten_sp nvarchar(70),
	hang_sx nvarchar(70),
	loai_hang nvarchar(70),
	foreign key(ma_nhacc) references NhaCungCap(ma_nhacc)
)
go
create table KhachHang(
	ma_kh nchar(5) not null primary key(ma_kh),
	ten nvarchar(70),
	gioi_tinh nchar(5),
	dia_chi nvarchar(70),
	sdt nchar(10)
)
go
 create table NhanVien(
	ma_nv nchar(5) not null primary key(ma_nv),
	ten nvarchar(70),
	tuoi int,
	gioi_tinh nchar(5),
	ngay_nv date
)
go
create table hdn(
	hd_nhap nchar(5)not null primary key(hd_nhap),
	ma_nv nchar(5),
	ma_sp nchar(5),
	ngay_lp date,
	sl int,
	dg int,
	thanh_tien int
	foreign key(ma_nv) references NhanVien(ma_nv),
	foreign key(ma_sp) references SanPham(ma_sp)
)
go
create table hdx(
	hd_xuat nchar(5)not null primary key(hd_xuat),
	ma_kh nchar(5),
	ma_sp nchar(5),
	ma_nv nchar(5),
	ngay_lp date,
	sl int,
	dg int,
	thanh_tien int
	foreign key(ma_kh) references KhachHang(ma_kh),
	foreign key(ma_sp) references SanPham(ma_sp),
	foreign key(ma_nv) references NhanVien(ma_nv)
)
go
create table Loai_Hang(
	ma_lh nchar(5) primary key(ma_lh) not null,
	loai_hang nvarchar(7)
)
go
create Luong(
	ma_nv nchar(5),
	so_gio int,
	luong1h int,
	ngay_nLuong date
)	foreign key(ma_nv) references NhanVien(ma_nv)
go
create table t_k(
	tk nchar(20) primary key(tk),
	mk varchar(10),
	ten_nd nvarchar(50),
	cv nvarchar(9)
)
go
insert into t_k
values('Admin','123','Admin','Admin')