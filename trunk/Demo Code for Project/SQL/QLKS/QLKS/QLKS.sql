go
use master
go 
-------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------	MODULE LE TAN --------------------------------------------------------------------------------------------------
if(exists(select name from sys.databases where name='QLKSKHTN'))
	drop database QLKSKHTN
create database QLKSKHTN
go
use QLKSKHTN
go
if(OBJECT_ID('LT_QUOCGIA','U') is not null)
	drop table LT_QUOCGIA
go
create table LT_QUOCGIA
(
	MAQG varchar(10) not null,
	TENQG nvarchar(20),
	constraint PK_QUOCGIA primary key(MAQG)
)
go
if(OBJECT_ID('LT_THANHPHO','U') is not null)
	drop table LT_THANHPHO
go
create table LT_THANHPHO
(
	MATP varchar(10) not null,
	TENTP nvarchar(20),
	MAQG varchar(10) not null,
	constraint FK_THANHPHO_QUOCGIA foreign key(MAQG) references LT_QUOCGIA(MAQG),
	constraint PK_THANHPHO primary key(MATP)
)
go
if(OBJECT_ID('LT_QUAN','U') is not null)
	drop table LT_QUAN
go
create table LT_QUAN
(
	MAQUAN varchar(10) not null,
	TENQUAN nvarchar(20),
	MATP varchar(10) not null,
	constraint FK_QUAN_TP foreign key(MATP) references LT_THANHPHO(MATP),
	constraint PK_QUAN primary key(MAQUAN)
)
go
if(OBJECT_ID('LT_LOAIKH','U')is not null)
	drop table LT_LOAIKH
go
create table LT_LOAIKH
(
	MALKH varchar(10) not null,
	TENLKH nvarchar(20),
	constraint PK_LOAIKH primary key(MALKH) 
)
go
if(OBJECT_ID('LT_KHACHHANG','U') is not null)
	drop table LT_KHACHHANG
go
create table LT_KHACHHANG
(
	MAKH varchar(10) not null,
	HOKH nvarchar(10),
	TENKH nvarchar(20),
	CMND varchar(12),
	PASSPORT varchar(20),
	DIACHI nvarchar(50),
	SODT varchar(30),
	MALKH varchar(10) not null,
	MAQUAN varchar(10) not null,
	MATP varchar(10) not null,
	MAQG varchar(10) not null,
	constraint FK_KHACHHANG_LOAIKH foreign key(MALKH) references LT_LOAIKH(MALKH),
	constraint FK_KHACHHANG_QUAN foreign key(MAQUAN) references LT_QUAN(MAQUAN),
	constraint FK_KHACHHANG_THANHPHO foreign key(MATP) references LT_THANHPHO(MATP),
	constraint FK_KHACHANG_QUOCGIA foreign key(MAQG) references LT_QUOCGIA(MAQG),
	constraint PK_KHACHHANG primary key (MAKH)
)
go
if(OBJECT_ID('LT_LOAIPHONG','U')is not null)
	drop table LT_LOAIPHONG 
go 
create table LT_LOAIPHONG
(
	MALPHG varchar(10) not null,
	TENLPHG nvarchar(20),
	DONGIA int,
	GHICHU nvarchar(200),
	constraint PK_LOAIPHONG primary key(MALPHG)
)
go
if(OBJECT_ID('LT_PHONG','U') is not null)
	drop table LT_PHONG
go
create table LT_PHONG
(
	MAPHG varchar(10) not null,
	TENPHG nvarchar(20),
	TINHTRANG int,
	MALPHG varchar(10) not null,
	constraint PK_PHONG primary key(MAPHG),
	constraint FK_PHONG_LOAIPHONG foreign key(MALPHG) references LT_LOAIPHONG(MALPHG)
)
go
if(OBJECT_ID('LT_PHIEUTHUE','U') is not null)
	drop table LT_PHIEUTHUE
go
create table LT_PHIEUTHUE
(
	MAPT varchar(10) not null,
	NGAYBD smalldatetime,
	NGAYKT smalldatetime,
	SOLUONG int,
	TINHTRANG int,
	constraint CHK_SOLUONG check(SOLUONG>0 and SOLUONG<4),
	constraint PK_PHIEUTHUE primary key(MAPT)
)
go
if(OBJECT_ID('LT_THAMSO','U') is not null)
	drop table LT_THAMSO
