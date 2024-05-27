-- Problem 1
CREATE DATABASE Minions
USE Minions

--Problem 2
CREATE TABLE [Minions](
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(50),
	[Age] INT
)

CREATE TABLE [Towns](
	[Id] INT PRIMARY KEY,
	[NAME] NVARCHAR(50)
)

--Problem 3
ALTER TABLE [Minions]
ADD [TownId] INT FOREIGN KEY REFERENCES [Towns]([Id]) NOT NULL


--Problem 4

INSERT INTO [Towns] ([Id], [Name])
	VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO [Minions] ([Id], [Name], [Age], [TownId])
	VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)


--Problem 5
TRUNCATE TABLE [Minions]


--Problem 6
DROP TABLE [Minions]
DROP TABLE [Towns]


--Problem 7
CREATE TABLE [People](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH([Picture]) <= 2000000),
	[Height] DECIMAL(3, 2),
	[Weight] DECIMAL(5, 2),
	[Gender] CHAR(1) NOT NULL,
	CHECK ([Gender] = 'm' OR [Gender] = 'f'),
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)

INSERT INTO [People]([Name], [Height], [Weight], [Gender], [Birthdate])
	VALUES
('Georgi', 1.90, 82.19, 'm', '1994-01-02'),
('Nikol', 1.73, 50.96, 'f', '2001-06-22'),
('Ivan', 1.76, 70.8, 'm', '2000-04-12'),
('Viktoriya', 1.60, 41.2, 'f', '1999-07-04'),
('Simona', 1.69, 46.5, 'f', '1993-08-01')


--Problem 8
CREATE TABLE [Users](
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26),
	[ProfilePicture] VARBINARY(MAX),
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT 
)

INSERT INTO [Users]([Username], [Password], [IsDeleted])
	VALUES	
('Gosho', 'supertainaparola', 0),
('Pesho', 'oshtepotainaparola', 1),
('Ivan', '123456789', 1),
('Sasho', 'sashoepich', 0),
('Tosho', 'parola', 1)	


--Problem 9
ALTER TABLE [Users] 
DROP CONSTRAINT PK__Users__3214EC074FC180D7

ALTER TABLE [Users]
	ADD CONSTRAINT PK__Users__3214EC074FC180D7
	PRIMARY KEY(Id, Username)



--Problem 10
ALTER TABLE [Users]
ADD CONSTRAINT Chech_Password
		CHECK(LEN([Password]) >= 5)


--Problem 11
ALTER TABLE [Users]
Add CONSTRAINT default_login_time
		DEFAULT	GETDATE() FOR [LastLoginTime]


--Problem 12
ALTER TABLE [Users]
DROP CONSTRAINT PK__Users_

ALTER TABLE[Users]
ADD CONSTRAINT PK_ID PRIMARY KEY(Id)

ALTER TABLE[Users]
ADD CONSTRAINT check_password
CHECK(LEN(Password) >=3)



--Problem 13
CREATE DATABASE [Movies]
USE [Movies]

CREATE TABLE [Directors](
	[Id] INT PRIMARY KEY IDENTITY,
	[DirectorName] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Genres](
	[Id] INT PRIMARY KEY IDENTITY,
	[GenreName] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Movies](
	[Id] INT PRIMARY KEY IDENTITY,
	[Title] VARCHAR(50) NOT NULL,
	[DirectorId] INT FOREIGN KEY REFERENCES[Directors](Id),
	[CopyrightYear] INT NOT NULL,
	[Length] TIME NOT NULL,
	[GenreId] INT FOREIGN KEY REFERENCES[Genres](Id),
	[CategoryId] INT FOREIGN KEY REFERENCES[Categories](Id),
	[Rating] DECIMAL(2,1) NOT NULL,
	[Notes] NVARCHAR(1000)
)

INSERT INTO [Directors]([DirectorName])
	VALUES
	('Stanley Kubrick'),
	('Alfred Hitchcock'),
	('Quentin Tarantino'),
	('Steven Spielberg'),
	('Martin Scorsese')

INSERT INTO [Genres]([GenreName])
	VALUES
	('Action'),
	('Comedy'),
	('Drama'),
	('Fantasy'),
	('Horror')

