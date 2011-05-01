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
	GIOITINH bit,
	TUOI int,
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
----------------------------------------------------------------------------------------------------------------------------------------------------------------
IF (OBJECTPROPERTY(OBJECT_ID('SpLT_QUAN'), N'IsProcedure') = 1)
	drop proc SpLT_QUAN
go
CREATE PROCEDURE SpLT_QUAN
(
    @MAQUAN varchar(10)=null,
    @TENQUAN nvarchar(20)=null,
    @MATP varchar(10)=null,
    @flag int=0
) 
AS
begin
/*
0:SelectALL
1:INSERT
2:UPDATE
3:DELETE
4:SELECTBYPK
*/	 
	if(@flag=0)
		begin
		 select * from LT_QUAN
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_QUAN where MAQUAN=@MAQUAN))
				begin
					INSERT INTO [LT_QUAN] (MAQUAN,TENQUAN,MATP)
					VALUES (@MAQUAN,@TENQUAN,@MATP)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_QUAN where MAQUAN=@MAQUAN))
			begin
				update  LT_QUAN
				set TENQUAN=@TENQUAN,MATP=@MATP
				where MAQUAN=@MAQUAN
				return 1
			end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_QUAN where MAQUAN=@MAQUAN))
				begin
					delete from LT_QUAN
					where MAQUAN=@MAQUAN
					return 1
				end
		end	
	if(@flag=4)	
		begin
			select * from LT_QUAN where MAQUAN=@MAQUAN
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_THANHPHO'), N'IsProcedure')=1)
	drop proc SpLT_THANHPHO
go
create proc SpLT_THANHPHO
(
	@MATP varchar(10)=null,
    @TENTP nvarchar(20)=null,
    @MAQG varchar(10)=null,
    @flag int =0
)
as 
begin
/*
0:SelectALL
1:INSERT
2:UPDATE
3:DELETE
4:SELECTBYPK
*/	
	if(@flag=0)
		begin
		select * from LT_THANHPHO
	end
	if(@flag=1)
		begin
			if(not exists(select * from LT_THANHPHO where MATP=@MATP))
				begin
					INSERT INTO LT_THANHPHO (MATP,TENTP,MAQG)
					VALUES (@MATP,@TENTP,@MAQG)
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_THANHPHO where MATP=@MATP))
			begin
				update LT_THANHPHO
				set  MATP = @MATP, TENTP = @TENTP
				where MAQG = @MAQG
			end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_THANHPHO where MATP=@MATP))
				begin
					delete from LT_THANHPHO
					where MATP=@MATP
				end
		end	
	if(@flag=4)
		begin
			select * from LT_THANHPHO where MATP=@MATP
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_QUOCGIA'),N'IsProcedure')=1 )
	drop proc SpLT_QUOCGIA
go
create proc SpLT_QUOCGIA
(
    @MAQG varchar(10)=null,
    @TENQG nvarchar(20)=null,
    @flag int=0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_QUOCGIA
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_QUOCGIA where MAQG=@MAQG))
				begin
					INSERT INTO [LT_QUOCGIA] (MAQG,TENQG)
					VALUES (@MAQG,@TENQG)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists (select * from LT_QUOCGIA where MAQG=@MAQG))
				begin
					update LT_QUOCGIA
					set	  TENQG=@TENQG
					where MAQG=@MAQG
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_QUOCGIA where MAQG=@MAQG))
				begin
					delete from LT_QUOCGIA
					where MAQG=@MAQG
					return 1 
				end
		end
	if(@flag=4)
		begin
			select * from LT_QUOCGIA where MAQG=@MAQG
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_LOAIKH'),N'IsProcedure')=1 )
	drop proc SpLT_LOAIKH
