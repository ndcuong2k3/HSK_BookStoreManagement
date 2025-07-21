-- ==============================
-- TẠO DATABASE
-- ==============================
CREATE DATABASE BookStoreManagement_Final;
GO

USE BookStoreManagement_Final;
GO

-- ==============================
-- BẢNG ĐƠN VỊ SẢN XUẤT (DÙNG CHUNG CHO SÁCH / VỞ / BÚT)
-- ==============================
CREATE TABLE tblDonViSanXuat (
    sMaDV VARCHAR(5) PRIMARY KEY,
    sTenDV NVARCHAR(60) NOT NULL,
    sDiachi NVARCHAR(50),
    sSDT VARCHAR(11)
);
GO

-- ==============================
-- BẢNG SẢN PHẨM (CHA)
-- ==============================
CREATE TABLE tblSanPham (
    sMaSP VARCHAR(5) PRIMARY KEY,
    sTenSP NVARCHAR(50) NOT NULL,
    iGiaNhap INT CHECK (iGiaNhap > 0),
    iGiaBan INT CHECK (iGiaBan > 0),
    iSL INT CHECK (iSL >= 0),
    sLoai NVARCHAR(20) CHECK (sLoai IN (N'Vở', N'Bút', N'Sách'))
);
GO

-- ==============================
-- BẢNG SÁCH
-- ==============================
CREATE TABLE tblSach (
    sMaSP VARCHAR(5) PRIMARY KEY REFERENCES tblSanPham(sMaSP) ON DELETE CASCADE,
    sMaDV VARCHAR(5) REFERENCES tblDonViSanXuat(sMaDV),
    sTacgia NVARCHAR(50),
    sTheloai NVARCHAR(50),
    iNamXB INT
);
GO

-- ==============================
-- BẢNG VỞ
-- ==============================
CREATE TABLE tblVo (
    sMaSP VARCHAR(5) PRIMARY KEY REFERENCES tblSanPham(sMaSP) ON DELETE CASCADE,
    iSoTrang INT CHECK (iSoTrang > 0),
    sKieuDongKe NVARCHAR(30),
    sMaDV VARCHAR(5) REFERENCES tblDonViSanXuat(sMaDV)
);
GO

-- ==============================
-- BẢNG BÚT
-- ==============================
CREATE TABLE tblBut (
    sMaSP VARCHAR(5) PRIMARY KEY REFERENCES tblSanPham(sMaSP) ON DELETE CASCADE,
    sLoaiBut NVARCHAR(30),
    sMauBut NVARCHAR(30),
    sMaDV VARCHAR(5) REFERENCES tblDonViSanXuat(sMaDV)
);
GO

-- ==============================
-- BẢNG NHÂN VIÊN
-- ==============================
CREATE TABLE tblNhanVien (
    sMaNV VARCHAR(5) PRIMARY KEY,
    sTenNV NVARCHAR(25),
    dNgaysinh DATE CHECK (DATEDIFF(YEAR, dNgaysinh, GETDATE()) >= 18),
    sGioitinh NVARCHAR(4) CHECK (sGioitinh IN (N'Nam', N'Nữ')),
    sQuequan NVARCHAR(25),
    sSDT VARCHAR(11),
    sChucvu NVARCHAR(50),
    dNgayvaolam DATE
);
GO

-- ==============================
-- BẢNG KHÁCH HÀNG
-- ==============================
CREATE TABLE tblKhachHang (
    sMaKH VARCHAR(5) PRIMARY KEY,
    sTenKH NVARCHAR(60) NOT NULL,
    sDiachi NVARCHAR(25) NOT NULL,
    sSDT VARCHAR(11) NOT NULL
);
GO

-- ==============================
-- BẢNG HÓA ĐƠN
-- ==============================
CREATE TABLE tblHoaDon (
    sMaHD VARCHAR(5) PRIMARY KEY,
    sMaNV VARCHAR(5) NOT NULL REFERENCES tblNhanVien(sMaNV),
    sMaKH VARCHAR(5) NOT NULL REFERENCES tblKhachHang(sMaKH),
    dNgaylap DATE CHECK (dNgaylap <= GETDATE()),
    sTrangthai NVARCHAR(20) CHECK (sTrangthai IN (N'Đã thanh toán', N'Chưa thanh toán')) DEFAULT N'Chưa thanh toán'
);
GO

