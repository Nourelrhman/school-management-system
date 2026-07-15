USE master;
GO
DROP DATABASE IF EXISTS School;
GO

CREATE DATABASE School;
GO
USE School;
GO


CREATE TABLE Admins(
AdminID INT PRIMARY KEY,
Username VARCHAR(50),
Password VARCHAR(50)
);
INSERT INTO Admins VALUES (1,'nour','123');
INSERT INTO Admins VALUES (2,'haya','321');
INSERT INTO Admins VALUES (3,'jessy','456');
USE School;
SELECT * FROM Admins;

Create Table Student(
StudentID int primary key,
fname VARCHAR(30) NOT NULL,
mname VARCHAR(30),
lname VARCHAR(30) NOT NULL,
birthdate DATE NOT NULL,
PhoneNO VARCHAR(100) NOT NULL
);

Create Table Teacher(
TeacherID int Primary Key,
Fname VARCHAR(30) NOT NULL,
Mname VARCHAR(30),
Lname VARCHAR(30) NOT NULL,
HireDate DATE NOT NULL,
SupervisorID INT NULL,
CONSTRAINT Teacher_Supervisor FOREIGN KEY (SupervisorID) REFERENCES Teacher(TeacherID)
);

Create table Subject(
SubjectID INT PRIMARY KEY,
SubjectName VARCHAR (30) NOT NULL,
TeacherID int NOT NULL,
CONSTRAINT Sub_Teacher FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID)
);

CREATE TABLE Parent (
    StudentID INT NOT NULL,
    ParentName VARCHAR(60) NOT NULL,   
    ParentNO VARCHAR(100) NOT NULL,     
    Relationship VARCHAR(20) NOT NULL CHECK (Relationship IN ('Father', 'Mother', 'Guardian')),
    IsPrimary BIT NOT NULL DEFAULT 0,
    CONSTRAINT PK_Parent PRIMARY KEY (StudentID, ParentName),
    CONSTRAINT FK_Parent_Student
FOREIGN KEY (StudentID)
REFERENCES Student(StudentID)
);

Create Table Enrollment(
EnrollmentID int PRIMARY KEY,
StudentID INT NOT NULL,
SubjectID INT NOT NULL,
EnrollmentDate DATE NOT NULL,
Grade CHAR(2) Check (Grade in('A','B','C','D','F')),
CONSTRAINT StudentENR FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
CONSTRAINT SubjectENR FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
CONSTRAINT UnqEnrollment UNIQUE (StudentID,SubjectID)
);

Create Table Attendance(
AttendanceID INT PRIMARY KEY,
StudentID INT NOT NULL,
SubjectID INT NOT NULL,
Date DATE NOT NULL,
Status NVARCHAR(10) NOT NULL CHECK (Status IN ('Present', 'Absent')),
CONSTRAINT Student_ATT FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
CONSTRAINT Subject_ATT FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
);

CREATE TABLE ExamResult (
ResultID INT PRIMARY KEY,
StudentID INT NOT NULL,
SubjectID INT NOT NULL,
ExamName NVARCHAR(100) NOT NULL,
Score DECIMAL(5,2) NOT NULL CHECK (Score >= 0 AND Score <= 100),
CONSTRAINT StudentRes FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
CONSTRAINT SubjectRes FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
);

INSERT INTO Teacher VALUES
(1, 'Ahmed', 'Mohamed', 'Mostafa', '2010-09-01', NULL),
(2, 'Mona', 'Sami', 'Lotfy', '2012-01-15', 1),
(3, 'Khaled', 'Ahmed', 'Eid', '2015-08-20', 1),
(4, 'Heba', 'Mahmoud', 'Samir', '2018-03-10', 2),
(5, 'Amir', 'Hassan', 'Fathy', '2008-11-01', NULL),
(6, 'Nada', 'Tarek', 'Gamal', '2020-09-01', 3),
(7, 'Tarek', 'Mohamed', 'Maged', '2019-02-14', 6),
(8, 'Salma', 'Adel', 'Nabil', '2011-07-20', 5),
(9, 'Hossam', 'Khaled', 'Emad', '2021-01-05', 3),
(10, 'Rana', 'Yasser', 'Ayman', '2022-09-10', 9);

