/*

-- 1.SORU Hangi ülkede kaçar kiþi olduklarýný bulalým

SELECT COUNT([EmployeeID]), Country
FROM Employees
GROUP BY Country;

*/

/*

-- 2.SORU Çalýþanlarýmýn yapmýþ olduklarý sipariþ sayýsýna göre gruplandýrarak azalan sýrada sýralayýnýz.

SELECT COUNT([OrderID]),[EmployeeID] FROM Orders
GROUP BY [EmployeeID]
ORDER BY [EmployeeID] DESC

*/

/*

-- 3.SORU Hangi kategoride kaç ürün var, gruplandýrarak azalan sýrada sýralayýnýz...

SELECT  COUNT([CategoryID]), ProductName FROM Products
GROUP BY ProductName
ORDER BY ProductName DESC

*/