go
create table LT_THAMSO
(
	MATS varchar(10) not null,
	TENTS nvarchar(100),
	HESO float,
	TINHTRANG bit,
	constraint PK_THAMSO primary key(MATS)
)
go
if(OBJECT_ID('LT_HOADON','U') is not null)
	drop table LT_HOADON
go
create table LT_HOADON
(
	MAHD varchar(10) not null,
	TRIGIA int,
	MATS varchar(10) not null,
	constraint PK_HOADON primary key(MAHD),
	constraint FK_HOADON_THAMSO  foreign key(MATS) references LT_THAMSO(MATS)
)
go
if(OBJECT_ID('LT_CT_HOADON','U')is not null)
	drop table LT_CT_HOADON
go
create table LT_CT_HOADON
(
	MAHD varchar(10) not null,
	MAPT varchar(10) not null,
	SONGAY int,
	THANHTIEN float,
	MAKH varchar(10) not null,
	constraint PK_CT_HOADON primary key(MAHD,MAPT),
	constraint FK_CT_HOADON_KHACHHANG  foreign key(MAKH) references LT_KHACHHANG(MAKH),
	constraint FK_CT_HOADON_HOADON foreign key(MAHD) references LT_HOADON(MAHD),
	constraint FK_CT_HOADON_PHIEUTHUE foreign key(MAPT) references LT_PHIEUTHUE(MAPT)
)
go
if(OBJECT_ID('LT_CT_PHIEUTHUE','U')is not null)
	drop table LT_CT_PHIEUTHUE
go
create table LT_CT_PHIEUTHUE
(
	MACTPT varchar(10) not null,
	MAPHG varchar(10) not null,
	MAKH varchar(10) not null,
	MAPT varchar(10) not null,
	constraint PK_CT_PHIEUTHUE primary key(MACTPT),
	constraint FK_CT_PHIEUTHUE_PHONG foreign key(MAPHG) references LT_PHONG(MAPHG),
	constraint FK_CT_PHIEUTHUE_KHACHHANG foreign key(MAKH) references LT_KHACHHANG(MAKH),
	constraint FK_CT_PHIEUTHUE_PHIEUTHUE foreign key(MAPT) references LT_PHIEUTHUE(MAPT)
)
go
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------nhân viên --------------------------------------------------------------------------------------------
if(OBJECT_ID('NS_CHUCVU','U') is not null)
	drop table NS_CHUCVU
go
create table NS_CHUCVU
(
	MACV varchar(10) not null,
	TENCV nvarchar(20),
	constraint PK_CHUCVU primary key(MACV)
)
go
if(OBJECT_ID('NS_NHANVIEN','U') is not null)
	drop table NS_NhanVien
go
create table NS_NhanVien
(
	MANV varchar(10) not null,
	HONV nvarchar(10),
	TENNV nvarchar(20),
	NGAYSINH varchar(20),
	GIOITINH bit,
	DIACHI nvarchar(100),
	MAQUAN varchar(10) not null,
	MATP varchar(10) not null,
	MAQG varchar(10) not null,
	CMND varchar(12),
	SODT varchar(20),
	EMAIL varchar(50),
	MACV varchar(10) not null,
	ANH image,
	NGAYBD smalldatetime,
	TINHTRANG bit,
	constraint PK_NHANVIEN primary key(MANV),
	constraint FK_NHANVIEN_QUAN foreign key(MAQUAN) references LT_QUAN(MAQUAN),
	constraint FK_NHANVIEN_THANHPHO foreign key(MATP) references LT_THANHPHO(MATP),
	constraint FK_NHANVIEN_QUOCGIA foreign key(MAQG) references LT_QUOCGIA(MAQG),
	constraint FK_NHANVIEN_CHUCVU foreign key(MACV)references NS_CHUCVU(MACV)
)
go
------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------- modul phan quyen -----------------------------------------------------------------------------------
if(OBJECT_ID('Sys_Menu','U') is not null)
	drop table Sys_Menu