INSERT INTO Subject VALUES
(1, 'Algebra', 1),
(2, 'Calculus', 1),
(3, 'Mechanics', 2),
(4, 'Grammar', 3),
(5, 'Literature', 3),
(6, 'Organic Chemistry', 4),
(7, 'Cell Biology', 5),
(8, 'World History', 6),
(9, 'GIS', 7),
(10, 'Programming', 8);

INSERT INTO Student VALUES
(1, 'Ahmed', 'Ali', 'Hassan', '2005-03-15', '01012345678'),
(2, 'Sara', 'Mohamed', 'Ibrahim', '2006-07-22', '01223456789'),
(3, 'Mohamed', 'Samy', 'Abdullah', '2005-11-02', '01534567890'),
(4, 'Fatma', 'Hassan', 'Youssef', '2006-01-10', '01145678901'),
(5, 'Omar', 'Mahmoud', 'El Sayed', '2004-09-18', '01056789012'),
(6, 'Nour', 'Khaled', 'Ahmed', '2005-05-25', '01267890123'),
(7, 'Youssef', 'Adel', 'Mohamed', '2006-12-30', '01578901234'),
(8, 'Mariam', 'Samy', 'Mahmoud', '2005-08-14', '01089012345'),
(9, 'Khaled', 'Tamer', 'Hassan', '2004-04-05', '01190123456'),
(10, 'Laila', 'Omar', 'Fathy', '2006-06-19', '01201234567');

INSERT INTO Enrollment VALUES
(1, 1, 1, '2024-09-01', 'A'),
(2, 1, 3, '2024-09-01', 'B'),
(3, 2, 2, '2024-09-01', 'A'),
(4, 2, 4, '2024-09-01', 'C'),
(5, 3, 5, '2024-09-01', 'B'),
(6, 3, 6, '2024-09-01', NULL),
(7, 4, 7, '2024-09-01', 'A'),
(8, 4, 8, '2024-09-01', 'B'),
(9, 5, 9, '2024-09-01', 'C'),
(10, 5, 10, '2024-09-01', 'A'),
(11, 6, 1, '2024-09-01', 'B'),
(12, 7, 2, '2024-09-01', NULL),
(13, 8, 3, '2024-10-01', 'A'),
(14, 9, 4, '2024-10-01', 'B'),
(15, 10, 5, '2024-10-01', 'C');

INSERT INTO Attendance VALUES
(1, 1, 1, '2025-04-01', 'Present'),
(2, 2, 2, '2025-04-01', 'Present'),
(3, 3, 3, '2025-04-01', 'Absent'),
(4, 4, 4, '2025-04-02', 'Present'),
(5, 5, 5, '2025-04-02', 'Present'),
(6, 6, 6, '2025-04-02', 'Absent'),
(7, 7, 1, '2025-04-03', 'Present'),
(8, 8, 2, '2025-04-03', 'Present'),
(9, 9, 3, '2025-04-03', 'Present'),
(10, 10, 4, '2025-04-03', 'Absent');

INSERT INTO ExamResult VALUES
(1, 1, 1, 'Midterm', 92.5),
(2, 2, 2, 'Final', 88.0),
(3, 3, 3, 'Midterm', 75.5),
(4, 4, 4, 'Final', 81.0),
(5, 5, 5, 'Midterm', 68.5),
(6, 6, 6, 'Final', 95.0),
(7, 7, 1, 'Midterm', 79.0),
(8, 8, 2, 'Final', 84.5),
(9, 9, 3, 'Midterm', 91.0),
(10, 10, 4, 'Final', 73.0);

INSERT INTO Parent (StudentID, ParentName, ParentNO, Relationship, IsPrimary) VALUES
(1, 'Ahmed Hassan', '0101111111,0111111111', 'Father', 1),
(1, 'Fatma Ibrahim', '0102222222', 'Mother', 0),
(2, 'Mohamed Mahmoud', '0103333333,0123333333', 'Father', 1),
(2, 'Nadia Samir', '0104444444', 'Mother', 0),
(3, 'Khaled Youssef', '0105555555,0115555555', 'Guardian', 1),
(4, 'Mona Adel', '0106666666', 'Mother', 1),
(4, 'Tarek Samy', '0107777777', 'Father', 0),
(5, 'Heba Mostafa', '0108888888,0128888888', 'Mother', 1),
(5, 'Omar Wael', '0109999999', 'Father', 0),
(6, 'Soha Nabil', '0100000000', 'Mother', 1);

Select*
from Student;










