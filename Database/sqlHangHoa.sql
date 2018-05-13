
--Them hanghoa
create proc ThemHH
(
	@MaHH nchar(15),
	@TenHH nvarchar(50),
	@ChungLoai nvarchar(30),
	@DonViTinh nvarChar(10),
	@TrongLuong int,
	@GiaBan int,
	@NoiSX nvarchar(30),
	@HSD date
)
as
begin 
INSERT INTO HangHoa
VALUES( @MaHH, @TenHH, @ChungLoai, @DonViTinh, @TrongLuong, @GiaBan, @NoiSX, @HSD )
end
go
--Sua Hang hoa
create proc SuaHH
(
    @MaHH nchar(15),
	@TenHH nvarchar(50),
	@ChungLoai nvarchar(30),
	@DonViTinh nvarChar(10),
	@TrongLuong int,
	@GiaBan int,
	@NoiSX nvarchar(30),
	@HSD date
)
as
begin 
update HangHoa set
 MaHH=@MaHH,  
 TenHH=@TenHH,
 ChungLoai=@ChungLoai,
 DonViTinh=@DonViTinh,
 TrongLuong=@TrongLuong,
 GiaBan=@GiaBan,
 NoiSX=@NoiSX,
 HSD=@HSD
 where MaHH = @Mahh
end