-- ==============================
-- BẢNG CHI TIẾT HÓA ĐƠN
-- ==============================
CREATE TABLE tblChiTietHD (
    sMaHD VARCHAR(5) REFERENCES tblHoaDon(sMaHD) ON DELETE CASCADE,
    sMaSP VARCHAR(5) REFERENCES tblSanPham(sMaSP) ON DELETE CASCADE,
    iSL INT NOT NULL CHECK (iSL > 0),
    CONSTRAINT pk_CTHD PRIMARY KEY (sMaHD, sMaSP)
);
GO

-- ==============================
-- BẢNG TÀI KHOẢN
-- ==============================
CREATE TABLE tblTaiKhoan (
    sTenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    sMatKhau VARCHAR(255) NOT NULL,
    sMaNV VARCHAR(5) REFERENCES tblNhanVien(sMaNV),
    CONSTRAINT pk_TK PRIMARY KEY (sMaNV)
);
GO

-- ==============================
-- BẢNG PHIẾU NHẬP
-- ==============================
CREATE TABLE tblPhieuNhap (
    sMaPN VARCHAR(5) PRIMARY KEY,
    sMaNV VARCHAR(5) NOT NULL REFERENCES tblNhanVien(sMaNV),
    dNgayNhap DATE NOT NULL CHECK (dNgayNhap <= GETDATE()),
    sGhiChu NVARCHAR(100)
);
GO

-- ==============================
-- BẢNG CHI TIẾT PHIẾU NHẬP
-- ==============================
CREATE TABLE tblChiTietPN (
    sMaPN VARCHAR(5) REFERENCES tblPhieuNhap(sMaPN) ON DELETE CASCADE,
    sMaSP VARCHAR(5) REFERENCES tblSanPham(sMaSP) ON DELETE CASCADE,
    iSoLuong INT NOT NULL CHECK (iSoLuong > 0),
    CONSTRAINT pk_CTPN PRIMARY KEY (sMaPN, sMaSP)
);
GO
USE BookStoreManagement_Final;
GO

-- ==============================
-- DỮ LIỆU MẪU: tblDonViSanXuat
-- ==============================
INSERT INTO tblDonViSanXuat VALUES
('DV001', N'NXB Kim Đồng', N'Hà Nội', '0911222333'),
('DV002', N'Văn phòng phẩm Hồng Hà', N'Hồ Chí Minh', '0909090909'),
('DV003', N'Cty Bút Thiên Long', N'Đà Nẵng', '0888123456'),
('DV004', N'Nhà sách Fahasa', N'Huế', '0933444555'),
('DV005', N'VPP An Lộc Phát', N'Cần Thơ', '0966788899');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblSanPham
-- ==============================
INSERT INTO tblSanPham VALUES
('SP001', N'Truyện Doremon', 12000, 18000, 50, N'Sách'),
('SP002', N'Vở ô ly 200 trang', 4000, 6000, 100, N'Vở'),
('SP003', N'Bút bi Thiên Long', 2000, 3500, 200, N'Bút'),
('SP004', N'Sách giáo khoa Toán', 15000, 20000, 40, N'Sách'),
('SP005', N'Vở Campus 150 trang', 6000, 9000, 80, N'Vở'),
('SP006', N'Bút mực xanh TL', 3000, 5000, 150, N'Bút');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblSach
-- ==============================
INSERT INTO tblSach VALUES
('SP001', 'DV001', N'Fujiko Fujio', N'Truyện tranh', 2001),
('SP004', 'DV001', N'Bộ GD&ĐT', N'Sách giáo khoa', 2023);
GO

