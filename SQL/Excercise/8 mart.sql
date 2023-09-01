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
	WHEN 'UK' THEN 'Birleþik Krallýk'
	WHEN 'Türkiye' THEN 'Türkiye Cumhuriyeti'
	WHEN NULL THEN 'ÜLKE BELÝRTÝLMEDÝ'
END AS 'ÜLKESÝ'
FROM Employees
*/

/*
DECLARE @NegatifSayi int
SET @NegatifSayi = -4

PRINT ABS(@NegatifSayi)
*/

/*
SELECT [FirstName],[LastName], DATEPART(YEAR,[BirthDate]) AS 'YIL', DATEPART(MONTH,[BirthDate]) AS 'AY', DATEPART(DAY,[BirthDate]) AS 'GÜN' FROM Employees
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
PRINT SUBSTRING('BÝLGE ADAM AKADEMÝ',1,10)
*/

/*
SELECT VALUE FROM STRING_SPLIT ( 'BÝLGE ADAM AKADEMÝ',' ')
*/

/*
PRINT LEN('BÝLGE ADAM AKADEMÝ')
*/

/*
PRINT LOWER('BÝLGE ADAM AKADEMÝ')
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