INSERT INTO [Categories]([CategoryName])
	VALUES
	('Short'),
	('Long'),
	('Biography'),
	('Documentary'),
	('TV')

INSERT INTO [Movies]([Title],[DirectorId], [CopyrightYear], [Length], [GenreId], [CategoryId], [Rating], [Notes])
	VALUES
	('The Shawshank Redemption', 1, 1994, '02:22:00', 2, 3, 9.4, NULL),
	('The Godfather', 2, 1972, '02:55:00', 3, 4, 9.2, NULL),
	('Schindler`s List', 3, 1993, '03:15:00', 4, 5, 9.0, NULL),
	('Pulp Fiction', 4, 1994, '02:34:00', 5, 1, 8.9, NULL),
	('Fight Club', 5, 1999, '02:19:00', 1, 2, 8.8, NULL)



--Problem 14
CREATE DATABASE [CarRental]
USE [CarRental]

CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(50) NOT NULL,
	[DailyRate] DECIMAL(6,2) NOT NULL,
	[WeeklyRate] DECIMAL(6,2) NOT NULL,
	[MonthlyRate] DECIMAL(6,2) NOT NULL,
	[WeekendRate] DECIMAL(6,2) NOT NULL
)

CREATE TABLE [Cars](
	[Id] INT PRIMARY KEY IDENTITY,
	[PlateNumber] VARCHAR(30) NOT NULL,
	[Manufacturer] VARCHAR(50) NOT NULL, 
	[Model] VARCHAR(50) NOT NULL,
	[CarYear] INT NOT NULL,
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id) NOT NULL,
	[Doors] INT NOT NULL,
	[Picture] IMAGE,
	[Condition] NVARCHAR(1000) NOT NULL,
	[Available] BIT NOT NULL
)

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Title] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)


CREATE TABLE [Customers](
	[Id] INT PRIMARY KEY IDENTITY,
	[DriverLicenceNumber] INT NOT NULL,
	[FullName] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(100) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[ZIPCode] INT NOT NULL,
	[Notes] NVARCHAR(1000)
)


CREATE TABLE [RentalOrders](
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id) NOT NULL,
	[CustomerId] INT FOREIGN KEY REFERENCES [Customers](Id) NOT NULL,
	[CarId] INT FOREIGN KEY REFERENCES [Cars](Id) NOT NULL,
	[TankLevel] INT NOT NULL,
	[KilometrageStart] INT NOT NULL,
	[KilometrageEnd] INT NOT NULL,
	[TotalKilometrage] INT NOT NULL,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[TotalDays] INT NOT NULL,
	[RateApplied] DECIMAL(6, 2) NOT NULL,
	[TaxRate] DECIMAL(4, 2) NOT NULL,
	[OrderStatus] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

INSERT INTO [Categories] ([CategoryName], [DailyRate], [WeeklyRate], [MonthlyRate], [WeekendRate])
	VALUES
	('First category name', 10.00, 50.00, 150.00, 20.00),
	('Second category name', 50.00, 250.00, 750.00, 100.00),
	('Third category name', 100.00, 500.00, 1500.00, 200.00)

INSERT INTO [Cars] ([PlateNumber], [Manufacturer], [Model], [CarYear], [CategoryId], [Doors], [Picture], [Condition], [Available])
	VALUES
	('PLN 0001', 'Ford', 'Model A', 1994, 1, 4, NULL, 'Good', 1),
	('PLN 0002', 'Tesla', 'Model B', 2021, 2, 4, NULL, 'Great', 1),
	('PLN 0003', 'Capsule Corp', 'Model C', 2054, 3, 10, NULL, 'Best', 0)

INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes]) 
	VALUES
	('Tyler', 'Durden', 'Edward Norton`s Alter Ego', NULL),
	('Plain', 'Jane', 'some gal', NULL),
	('Average', 'Joe', 'some dude', NULL)

INSERT INTO [Customers]([DriverLicenceNumber], [FullName], [Address], [City], [ZIPCode], [Notes])
	VALUES
	('123456', 'Jimmy Carr', 'Britain', 'London', 1000, NULL),
	('654321', 'Bill Burr', 'USA', 'Washington', 2000, NULL),
	('999999', 'Louis CK', 'Mexico', 'Mexico City', 3000, NULL)