-- ==============================
-- DỮ LIỆU MẪU: tblVo
-- ==============================
INSERT INTO tblVo VALUES
('SP002', 200, N'Ô ly', 'DV002'),
('SP005', 150, N'Kẻ ngang', 'DV004');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblBut
-- ==============================
INSERT INTO tblBut VALUES
('SP003', N'Bút bi', N'Mực đen', 'DV003'),
('SP006', N'Bút mực', N'Mực xanh', 'DV003');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblNhanVien
-- ==============================
INSERT INTO tblNhanVien VALUES
('NV001', N'Nguyễn Văn A', '1990-05-01', N'Nam', N'Hà Nội', '0911000001', N'Quản lý', '2015-03-10'),
('NV002', N'Lê Thị B', '1995-07-12', N'Nữ', N'Đà Nẵng', '0911000002', N'Nhân viên', '2018-06-01'),
('NV003', N'Trần Văn C', '1992-10-22', N'Nam', N'HCM', '0911000003', N'Nhân viên', '2017-09-15'),
('NV004', N'Phạm Thị D', '1998-01-20', N'Nữ', N'Hải Phòng', '0911000004', N'Nhân viên', '2020-11-05'),
('NV005', N'Hoàng Văn E', '1993-03-18', N'Nam', N'Bình Dương', '0911000005', N'Quản lý', '2016-04-12');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblKhachHang
-- ==============================
INSERT INTO tblKhachHang VALUES
('KH001', N'Ngô Văn X', N'Cầu Giấy, HN', '0988000001'),
('KH002', N'Trần Thị Y', N'Thanh Xuân, HN', '0988000002'),
('KH003', N'Lê Văn Z', N'Q1, HCM', '0988000003'),
('KH004', N'Phan Thị M', N'Ninh Bình', '0988000004'),
('KH005', N'Bùi Văn K', N'Đà Nẵng', '0988000005');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblHoaDon
-- ==============================
INSERT INTO tblHoaDon VALUES
('HD001', 'NV001', 'KH001', '2024-07-01', N'Đã thanh toán'),
('HD002', 'NV002', 'KH002', '2024-07-02', N'Chưa thanh toán'),
('HD003', 'NV003', 'KH003', '2024-07-03', N'Đã thanh toán'),
('HD004', 'NV004', 'KH004', '2024-07-04', N'Chưa thanh toán'),
('HD005', 'NV005', 'KH005', '2024-07-05', N'Đã thanh toán');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblChiTietHD
-- ==============================
INSERT INTO tblChiTietHD VALUES
('HD001', 'SP001', 2),
('HD001', 'SP002', 5),
('HD002', 'SP003', 10),
('HD003', 'SP004', 1),
('HD004', 'SP005', 3),
('HD005', 'SP006', 4);
GO

-- ==============================
-- DỮ LIỆU MẪU: tblTaiKhoan
-- ==============================
INSERT INTO tblTaiKhoan VALUES
('adminA', '123456', 'NV001'),
('userB', 'passwordB', 'NV002'),
('userC', 'passwordC', 'NV003'),
('userD', 'passwordD', 'NV004'),
('userE', 'passwordE', 'NV005');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblPhieuNhap
-- ==============================
INSERT INTO tblPhieuNhap VALUES
('PN001', 'NV003', '2024-06-28', N'Nhập đầu kỳ'),
('PN002', 'NV003', '2024-07-01', N'Nhập thêm vở'),
('PN003', 'NV002', '2024-07-02', N'Nhập bút mực'),
('PN004', 'NV004', '2024-07-03', N'Nhập truyện mới'),
('PN005', 'NV001', '2024-07-04', N'Nhập sách giáo khoa');
GO

-- ==============================
-- DỮ LIỆU MẪU: tblChiTietPN
-- ==============================
INSERT INTO tblChiTietPN VALUES
('PN001', 'SP001', 30),
('PN002', 'SP002', 50),
('PN003', 'SP006', 60),
('PN004', 'SP001', 20),
('PN005', 'SP004', 25);
GO


CREATE OR ALTER VIEW vvSach AS
SELECT 
    s.sMaSP AS [Mã sách],
    sp.sTenSP AS [Tên sách],
    dv.sTenDV AS [Đơn vị sản xuất],
    s.sTacgia AS [Tác giả],
    s.sTheloai AS [Thể loại],
	sp.iGiaNhap AS [Giá nhập],
    sp.iGiaBan AS [Giá bán],
    sp.iSL AS [Số lượng],
    s.iNamXB AS [Năm xuất bản]
