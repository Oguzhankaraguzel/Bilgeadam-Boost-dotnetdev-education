/*
DECLARE @AdSoyad nvarchar (50)
SET @AdSoyad = 
(
	SELECT TOP 1 CONCAT([FirstName],'  ',[LastName]) FROM Employees AS AdSoyad
	ORDER BY HireDate
)

PRINT @AdSoyad
*/

/*
SELECT *, 
CASE [Country]
	WHEN 'USA' THEN 'Amerika'
	WHEN 'UK' THEN 'Birle�ik Krall�k'
	WHEN 'T�rkiye' THEN 'T�rkiye Cumhuriyeti'
	WHEN NULL THEN '�LKE BEL�RT�LMED�'
END AS '�LKES�'
FROM Employees
*/

/*
DECLARE @NegatifSayi int
SET @NegatifSayi = -4

PRINT ABS(@NegatifSayi)
*/

/*
SELECT [FirstName],[LastName], DATEPART(YEAR,[BirthDate]) AS 'YIL', DATEPART(MONTH,[BirthDate]) AS 'AY', DATEPART(DAY,[BirthDate]) AS 'G�N' FROM Employees
*/

/*
SELECT CONVERT(INT,GETDATE()-[BirthDate])/365 AS YAS FROM Employees
*/

/*
SELECT [FirstName],[LastName],CONVERT(INT,GETDATE()-[HireDate]) AS MESAI FROM Employees
*/

/*
PRINT DATEADD(DAY,2,GETDATE())
*/

/*
PRINT ASCII('a')
*/

/*
PRINT CHAR(65)
*/

/*
PRINT CHARINDEX ('e', 'Bilge Adam Akademi')
*/

/*
PRINT SUBSTRING('B�LGE ADAM AKADEM�',1,10)
*/

/*
SELECT VALUE FROM STRING_SPLIT ( 'B�LGE ADAM AKADEM�',' ')
*/

/*
PRINT LEN('B�LGE ADAM AKADEM�')
*/

/*
PRINT LOWER('B�LGE ADAM AKADEM�')
PRINT UPPER('bilge adam akademi')
*/

/*
PRINT TRIM('          Bilge Adam Akdemi       ')
PRINT LTRIM('          Bilge Adam Akdemi       ') 
PRINT RTRIM('          Bilge Adam Akdemi       ') 
*/

/*
SELECT TOP 1 [EmployeeID] FROM Employees ORDER BY [EmployeeID] DESC
*/

/*
SELECT COUNT(DISTINCT [City])  FROM Employees 
*/

/*
SELECT SUM([EmployeeID])
FROM Employees
*/

SELECT AVG([EmployeeID])
FROM Employees