go
create proc SpLT_LOAIKH
(
	@MALKH varchar(10)=null,
    @TENLKH nvarchar(20)=null,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_LOAIKH
		end
	if(@flag=1)
		begin
			if(not exists (select * from LT_LOAIKH where MALKH=@MALKH))
				begin
					INSERT INTO [LT_LOAIKH] (MALKH,TENLKH)
					VALUES (@MALKH,@TENLKH)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_LOAIKH where MALKH=@MALKH))
				begin
					update LT_LOAIKH
					set TENLKH=@TENLKH
					where MALKH=@MALKH
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_LOAIKH where MALKH=@MALKH))
				begin
					delete from LT_LOAIKH
					where MALKH=@MALKH
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from LT_LOAIKH where MALKH=@MALKH
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_KHACHHANG'),N'IsProcedure')=1 )
	drop proc SpLT_KHACHHANG
go
create proc SpLT_KHACHHANG
(
	@MAKH varchar(10)=null,
    @HOKH nvarchar(10)=null,
    @TENKH nvarchar(20)=null,
    @CMND varchar(12)=null,
    @PASSPORT varchar(20)=null,
    @GIOITINH bit=0,
	@TUOI int=0,
    @DIACHI nvarchar(50)=null,
    @SODT varchar(30)=null,
    @MALKH varchar(10)=null,
    @MAQUAN varchar(10)=null,
    @MATP varchar(10)=null,
    @MAQG varchar(10)  =null,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_KHACHHANG
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_KHACHHANG where MAKH=@MAKH))
				begin
					INSERT INTO [LT_KHACHHANG] (
											MAKH,
											HOKH,
											TENKH,
											CMND,
											PASSPORT,
											DIACHI,
											SODT,
											MALKH,
											MAQUAN,
											MATP,
											MAQG,
											GIOITINH,
											TUOI)
										VALUES (
											@MAKH,
											@HOKH,
											@TENKH,
											@CMND,
											@PASSPORT,
											@DIACHI,
											@SODT,
											@MALKH,
											@MAQUAN,
											@MATP,
											@MAQG,
											@GIOITINH,
											@TUOI)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_KHACHHANG where MAKH=@MAKH))
				begin
					update LT_KHACHHANG
					set MAKH=@MAKH,
						HOKH=@HOKH,
						TENKH=@TENKH,
						CMND=@CMND,
						PASSPORT=@PASSPORT,
						DIACHI=@DIACHI,
						SODT=@SODT,
						MAQUAN=@MAQUAN,
						MATP=@MATP,
						MAQG=@MAQG,
						GIOITINH=@GIOITINH,
						TUOI=@TUOI
					where MAKH=@MAKH
					return 1
				end
		end	
	if(@flag=3)
		begin
			if(exists(select * from LT_KHACHHANG where MAKH=@MAKH))
				begin
					delete from LT_KHACHHANG
					where MAKH=@MAKH
					return 1
				end
		end	
	if(@flag=4)
		begin
			select * from LT_KHACHHANG where MAKH=@MAKH
		end	
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_LOAIPHONG'),N'IsProcedure')=1 )
	drop proc SpLT_LOAIPHONG
go
create proc SpLT_LOAIPHONG
(
	@MALPHG varchar(10)=null,
    @TENLPHG nvarchar(20)=null,
    @DONGIA int =0,
    @GHICHU nvarchar(200)=null,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_LOAIPHONG
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_LOAIPHONG where MALPHG=@MALPHG))
				begin
					INSERT INTO LT_LOAIPHONG (
										MALPHG,
										TENLPHG,
										DONGIA,
										GHICHU)
									VALUES (
										@MALPHG,
										@TENLPHG,
										@DONGIA,
										@GHICHU)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_LOAIPHONG where MALPHG=@MALPHG))
				begin
					update LT_LOAIPHONG
					set TENLPHG=@TENLPHG,
						DONGIA=@DONGIA,
						GHICHU=@GHICHU
					where MALPHG=@MALPHG
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_LOAIPHONG where MALPHG=@MALPHG))
				begin
					delete from LT_LOAIPHONG
					where MALPHG=@MALPHG
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from LT_LOAIPHONG where MALPHG=@MALPHG
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_PHONG'),N'IsProcedure')=1 )
	drop proc SpLT_PHONG