INSERT INTO [RentalOrders] ([EmployeeId], [CustomerId], [CarId], [TankLevel], [KilometrageStart], [KilometrageEnd], [TotalKilometrage], [StartDate], [EndDate], [TotalDays], [RateApplied], [TaxRate], [OrderStatus], [Notes])
	VALUES
	(1, 1, 1, 70, 90000, 100000, 10000, '1994-10-01', '1994-10-21', 20, 100.00, 14.00, 'Pending', NULL),
	(2, 2, 2, 85, 250000, 2750000, 25000, '2011-11-12', '2011-11-24', 12, 150.00, 17.50, 'Canceled', NULL),
	(3, 3, 3, 90, 0, 120000, 120000, '2025-04-05', '2025-05-02', 27, 220.00, 21.25, 'Delivered', NULL)



--Problem 15
CREATE DATABASE [Hotel]
USE [Hotel]

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Title] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)


CREATE TABLE [Customers](
	[AccountNumber] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[PhoneNumber] INT NOT NULL,
	[EmergencyName] VARCHAR(50) NOT NULL,
	[EmergencyNumber] INT NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [RoomStatus](
	[RoomStatus] VARCHAR(50) PRIMARY KEY NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [RoomTypes](
	[RoomType] VARCHAR(50) PRIMARY KEY NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [BedTypes](
	[BedType] VARCHAR(50) PRIMARY KEY NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Rooms](
	[RoomNumber] INT PRIMARY KEY IDENTITY,
	[RoomType] VARCHAR(50) FOREIGN KEY REFERENCES [RoomTypes](RoomType) NOT NULL,
	[BedType] VARCHAR(50) FOREIGN KEY REFERENCES [BedTypes](BedType) NOT NULL,
	[Rate] DECIMAL(5,2) NOT NULL,
	[RoomStatus] VARCHAR(50) FOREIGN KEY REFERENCES [RoomStatus](RoomStatus) NOT NULL,
	[Notes] NVARCHAR(1000) 
)

CREATE TABLE [Payments](
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id) NOT NULL,
	[PaymentDate] DATE NOT NULL,
	[AccountNumber] INT FOREIGN KEY REFERENCES [Customers](AccountNumber) NOT NULL,
	[FirstDateOccupied] DATE NOT NULL,
	[LastDateOccupied] DATE NOT NULL,
	[TotalDays] INT NOT NULL,
	[AmountCharged] DECIMAL(6,2) NOT NULL, 
	[TaxRate] DECIMAL(4,2) NOT NULL,
	[TaxAmount] DECIMAL(6,2) NOT NULL,
	[PaymentTotal] DECIMAL(6,2) NOT NULL,
	[Notes] NVARCHAR(1000) 
)

CREATE TABLE [Occupancies](
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id) NOT NULL,
	[DateOccupied] DATE NOT NULL,
	[AccountNumber] INT FOREIGN KEY REFERENCES [Customers](AccountNumber) NOT NULL,
	[RoomNumber] INT FOREIGN KEY REFERENCES [Rooms](RoomNumber) NOT NULL,
	[RateApplied] DECIMAL(4, 2) NOT NULL,
	[PhoneCharge] DECIMAL(4, 2) NOT NULL,
	[Notes] NVARCHAR(1000)
)



INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes])
	VALUES
	('Jim', 'McJim', 'Supervisor', NULL),
	('Jane', 'McJane', 'Cook', NULL),
	('John', 'McJohn', 'Waiter', NULL)
		
INSERT INTO [Customers] ([FirstName], [LastName], [PhoneNumber], [EmergencyName], [EmergencyNumber], [Notes])
	VALUES
	('Mickey', 'Mouse', 12345678, 'Minnie', 11111111, NULL),
	('Donald', 'Duck', 87654321, 'Daisy', 22222222, NULL),
	('Scrooge', 'McDuck', 9999999, 'Richie', 33333333, NULL)
		
INSERT INTO [RoomStatus]([RoomStatus], [Notes]) 
	VALUES
	('Free', NULL),
	('Occupied', NULL),
	('No idea', NULL)
		
