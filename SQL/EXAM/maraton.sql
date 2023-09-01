USE Northwind

SELECT o.OrderID, CONCAT(e.FirstName, ' ',e.LastName) AS TAMADI, o.CustomerID
FROM Orders o
JOIN Shippers s ON o.ShipVia = s.ShipperID
JOIN Employees e ON o.EmployeeID = e.EmployeeID
WHERE s.CompanyName = 'Federal Shipping' AND e.FirstName = 'Nancy' 


SELECT *
FROM Territories t
JOIN Region r ON t.RegionID = r.RegionID
WHERE r.RegionDescription LIKE '%West%'

SELECT TOP 1 ProductName, SUM(Quantity) AS TotalQuantity
FROM [Order Details]
JOIN Products ON [Order Details].ProductID = Products.ProductID
GROUP BY ProductName
ORDER BY TotalQuantity ASC

SELECT s.CompanyName,s.ContactName, s.Phone 
FROM Suppliers s
INNER JOIN Products p ON s.SupplierID = p.SupplierID
WHERE p.Discontinued = 1 AND p.UnitsInStock = 0

SELECT DISTINCT Customers.ContactName
FROM Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
WHERE Orders.OrderDate >= '1998-01-01'
ORDER BY Customers.ContactName ASC;

SELECT e.EmployeeID,e.FirstName, e.LastName FROM Orders o
INNER JOIN Customers c ON c.CustomerID = o.CustomerID
INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
WHERE c.Country = 'Mexico' AND c.ContactTitle = 'Owner'AND o.Freight < 30

SELECT CONCAT(FirstName, ' ', LastName) AS TAMADI
FROM Employees
ORDER BY LastName;

SELECT FirstName + ' ' + LastName AS FullName, MONTH(BirthDate) AS 'DOÐDUÐU AY'
FROM Employees
WHERE DATEDIFF(year, BirthDate, GETDATE()) >= 70
ORDER BY 'DOÐDUÐU AY' ASC

SELECT DISTINCT s.Country
FROM Suppliers s
INNER JOIN Products p ON s.SupplierID = p.SupplierID
GROUP BY s.Country
HAVING SUM(p.UnitsInStock) > 150

CREATE VIEW EnPahalý10Condiments AS
SELECT TOP 10 
    p.ProductID, 
    p.ProductName, 
    s.CompanyName AS SupplierName
FROM 
    Products p
    JOIN Suppliers s ON p.SupplierID = s.SupplierID
    JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE 
    c.CategoryName = 'Condiments'
ORDER BY 
    p.UnitPrice DESC;
GO

SELECT * FROM EnPahalý10Condiments

CREATE VIEW KritikSeviyeUrunBilgileri AS
SELECT p.ProductID, p.ProductName, s.CompanyName AS Supplier, c.CategoryName,
       MAX(p.UnitsInStock - p.UnitsOnOrder) AS MinOrderQuantity
FROM Products p
JOIN Suppliers s ON p.SupplierID = s.SupplierID
JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE p.Discontinued = 1 AND p.UnitsOnOrder = 0
GROUP BY p.ProductID, p.ProductName, s.CompanyName, c.CategoryName;
GO

SELECT * FROM KritikSeviyeUrunBilgileri

CREATE PROCEDURE CheckShipvia
    @shipvia int
AS
BEGIN
    DECLARE @count int
    SELECT @count = COUNT(*) FROM Orders WHERE ShipVia = @shipvia

    IF @count = 0
        BEGIN
            PRINT 'Hata: Girilen Shipvia deðeri kayýtlarda yok veya bu deðere sahip kargocu yok'
            RETURN
        END

    IF @count > 300
        BEGIN
            PRINT '300den fazla kayýt var. Kayýt Sayýsý= ' + CAST(@count AS varchar)
        END
    ELSE
        BEGIN
            PRINT '300den az kayýt var. Kayýt Sayýsý= ' + CAST(@count AS varchar)
        END
END 

GO

EXEC CheckShipvia 2

CREATE PROCEDURE KategoriyeGoreRapor
    @CategoryName nvarchar(15)
AS
BEGIN
    SELECT ProductName, UnitsInStock
    FROM Products p
    JOIN Categories c ON p.CategoryID = c.CategoryID
    WHERE c.CategoryName = @CategoryName
END

GO

EXEC KategoriyeGoreRapor 'Beverages'

CREATE FUNCTION Ciro
(
    @BaslangicTarihi DATETIME,
    @BitisTarihi DATETIME
)
RETURNS DECIMAL
AS
BEGIN
    DECLARE @Ciro DECIMAL;
    
    SELECT @Ciro = SUM((od.UnitPrice - od.Discount) * od.Quantity)
    FROM Orders o
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    WHERE o.OrderDate >= @BaslangicTarihi AND o.OrderDate <= @BitisTarihi
    
    RETURN @Ciro
END

GO

SELECT dbo.Ciro ('1997-01-01', '1997-12-31');


