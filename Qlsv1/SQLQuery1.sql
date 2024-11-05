CREATE DATABASE QLSV;
GO
USE QLSV;
GO

CREATE TABLE STUDENT
(
	StudentID NVARCHAR (30) PRIMARY KEY,
	FullName nvarchar (100),
	AverageScore float
);

Create Table Faculty
(
	FacultyID int Primary Key,
	FacultyName Nvarchar (200)
);