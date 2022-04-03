CREATE TABLE [dbo].[tblLoai]
(
	[Maloai] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Tenloai] NVARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[tblThu]
(
	[Mathu] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Tenthu] NVARCHAR(50) NOT NULL, 
    [Maloai] NVARCHAR(50) NOT NULL, 
    [Soluong] FLOAT NOT NULL, 
    [Gioitinh] NVARCHAR(50) NOT NULL, 
    [Tuoitho] FLOAT NOT NULL,
	Foreign key (Maloai) references tblLoai(Maloai)
)
