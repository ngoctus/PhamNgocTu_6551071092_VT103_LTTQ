CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE CongViec (
	MaSach NVARCHAR(15) NOT NULL PRIMARY KEY,
	TenSach	nText NOT NULL,
	GiaTien NVARCHAR(12) NOT NULL
);
GO

INSERT INTO dbo.CongViec (MaSach, TenSach, GiaTien) VALUES
(N'S001', N'Lập trình C# cơ bản', N'180.000'),
(N'S002', N'Cấu trúc dữ liệu', N'210.000'),
(N'S003', N'Giải thuật nâng cao', N'195.000'),
(N'S004', N'Nhập môn AI', N'230.000'),
(N'S005', N'Quản trị mạng', N'175.000');
GO