go
create proc SpLT_PHONG
(
	@MAPHG varchar(10)=null,
    @TENPHG nvarchar(20)=null,
    @TINHTRANG int=0,
    @MALPHG varchar(10)=null,
    @flag int=0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_PHONG 
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_PHONG where MAPHG=@MALPHG))
				begin
					INSERT INTO LT_PHONG (
										MAPHG,
										TENPHG,
										TINHTRANG,
										MALPHG)
									VALUES (
										@MAPHG,
										@TENPHG,
										@TINHTRANG,
										@MALPHG)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_PHONG where MAPHG=@MALPHG))
				begin
					update LT_PHONG
					set TENPHG=@TENPHG,
						TINHTRANG=@TINHTRANG,
						MALPHG=@MALPHG
					where MAPHG=@MALPHG
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_PHONG where MAPHG=@MAPHG))
				begin
					delete from LT_PHONG
					where MAPHG=@MAPHG
					return 1
				end
		end	
	if(@flag=4)
		begin
			select * from LT_PHONG where MAPHG=@MAPHG
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_THAMSO'),N'IsProcedure')=1 )
	drop proc SpLT_THAMSO
go
create proc SpLT_THAMSO
(
	@MATS varchar(10)=null,
    @TENTS nvarchar(100)=null,
    @HESO float=0,
    @TINHTRANG bit=0,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_THAMSO
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_THAMSO where MATS=@MATS))
				begin
					INSERT INTO LT_THAMSO (
										MATS,
										TENTS,
										HESO,
										TINHTRANG)
									VALUES (
										@MATS,
										@TENTS,
										@HESO,
										@TINHTRANG)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_THAMSO where MATS=@MATS))
				begin
					update LT_THAMSO
					set TENTS=@TENTS,
						HESO=@HESO,
						TINHTRANG=@TINHTRANG
					where MATS=@MATS
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_THAMSO where MATS=@MATS))
				begin
					delete from LT_THAMSO
					where MATS=@MATS
				end
		end	
	if(@flag=4)
		begin
			select * from LT_THAMSO where MATS=@MATS
		end	
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_HOADON'),N'IsProcedure')=1 )
	drop proc SpLT_HOADON
go
create proc SpLT_HOADON
(
	@MAHD varchar(10)=null,
    @TRIGIA int=0,
    @MATS varchar(10)=null,
    @flag int =0
)
as 
begin
	if(@flag=0)
		begin
			select * from LT_HOADON
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_HOADON where MAHD=@MAHD))
				begin
					INSERT INTO LT_HOADON (
										MAHD,
										TRIGIA,
										MATS)
									VALUES (
										@MAHD,
										@TRIGIA,
										@MATS)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_HOADON where MAHD=@MAHD))
				begin
					update LT_HOADON
					set TRIGIA=@TRIGIA,
						MATS=@MATS
					where MAHD=@MAHD
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_HOADON where MAHD=@MAHD))
				begin
					delete from LT_HOADON
					where MAHD=@MAHD
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from LT_HOADON where MAHD=@MAHD
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_CT_HOADON'),N'IsProcedure')=1 )
	drop proc SpLT_CT_HOADON
