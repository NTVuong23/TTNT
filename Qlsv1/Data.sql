CREATE DATABASE QLSV;
GO

USE QLSV;
GO

-- Tạo bảng Faculty trước
CREATE TABLE Faculty
(
    FacultyID INT PRIMARY KEY,
    FacultyName NVARCHAR(200)
);
GO

-- Tạo bảng STUDENT sau khi bảng Faculty đã được tạo
CREATE TABLE STUDENT
(
    StudentID NVARCHAR(30) PRIMARY KEY,
    FullName NVARCHAR(100),
	Gender nvarchar(10),
    AverageScore FLOAT,
    FacultyID INT,  -- Thêm cột FacultyID để tạo khóa ngoại
    FOREIGN KEY (FacultyID) REFERENCES dbo.Faculty(FacultyID)  -- Định nghĩa khóa ngoại
);
GO

-- Xóa dữ liệu cũ nếu cần
DELETE FROM STUDENT;
GO

-- Thêm dữ liệu cho bảng Faculty
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (1, 'QTKD');
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (2, 'CNTT');
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (3, 'NNA');
GO

-- Thêm dữ liệu cho bảng STUDENT
	INSERT INTO STUDENT (StudentID, FullName, Gender, AverageScore, FacultyID) VALUES ('SV001', 'Nguyen Van A', 'Nam', 8.5, 1);
	INSERT INTO STUDENT (StudentID, FullName, Gender, AverageScore, FacultyID) VALUES ('SV002', 'Tran Thi B', 'Nữ', 9.0, 2);
	INSERT INTO STUDENT (StudentID, FullName, Gender, AverageScore, FacultyID) VALUES ('SV003', 'Le Van C', 'Nam', 7.5, 1);
	INSERT INTO STUDENT (StudentID, FullName, Gender, AverageScore, FacultyID) VALUES ('SV004', 'Nguyen Thi D', 'Nữ', 8.0, 2);
GO

-- Kiểm tra dữ liệu đã thêm
SELECT * FROM STUDENT;

SELECT 
    s.StudentID, 
    s.FullName, 
    s.Gender, 
    s.AverageScore, 
    f.FacultyName  -- Lấy FacultyName từ bảng Faculty
FROM 
    STUDENT s
JOIN 
    Faculty f
ON 
    s.FacultyID = f.FacultyID;  -- Liên kết hai bảng qua FacultyID

	SELECT * FROM Faculty WHERE FacultyName = 'NNA';

