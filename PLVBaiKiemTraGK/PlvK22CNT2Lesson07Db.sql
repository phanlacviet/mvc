USE [PlvK22CNT2Lesson07Db]
GO
/****** Object:  Table [dbo].[plvKhoa]    Script Date: 17/06/2024 2:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plvKhoa](
	[PlvMaKh] [nchar](10) NOT NULL,
	[PlvTenKh] [nvarchar](50) NULL,
	[PlvTrangThai] [bit] NULL,
 CONSTRAINT [PK_plvKhoa] PRIMARY KEY CLUSTERED 
(
	[PlvMaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlvSinhVien]    Script Date: 17/06/2024 2:09:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlvSinhVien](
	[PlvMaSv] [nvarchar](50) NOT NULL,
	[PlvHoSv] [nvarchar](50) NULL,
	[PlvTenSv] [nvarchar](50) NULL,
	[PlvNgaySinh] [date] NULL,
	[PlvPhai] [bit] NULL,
	[PlvPhone] [nchar](10) NULL,
	[PlvEmail] [nvarchar](50) NULL,
	[PlvMaKh] [nchar](10) NULL,
 CONSTRAINT [PK_PlvSinhVien] PRIMARY KEY CLUSTERED 
(
	[PlvMaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[plvKhoa] ([PlvMaKh], [PlvTenKh], [PlvTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT2', 1)
INSERT [dbo].[PlvSinhVien] ([PlvMaSv], [PlvHoSv], [PlvTenSv], [PlvNgaySinh], [PlvPhai], [PlvPhone], [PlvEmail], [PlvMaKh]) VALUES (N'2210900079', N'Phan Lạc', N'Việt', CAST(N'2004-06-17' AS Date), 1, N'0989930824', N'lacvietphan578@gmail.com', N'K22CNT2   ')