go
create proc SpLT_CT_HOADON
(
	@MAHD varchar(10)=null,
    @MAPT varchar(10)=null,
    @SONGAY int=0,
    @THANHTIEN float=0,
    @MAKH varchar(10)=null,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_CT_HOADON
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_CT_HOADON where MAHD=@MAHD and MAPT=@MAPT))
				begin
					INSERT INTO LT_CT_HOADON (
											MAHD,
											MAPT,
											SONGAY,
											THANHTIEN,
											MAKH)
										VALUES (
											@MAHD,
											@MAPT,
											@SONGAY,
											@THANHTIEN,
											@MAKH)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_CT_HOADON where MAHD=@MAHD and MAPT=@MAPT))
				begin
					update LT_CT_HOADON
					set	 SONGAY =@SONGAY,
						THANHTIEN=@THANHTIEN,
						MAKH=@MAKH
					where MAHD=@MAHD and MAPT=@MAPT
					return 1
				end
		end
	if(@flag=3)
		begin
			 if(exists(select * from LT_CT_HOADON where MAHD=@MAHD and MAPT=@MAPT))
				begin
					delete from LT_CT_HOADON
					where MAHD=@MAHD and MAPT=@MAPT
				end
		end
	if(@flag=4)
		begin
			select * from LT_CT_HOADON where MAHD=@MAHD and MAPT=@MAPT
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_PHIEUTHUE'),N'IsProcedure')=1 )
	drop proc SpLT_PHIEUTHUE
go
create proc SpLT_PHIEUTHUE
(
	@MAPT varchar(10)=null,
    @NGAYBD smalldatetime=null,
    @NGAYKT smalldatetime=null,
    @SOLUONG int=0,
    @TINHTRANG int=0,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_PHIEUTHUE
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_PHIEUTHUE where MAPT=@MAPT))
				begin
					INSERT INTO LT_PHIEUTHUE (
											MAPT,
											NGAYBD,
											NGAYKT,
											SOLUONG,
											TINHTRANG)
										VALUES (
											@MAPT,
											@NGAYBD,
											@NGAYKT,
											@SOLUONG,
											@TINHTRANG)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_PHIEUTHUE where MAPT=@MAPT))
				begin
					update LT_PHIEUTHUE
					set NGAYBD=@NGAYBD,
						NGAYKT=@NGAYKT,
						SOLUONG=@SOLUONG,
						TINHTRANG=@TINHTRANG
					where MAPT=@MAPT
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_PHIEUTHUE where MAPT=@MAPT))
				begin
					delete from LT_PHIEUTHUE
					where MAPT=@MAPT
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from LT_PHIEUTHUE where MAPT=@MAPT
		end	
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpLT_CT_PHIEUTHUE'),N'IsProcedure')=1 )
	drop proc SpLT_CT_PHIEUTHUE
go
create proc SpLT_CT_PHIEUTHUE
(   
	@MACTPT varchar(10)=null,
    @MAPHG varchar(10)=null,
    @MAKH varchar(10)=null,
    @MAPT varchar(10)=null,
    @flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from LT_CT_PHIEUTHUE
		end
	if(@flag=1)
		begin
			if(not exists(select * from LT_CT_PHIEUTHUE where MACTPT=@MACTPT))
				begin
					INSERT INTO LT_CT_PHIEUTHUE (
											MACTPT,
											MAPHG,
											MAKH,
											MAPT)
										VALUES (
											@MACTPT,
											@MAPHG,
											@MAKH,
											@MAPT)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from LT_CT_PHIEUTHUE where MACTPT=@MACTPT))
				begin
					update LT_CT_PHIEUTHUE
					set MAKH=@MAKH,
						MAPHG=@MAPHG,
						MAPT=@MAPT
					where MACTPT=@MACTPT
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from LT_CT_PHIEUTHUE where MACTPT=@MACTPT))
				begin
					delete from LT_CT_PHIEUTHUE
					where MACTPT=@MACTPT
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from LT_CT_PHIEUTHUE where MACTPT=@MACTPT
		end
end
go

------------------------------------  store proceduce for phan quyen ------------------------------------------------------------
if(OBJECTPROPERTY(OBJECT_ID('SpSys_Authorization'),N'IsProcedure')=1 )
	drop proc SpSys_Authorization
