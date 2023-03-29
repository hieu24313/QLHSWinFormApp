/* Đây là Script tạo table và chèn dữ liệu vào table, trước khi chạy script này vui lòng tạo cơ sở dữ liệu QLHS, Không copy dòng này */


/* drop table Diem, LoaiDiem, Mon, HocSinh, Lop, GiaoVien;
go */




use QLHS
go

CREATE TABLE GiaoVien (
    MaGV INT PRIMARY KEY,
    HoGV VARCHAR(50),
    TenGV VARCHAR(50),
    NgaySinh DATE,
    QueQuan VARCHAR(50),
    SoDT VARCHAR(20)
);

CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(50),
    MaGV INT,
    NamHoc VARCHAR(20),
    FOREIGN KEY (MaGV) REFERENCES GiaoVien(MaGV)
);

CREATE TABLE HocSinh (
    MaHS INT PRIMARY KEY,
    Ho VARCHAR(50),
    Ten VARCHAR(50),
    GioiTinh VARCHAR(10),
    NgaySinh DATE,
    MaLop INT,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

CREATE TABLE LoaiDiem (
    MaLoaiDiem INT PRIMARY KEY,
    Ten VARCHAR(50),
    HeSo FLOAT,
    MoTa VARCHAR(255)
);

CREATE TABLE Mon (
    MaMon INT PRIMARY KEY,
    TenMon VARCHAR(50)
);

CREATE TABLE Diem (
    MaDiem INT PRIMARY KEY,
    DiemSo FLOAT,
    MaHS INT,
    MaMon INT,
    MaLoaiDiem INT,
    FOREIGN KEY (MaHS) REFERENCES HocSinh(MaHS),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon),
    FOREIGN KEY (MaLoaiDiem) REFERENCES LoaiDiem(MaLoaiDiem)
);

/* Đây là Script tạo table và chèn dữ liệu vào table, trước khi chạy script này vui lòng tạo cơ sở dữ liệu QLHS, Không copy dòng này */


drop table Diem, LoaiDiem, Mon, HocSinh, Lop, GiaoVien;
go

use QLHS
go

CREATE TABLE GiaoVien (
    MaGV INT PRIMARY KEY,
    HoGV VARCHAR(50),
    TenGV VARCHAR(50),
    NgaySinh DATE,
    QueQuan VARCHAR(50),
    SoDT VARCHAR(20)
);

CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(50),
    MaGV INT,
    NamHoc VARCHAR(20),
    FOREIGN KEY (MaGV) REFERENCES GiaoVien(MaGV)
);

CREATE TABLE HocSinh (
    MaHS INT PRIMARY KEY,
    Ho VARCHAR(50),
    Ten VARCHAR(50),
    GioiTinh VARCHAR(10),
    NgaySinh DATE,
    MaLop INT,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

CREATE TABLE LoaiDiem (
    MaLoaiDiem INT PRIMARY KEY,
    Ten VARCHAR(50),
    HeSo FLOAT,
    MoTa VARCHAR(255)
);

CREATE TABLE Mon (
    MaMon INT PRIMARY KEY,
    TenMon VARCHAR(50)
);

CREATE TABLE Diem (
    MaDiem INT PRIMARY KEY,
    DiemSo FLOAT,
    MaHS INT,
    MaMon INT,
    MaLoaiDiem INT,
    FOREIGN KEY (MaHS) REFERENCES HocSinh(MaHS),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon),
    FOREIGN KEY (MaLoaiDiem) REFERENCES LoaiDiem(MaLoaiDiem)
);

-- Chèn dữ liệu vào bảng GiaoVien
INSERT INTO GiaoVien (MaGV, HoGV, TenGV, NgaySinh, QueQuan, SoDT)
VALUES
    (1, N'Nguyễn', N'Văn A', '1980-05-12', N'Hà Nội', '0987654321'),
    (2, N'Trần', N'Thị B', '1982-02-28', N'Hải Phòng', '0123456789'),
    (3, N'Lê', N'Quốc C', '1985-09-15', N'Hà Tĩnh', '0909090909'),
    (4, N'Phạm', N'Hồng D', '1987-11-02', N'Hưng Yên', '0912345678'),
    (5, N'Vũ', N'Thị E', '1983-04-22', N'Nam Định', '0987123456'),
    (6, N'Nguyễn', N'Đình F', '1984-08-10', N'Bắc Ninh', '0905123456'),
    (7, N'Trần', N'Thị G', '1981-03-25', N'Thanh Hóa', '0123456789'),
    (8, N'Lê', N'Quang H', '1979-06-11', N'Nghệ An', '0912345678'),
    (9, N'Phạm', N'Hồng I', '1986-10-18', N'Hải Dương', '0987123456'),
    (10, N'Vũ', N'Thị K', '1982-12-27', N'Hà Nội', '0905123456');

