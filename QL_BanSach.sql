-- ==============================
-- TẠO DATABASE
-- ==============================
CREATE DATABASE BookStoreManagement;
GO

USE BookStoreManagement;
GO

-- ==============================
-- TẠO CÁC BẢNG
-- ==============================

-- 1. Bảng Nhân Viên
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

-- 2. Bảng Khách Hàng
CREATE TABLE tblKhachHang (
    sMaKH VARCHAR(5) PRIMARY KEY,
    sTenKH NVARCHAR(60) NOT NULL,
    sDiachi NVARCHAR(25) NOT NULL,
    sSDT VARCHAR(11) NOT NULL
);
GO

-- 3. Bảng Nhà Xuất Bản
CREATE TABLE tblNXB (
    sMaNXB VARCHAR(5) PRIMARY KEY,
    sTenNXB NVARCHAR(60) NOT NULL,
    sDiachi NVARCHAR(25),
    sSDT VARCHAR(11)
);
GO

-- 4. Bảng Sách
CREATE TABLE tblSach (
    sMasach VARCHAR(5) PRIMARY KEY,
    sTensach NVARCHAR(25) NOT NULL,
    sMaNXB VARCHAR(5) NOT NULL REFERENCES tblNXB(sMaNXB),
    sTacgia NVARCHAR(25) NOT NULL,
    sTheloai NVARCHAR(30),
    iGia INT CHECK (iGia > 0),
    iSL INT CHECK (iSL > 0),
    iNamXB INT
);
GO

-- 5. Bảng Hóa Đơn
CREATE TABLE tblHoaDon (
    sMaHD VARCHAR(5) PRIMARY KEY,
    sMaNV VARCHAR(5) NOT NULL REFERENCES tblNhanVien(sMaNV),
    sMaKH VARCHAR(5) NOT NULL REFERENCES tblKhachHang(sMaKH),
    dNgaylap DATE CHECK (dNgaylap <= GETDATE()),
    sTrangthai NVARCHAR(20) CHECK (sTrangthai IN (N'Đã thanh toán', N'Chưa thanh toán')) DEFAULT N'Chưa thanh toán'
);
GO

-- 6. Bảng Chi Tiết Hóa Đơn
CREATE TABLE tblChiTietHD (
    sMaHD VARCHAR(5) REFERENCES tblHoaDon(sMaHD) ON DELETE CASCADE,
    sMasach VARCHAR(5) REFERENCES tblSach(sMasach) ON DELETE CASCADE,
    iSL INT NOT NULL CHECK (iSL > 0),
    CONSTRAINT pk_CTHD PRIMARY KEY (sMaHD, sMasach)
);
GO

-- 7. Bảng Tài Khoản
CREATE TABLE tblTaiKhoan (
    sTenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    sMatKhau VARCHAR(255) NOT NULL,
    sMaNV VARCHAR(5) REFERENCES tblNhanVien(sMaNV),
    CONSTRAINT pk_TK PRIMARY KEY (sMaNV)
);
GO

-- ==============================
-- CHÈN DỮ LIỆU MẪU
-- ==============================

-- Nhân viên
INSERT INTO tblNhanVien VALUES
('NV01', N'Nguyễn Văn An', '1995-03-15', N'Nam', N'Hà Nội', '0912345678', N'Nhân viên', '2020-01-10'),
('NV02', N'Trần Thị Bích', '1992-07-22', N'Nữ', N'Hải Phòng', '0987654321', N'Quản lý', '2018-05-20'),
('NV03', N'Phạm Minh Khoa', '1990-11-01', N'Nam', N'Nghệ An', '0933333333', N'Nhân viên', '2017-09-15'),
('NV04', N'Lê Thị Hồng', '1998-02-20', N'Nữ', N'Huế', '0944444444', N'Nhân viên', '2021-06-01'),
('NV05', N'Hoàng Văn Dũng', '1988-08-30', N'Nam', N'Hà Nam', '0955555555', N'Thủ kho', '2015-03-30');
GO

-- Khách hàng
INSERT INTO tblKhachHang VALUES
('KH01', N'Lê Minh Tuấn', N'Bắc Ninh', '0901111222'),
('KH02', N'Phạm Hồng Nhung', N'TP.HCM', '0933444555'),
('KH03', N'Trịnh Thị Thảo', N'Ninh Bình', '0966666666'),
('KH04', N'Ngô Văn Nam', N'Thanh Hóa', '0977777777'),
('KH05', N'Đặng Huy Hoàng', N'Đà Nẵng', '0988888888');
GO

-- Nhà xuất bản
INSERT INTO tblNXB VALUES
('NX01', N'NXB Kim Đồng', N'Hà Nội', '0241234567'),
('NX02', N'NXB Trẻ', N'TP.HCM', '0282345678'),
('NX03', N'NXB Giáo Dục', N'Đà Nẵng', '0236456456');
GO