go
create proc SpSys_Authorization
(
  @AUTHORRIZATIONID  uniqueidentifier=null,
  @TITLE  nvarchar(max)=null,
  @DESCRIPTION  nvarchar(max)=null,
  @METHODFULLNAME  nvarchar(max)=null,
  @MODULEID  int=0	,
  @flag int =0
)
as
begin
	if(@flag=0)	
		begin
			select * from Sys_Authorization 
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_Authorization where AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					insert into Sys_Authorization(
											AUTHORRIZATIONID,
											TITLE,
											DESCRIPTION,
											METHODFULLNAME,
											MODULEID)
										values(
											@AUTHORRIZATIONID,
											@TITLE,
											@DESCRIPTION,
											@METHODFULLNAME,
											@MODULEID)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_Authorization where AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					update Sys_Authorization 
					set	AUTHORRIZATIONID=@AUTHORRIZATIONID,
						TITLE=@TITLE,
						DESCRIPTION=@DESCRIPTION,
						METHODFULLNAME=@METHODFULLNAME,
						MODULEID=@MODULEID
					where AUTHORRIZATIONID=@AUTHORRIZATIONID
					return 1
				end
		end
	if(@flag=3)
		begin
			 if(exists(select * from Sys_Authorization where AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					delete from Sys_Authorization
					where AUTHORRIZATIONID=@AUTHORRIZATIONID
					return 1
				end
		end
	if(@flag=4)
		begin
			if(exists(select * from Sys_Authorization where AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					select * from Sys_Authorization where AUTHORRIZATIONID=@AUTHORRIZATIONID
				end
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_Groups'),N'IsProcedure')=1 )
	drop proc SpSys_Groups
go
create proc SpSys_Groups
(
@GROUPID  uniqueidentifier=null,
@GROUPNAME  nvarchar(max)=null,
@NOTE  nvarchar(max)=null,
@ISADMIN  bit=0,
@flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from Sys_Groups
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_Groups where GROUPID=@GROUPID))
				begin
					insert into Sys_Groups(
										GROUPID,
										GROUPNAME,
										NOTE,
										ISADMIN)
									values(
										@GROUPID,
										@GROUPNAME,
										@NOTE,
										@ISADMIN)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_Groups where GROUPID=@GROUPID))
				begin
					update Sys_Groups
					set GROUPID=@GROUPID,
						GROUPNAME=@GROUPNAME,
						NOTE=@NOTE,
						ISADMIN=@ISADMIN
					where GROUPID=@GROUPID
					return 1
				end
		end
	if(@flag=3)
		begin
			 if(exists(select * from Sys_Groups where GROUPID=@GROUPID))
				begin
					delete from Sys_Groups
					where GROUPID=@GROUPID
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from Sys_Groups where GROUPID=@GROUPID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_GroupsAuthorization'),N'IsProcedure')=1 )
	drop proc SpSys_GroupsAuthorization
go
create proc SpSys_GroupsAuthorization
(
@GROUPID as uniqueidentifier=null,
@AUTHORRIZATIONID as uniqueidentifier=null,
@flag int=0
)
as
begin
	if(@flag=0)
		begin
			select * from Sys_GroupsAuthorization 
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_GroupsAuthorization where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					insert into Sys_GroupsAuthorization(
						GROUPID,
						AUTHORRIZATIONID)
					values(
						@GROUPID,
						@AUTHORRIZATIONID)
					return 1
				end
		end
	if(@flag=2)
		begin
			 if(exists(select * from Sys_GroupsAuthorization where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					update Sys_GroupsAuthorization
					set GROUPID=@GROUPID,
						AUTHORRIZATIONID=@AUTHORRIZATIONID
					where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID
					return 1
				end
		end
	if(@flag=3)
		begin	
			if(exists(select * from Sys_GroupsAuthorization where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID))
				begin
					delete from Sys_GroupsAuthorization 
					where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from	 Sys_GroupsAuthorization where GROUPID=@GROUPID and AUTHORRIZATIONID=@AUTHORRIZATIONID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_GroupUser'),N'IsProcedure')=1 )
	drop proc SpSys_GroupUser
go
create proc SpSys_GroupUser
(
	@GROUPID as uniqueidentifier=null,
	@LOGINID as varchar(50)	=null,
	@flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from Sys_GroupUser
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_GroupUser where GROUPID=@GROUPID and LOGINID=@LOGINID))
				begin
					insert into Sys_GroupUser(
											GROUPID,
											LOGINID)
										values(
											@GROUPID,
											@LOGINID)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_GroupUser where GROUPID=@GROUPID and LOGINID=@LOGINID))
				begin 
					update Sys_GroupUser 
					set GROUPID=@GROUPID,
						LOGINID=@LOGINID
					where GROUPID=@GROUPID and LOGINID=@LOGINID
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from Sys_GroupUser where GROUPID=@GROUPID and LOGINID=@LOGINID))
				begin
					delete from Sys_GroupUser 
					where GROUPID=@GROUPID and LOGINID=@LOGINID
					return 1 
				end
		end
	if(@flag=4)
		begin
			select * from Sys_GroupUser where GROUPID=@GROUPID and LOGINID=@LOGINID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_Menu'),N'IsProcedure')=1 )
	drop proc SpSys_Menu
