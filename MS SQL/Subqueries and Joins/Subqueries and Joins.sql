--Problem 1
  SELECT TOP 5
		e.[EmployeeID],
		e.[JobTitle],
		e.[AddressID],
		a.[AddressText]
FROM [Employees] as e
JOIN [Addresses] as a
      ON e.[AddressID] = a.[AddressID]
ORDER BY e.[AddressID]


--Problem 2
SELECT TOP 50
		e.[FirstName],
		e.[LastName],
		t.[Name],
		a.[AddressText]
FROM [Employees] AS [e]
JOIN [Addresses] AS [a]
		ON e.[AddressID] = a.[AddressID]
JOIN [Towns] AS t
		ON t.[TownID] = a.[TownID]
ORDER BY [FirstName] ASC, [LastName]


--Problem 3
SELECT 
	e.[EmployeeID],
	e.[FirstName], 
	e.[LastName],
	d.[Name]
FROM [Employees] AS [e]
JOIN [Departments] AS [d]
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE d.[Name] = 'Sales'
ORDER BY [EmployeeID] ASC


--Problem 4
SELECT TOP 5
	e.[EmployeeID],
	e.[FirstName],
	e.[Salary],
	d.[Name]
FROM [Employees] AS [e]
JOIN [Departments] AS [d]
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE [Salary] > 15000
ORDER BY e.[DepartmentID] ASC 


--Problem 5
SELECT TOP 3
	e.[EmployeeID],
	e.[FirstName]
FROM [Employees] AS [e]
LEFT JOIN [EmployeesProjects] AS [ep]
	ON e.[EmployeeID] = ep.EmployeeID
WHERE ep.[ProjectID] IS NULL
ORDER BY e.[EmployeeID] ASC


--Problem 6
SELECT 
	e.[FirstName],
	e.[LastName],
	e.[HireDate],
	d.[Name]
FROM [Employees] AS [e]
JOIN [Departments] AS [d]
	ON e.[DepartmentID] = d.[DepartmentID]
WHERE e.[HireDate] > '01-01-1999' AND 
	  d.[Name] IN ('Sales', 'Finance')
ORDER BY e.[HireDate] ASC


--Problem 7
SELECT TOP 5
	e.[EmployeeID],
	e.[FirstName],
	p.[Name]
FROM [Employees] AS [e]
JOIN [EmployeesProjects] AS [ep]
	ON e.[EmployeeID] = ep.[EmployeeID]
JOIN [Projects] AS [p]
	ON ep.[ProjectID] = p.[ProjectID]
WHERE p.[StartDate] > '2002-08-13' AND 
	  P.[EndDate] IS NULL
ORDER BY e.[EmployeeID] ASC


--Problem 8
SELECT 
	e.[EmployeeID],
	e.[FirstName],
	CASE
		WHEN p.[StartDate] >= '2005-01-01' THEN NULL
		ELSE p.[Name]
	END AS [ProjectName]
FROM [Employees] AS [e]
JOIN [EmployeesProjects] AS [ep]
	ON e.[EmployeeID] = ep.[EmployeeID]
JOIN [Projects] AS [p]
	ON p.[ProjectID] = ep.ProjectID
WHERE e.[EmployeeID] = 24


--Problem 9
SELECT
	e.[EmployeeID],
	e.[FirstName],
	e.[ManagerID],
	e2.[FirstName] AS [ManagerName]
FROM [Employees] AS [e]
JOIN [Employees] AS [e2]
	ON e.[ManagerID] = e2.[EmployeeID]
WHERE e.[ManagerID] IN (3,7)
ORDER BY e.[EmployeeID]



--Problem 10
SELECT TOP 50
	e.[EmployeeID],
	CONCAT_WS(' ', e.[FirstName], e.[LastName]) AS [EmployeeName],
	CONCAT_WS(' ', e2.[FirstName], e2.[LastName]) AS [ManagerName],
	d.[Name] AS [DepartmentName]