-- Sách
INSERT INTO tblSach VALUES
('S001', N'Đắc Nhân Tâm', 'NX01', N'Dale Carnegie', N'Kỹ năng sống', 80000, 50, 2020),
('S002', N'Toán Học Ứng Dụng', 'NX02', N'Nguyễn Văn A', N'Giáo trình', 95000, 20, 2021),
('S003', N'Cuộc đời Steve Jobs', 'NX01', N'Walter Isaacson', N'Tiểu sử', 120000, 15, 2019),
('S004', N'Lập Trình C#', 'NX03', N'Lê Quang Minh', N'Giáo trình', 110000, 25, 2022),
('S005', N'Mắt Biếc', 'NX02', N'Nguyễn Nhật Ánh', N'Truyện dài', 70000, 40, 2023);
GO

-- Hóa đơn
INSERT INTO tblHoaDon VALUES
('HD01', 'NV01', 'KH01', '2025-06-01', N'Đã thanh toán'),
('HD02', 'NV02', 'KH02', '2025-06-02', N'Chưa thanh toán'),
('HD03', 'NV03', 'KH03', '2025-06-03', N'Đã thanh toán'),
('HD04', 'NV04', 'KH04', '2025-06-03', N'Đã thanh toán'),
('HD05', 'NV01', 'KH05', '2025-06-04', N'Chưa thanh toán');
GO

-- Chi tiết hóa đơn
INSERT INTO tblChiTietHD VALUES
('HD01', 'S001', 2),
('HD01', 'S002', 1),
('HD02', 'S003', 1),
('HD03', 'S002', 2),
('HD03', 'S005', 1),
('HD04', 'S004', 1),
('HD05', 'S001', 1),
('HD05', 'S005', 2);
GO

-- Tài khoản
INSERT INTO tblTaiKhoan VALUES
('an.nguyen', 'matkhau123', 'NV01'),
('bich.tran', '12345678', 'NV02'),
('khoa.pham', 'abc12345', 'NV03'),
('hong.le', 'hong2024', 'NV04'),
('dung.hoang', 'dungvip', 'NV05');
GO

-- ==============================
-- TẠO VIEW
-- ==============================
CREATE VIEW vvSach AS
SELECT 
    s.sMasach AS [Mã sách],
    s.sTensach AS [Tên sách],
    n.sTenNXB AS [Nhà xuất bản],
    s.sTacgia AS [Tác giả],
    s.sTheloai AS [Thể loại],
    s.iGia AS [Giá],
    s.iSL AS [Số lượng],
    s.iNamXB AS [Năm xuất bản]
FROM tblSach s
JOIN tblNXB n ON s.sMaNXB = n.sMaNXB;
GO

-- ==============================
-- STORE PROCEDURES
-- ==============================

-- Thêm sách
CREATE PROCEDURE ThemSach
    @sMasach VARCHAR(5),
    @sTensach NVARCHAR(25),
    @sMaNXB VARCHAR(5),
    @sTacgia NVARCHAR(25),
    @sTheloai NVARCHAR(30),
    @iGia INT,
    @iSL INT,
    @iNamXB INT
AS
BEGIN
    INSERT INTO tblSach
    VALUES (@sMasach, @sTensach, @sMaNXB, @sTacgia, @sTheloai, @iGia, @iSL, @iNamXB);
END;
GO

-- Sửa sách
CREATE PROCEDURE SuaSach
    @sMasach VARCHAR(5),
    @sTensach NVARCHAR(25),
    @sMaNXB VARCHAR(5),
    @sTacgia NVARCHAR(25),
    @sTheloai NVARCHAR(30),
    @iGia INT,
    @iSL INT,
    @iNamXB INT
AS
BEGIN
    UPDATE tblSach
    SET sTensach = @sTensach,
        sMaNXB = @sMaNXB,
        sTacgia = @sTacgia,
        sTheloai = @sTheloai,
        iGia = @iGia,
        iSL = @iSL,
        iNamXB = @iNamXB
    WHERE sMasach = @sMasach;
END;
GO

-- Xóa sách
CREATE PROCEDURE XoaSach
    @sMasach VARCHAR(5)
AS
BEGIN
    DELETE FROM tblSach WHERE sMasach = @sMasach;
END;
GO

