Go
Create database SQLFILM
go
use SQLFILM
Go 
CREATE TABLE quanlyuser
(
	tennhanvien nvarchar(30) Primary Key,
	phanquyen nvarchar(30) NOT NULL,
)

Go
Create Table film
(
	tenphim nvarchar(30) Primary Key,
	theloai nvarchar(30) NOT NULL,
	daodien nvarchar(30),
	ngaykhoichieu smalldatetime NOT NULL,
	dienvien nvarchar(100) NOT NULL,
	motaphim nvarchar(100),
)

Go
Create Table quanlyrap
(
	suatchieu int Primary Key,
	giochieu time NOT NULL,
	tenphim nvarchar(30) foreign key (tenphim) references film NOT NULL,
	sorap int NOT NULL,
)

Go
Create Table banve
(
	masove varchar(10) Primary key,
	tennhanvien nvarchar(30) foreign key(tennhanvien) references quanlyuser NOT NULL,
	tenphim nvarchar(30) foreign key (tenphim) references film not null,
	suatchieu int foreign key (suatchieu) references quanlyrap NOT NULL,
)
go

CREATE TABLE ThongTinCaNhan
(
	TenDangNhap nvarchar(30) Primary key,
	HoTen nvarchar(50) not null,
	NgaySinh date,
	DiaChi nvarchar(100),
	CMND int,
	SDT char(12) constraint CheckPhone CHECK(SDT like '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	Email varchar(50) constraint CheckEmail CHECK(Email Like '_%@_%._%'),
	ImageByte image,
	Foreign Key(TenDangNhap) references QuanLyNhanSu,
)
GO

ALTER TABLE ThongTinCaNhan ADD ImageByte image  
GO

ALTER TABLE QuanLyNhanSu DROP COLUMN ImageByte
GO

ALTER TRIGGER trgInsertQuanLyNhanSu_TrangThai_Null
ON QuanLyNhanSu
FOR INSERT
AS
BEGIN
	DECLARE @Ten nvarchar(30)
	SELECT @Ten = (SELECT TenDangNhap FROM inserted)
	if (SELECT TrangThai FROM inserted) IS NULL
		UPDATE QuanLyNhanSu SET TrangThai = 'Blocked' WHERE TenDangNhap = @Ten
END
GO

INSERT QuanLyNhanSu VALUES(NULL,'123','User',NULL)
GO

SELECT * FROM QuanLyNhanSu
GO

DROP TRIGGER trgInsertQuanLyNhanSu_TrangThai_Null
GO

DECLARE @T varchar = 'ABC'
SELECT @T = (SELECT TOP 1 TrangThai FROM QuanLyNhanSu ORDER BY TenNhanVien DESC)
SELECT @T
if	(@T IS NULL) 
(
	SELECT @T
)
GO

INSERT QuanLyNhanSu VALUES('Sang12',123,'User',NULL)
GO
