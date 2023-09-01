/*

-- 1.SORU Hangi �lkede ka�ar ki�i olduklar�n� bulal�m

SELECT COUNT([EmployeeID]), Country
FROM Employees
GROUP BY Country;

*/

/*

-- 2.SORU �al��anlar�m�n yapm�� olduklar� sipari� say�s�na g�re grupland�rarak azalan s�rada s�ralay�n�z.

SELECT COUNT([OrderID]),[EmployeeID] FROM Orders
GROUP BY [EmployeeID]
ORDER BY [EmployeeID] DESC

*/

/*

-- 3.SORU Hangi kategoride ka� �r�n var, grupland�rarak azalan s�rada s�ralay�n�z...

SELECT  COUNT([CategoryID]), ProductName FROM Products
GROUP BY ProductName
ORDER BY ProductName DESC

*/

