-- Step 1: Create and use the database
CREATE DATABASE db_quan_ly_ban_sach;
USE db_quan_ly_ban_sach;

-- Step 2: Create tables in the correct order

CREATE TABLE tbl_users (
    user_id INT PRIMARY KEY IDENTITY(1,1),    
    username NVARCHAR(50) NOT NULL UNIQUE,    
    password NVARCHAR(256) NOT NULL          
);

-- Create tbl_loai_sach
CREATE TABLE tbl_loai_sach (
    ma_loai_sach INT IDENTITY(1,1) PRIMARY KEY,
    ten_loai_sach NVARCHAR(256) NOT NULL
);

-- Create tbl_sach
CREATE TABLE tbl_sach (
    ma_sach INT IDENTITY(1,1) PRIMARY KEY,
    ten_sach NVARCHAR(256) NOT NULL,
    ma_loai_sach INT NOT NULL,
    tac_gia NVARCHAR(256),
    gia_ban FLOAT,
    CONSTRAINT fk_sach_ma_loai_sach FOREIGN KEY(ma_loai_sach) 
    REFERENCES tbl_loai_sach(ma_loai_sach) ON DELETE CASCADE
);

-- Create tbl_hoa_don
CREATE TABLE tbl_hoa_don (
    ma_hoa_don INT IDENTITY(1,1) PRIMARY KEY,
    ngay_lap_hoa_don DATETIME NOT NULL,
    ten_khach_hang NVARCHAR(150) NOT NULL,
    sdt_khach_hang NVARCHAR(20) NOT NULL,
	so_luong INT NOT NULL,
	ma_sach INT NOT NULL,
	thanh_tien FLOAT
);


-- Create tbl_chi_tiet_hoa_don
CREATE TABLE tbl_chi_tiet_hoa_don (
    ma_hoa_don INT NOT NULL,
    ma_sach INT NOT NULL,
    so_luong INT NOT NULL,
    PRIMARY KEY(ma_hoa_don, ma_sach),
    CONSTRAINT fk_tbl_chi_tiet_hoa_don_ma_sach FOREIGN KEY(ma_sach) 
    REFERENCES tbl_sach(ma_sach) ON DELETE CASCADE,
    CONSTRAINT fk_tbl_chi_tiet_hoa_don_ma_hoa_don FOREIGN KEY(ma_hoa_don) 
    REFERENCES tbl_hoa_don(ma_hoa_don) ON DELETE CASCADE
);

-- Create tbl_phieu_nhap
CREATE TABLE tbl_phieu_nhap (
    ma_phieu_nhap INT IDENTITY(1,1) PRIMARY KEY,
    ngay_lap_phieu_nhap DATETIME NOT NULL,
    ma_nha_phan_phoi INT,  -- Khóa ngoại
    ten_nha_phan_phoi NVARCHAR(150),  -- Cột thông thường
    CONSTRAINT fk_phieu_nhap_nha_phan_phoi FOREIGN KEY (ma_nha_phan_phoi)
    REFERENCES tbl_nha_phan_phoi(ma_nha_phan_phoi) ON DELETE CASCADE
);

-- Create tbl_chi_tiet_phieu_nhap
CREATE TABLE tbl_chi_tiet_phieu_nhap (
    ma_phieu_nhap INT NOT NULL,
    ma_sach INT NOT NULL,
    so_luong INT NOT NULL,
	gia_nhap FLOAT NOT NULL,  -- Giá nhập của mỗi cuốn sách
    thanh_tien AS (so_luong * gia_nhap) PERSISTED,
    PRIMARY KEY(ma_phieu_nhap, ma_sach),
    CONSTRAINT fk_tbl_chi_tiet_phieu_nhap_ma_sach FOREIGN KEY(ma_sach) 
    REFERENCES tbl_sach(ma_sach) ON DELETE CASCADE,
    CONSTRAINT fk_tbl_chi_tiet_phieu_nhap_ma_phieu_nhap FOREIGN KEY(ma_phieu_nhap) 
    REFERENCES tbl_phieu_nhap(ma_phieu_nhap) ON DELETE CASCADE
);

-- Create tbl_nha_phan_phoi
CREATE TABLE tbl_nha_phan_phoi (
    ma_nha_phan_phoi INT PRIMARY KEY,
    ten_nha_phan_phoi NVARCHAR(256) NOT NULL,
    dia_chi NVARCHAR(256),
    so_dien_thoai VARCHAR(20)
);