-- Tìm kiếm sách theo tên
CREATE PROCEDURE TimKiemSachTheoTen
    @TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT 
        s.sMasach AS [Mã sách],
        s.sTensach AS [Tên sách],
        n.sTenNXB AS [Nhà xuất bản],
        s.sTacgia AS [Tác giả],
        s.sTheloai AS [Thể loại],
        s.iGia AS [Giá],
        s.iSL AS [Số lượng],
        s.iNamXB AS [Năm xuất bản]
    FROM tblSach s
    JOIN tblNXB n ON s.sMaNXB = n.sMaNXB
    WHERE s.sTensach LIKE N'%' + @TuKhoa + '%';
END;
GO

-- Cập nhật thông tin nhân viên
CREATE PROCEDURE sp_UpdateNhanVienTheoMa
    @MaNV NVARCHAR(10),
    @TenNV NVARCHAR(50),
    @ChucVu NVARCHAR(50),
    @GioiTinh NVARCHAR(10),
    @QueQuan NVARCHAR(100),
    @SDT NVARCHAR(15),
    @NgaySinh DATE,
    @NgayVaoLam DATE
AS
BEGIN
    UPDATE tblNhanVien
    SET sTenNV = @TenNV,
        sChucVu = @ChucVu,
        sGioitinh = @GioiTinh,
        sQuequan = @QueQuan,
        sSDT = @SDT,
        dNgaysinh = @NgaySinh,
        dNgayvaolam = @NgayVaoLam
    WHERE sMaNV = @MaNV;
END;
GO

-- Cập nhật mật khẩu
CREATE PROCEDURE sp_UpdateMatKhauTheoMaNV
    @MaNV VARCHAR(5),
    @MatKhau VARCHAR(255)
AS
BEGIN
    UPDATE tblTaiKhoan
    SET sMatKhau = @MatKhau
    WHERE sMaNV = @MaNV;
END;
GO

-- Thống kê số sách theo NXB
CREATE PROCEDURE TK_Sach_NXB
AS
BEGIN
    SELECT 
        n.sTenNXB AS [Tên NXB],
        COUNT(s.sMasach) AS [Số lượng sách]
    FROM tblNXB n
    LEFT JOIN tblSach s ON s.sMaNXB = n.sMaNXB
    GROUP BY n.sTenNXB;
END;
GO

-- Thêm nhân viên
CREATE PROCEDURE pr_ThemNhanVien
    @sMaNV NVARCHAR(10),
    @sTenNV NVARCHAR(100),
    @dNgaysinh DATE,
    @sGioitinh NVARCHAR(10),
    @sQuequan NVARCHAR(100),
    @sSDT NVARCHAR(20),
    @sChucvu NVARCHAR(50),
    @dNgayvaolam DATE
AS
BEGIN
    INSERT INTO tblNhanVien
    VALUES (@sMaNV, @sTenNV, @dNgaysinh, @sGioitinh, @sQuequan, @sSDT, @sChucvu, @dNgayvaolam);
END;
GO

select * from tblChiTietHD

CREATE PROCEDURE BaoCao_DoanhThuTheoNhanVien
AS
BEGIN
    SELECT 
        nv.sMaNV, 
        nv.sTenNV, 
        COUNT(DISTINCT hd.sMaHD) AS [Số lượng hóa đơn], 
        SUM(cthd.iSL * sach.iGia) AS [Doanh thu]
    FROM tblNhanVien nv
    JOIN tblHoaDon hd ON nv.sMaNV = hd.sMaNV
    JOIN tblChiTietHD cthd ON hd.sMaHD = cthd.sMaHD
    JOIN tblSach sach ON cthd.sMasach = sach.sMasach
    GROUP BY nv.sMaNV, nv.sTenNV
END;
GO

CREATE PROCEDURE pr_ThemNXB
    @smaNXB VARCHAR(5),
    @sten NVARCHAR(60),
    @sdiachi NVARCHAR(25),
    @sSDT VARCHAR(11)
AS
BEGIN
    INSERT INTO tblNXB (sMaNXB, sTenNXB, sDiachi, sSDT)
    VALUES (@smaNXB, @sten, @sdiachi, @sSDT);
END;
GO

CREATE PROCEDURE pr_SuaNXB
    @smaNXB VARCHAR(5),
    @sten NVARCHAR(60),
    @sdiachi NVARCHAR(25),
    @sSDT VARCHAR(11)
AS
BEGIN
    UPDATE tblNXB
    SET sTenNXB = @sten,
        sDiachi = @sdiachi,
        sSDT = @sSDT
    WHERE sMaNXB = @smaNXB;
END;
GO

CREATE PROCEDURE pr_XoaNXB
    @imaNXB VARCHAR(5)
AS
BEGIN
    DELETE FROM tblNXB
    WHERE sMaNXB = @imaNXB;
END;
GO

CREATE PROCEDURE pr_TimKiemNXB
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM tblNXB
    WHERE sTenNXB LIKE N'%' + @keyword + '%';
END;
GO