go
create proc SpSys_Menu
(
	@MENUID varchar(100)=null,
	@MENUPOSITION int=0,
	@MENUVALUE  nvarchar(max)=null,
	@MENUFILIATIONID varchar(100)=null,
	@FORMNAME varchar(100)=null,
	@flag int =0
)
as
begin 
	if(@flag=0)
		begin
			select * from Sys_Menu
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_Menu where MENUID=@MENUID))
				begin
					insert into Sys_Menu(
									MENUID,
									MENUPOSITION,
									MENUVALUE,
									MENUFILIATIONID,
									FORMNAME)
								values(
									@MENUID,
									@MENUPOSITION,
									@MENUVALUE,
									@MENUFILIATIONID,
									@FORMNAME)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_Menu where MENUID=@MENUID))
				begin
					update Sys_Menu
					set MENUPOSITION=@MENUPOSITION,
						MENUVALUE=@MENUVALUE,
						MENUFILIATIONID=@MENUFILIATIONID,
						FORMNAME=@FORMNAME,
						MENUID=@MENUID
					where MENUID=@MENUID
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from Sys_Menu where MENUID=@MENUID))
				begin
					delete from Sys_Menu 
					where   MENUID=@MENUID
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from Sys_Menu where MENUID=@MENUID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_MenuGroup'),N'IsProcedure')=1 )
	drop proc SpSys_MenuGroup
go
create proc SpSys_MenuGroup
(
	@GROUPID as uniqueidentifier=null,
	@MENUID as varchar(100)=null,
	@flag int =0
)
as
begin 
	if(@flag=0)
		begin
			select * from Sys_MenuGroup
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_MenuGroup where MENUID=@MENUID and GROUPID=@GROUPID))
				begin
					insert into Sys_MenuGroup(
											GROUPID,
											MENUID)
										values(
											@GROUPID,
											@MENUID)
					return 1
				end 
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_MenuGroup where MENUID=@MENUID and GROUPID=@GROUPID))
				begin
					update Sys_MenuGroup 
					set MENUID=@MENUID,
						GROUPID=@GROUPID
					where MENUID=@MENUID and GROUPID=@GROUPID
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from Sys_MenuGroup where MENUID=@MENUID and GROUPID=@GROUPID))
				begin
					delete from Sys_MenuGroup 
					where MENUID=@MENUID and GROUPID=@GROUPID
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from Sys_MenuGroup where MENUID=@MENUID and GROUPID=@GROUPID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_MoDules'),N'IsProcedure')=1 )
	drop proc SpSys_MoDules