-- Create tbl_kho_hang
CREATE TABLE tbl_kho_hang (
    ma_kho INT IDENTITY(1,1) PRIMARY KEY,
    ma_sach INT NOT NULL,
    -- so_luong_trong_kho INT NOT NULL,
    -- vi_tri NVARCHAR(256),
    CONSTRAINT fk_kho_hang_ma_sach FOREIGN KEY(ma_sach) 
    REFERENCES tbl_sach(ma_sach) ON DELETE CASCADE
);


USE master;  -- Chuyển về cơ sở dữ liệu master
ALTER DATABASE db_quan_ly_ban_sach SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

DROP DATABASE db_quan_ly_ban_sach;

DROP TABLE IF EXISTS tbl_chi_tiet_phieu_nhap;
DROP TABLE IF EXISTS tbl_phieu_nhap;
DROP TABLE IF EXISTS tbl_chi_tiet_hoa_don;
DROP TABLE IF EXISTS tbl_hoa_don;
DROP TABLE IF EXISTS tbl_kho_hang;
DROP TABLE IF EXISTS tbl_sach;
DROP TABLE IF EXISTS tbl_loai_sach;
DROP TABLE IF EXISTS tbl_nha_phan_phoi;



-- Step 3: Insert initial data into tbl_loai_sach
-- Chèn dữ liệu vào bảng tbl_loai_sach (bỏ cột ma_loai_sach)
INSERT INTO tbl_loai_sach (ten_loai_sach) VALUES 
(N'Văn học'),
(N'Khoa học'),
(N'Tiểu thuyết'),
(N'Truyện thiếu nhi');

-- Chèn dữ liệu vào bảng tbl_sach (bỏ cột ma_sach)
INSERT INTO tbl_sach (ten_sach, ma_loai_sach, tac_gia, gia_ban) VALUES 
(N'Tắt đèn', 1, N'Ngô Tất Tố', 55000),
(N'Lược sử thời gian', 2, N'Stephen Hawking', 120000),
(N'Harry Potter và Hòn đá Phù thủy', 3, N'J.K. Rowling', 150000),
(N'Dế Mèn phiêu lưu ký', 4, N'Tô Hoài', 45000);

-- Chèn dữ liệu vào bảng tbl_hoa_don (bỏ cột ma_hoa_don)
INSERT INTO tbl_hoa_don (ngay_lap_hoa_don, ten_khach_hang, sdt_khach_hang) VALUES 
('2024-10-01', N'Nguyễn Văn An', '0912345678'),
('2024-10-02', N'Trần Thị Bình', '0987654321');

-- Chèn dữ liệu vào bảng tbl_chi_tiet_hoa_don
INSERT INTO tbl_chi_tiet_hoa_don (ma_hoa_don, ma_sach, so_luong) VALUES 
(1, 1, 2),
(1, 2, 1),
(2, 3, 3);

-- Chèn dữ liệu vào bảng tbl_phieu_nhap
INSERT INTO tbl_phieu_nhap (ngay_lap_phieu_nhap, ten_nha_phan_phoi) VALUES 
('2024-09-28', N'Nhà xuất bản Kim Ðồng'),
('2024-09-30', N'Nhà xuất bản Trẻ');

-- Chèn dữ liệu vào bảng tbl_chi_tiet_phieu_nhap
INSERT INTO tbl_chi_tiet_phieu_nhap (ma_phieu_nhap, ma_sach, so_luong) VALUES 
(1, 4, 50),
(1, 1, 30),
(2, 2, 20);

SET IDENTITY_INSERT tbl_nha_phan_phoi ON;

INSERT INTO tbl_nha_phan_phoi (ma_nha_phan_phoi, ten_nha_phan_phoi, dia_chi, so_dien_thoai) VALUES 
(1, N'Nhà phân phối A', N'123 Đường A, Quận 1, TP HCM', '0901123456'),
(2, N'Nhà phân phối B', N'456 Đường B, Quận 2, TP HCM', '0912123456');

SET IDENTITY_INSERT tbl_nha_phan_phoi OFF;

-- Insert data into tbl_kho_hang
INSERT INTO tbl_kho_hang (ma_sach, so_luong_trong_kho, vi_tri) VALUES 
(1, 100, N'Kệ 1'),
(2, 150, N'Kệ 2'),
(3, 200, N'Kệ 3'),
(4, 50, N'Kệ 4')