FROM [Employees] AS [e]
JOIN [Employees] AS [e2]
	ON e.[ManagerID] = e2.[EmployeeID]
JOIN [Departments] AS [d]
	ON d.[DepartmentID] = e.[DepartmentID]
ORDER BY [EmployeeID]


--Problem 11
SELECT MIN (AvgSalary) AS [MinAvgSalary]
FROM(
	SELECT AVG(Salary) AS [AvgSalary]
	FROM [Employees]
	GROUP BY [DepartmentID])
	AS [AvgSalaries]



--Problem 12
SELECT 
	mc.[CountryCode],
	m.[MountainRange],
	p.[PeakName],
	p.[Elevation]
FROM [MountainsCountries] AS [mc]
JOIN [Mountains] AS [m]
	ON mc.[MountainId] = m.[Id]
JOIN [Peaks] AS [p]
	ON mc.[MountainId] = p.[MountainId]
WHERE 
	mc.[CountryCode] = 'BG' AND
	p.[Elevation] > 2835 
ORDER BY [Elevation] DESC


--Problem 13
SELECT 
	mc.[CountryCode], 
	COUNT(m.[MountainRange]) AS [MountainRanges]
FROM [MountainsCountries] AS [mc] 
JOIN [Mountains] AS [m]
	ON m.[Id] = mc.[MountainId] 
WHERE
	mc.CountryCode = 'BG' OR
	mc.CountryCode = 'RU' OR
	mc.CountryCode = 'US'
GROUP BY mc.[CountryCode]



--Problem 14
SELECT TOP 5
	c.[CountryName],
	r.[RiverName]
FROM [Countries] AS [c]
LEFT JOIN [CountriesRivers] AS [cr]
	ON cr.[CountryCode] = c.[CountryCode]
LEFT JOIN [Rivers] AS [r]
	ON r.[Id] =	cr.[RiverId]
WHERE c.[ContinentCode] = 'AF'
ORDER BY [CountryName] ASC



--Problem 15
SELECT 
	[r].ContinentCode, 
	[r].CurrencyCode, 
	[r].CurrencyUsage
FROM 
(
	SELECT 
      c.[ContinentCode],
	  c.[CurrencyCode],
	  COUNT(c.[CurrencyCode]) AS [CurrencyUsage],
	  DENSE_RANK() OVER
	  (
		PARTITION BY c.[ContinentCode] 
		ORDER BY COUNT(c.[CurrencyCode]) DESC
	  ) AS [CurrencyRank]
	  FROM [Countries] AS [c]
	  GROUP BY c.[ContinentCode],c.[CurrencyCode]
	  HAVING COUNT(c.[CurrencyCode]) > 1
) AS [r]
WHERE [r].CurrencyRank = 1
ORDER BY [r].ContinentCode



--Problem 16
SELECT 
	COUNT(c.[CountryCode]) AS [Count]
FROM [Countries] AS [c]
LEFT JOIN [MountainsCountries] AS [mc]
	ON mc.[CountryCode] = c.[CountryCode]
WHERE mc.[MountainId] IS NULL



--Problem 17
SELECT TOP 5
	c.[CountryName],
	MAX(p.[Elevation]) AS [HighestPeakEvelation],
	MAX(r.[Length]) AS [LongestRiverLength]
FROM [Countries] AS [c]
JOIN [MountainsCountries] AS [mc]
	ON mc.[CountryCode] = c.[CountryCode]
JOIN [Peaks] AS [p]
	ON p.[MountainId] = mc.[MountainId]
JOIN [CountriesRivers] AS [cr]
	ON cr.[CountryCode] = c.[CountryCode]
JOIN [Rivers] AS [r]
	ON r.[Id] = cr.[RiverId]
GROUP BY [CountryName]
ORDER BY 
	[HighestPeakEvelation] DESC,
	[LongestRiverLength] DESC,
	[CountryName] ASC