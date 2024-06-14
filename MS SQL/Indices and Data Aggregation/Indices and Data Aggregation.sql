--Problem 1
SELECT COUNT(*) AS [Count]
  FROM [WizzardDeposits]

 --Problem 2
  SELECT MAX([MagicWandSize]) AS [LongestMagicWand]
    FROM [WizzardDeposits]


--Problem 3
  SELECT [DepositGroup], MAX([MagicWandSize]) AS [LongestMagicWand]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup]


--Problem 4
  SELECT TOP 2[DepositGroup]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup]
ORDER BY AVG(MagicWandSize)


--Problem 5
  SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup]


--Problem 6
  SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY [DepositGroup]


--Problem 7
  SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY [DepositGroup]
  HAVING SUM([DepositAmount]) < 150000 
ORDER BY SUM([DepositAmount]) DESC
   

 
--Problem 8
  SELECT [DepositGroup], [MagicWandCreator], MIN([DepositCharge])
    FROM [WizzardDeposits]
GROUP BY [DepositGroup], [MagicWandCreator]
ORDER BY [MagicWandCreator] ASC, [DepositGroup] ASC


--Problem 9
SELECT [AgeGroup],
	   COUNT([AgeGroup]) AS [WizzardCount]
FROM (
		SELECT 
				CASE 
						WHEN [Age] <= 10 THEN '[0-10]'
						WHEN [Age] > 10 AND [Age] <= 20 THEN '[11-20]'
						WHEN [Age] > 20 AND [Age] <= 30 THEN '[21-30]'
						WHEN [Age] > 30 AND [Age] <= 40 THEN '[31-40]'
						WHEN [Age] > 40 AND [Age] <= 50 THEN '[41-50]'
						WHEN [Age] > 50 AND [Age] <= 60 THEN '[51-60]'
						ELSE '[61+]'
				END AS [AgeGroup]
				FROM [WizzardDeposits]
) AS [a]
GROUP BY [AgeGroup]


--Problem 10
SELECT DISTINCT [FirstLetter]
FROM 
(SELECT SUBSTRING([FirstName], 1, 1) AS [FirstLetter]
FROM [WizzardDeposits]
WHERE [DepositGroup] = 'Troll Chest')
AS [letters]


--Problem 11
  SELECT [DepositGroup],
	     [IsDepositExpired],
		 AVG(DepositInterest) AS [AverageInterest]
    FROM [WizzardDeposits]
   WHERE ([DepositStartDate] > '1985-01-01')
GROUP BY [DepositGroup], [IsDepositExpired]
ORDER BY [DepositGroup] DESC, [IsDepositExpired] ASC



--Problem 13
  SELECT [DepartmentID],
		 SUM([Salary]) AS [TotalSalary]
    FROM [Employees]
GROUP BY [DepartmentID]
ORDER BY [DepartmentID]


--Problem 14
  SELECT [DepartmentID], MIN(Salary) AS [MinimumSalary]
    FROM [Employees]
   WHERE [HireDate] > '2000-01-01' AND
		 [DepartmentID] IN (2,5,7)
GROUP BY [DepartmentID]



--Problem 15
SELECT * INTO [NewTable]
  FROM [Employees]
 WHERE [Salary] > 30000

 DELETE 
   FROM [NewTable]
  WHERE [ManagerID] = 42

UPDATE [NewTable]
   SET [SALARY] += 5000
 WHERE [DepartmentID] = 1

  SELECT [DepartmentID], AVG([Salary]) AS [AverageSalary]
    FROM [NewTable]
GROUP BY [DepartmentID]


--Problem 16
  SELECT [DepartmentID], MAX([Salary]) AS [MaxSalary]
    FROM [Employees]
GROUP BY [DepartmentID]
  HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000


--Problem 17
SELECT COUNT([Salary]) AS [Count]
  FROM [Employees]
 WHERE [ManagerID] IS NULL