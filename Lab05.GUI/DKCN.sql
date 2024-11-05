-- Tạo cơ sở dữ liệu
CREATE DATABASE DKCN;
go
USE DKCN;
go

-- Tạo bảng Faculty (Khoa)
CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY, -- Mã khoa (tự động tăng)
    FacultyName NVARCHAR(255) NOT NULL         -- Tên khoa
);

-- Tạo bảng Major (Ngành học)
CREATE TABLE Major (
    MajorID INT PRIMARY KEY,   -- Mã ngành học (tự động tăng)
    MajorName NVARCHAR(255) NOT NULL,          -- Tên ngành học
    FacultyID INT,                            -- Liên kết với Faculty
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID) -- Ràng buộc khóa ngoại
);

-- Tạo bảng Student (Sinh viên)
CREATE TABLE Student (
    StudentID NVARCHAR(10) PRIMARY KEY, -- Mã sinh viên (tự động tăng)
    FullName NVARCHAR(255) NOT NULL,           -- Họ tên sinh viên
	AverageScore FLOAT NOT NULL,
    FacultyID INT,                            -- Liên kết với Faculty
    MajorID INT,                              -- Liên kết với Major
	Avatar NVARCHAR(255),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID), -- Ràng buộc khóa ngoại
    FOREIGN KEY (MajorID) REFERENCES Major(MajorID)        -- Ràng buộc khóa ngoại
);