-- Chèn dữ liệu vào bảng Lop
INSERT INTO Lop (MaLop, TenLop, MaGV, NamHoc)
VALUES
    (1, N'Lớp 1A', 1, '2022-2023'),
    (2, N'Lớp 1B', 2, '2022-2023'),
    (3, N'Lớp 2A', 3, '2022-2023'),
    (4, N'Lớp 2B', 4, '2022-2023'),
    (5, N'Lớp 3A', 5, '2022-2023'),
    (6, N'Lớp 3B', 6, '2022-2023'),
    (7, N'Lớp 4A', 7, '2022-2023'),
    (8, N'Lớp 4B', 8, '2022-2023'),
    (9, N'Lớp 5A', 9, '2022-2023'),
    (10, N'Lớp 5B', 10, '2022-2023');

-- Chèn dữ liệu vào bảng HocSinh
INSERT INTO HocSinh (MaHS, Ho, Ten, GioiTinh, NgaySinh, MaLop)
VALUES
(1, N'Phạm Thị', N' Hà', N'Nữ','2006-01-02', 1),
(2, N'Nguyễn Văn', N' Ba', N'Nam', '2006-02-03', 2),
(3, N'Trần Thị', N' Cà', N'Nữ', '2005-03-04', 3),
(4, N'Lê Quang', N' Đạt', N'Nam', '2006-04-05', 4),
(5, N'Phạm Thị', N' Em', N'Nữ', '2006-05-06', 5),
(6, N'Vũ Thị', N' Nhi', N'Nữ', '2007-06-07', 6),
(7, N'Nguyễn Văn', N' Đạt', N'Nam', '2007-07-08', 7),
(8, N'Trần Thị', N' Hạnh', N'Nữ', '2005-08-09', 8),
(9, N'Lê Quốc', N' Hải', N'Nam', '2006-09-10', 9),
(10, N'Phạm Hồng', N' Khang', N'Nam', '2007-10-11', 10);

-- Chèn dữ liệu vào bảng LoaiDiem
INSERT INTO LoaiDiem (MaLoaiDiem, Ten, HeSo, MoTa)
VALUES
(1, N'Điểm miệng', 1, N'Điểm kiểm tra của giáo viên'),
(2, N'Điểm 15 phút', 1, N'Điểm kiểm tra của giáo viên'),
(3, N'Điểm 1 tiết', 2, N'Điểm kiểm tra của giáo viên'),
(4, N'Điểm Cuối kỳ', 3, N'Điểm kiểm tra cuối kỳ');

-- Chèn dữ liệu vào bảng Mon
INSERT INTO Mon (MaMon, TenMon)
VALUES
(1, N'Toán'),
(2, N'Văn'),
(3, N'Anh'),
(4, N'Lý'),
(5, N'Hóa'),
(6, N'Sử'),
(7, N'Địa'),
(8, N'GDCD'),
(9, N'Công nghệ'),
(10, N'Tin học');

-- Chèn dữ liệu vào bảng Diem
INSERT INTO Diem (MaDiem, DiemSo, MaHS, MaMon, MaLoaiDiem)
VALUES
(1, 9.0, 1, 1, 1),
(2, 8.5, 5, 2, 1),
(3, 9.5, 1, 3, 1),
(4, 7.0, 6, 4, 1),
(5, 8.0, 1, 5, 1),
(6, 9.0, 2, 1, 1),
(7, 8.5, 2, 2, 1),
(8, 9.5, 7, 3, 1),
(9, 7.0, 2, 4, 1),
(10, 8.0, 2, 5, 1),
(11, 9.0, 8, 1, 1),
(12, 8.5, 3, 2, 1),
(13, 9.5, 3, 3, 1),
(14, 7.0, 3, 4, 1),
(15, 8.0, 9, 5, 1),
(16, 9.0, 4, 1, 1),
(17, 8.5, 4, 2, 1),
(18, 9.5, 10, 3, 1),
(19, 7.0, 10, 4, 1),
(20, 8.0, 4, 5, 1);
