--Problem 1
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [FirstName] LIKE 'Sa%'


--Problem 2
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [LastName] LIKE '%ei%'


--Problem 3
SELECT [FirstName]
  FROM [Employees]
 WHERE [DepartmentID] IN (3,10)
   AND YEAR([HireDate]) BETWEEN 1995 AND 2005


--Problem 4
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [JobTitle] NOT LIKE '%engineer%'


 --Problem 5
  SELECT [Name]
    FROM [Towns]
   WHERE LEN([Name]) IN (5,6)
ORDER BY [Name]


--Problem 6
  SELECT [TownId], [Name]
    FROM [Towns]
   WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name]


--Problem 7
  SELECT [TownId], [Name]
    FROM [Towns]
   WHERE LEFT([Name], 1) NOT IN('R', 'B', 'D')
ORDER BY [Name]


--Problem 8
CREATE VIEW V_EmployeesHiredAfter2000 AS
	 SELECT [FirstName], [LastName]
	   FROM [Employees]
	  WHERE YEAR([HireDate]) > 2000


--Problem 9
	SELECT [FirstName], [LastName]
	  FROM [Employees]
	 WHERE LEN([LastName]) = 5


--Problem 10
	  SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID])
		FROM [Employees]
	   WHERE [Salary] BETWEEN 10000 AND 50000
	ORDER BY [Salary] DESC


--Problem 11
SELECT * FROM
(SELECT EmployeeID,FirstName, LastName, Salary,
DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
FROM Employees) AS EmployeeRank
WHERE Salary BETWEEN 10000 AND 50000 AND [Rank] =2
ORDER BY Salary DESC


--Problem 12
  SELECT [CountryName], [IsoCode]
    FROM [Countries]
   WHERE [CountryName] LIKE '%a%a%a%'
ORDER BY [IsoCode]


--Problem 13
  SELECT [PeakName], [RiverName], LOWER([PeakName] + SUBSTRING([RiverName], 2, LEN([RiverName]))) AS [Mix]
    FROM [Peaks], [Rivers]
   WHERE RIGHT([PeakName], 1) = LEFT([RiverName], 1)
ORDER BY [Mix]


--Problem 14
   SELECT 
      TOP (50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start]
     FROM [Games]
    WHERE YEAR([Start]) IN (2011, 2012)
 ORDER BY [Start], [Name]


 --Problem 15
  SELECT [Username], SUBSTRING([Email], CHARINDEX('@', [Email]) + 1, LEN([Email]) - CHARINDEX('@', [Email])) AS [Email Provider] 
    FROM [Users]
ORDER BY [Email Provider], [Username]


--Problem 16
  SELECT [Username], [IpAddress]
    FROM [Users]
   WHERE [IpAddress] LIKE '___.1%.%.___'
ORDER BY [Username]


--Problem 17
  SELECT [Name] AS [Game], 
	   CASE
			WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
			WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
			WHEN DATEPART(HOUR, [Start]) >= 18 AND DATEPART(HOUR, [Start]) < 24 THEN 'Evening'
		END
		AS [Part of the day],

		 CASE
			WHEN [Duration] <= 3 THEN 'Extra Short'	
			WHEN [Duration] >= 4 AND [Duration] <= 6 THEN 'Short'
			WHEN [Duration] > 6  THEN 'Long'
			WHEN [Duration] IS NULL THEN 'Extra Long'
		END
		AS [Duration]

  FROM [Games]
ORDER BY [Game], [Duration], [Part of the day]


--Problem 18
SELECT [ProductName], 
	   [OrderDate],
	   DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
	   DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
  FROM [Orders]