go
create table Sys_Menu
(
	MENUID varchar(100) not null,
	MENUPOSITION int not null,
	MENUVALUE nvarchar(max),
	MENUFILIATIONID varchar(100),
	FORMNAME varchar(100),
	constraint PK_SysMenu primary key(MENUID)
)
go
if(OBJECT_ID('Sys_User','U') is not null)
	drop table Sys_User
go
create table Sys_User
(
	LOGINID varchar(50),
	PASSWORD varchar(50),
	MANV varchar(10) not null,
	EMAIL varchar(50),
	CREATEDATE smalldatetime,
	LOCKUSER bit not null,
	LOCKDATE smalldatetime,
	LOCKEDREASON nvarchar(max),
	LASTLOGIN smalldatetime,
	LASTCHANGEPASSWORD smalldatetime,
	DEADLINEOFUSING smalldatetime,
	constraint PK_SYS_USER primary key(LOGINID),
	constraint FK_USER_NHANVIEN foreign key(MANV) references NS_NHANVIEN(MANV)
)
go
if(OBJECT_ID('Sys_Groups','U')is not null)
	drop table Sys_Groups
go
create table Sys_Groups
(
	GROUPID uniqueidentifier not null,
	GROUPNAME nvarchar(max),
	NOTE nvarchar(max),
	ISADMIN bit,
	constraint PK_GROUPS primary key(GROUPID) 
)
go
if(OBJECT_ID('Sys_GroupUser','U')is not null)
	drop table Sys_GroupUser
go
create table Sys_GroupUser
(
	GROUPID uniqueidentifier not null,
	LOGINID varchar(50) not null,
	constraint PK_SYS_GROUPUSER primary key(GROUPID,LOGINID),
	constraint FK_SYS_GROUPUSER_USRE foreign key(LOGINID) references Sys_User(LOGINID),
	constraint FK_SYS_GROUPUSER_GROUP foreign key(GROUPID) references Sys_Groups(GROUPID)
)
go
if(OBJECT_ID('Sys_MenuGroup','U')is not null)
	drop table Sys_MenuGroup
go
create table Sys_MenuGroup
(
	GROUPID uniqueidentifier not null,
	MENUID varchar(100) not null,
	constraint PK_MENU_GROUP primary key(GROUPID,MENUID),
	constraint FK_MENU_GROUP_GROUP foreign key(GROUPID) references Sys_Groups(GROUPID),
	constraint FK_MENU_GROUP_MENU foreign key(MENUID) references Sys_Menu(MENUID)
)
go
if(OBJECT_ID('Sys_MoDules','U') is not null)
	drop table Sys_MoDules
go
create table Sys_MoDules
(
	MODULEID int not null,
	MODULENAME nvarchar(max),
	NODE nvarchar(max),
	constraint PK_MODULE primary key(MODULEID)
)
go
if(OBJECT_ID('Sys_Authorization','U') is not null)
	drop table Sys_Authorization
go
create table Sys_Authorization
(
	AUTHORRIZATIONID uniqueidentifier not null,
	TITLE nvarchar(max),
	DESCRIPTION nvarchar(max),
	METHODFULLNAME nvarchar(max),
	MODULEID int,
	constraint PK_AUTHORIZATION primary key(AUTHORRIZATIONID),
	constraint FK_AUTHORZITION_MODULE foreign key(MODULEID) references Sys_MoDules(MODULEID)
)
go
if(OBJECT_ID('Sys_GroupsAuthorization','U') is not null)
	drop table Sys_GroupsAuthorization
go
create table Sys_GroupsAuthorization
(
	GROUPID uniqueidentifier not null,
	AUTHORRIZATIONID uniqueidentifier not null,
	constraint PK_GROUP_AUTHORIZATION primary key(GROUPID,AUTHORRIZATIONID),
	constraint FK_GROUP_AUTHOR_GROUP foreign key(GROUPID) references Sys_Groups(GROUPID),
	constraint FK_GROUP_AUTHOR_AUTHOR foreign key(AUTHORRIZATIONID) references Sys_Authorization(AUTHORRIZATIONID)
)
go