go
create proc SpSys_MoDules
(
	@MODULEID int=0,
	@MODULENAME nvarchar(max)=null,
	@NODE as nvarchar(max)=null,
	@flag int =0
)
as 
begin
	if(@flag=0)
		begin
			select * from Sys_MoDules
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_MoDules where MODULEID=@MODULEID))
				begin
					insert into Sys_MoDules(
										MODULEID,
										MODULENAME,
										NODE)
									values(
										@MODULEID,
										@MODULENAME,
										@NODE)
					return 1
				end
		end
	if(@flag=2)	
		begin
			if( exists(select * from Sys_MoDules where MODULEID=@MODULEID))
				begin
					update Sys_MoDules
					set 	MODULEID= @MODULEID,
							MODULENAME= @MODULENAME,
							NODE= @NODE 
					where MODULEID=@MODULEID
					return 1
				end
		end	 
	if(@flag=3)
		 begin
			if( exists(select * from Sys_MoDules where MODULEID=@MODULEID))
				begin
					delete from Sys_MoDules
					where MODULEID=@MODULEID
					return 1
				end
		 end
	if(@flag=4)
		begin
			select * from Sys_MoDules where MODULEID=@MODULEID
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpSys_User'),N'IsProcedure')=1 )
	drop proc SpSys_User
go
create proc SpSys_User
(
	@LOGINID varchar(50)=null,
	@PASSWORD varchar(50)=null,
	@MANV varchar(10)=null,
	@EMAIL varchar(50)=null,
	@CREATEDATE smalldatetime=null,
	@LOCKUSER bit=0,
	@LOCKDATE  smalldatetime=null,
	@LOCKEDREASON  nvarchar(max)=null,
	@LASTLOGIN smalldatetime=null,
	@LASTCHANGEPASSWORD  smalldatetime=null,
	@DEADLINEOFUSING  smalldatetime	=null,
	@flag int =	0
)
as
begin
	if(@flag=0)
		begin
			select * from Sys_User 
		end
	if(@flag=1)
		begin
			if(not exists(select * from Sys_User where LOGINID=@LOGINID))
				begin
					insert into Sys_User(
										LOGINID,
										PASSWORD,
										MANV,
										EMAIL,
										CREATEDATE,
										LOCKUSER,
										LOCKDATE,
										LOCKEDREASON,
										LASTLOGIN,
										LASTCHANGEPASSWORD,
										DEADLINEOFUSING)
									values(
										@LOGINID,
										@PASSWORD,
										@MANV,
										@EMAIL,
										@CREATEDATE,
										@LOCKUSER,
										@LOCKDATE,
										@LOCKEDREASON,
										@LASTLOGIN,
										@LASTCHANGEPASSWORD,
										@DEADLINEOFUSING)
				return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from Sys_User where LOGINID=@LOGINID))
				begin
					update Sys_User
					set	LOGINID= @LOGINID,
						PASSWORD= @PASSWORD,
						MANV= @MANV,
						EMAIL= @EMAIL,
						CREATEDATE= @CREATEDATE,
						LOCKUSER= @LOCKUSER,
						LOCKDATE= @LOCKDATE,
						LOCKEDREASON= @LOCKEDREASON,
						LASTLOGIN= @LASTLOGIN,
						LASTCHANGEPASSWORD= @LASTCHANGEPASSWORD,
						DEADLINEOFUSING= @DEADLINEOFUSING
					where LOGINID=@LOGINID
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from Sys_User where LOGINID=@LOGINID))
				begin
					delete from Sys_User
					where LOGINID=@LOGINID
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from Sys_User where LOGINID=@LOGINID
		end
end
go
----------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------- module nhan su -------------------------------------------------------------------
if(OBJECTPROPERTY(OBJECT_ID('SpNS_CHUCVU'),N'IsProcedure')=1 )
	drop proc SpNS_CHUCVU