FROM tblSach s
JOIN tblSanPham sp ON s.sMaSP = sp.sMaSP
LEFT JOIN tblDonViSanXuat dv ON s.sMaDV = dv.sMaDV
WHERE sp.sLoai = N'Sách'
;
GO
select * from tblSach
CREATE OR ALTER PROCEDURE prThemSach
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @sTacgia NVARCHAR(50),
    @sTheloai NVARCHAR(50),
    @iNamXB INT,
    @sMaDV VARCHAR(5)
AS
BEGIN
    INSERT INTO tblSanPham (sMaSP, sTenSP, iGiaNhap, iGiaBan, iSL, sLoai)
    VALUES (@sMaSP, @sTenSP, @iGiaNhap, @iGiaBan, @iSL, N'Sách');

    INSERT INTO tblSach (sMaSP, sTacgia, sTheloai, iNamXB, sMaDV)
    VALUES (@sMaSP, @sTacgia, @sTheloai, @iNamXB, @sMaDV);
END;
GO

CREATE OR ALTER PROCEDURE prSuaSach
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @sTacgia NVARCHAR(50),
    @sTheloai NVARCHAR(50),
    @iNamXB INT,
    @sMaDV VARCHAR(5)
AS
BEGIN
    UPDATE tblSanPham
    SET sTenSP = @sTenSP,
        iGiaNhap = @iGiaNhap,
        iGiaBan = @iGiaBan,
        iSL = @iSL
    WHERE sMaSP = @sMaSP;

    UPDATE tblSach
    SET sTacgia = @sTacgia,
        sTheloai = @sTheloai,
        iNamXB = @iNamXB,
        sMaDV = @sMaDV
    WHERE sMaSP = @sMaSP;
END;
GO

CREATE OR ALTER PROCEDURE prXoaSach
    @sMaSP VARCHAR(5)
AS
BEGIN
    DELETE FROM tblSanPham WHERE sMaSP = @sMaSP;
END;
GO

select * from tblVo

CREATE OR ALTER PROCEDURE prThemVo
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @iSoTrang INT,
    @sKieuDongKe NVARCHAR(30),
    @sMaDV VARCHAR(5)
AS
BEGIN
    -- Thêm vào bảng sản phẩm
    INSERT INTO tblSanPham (sMaSP, sTenSP, iGiaNhap, iGiaBan, iSL, sLoai)
    VALUES (@sMaSP, @sTenSP, @iGiaNhap, @iGiaBan, @iSL, N'Vở');

    -- Thêm vào bảng vở
    INSERT INTO tblVo (sMaSP, iSoTrang, sKieuDongKe, sMaDV)
    VALUES (@sMaSP, @iSoTrang, @sKieuDongKe, @sMaDV);
END;
GO
CREATE OR ALTER PROCEDURE prSuaVo
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @iSoTrang INT,
    @sKieuDongKe NVARCHAR(30),
    @sMaDV VARCHAR(5)
AS
BEGIN
    -- Cập nhật bảng sản phẩm
    UPDATE tblSanPham
    SET sTenSP = @sTenSP,
        iGiaNhap = @iGiaNhap,
        iGiaBan = @iGiaBan,
        iSL = @iSL
    WHERE sMaSP = @sMaSP;

    -- Cập nhật bảng vở
    UPDATE tblVo
    SET iSoTrang = @iSoTrang,
        sKieuDongKe = @sKieuDongKe,
        sMaDV = @sMaDV
    WHERE sMaSP = @sMaSP;
END;
GO
CREATE OR ALTER PROCEDURE prXoaVo
    @sMaSP VARCHAR(5)
AS
BEGIN
    DELETE FROM tblSanPham WHERE sMaSP = @sMaSP;
END;
GO
CREATE OR ALTER VIEW vvVo AS
SELECT 
    v.sMaSP AS [Mã vở],
    sp.sTenSP AS [Tên vở],
    dv.sTenDV AS [Đơn vị sản xuất],
    v.iSoTrang AS [Số trang],
    v.sKieuDongKe AS [Kiểu dòng kẻ],
    sp.iGiaNhap AS [Giá nhập],
    sp.iGiaBan AS [Giá bán],
    sp.iSL AS [Số lượng]