-- Step 4: Create stored procedures

-- Stored procedure to add a record to tbl_loai_sach
CREATE PROC proc_them_loai_sach
@tenLoaiSach NVARCHAR(256)
AS
BEGIN
    INSERT INTO tbl_loai_sach(ten_loai_sach) 
    VALUES(@tenLoaiSach);
END;

-- Stored procedure to update a record in tbl_loai_sach
CREATE PROC proc_cap_nhat_loai_sach
@maLoaiSach INT, @tenLoaiSach NVARCHAR(256)
AS
BEGIN
    UPDATE tbl_loai_sach
    SET ten_loai_sach = @tenLoaiSach
    WHERE ma_loai_sach = @maLoaiSach;
END;

-- Stored procedure to add a record to tbl_sach
CREATE PROC proc_them_sach
@tenSach NVARCHAR(256), @maLoaiSach INT, @tacGia NVARCHAR(256), @soLuong INT, @giaBan FLOAT
AS
BEGIN
    INSERT INTO tbl_sach(ten_sach, ma_loai_sach, tac_gia, so_luong, gia_ban)
    VALUES(@tenSach, @maLoaiSach, @tacGia, @soLuong, @giaBan);
END;

-- Stored procedure to update a record in tbl_sach
CREATE PROC proc_cap_nhat_sach
@maSach INT, @tenSach NVARCHAR(256), @maLoaiSach INT, @tacGia NVARCHAR(256), @soLuong INT, @giaBan FLOAT
AS
BEGIN
    UPDATE tbl_sach
    SET ten_sach = @tenSach, ma_loai_sach = @maLoaiSach, tac_gia = @tacGia, so_luong = @soLuong, gia_ban = @giaBan
    WHERE ma_sach = @maSach;
END;

-- Stored procedure to add a record to tbl_hoa_don
CREATE PROC proc_them_hoa_don
@ngayLapHoaDon DATETIME, @tenKhachHang VARCHAR(30), @sdtKhachHang VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_hoa_don(ngay_lap_hoa_don, ten_khach_hang, sdt_khach_hang)
    VALUES (@ngayLapHoaDon, @tenKhachHang, @sdtKhachHang);
END;

-- Stored procedure to update a record in tbl_hoa_don
CREATE PROC proc_cap_nhat_hoa_don
@maHoaDon INT, @ngayLapHoaDon DATETIME, @tenKhachHang VARCHAR(30), @sdtKhachHang VARCHAR(20)
AS
BEGIN
    UPDATE tbl_hoa_don
    SET ngay_lap_hoa_don = @ngayLapHoaDon, 
        ten_khach_hang = @tenKhachHang, 
        sdt_khach_hang = @sdtKhachHang
    WHERE ma_hoa_don = @maHoaDon;
END;

-- Stored procedure to add a record to tbl_chi_tiet_hoa_don
CREATE PROC proc_them_chi_tiet_hoa_don
@maHoaDon INT, @maSach INT, @soLuong INT
AS
BEGIN
    INSERT INTO tbl_chi_tiet_hoa_don(ma_hoa_don, ma_sach, so_luong)
    VALUES(@maHoaDon, @maSach, @soLuong);
END;

-- Stored procedure to update a record in tbl_chi_tiet_hoa_don
CREATE PROC proc_cap_nhat_chi_tiet_hoa_don
@maHoaDon INT, @maSach INT, @soLuong INT
AS
BEGIN
    UPDATE tbl_chi_tiet_hoa_don
    SET so_luong = @soLuong
    WHERE ma_hoa_don = @maHoaDon AND ma_sach = @maSach;
END;

-- Stored procedure to add a record to tbl_phieu_nhap
CREATE PROC proc_them_phieu_nhap
@ngayLapPhieuNhap DATETIME, @tenNhaCungCap NVARCHAR(30)
AS
BEGIN
    INSERT INTO tbl_phieu_nhap (ngay_lap_phieu_nhap, ten_nha_phan_phoi)
    VALUES (@ngayLapPhieuNhap, @tenNhaCungCap);
END;

-- Stored procedure to update a record in tbl_phieu_nhap
CREATE PROC proc_cap_nhat_phieu_nhap
@maPhieuNhap INT, @ngayLapPhieuNhap DATETIME, @tenNhaCungCap NVARCHAR(30)
AS
BEGIN
    UPDATE tbl_phieu_nhap
    SET ngay_lap_phieu_nhap = @ngayLapPhieuNhap, 
        ten_nha_phan_phoi = @tenNhaCungCap
    WHERE ma_phieu_nhap = @maPhieuNhap;