INSERT INTO [RoomTypes]([RoomType], [Notes])
	VALUES
	('Room', NULL),
	('Studio', NULL),
	('Apartment', NULL)
		
INSERT INTO [BedTypes]([BedType], [Notes])
	VALUES
	('Big', NULL),
	('Small', NULL),
	('Child', NULL)
		
INSERT INTO [Rooms]([RoomType], [BedType], [Rate], [RoomStatus], [Notes])
	VALUES
	('Room', 'Big', 15.00, 'Free', NULL),
	('Studio', 'Small', 12.50, 'Occupied', NULL),
	('Apartment', 'Child', 10.25, 'No idea', NULL)
		
INSERT INTO [Payments]([EmployeeId], [PaymentDate], [AccountNumber], [FirstDateOccupied], [LastDateOccupied], [TotalDays], [AmountCharged], [TaxRate], [TaxAmount], [PaymentTotal], [Notes])
	VALUES
	(1, '2023-02-01', 1, '2023-01-11', '2023-01-14', 3, 250.00, 20.00, 50.00, 300.00, NULL),
	(2, '2023-02-02', 2, '2023-01-12', '2023-01-15', 3, 199.90, 20.00, 39.98, 239.88, NULL),
	(3, '2023-02-03', 3, '2023-01-13', '2023-01-16', 3, 330.50, 20.00, 66.10, 396.60, NULL)
	   	
INSERT INTO [Occupancies]([EmployeeId], [DateOccupied], [AccountNumber], [RoomNumber], [RateApplied], [PhoneCharge], [Notes])
	VALUES
	(1, '2023-01-01', 1, 1, 20.00, 15.00, NULL),
	(2, '2023-01-02', 2, 2, 20.00, 12.50, NULL),
	(3, '2023-01-03', 3, 3, 20.00, 18.90, NULL)



--Problem 16
CREATE DATABASE [SoftUni]
USE [SoftUni]

CREATE TABLE [Towns](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Addresses](
	[Id] INT PRIMARY KEY IDENTITY,
	[AddressText] VARCHAR(50) NOT NULL,
	[TownId] INT FOREIGN KEY REFERENCES [Towns](Id) NOT NULL
)

CREATE TABLE [Departments](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL, 
	[MiddleName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[JobTitle] VARCHAR(50) NOT NULL,
	[DepartmentId] INT FOREIGN KEY REFERENCES [Departments](Id) NOT NULL,
	[HireDate] DATE NOT NULL,
	[Salary] DECIMAL(6,2) NOT NULL,
	[AddressId] INT FOREIGN KEY REFERENCES [Addresses](Id) NOT NULL
)


--17 (created a back-up)


--18
INSERT INTO [Towns](Name)
	VALUES
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')

INSERT INTO [Departments](Name)
	VALUES
	('Engineering'),
	('Sales'),
	('Marketing'),
	('Software Development'),
	('Quality Assurance')

INSERT INTO [Addresses]([AddressText], [TownId])
	VALUES
	('Default entry', 1)

INSERT INTO [Employees]([FirstName], [MiddleName], [LastName], [JobTitle], [DepartmentId], [HireDate], [Salary], [AddressId])
	VALUES
	('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
	('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 1),
	('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 1),
	('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 1),
	('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 1)




--Problem 19
SELECT * FROM [Towns]
SELECT * FROM [Departments]
SELECT * FROM [Employees]



--Problem 20
SELECT * FROM [Towns]
	ORDER BY [Name]

SELECT * FROM [Departments]
	ORDER BY [Name]

SELECT * FROM [Employees]
	ORDER BY [Salary] DESC



--Problem 21
SELECT [Name] FROM [Towns]
	ORDER BY [Name]

SELECT [Name] FROM [Departments]
	ORDER BY [Name]

SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM [Employees]
	ORDER BY [Salary] DESC



--Problem 22
UPDATE [Employees]
	SET [Salary] *= 1.1

SELECT [Salary] FROM [Employees]


--Problem 23
USE [Hotel]
UPDATE [Payments]
	SET [PaymentTotal] -= 0.03

SELECT [TaxRate] FROM [Payments]


--Problem 24
USE [Hotel]
DELETE [Occupancies]