CREATE PROCEDURE pr_ThemNhanVien
    @sMaNV NVARCHAR(5),
    @sTenNV NVARCHAR(100),
    @dNgaysinh DATE,
    @sGioitinh NVARCHAR(10),
    @sQuequan NVARCHAR(100),
    @sSDT NVARCHAR(20),
    @sChucvu NVARCHAR(50),
    @dNgayvaolam DATE
AS
BEGIN
    INSERT INTO tblNhanVien
    VALUES (@sMaNV, @sTenNV, @dNgaysinh, @sGioitinh, @sQuequan, @sSDT, @sChucvu, @dNgayvaolam);
END;
GO
CREATE PROCEDURE pr_SuaNhanVien
    @sMaNV NVARCHAR(5),
    @sTenNV NVARCHAR(100),
    @dNgaysinh DATE,
    @sGioitinh NVARCHAR(10),
    @sQuequan NVARCHAR(100),
    @sSDT NVARCHAR(20),
    @sChucvu NVARCHAR(50),
    @dNgayvaolam DATE
AS
BEGIN
    UPDATE tblNhanVien
    SET sTenNV = @sTenNV,
        dNgaysinh = @dNgaysinh,
        sGioitinh = @sGioitinh,
        sQuequan = @sQuequan,
        sSDT = @sSDT,
        sChucvu = @sChucvu,
        dNgayvaolam = @dNgayvaolam
    WHERE sMaNV = @sMaNV;
END;
GO
CREATE PROCEDURE pr_XoaNhanVien
    @sMaNV NVARCHAR(5)
AS
BEGIN
    DELETE FROM tblNhanVien WHERE sMaNV = @sMaNV;
END;
GO
CREATE PROCEDURE pr_TimKiemNhanVien
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM tblNhanVien
    WHERE sMaNV LIKE '%' + @keyword + '%'
       OR sTenNV LIKE N'%' + @keyword + '%'
       OR sSDT LIKE '%' + @keyword + '%';
END;
GO
CREATE PROCEDURE pr_TimKiemHoaDon
    @keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM tblHoaDon
    WHERE sMaHD LIKE '%' + @keyword + '%'
       OR sMaNV LIKE '%' + @keyword + '%'
       OR sMaKH LIKE '%' + @keyword + '%'
       OR sTrangthai LIKE N'%' + @keyword + '%'
END;
GO
CREATE PROCEDURE pr_HienThiChiTietHD
    @sMaHD VARCHAR(5)
AS
BEGIN
    SELECT 
        cthd.sMaHD AS [Mã hóa đơn],
        cthd.sMasach AS [Mã sách],
        s.sTensach AS [Tên sách],
        cthd.iSL AS [Số lượng],
        s.iGia AS [Đơn giá],
        (cthd.iSL * s.iGia) AS [Tổng tiền]
    FROM tblChiTietHD cthd
    JOIN tblSach s ON cthd.sMasach = s.sMasach
    WHERE cthd.sMaHD = @sMaHD;
END;
GO
CREATE PROCEDURE pr_ThemChiTietHD
    @sMaHD VARCHAR(5),
    @sMaSach VARCHAR(5),
    @iSL INT
AS
BEGIN
    -- Nếu đã có rồi thì cộng dồn
    IF EXISTS (SELECT 1 FROM tblChiTietHD WHERE sMaHD = @sMaHD AND sMasach = @sMaSach)
    BEGIN
        UPDATE tblChiTietHD
        SET iSL = iSL + @iSL
        WHERE sMaHD = @sMaHD AND sMasach = @sMaSach;
    END
    ELSE
    BEGIN
        INSERT INTO tblChiTietHD (sMaHD, sMasach, iSL)
        VALUES (@sMaHD, @sMaSach, @iSL);
    END
END;
GO
CREATE PROCEDURE pr_SuaChiTietHD
    @sMaHD VARCHAR(5),
    @sMaSach VARCHAR(5),
    @iSL INT
AS
BEGIN
    UPDATE tblChiTietHD
    SET iSL = @iSL
    WHERE sMaHD = @sMaHD AND sMasach = @sMaSach;
END;
GO
CREATE PROCEDURE pr_XoaChiTietHD
    @sMaHD VARCHAR(5),
    @sMaSach VARCHAR(5)
AS
BEGIN
    DELETE FROM tblChiTietHD
    WHERE sMaHD = @sMaHD AND sMasach = @sMaSach;
END;
GO

CREATE OR ALTER PROCEDURE pr_ThongKeNhanVien_TheoGioiTinh
AS
BEGIN
    SELECT sGioitinh AS [Giới tính], COUNT(*) AS [Số lượng nhân viên]
    FROM tblNhanVien
    GROUP BY sGioitinh
END
