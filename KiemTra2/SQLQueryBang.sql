CREATE TABLE [dbo].[tblMausac]
(
	[Mamau] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [Tenmau] NVARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[tblHanghoa]
(
	[Mahang] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Tenhang] NVARCHAR(50) NOT NULL, 
    [Mamau] NVARCHAR(20) NOT NULL, 
    [Anh] NVARCHAR(200) NOT NULL, 
    [Soluong] FLOAT NOT NULL, 
    [TGBH] FLOAT NOT NULL,
    Foreign Key (Mamau) references tblMausac (Mamau)
)
