USE [master]
GO
/****** Object:  Database [QLSieuThi]    Script Date: 23/04/2018 07:30:26 PM ******/
CREATE DATABASE [QLSieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSieuThi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLSieuThi.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSieuThi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLSieuThi_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSieuThi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSieuThi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSieuThi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QLSieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSieuThi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLSieuThi]
GO
/****** Object:  Table [dbo].[ChitietHoaDon]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChitietHoaDon](
	[MactHD] [char](10) NOT NULL,
	[MaHD] [char](10) NULL,
	[MaHH] [char](15) NULL,
	[Dongia] [float] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [CTHD_MACTHD_PK] PRIMARY KEY CLUSTERED 
(
	[MactHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [char](15) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[ChungLoai] [nvarchar](30) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[TrongLuong] [int] NULL,
	[GiaBan] [float] NULL,
	[NoiSX] [nvarchar](30) NULL,
	[HSD] [date] NULL,
 CONSTRAINT [HH_MAHH_PK] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[MaKH] [char](10) NULL,
	[Ngaylap] [datetime] NULL,
	[VAT] [float] NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [HD_MaHD_Pk] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKh] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [KH_MaKH_PK] PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKho] [char](10) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[MaThuKho] [char](10) NULL,
	[DiaChi] [nvarchar](30) NULL,
 CONSTRAINT [KH_MaKho_PK] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [nchar](10) NOT NULL,
	[PassWord] [nchar](10) NULL,
	[MaQuyen] [int] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [NV_MANV_PK] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 23/04/2018 07:30:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT01      ', N'HD01      ', N'HH01           ', 11, 100)
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT02      ', N'HD03      ', N'HH02           ', 22, 200)
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT03      ', N'HD02      ', N'HH03           ', 33, 300)
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT04      ', N'HD04      ', N'HH04           ', 44, 400)
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT05      ', N'HD05      ', N'HH05           ', 55, 500)
INSERT [dbo].[ChitietHoaDon] ([MactHD], [MaHD], [MaHH], [Dongia], [soluong]) VALUES (N'CT06      ', N'HD06      ', N'HH06           ', 66, 600)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH01           ', N'Xúc xích', N'Thực phẩm ăn nhanh', N'gói', 1, 20000, N'Hà Nội', CAST(0x133E0B00 AS Date))
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH02           ', N'Bim Bim', N'Thực phẩm ăn nhanh', N'gói', 1, 10000, N'Hải Phòng', CAST(0x323E0B00 AS Date))
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH03           ', N'Thịt bò', N'Thực phẩm tươi sống', N'kg', 3, 500000, N'Bắc Giang', CAST(0xF33D0B00 AS Date))
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH04           ', N'Tôm', N'Thực phẩm tươi sống', N'kg', 4, 400000, N'Bắc Ninh', CAST(0xD63D0B00 AS Date))
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH05           ', N'Chảo', N'Đồ gia dụng', N'cái', 1, 200000, N'Đà Nẵng', NULL)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [ChungLoai], [DonViTinh], [TrongLuong], [GiaBan], [NoiSX], [HSD]) VALUES (N'HH06           ', N'Quần áo', N'Trang phục', N'bộ', 4, 250000, N'Đà Lạt', NULL)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD01      ', N'NV01      ', N'KH01      ', CAST(0x0000A85B00000000 AS DateTime), 0.1, 200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD02      ', N'NV03      ', N'KH03      ', CAST(0x0000A85B00000000 AS DateTime), 0.001, 200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD03      ', N'NV02      ', N'KH04      ', CAST(0x0000A85B00000000 AS DateTime), 0.001, 200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD04      ', N'NV04      ', N'KH06      ', CAST(0x0000A85B00000000 AS DateTime), 0.001, 200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD05      ', N'NV05      ', N'KH05      ', CAST(0x0000A85B00000000 AS DateTime), 0.001, 200000)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Ngaylap], [VAT], [Tongtien]) VALUES (N'HD06      ', N'NV06      ', N'KH02      ', CAST(0x0000A85B00000000 AS DateTime), 0.001, 200000)
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH01      ', N'Phan Thị Hạnh', N'Bắc Giang', N'Nữ', N'01643864354    ')
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH02      ', N'Nguyễn Thị Linh', N'Sơn La', N'Nữ', N'01672804839    ')
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH03      ', N'Hoàng Thị Hằng', N'Bắc Giang', N'Nữ', N'01673453256    ')
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH04      ', N'Vũ Mạnh Tuấn', N'Phú Thọ ', N'Nam', N'01692482835    ')
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH05      ', N'Hoàng Nguyên Giáp ', N'Phú Thọ', N'Nam', N'01683275939    ')
INSERT [dbo].[KhachHang] ([MaKh], [TenKH], [Diachi], [GioiTinh], [SDT]) VALUES (N'KH06      ', N'Nguyễn Thị Ngọc Ánh', N'Hà Nội', N'Nữ', N'0947385455     ')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K01       ', N'Trường An ', N'NV01      ', N'Ninh Bình')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K02       ', N'Tràng An ', N'NV02      ', N'Ninh Bình')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K03       ', N'Hồng hải', N'NV04      ', N'Hà Nội')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K04       ', N'Sam Sung', N'NV05      ', N'Thái Nguyên')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K05       ', N'Bami', N'NV06      ', N'Hà Nội')
INSERT [dbo].[KhoHang] ([MaKho], [TenKho], [MaThuKho], [DiaChi]) VALUES (N'K06       ', N'Germer', N'NV03      ', N'Hà Nội')
INSERT [dbo].[Login] ([UserName], [PassWord], [MaQuyen]) VALUES (N'manhtuan  ', N'123       ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV01      ', N'Đào Thanh Tú', N'Bán Hàng', N'Nữ', N'Hà Nội', N'0934854738     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV02      ', N'Nguyễn LAn Phương', N'Bán Hàng', N'Nữ', N'Ninh Bình', N'0923763483     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV03      ', N'Phan Văn Nam', N'Giám Đốc', N'Nam', N'Bắc Ninh', N'0937643833     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV04      ', N'Nguyễn Văn Giáp', N'Bảo vệ', N'Nam', N'Phú Thọ', N'0973721723     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV05      ', N'Tăng Thị Huyễn Trang', N'Thu Ngân', N'Nữ', N'Vĩnh Phúc', N'0927632883     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [Gioitinh], [DiaChi], [SDT]) VALUES (N'NV06      ', N'Trương Hà Ana', N'Thư Kí', N'Nữ', N'Tuyên Quang', N'0938764783     ')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen]) VALUES (1, N'admin')
ALTER TABLE [dbo].[ChitietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHD_HD_FK] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChitietHoaDon] CHECK CONSTRAINT [CTHD_HD_FK]
GO
ALTER TABLE [dbo].[ChitietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHD_HH_FK] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChitietHoaDon] CHECK CONSTRAINT [CTHD_HH_FK]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_KH_FK] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HD_KH_FK]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_NV_FK] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HD_NV_FK]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [KH_NV_FK] FOREIGN KEY([MaThuKho])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [KH_NV_FK]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_PhanQuyen]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([Gioitinh]=N'Nữ' OR [Gioitinh]='Nam'))
GO
USE [master]
GO
ALTER DATABASE [QLSieuThi] SET  READ_WRITE 
GO
