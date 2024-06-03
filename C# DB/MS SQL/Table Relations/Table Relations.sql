CREATE DATABASE [Table_Relations_Exercise]
USE [Table_Relations_Exercise]

--Problem 1

CREATE TABLE [Passports](
	[PassportID] INT PRIMARY KEY,
	[PassportNumber] CHAR(8) NOT NULL
)

INSERT INTO [Passports](PassportID, PassportNumber)
	VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

CREATE TABLE [Persons](
	[PersonID] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[Salary] DECIMAL(7,2) NOT NULL,
	[PassportID] INT FOREIGN KEY REFERENCES Passports(PassportID) NOT NULL
)

INSERT INTO [Persons](FirstName, Salary, PassportID)
	VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101)



--Problem 2

CREATE TABLE [Manufacturers](
	[ManufacturerID] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	[EstablishedOn] DATETIME2
)

INSERT INTO [Manufacturers](Name, EstablishedOn)
	VALUES
('BMW', '07-03-1916'),
('Tesla', '01-01-2003'),
('Lada', '01-05-1966')

CREATE TABLE [Models](
	[ModelID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[ManufacturerID] INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO [Models](ModelID, Name, ManufacturerID)
	VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)



--Problem 3

CREATE TABLE [Students](
	[StudentID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

INSERT INTO [Students](Name)
	VALUES
('Mila'),
('Toni'),
('Ron')

CREATE TABLE [Exams](
	[ExamID] INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
)

INSERT INTO [Exams](ExamID, Name)
	VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')

CREATE TABLE [StudentsExams](
	[StudentID] INT FOREIGN KEY REFERENCES Students(StudentID) NOT NULL,
	[ExamID] INT FOREIGN KEY REFERENCES Exams(ExamID) NOT NULL
	CONSTRAINT PK_StudentsExamsPK PRIMARY KEY (StudentID,ExamID)
)

INSERT INTO [StudentsExams](StudentID, ExamID)
	VALUES
(1, 101),
(1, 102),
(2, 101)



--Problem 4

CREATE TABLE [Teachers](
	[TeacherID] INT PRIMARY KEY IDENTITY(101, 1),
	[Name] VARCHAR(50) NOT NULL,
	[ManagerID] INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO [Teachers](Name, ManagerID)
	VALUES
('John', NULL),
('Maya', 106),
('Silvia', 106),
('Ted', 105),
('Mark', 101),
('Greta', 101)


--Problem 5

CREATE TABLE [Cities](
	[CityID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Customers](
	[CustomerID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[Birthday] DATETIME2,
	[CityID] INT FOREIGN KEY REFERENCES[Cities](CityID)
)

CREATE TABLE [Orders](
	[OrderID] INT PRIMARY KEY IDENTITY,
	[CustomerID] INT FOREIGN KEY REFERENCES[Customers](CustomerID)
)

CREATE TABLE [ItemTypes](
	[ItemTypeID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Items](
	[ItemID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[ItemTypeID] INT FOREIGN KEY REFERENCES[ItemTypes](ItemTypeID)
)

CREATE TABLE [OrderItems](
	[OrderID] INT FOREIGN KEY REFERENCES[Orders](OrderID),
	[ItemID] INT FOREIGN KEY REFERENCES [Items](ItemID)
	PRIMARY KEY(OrderID, ItemID)
)



--Problem 6
CREATE TABLE [Subjects](
	[SubjectID] INT PRIMARY KEY IDENTITY,
	[SubjectName] VARCHAR(50) NOT NULL
)

CREATE TABLE [Majors](
	[MajorID] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Students2](
	[StudentID] INT PRIMARY KEY IDENTITY,
	[StudentNumber] INT NOT NULL,
	[StudentName] VARCHAR(50) NOT NULL,
	[MajorID] INT FOREIGN KEY REFERENCES[Majors](MajorID)
)

CREATE TABLE [Agenda](
	[StudentID] INT FOREIGN KEY REFERENCES[Students2](StudentID),
	[SubjectID] INT FOREIGN KEY REFERENCES[Subjects](SubjectID)
	PRIMARY KEY (StudentID, SubjectID)
)


CREATE TABLE [Payments](
	[PaymentID] INT PRIMARY KEY IDENTITY,
	[PaymentDate] DATETIME2,
	[PaymentAmount] DECIMAL(18,2),
	[StudentID] INT FOREIGN KEY REFERENCES [Students2](StudentID)
)



--Problem 7
--created an E/R diagram of Softuni Database



--Problem 8
--created an E/R diagram of Geography Database


--Problem 9
USE Geography
   SELECT [m].MountainRange, [p].PeakName, [p].Elevation
     FROM [Peaks]
       AS [p]
LEFT JOIN [Mountains]
	AS [m]
	ON [p].MountainId = [m].Id
     WHERE [m].MountainRange = 'Rila'
  ORDER BY [p].Elevation DESC