go
create proc SpNS_CHUCVU
(
	@MACV  varchar(10)=null,
	@TENCV  nvarchar(20) =null ,
	@flag int =0
)
as
begin 
	if(@flag=0)
		begin
			select * from NS_CHUCVU
		end
	if(@flag=1)
		begin
			if(not exists(select * from NS_CHUCVU where MACV=@MACV))
				begin
					insert into NS_CHUCVU(
											MACV,
											TENCV)
										values(
											@MACV,
											@TENCV)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from NS_CHUCVU where MACV=@MACV))
				begin
					update NS_CHUCVU
					set MACV=@MACV,
						TENCV=@TENCV
					where MACV=@MACV
					return 1
				end
		end
	if(@flag=3)
		begin
			if(exists(select * from NS_CHUCVU where MACV=@MACV))
				begin
					delete from NS_CHUCVU
					where MACV=@MACV
					return 1
				end
		end
	if(@flag=4)
		begin
			select * from NS_CHUCVU where MACV=@MACV
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpNS_NhanVien'),N'IsProcedure')=1 )
	drop proc SpNS_NhanVien
go
create proc SpNS_NhanVien
(
	@MANV  varchar(10)=null,
	@HONV  nvarchar(10)=null,
	@TENNV  nvarchar(20)=null,
	@NGAYSINH  varchar(20)=null,
	@GIOITINH  bit=0,
	@DIACHI  nvarchar(100)=null,
	@MAQUAN  varchar(10)=null,
	@MATP  varchar(10)=null,
	@MAQG  varchar(10)=null,
	@CMND  varchar(12)=null,
	@SODT  varchar(20)=null,
	@EMAIL  varchar(50)=null,
	@MACV  varchar(10)=null,
	@ANH  image=null,
	@NGAYBD  smalldatetime=null,
	@TINHTRANG  bit	=0,
	@flag int =0
)
as
begin
	if(@flag=0)
		begin
			select * from NS_NhanVien
		end
	if(@flag=1)
		begin
			if(not exists(select * from NS_NhanVien where MACV=@MACV))
				begin
					insert into NS_NhanVien(
												MANV,
												HONV,
												TENNV,
												NGAYSINH,
												GIOITINH,
												DIACHI,
												MAQUAN,
												MATP,
												MAQG,
												CMND,
												SODT,
												EMAIL,
												MACV,
												ANH,
												NGAYBD,
												TINHTRANG)
											values(
												@MANV,
												@HONV,
												@TENNV,
												@NGAYSINH,
												@GIOITINH,
												@DIACHI,
												@MAQUAN,
												@MATP,
												@MAQG,
												@CMND,
												@SODT,
												@EMAIL,
												@MACV,
												@ANH,
												@NGAYBD,
												@TINHTRANG)
					return 1
				end
		end
	if(@flag=2)
		begin
			if(exists(select * from NS_NhanVien where MACV=@MACV))
				begin
					update NS_NhanVien
					set MANV= @MANV,
						HONV= @HONV,
						TENNV= @TENNV,
						NGAYSINH= @NGAYSINH,
						GIOITINH= @GIOITINH,
						DIACHI= @DIACHI,
						MAQUAN= @MAQUAN,
						MATP= @MATP,
						MAQG= @MAQG,
						CMND= @CMND,
						SODT= @SODT,
						EMAIL= @EMAIL,
						MACV= @MACV,
						ANH= @ANH,
						NGAYBD= @NGAYBD,
						TINHTRANG= @TINHTRANG
					where MANV=@MANV
					return 1
				end 
		end
	if(@flag=3)
		begin
			if(exists(select * from NS_NhanVien where MACV=@MACV))
				begin
					delete from NS_NhanVien 
					where MANV =@MANV
					return 1
				end	
		end	
	if(@flag=4)
		begin
			select * from NS_NhanVien where MANV=@MANV
		end
end
go
if(OBJECTPROPERTY(OBJECT_ID('SpgetSystemdate'),N'IsProcedure')=1 )
	drop proc SpgetSystemdate
go
create proc SpgetSystemdate
as
begin
	select GETDATE() as SystemDate 
end