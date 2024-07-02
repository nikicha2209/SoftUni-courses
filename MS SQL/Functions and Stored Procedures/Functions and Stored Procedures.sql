--Problem 1
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT [FirstName], [LastName]
	  FROM [Employees]
	 WHERE [Salary] > 35000
END


--Problem 2
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber
	(@number DECIMAL(18,4))
AS
BEGIN
	SELECT [FirstName], [LastName]
	  FROM [Employees]
	 WHERE [Salary] >= @number
END



--Problem 3
CREATE PROCEDURE usp_GetTownsStartingWith
	(@character VARCHAR(50))
AS
BEGIN
	SELECT [Name] AS [Town]
	  FROM [Towns]
	 WHERE SUBSTRING([Name], 1, LEN(@character)) = UPPER(@character)
END


--Problem 4
CREATE PROCEDURE usp_GetEmployeesFromTown
	(@townName VARCHAR(50))
AS
BEGIN
	SELECT [FirstName], [LastName]
	FROM [Employees] AS [e]
	JOIN [Addresses] AS [a] 
	ON a.[AddressID] = e.[AddressID]
	JOIN [Towns] AS [t]
	ON a.[TownID] = t.[TownID]
	WHERE t.[Name] = @townName
END



--Problem 5
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(10)

	IF(@salary < 30000)
		SET @salaryLevel = 'Low'

	ELSE IF(@salary < 50000)
		SET @salaryLevel = 'Average'

	ELSE
		SET @salaryLevel = 'High'

	RETURN @salaryLevel
END



--Problem 6
CREATE PROCEDURE usp_EmployeesBySalaryLevel
	(@levelOfSalary VARCHAR(10))
AS
BEGIN
	SELECT [FirstName], [LastName]
	  FROM [Employees]
	 WHERE dbo.ufn_GetSalaryLevel([Salary]) = @levelOfSalary
END	


--Problem 7
CREATE FUNCTION ufn_IsWordComprised
(@setOfLetters VARCHAR(50), @word VARCHAR(50))
RETURNS BIT
AS 
BEGIN 
	DECLARE @counter INT = 1
	WHILE(@counter <= LEN(@word))
	BEGIN 
		IF @setOfLetters NOT LIKE '%' + SUBSTRING(@word, @counter, 1) +'%' RETURN 0
		SET @counter += 1
	END

	RETURN 1
END


--Problem 8
CREATE PROC usp_DeleteEmployeesFromDepartment 
(@departmentId INT)
AS
BEGIN
	ALTER TABLE [Departments]
	ALTER COLUMN [ManagerID] INT NULL
	
	DELETE FROM [EmployeesProjects]	
	WHERE [EmployeeID] IN
	(
		SELECT [EmployeeID] FROM [Employees]
		WHERE [DepartmentID] = @departmentId
	)

	UPDATE [Employees]
	SET [ManagerID] = NULL
	WHERE [ManagerID] IN
	(
		SELECT [EmployeeID] FROM [Employees]
		WHERE [DepartmentID] = @departmentId
	)
	
	UPDATE [Departments]
	SET [ManagerID] = NULL
	WHERE [DepartmentID] = @departmentId
	
 	DELETE FROM [Employees]
	WHERE [DepartmentID] = @departmentId

	DELETE FROM [Departments]
	WHERE [DepartmentID] = @departmentId

	SELECT COUNT(*) FROM [Employees]
	WHERE [DepartmentID] = @departmentId
END



--Problem 9
CREATE PROCEDURE usp_GetHoldersFullName
AS
BEGIN 
	SELECT CONCAT_WS(' ', [FirstName], [LastName]) AS [Full Name]
	FROM [AccountHolders]
END



--Problem 10
CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan
	(@number DECIMAL(18,4))
AS
BEGIN 
	SELECT a.[FirstName], a.[LastName]
	  FROM [AccountHolders] AS [a]
	  JOIN
	  (
		SELECT 
			[AccountHolderId],
			SUM(Balance) AS [TotalMoney]
		FROM [Accounts]
		GROUP BY [AccountHolderId]
	  ) AS [acc] ON a.[Id] = acc.[AccountHolderId]
	 WHERE acc.[TotalMoney] >  @number
  ORDER BY [FirstName], [LastName]
END




--Problem 11
CREATE FUNCTION ufn_CalculateFutureValue
(@sum DECIMAL(18, 4), @annualRate FLOAT, @years INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN 
	RETURN @sum*POWER(1+@annualRate, @years)
END



--Problem 12
CREATE PROC usp_CalculateFutureValueForAccount 
(@accountId INT, @annualRate FLOAT)
AS
	SELECT
		acc.[Id] AS [Account Id],
		h.[FirstName] AS [First Name],
		h.[LastName] AS [Last Name],
		acc.[Balance] AS [Current Balance],
		dbo.ufn_CalculateFutureValue(acc.[Balance], @annualRate, 5) AS [Balance in 5 years]
	FROM [Accounts] AS [acc]
	JOIN [AccountHolders] AS [h]
		ON acc.[AccountHolderId] = h.[Id]
	WHERE acc.[Id] = @accountId