END;

-- Stored procedure to add a record to tbl_chi_tiet_phieu_nhap
CREATE PROC proc_them_chi_tiet_phieu_nhap
@maPhieuNhap INT, @maSach INT, @soLuong INT
AS
BEGIN
    INSERT INTO tbl_chi_tiet_phieu_nhap(ma_phieu_nhap, ma_sach, so_luong)
    VALUES(@maPhieuNhap, @maSach, @soLuong);
END;

-- Stored procedure to update a record in tbl_chi_tiet_phieu_nhap
CREATE PROC proc_cap_nhat_chi_tiet_phieu_nhap
@maPhieuNhap INT, @maSach INT, @soLuong INT
AS
BEGIN
    UPDATE tbl_chi_tiet_phieu_nhap
    SET so_luong = @soLuong
    WHERE ma_phieu_nhap = @maPhieuNhap AND ma_sach = @maSach;
END;

--?????
-- Stored procedure to add a record to tbl_nha_phan_phoi
CREATE PROC proc_them_nha_phan_phoi
@tenNhaPhanPhoi NVARCHAR(256), @diaChi NVARCHAR(256), @sdt VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_nha_phan_phoi(ten_nha_phan_phoi, dia_chi, so_dien_thoai)
    VALUES(@tenNhaPhanPhoi, @diaChi, @sdt);
END;

--DROP PROCEDURE IF EXISTS proc_cap_nhat_kho_hang;

-- Stored procedure to update a record in tbl_nha_phan_phoi
CREATE PROC proc_cap_nhat_nha_phan_phoi
@maNhaPhanPhoi INT, @tenNhaPhanPhoi NVARCHAR(256), @diaChi NVARCHAR(256), @sdt VARCHAR(20)
AS
BEGIN
    UPDATE tbl_nha_phan_phoi
    SET ten_nha_phan_phoi = @tenNhaPhanPhoi, 
        dia_chi = @diaChi, 
        so_dien_thoai = @sdt
    WHERE ma_nha_phan_phoi = @maNhaPhanPhoi;
END;

-- Stored procedure to delete a record from tbl_nha_phan_phoi
CREATE PROC proc_xoa_nha_phan_phoi
@maNhaPhanPhoi INT
AS
BEGIN
    DELETE FROM tbl_nha_phan_phoi 
    WHERE ma_nha_phan_phoi = @maNhaPhanPhoi;
END;

-- Stored procedure to add a record to tbl_kho_hang
-- Stored procedure to add a record to tbl_kho_hang
CREATE PROC proc_them_kho_hang
    @maSach INT,                     -- Tham số để thêm mã sách
    @soLuongTrongKho INT,            -- Tham số để thêm số lượng trong kho
    @viTri NVARCHAR(256)             -- Tham số để thêm vị trí
AS
BEGIN
    INSERT INTO tbl_kho_hang(ma_sach, so_luong_trong_kho, vi_tri)  -- Chỉ định các cột cần thêm
    VALUES(@maSach, @soLuongTrongKho, @viTri);                      -- Chèn các tham số vào bảng
END;

-- Stored procedure to update a record in tbl_kho_hang
CREATE PROC proc_cap_nhat_kho_hang
    @maKho INT,                      -- Mã kho để xác định bản ghi cần cập nhật
    @maSach INT,                     -- Mã sách cần cập nhật
    @soLuongTrongKho INT,            -- Số lượng trong kho cần cập nhật
    @viTri NVARCHAR(256)             -- Vị trí cần cập nhật
AS
BEGIN
    UPDATE tbl_kho_hang
    SET ma_sach = @maSach,                  -- Cập nhật mã sách
        so_luong_trong_kho = @soLuongTrongKho,  -- Cập nhật số lượng trong kho
        vi_tri = @viTri                     -- Cập nhật vị trí
    WHERE ma_kho = @maKho;                  -- Điều kiện để xác định bản ghi cần cập nhật
END;

-- Stored procedure to delete a record from tbl_kho_hang
CREATE PROC proc_xoa_kho_hang
    @maKho INT  -- Mã kho cần xóa
AS
BEGIN
    DELETE FROM tbl_kho_hang
    WHERE ma_kho = @maKho;  -- Điều kiện để xác định bản ghi cần xóa
END;
