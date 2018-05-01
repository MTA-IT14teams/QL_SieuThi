


--Thủ tục bảng khách hàng, bán hàng

ALTER procedure [dbo].[Proc_ThemKH]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10)
)
as
begin 
INSERT INTO KhachHang VALUES( @Makh, @Tenkh, @GioiTinh,@Tuoi)
end

GO

ALTER procedure [dbo].[SP_SuaKhachHang]
(
	@Makh nchar(10),
	@Tenkh nvarchar(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(10)
)
as
begin 
update KhachHang set MaKH =@Makh  , TenKH=@Tenkh ,TuoiKH = @Tuoi , GioiTinh =@GioiTinh where MaKH = @Makh
end

go

ALTER PROC BanHang
(
	@MaHD NCHAR(10),
	@MaNV NCHAR(10),
	@MaKH NCHAR(10),
	@NgayLap DATE,
	@MaHH NCHAR(10),
	@SoLuong INT
)
AS
BEGIN
	DECLARE @tien INT
	SELECT @tien = @SoLuong * hh.GiaBan
	FROM dbo.ChiTietHoaDon ct, dbo.HangHoa hh
	WHERE ct.MaHH = hh.MaHH

	INSERT INTO dbo.HoaDon 
	        ( MaHD ,
	          MaNV ,
	          MaKH ,
	          Ngaylap
	        )
	VALUES  ( @MaHD , -- MaHD - char(10)
	          @MaNV , -- MaNV - char(10)
	          @MaKH , -- MaKH - char(10)
	          @NgayLap  -- Ngaylap - datetime
	        )

	INSERT INTO dbo.ChitietHoaDon
	VALUES  (
	          @MaHD, -- MaHD - char(10)
	          @MaHH, -- MaHH - char(15)
	          @SoLuong , -- soluong - int
			  @tien
	          )

END

GO

dbo.BanHang
	@MaHD = N'hd0112', -- nchar(10)
    @MaNV = N'nv01', -- nchar(10)
    @MaKH = N'kh01', -- nchar(10)
    @NgayLap = '2018-04-29', -- date
    @MaHH = N'hh01', -- nchar(10)
    @SoLuong = 3 -- int

GO

CREATE PROC ThemCTHD
(
	@MaHD NCHAR(10),
	@MaHH NCHAR(10),
	@SoLuong INT
)
AS
BEGIN
	DECLARE @tien INT
	SELECT @tien = @SoLuong * hh.GiaBan
	FROM dbo.ChiTietHoaDon ct, dbo.HangHoa hh
	WHERE ct.MaHH = hh.MaHH

	INSERT INTO dbo.ChitietHoaDon
	VALUES  (
	          @MaHD, -- MaHD - char(10)
	          @MaHH, -- MaHH - char(15)
	          @SoLuong , -- soluong - int
			  @tien
	          )
END

GO

dbo.ThemCTHD
	@MaHD = N'HD06', -- nchar(10)
    @MaHH = N'hh01', -- nchar(10)
    @SoLuong = 2 -- int