FROM tblVo v
JOIN tblSanPham sp ON v.sMaSP = sp.sMaSP
LEFT JOIN tblDonViSanXuat dv ON v.sMaDV = dv.sMaDV
WHERE sp.sLoai = N'Vở';
GO
select * from tblSanPham


CREATE OR ALTER VIEW vvBut AS
SELECT 
    b.sMaSP AS [Mã bút],
    sp.sTenSP AS [Tên bút],
    dv.sTenDV AS [Đơn vị sản xuất],
    b.sLoaiBut AS [Loại bút],
	b.sMauBut as [Màu bút],
    sp.iGiaNhap AS [Giá nhập],
    sp.iGiaBan AS [Giá bán],
    sp.iSL AS [Số lượng]
FROM tblBut b
JOIN tblSanPham sp ON b.sMaSP = sp.sMaSP
LEFT JOIN tblDonViSanXuat dv ON b.sMaDV = dv.sMaDV
WHERE sp.sLoai = N'Bút';
GO

select * from vvBut

CREATE OR ALTER PROCEDURE prThemBut
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @sLoaiBut NVARCHAR(30),
    @sMauBut NVARCHAR(30),
    @sMaDV VARCHAR(5)
AS
BEGIN
    -- Thêm vào bảng sản phẩm
    INSERT INTO tblSanPham (sMaSP, sTenSP, iGiaNhap, iGiaBan, iSL, sLoai)
    VALUES (@sMaSP, @sTenSP, @iGiaNhap, @iGiaBan, @iSL, N'Bút');

    -- Thêm vào bảng bút
    INSERT INTO tblBut (sMaSP, sLoaiBut, sMauBut, sMaDV)
    VALUES (@sMaSP, @sLoaiBut, @sMauBut, @sMaDV);
END;
GO

CREATE OR ALTER PROCEDURE prSuaBut
    @sMaSP VARCHAR(5),
    @sTenSP NVARCHAR(50),
    @iGiaNhap INT,
    @iGiaBan INT,
    @iSL INT,
    @sLoaiBut NVARCHAR(30),
    @sMauBut NVARCHAR(30),
    @sMaDV VARCHAR(5)
AS
BEGIN
    -- Cập nhật bảng sản phẩm
    UPDATE tblSanPham
    SET sTenSP = @sTenSP,
        iGiaNhap = @iGiaNhap,
        iGiaBan = @iGiaBan,
        iSL = @iSL
    WHERE sMaSP = @sMaSP;

    -- Cập nhật bảng bút
    UPDATE tblBut
    SET sLoaiBut = @sLoaiBut,
        sMauBut = @sMauBut,
        sMaDV = @sMaDV
    WHERE sMaSP = @sMaSP;
END;
GO
CREATE OR ALTER PROCEDURE prXoaBut
    @sMaSP VARCHAR(5)
AS
BEGIN
    -- Xóa khỏi bảng cha (tblSanPham), sẽ tự động xóa từ tblBut nhờ ON DELETE CASCADE
    DELETE FROM tblSanPham WHERE sMaSP = @sMaSP;
END;
GO

CREATE OR ALTER PROCEDURE TK_Sach_NXB
AS
BEGIN
    SELECT 
        dv.sTenDV AS [Tên NXB],
        COUNT(s.sMaSP) AS [Số lượng sách]
    FROM tblSach s
    JOIN tblSanPham sp ON s.sMaSP = sp.sMaSP
    LEFT JOIN tblDonViSanXuat dv ON s.sMaDV = dv.sMaDV
    GROUP BY dv.sTenDV
END;
GO

select * from tblSach
select * from vvSach
select * from tblSanPham

select * from tblVo

CREATE PROCEDURE sp_ThongKeNhanVienTheoGioiTinh
AS
BEGIN
    SELECT GioiTinh, COUNT(*) AS SoLuong
    FROM NhanVien
    GROUP BY GioiTinh;
END;
