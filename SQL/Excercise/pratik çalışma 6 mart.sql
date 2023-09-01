USE Northwind
/*
1.SORU Çalýþanlarýmýn arasýnda adýnýn ilk harfi A veya R olanlarý listeleyiniz...

SELECT FirstName FROM Employees
WHERE FirstName LIKE 'A%' OR FirstName LIKE 'R%'

where frstname like '[AR]%' iþe yarýyor. köþeli parantez veya anlamý taþýr
*/

/*
-- 2.SORU Çalýþanlarýmýn arasýnda soyadýnýn içinde A harfi geçenleri listeleyelim...

SELECT LastName FROM Employees
WHERE LastName LIKE '%A%' 

*/

/*
-- 3.SORU Çalýþanlarýmýn arasýnda adý alfabetik olarak B ile S arasýnda olanlarý listeleyiniz...

select FirstName from Employees
WHERE SUBSTRING(FirstName, 1, 1) BETWEEN 'B' AND 'S'
ORDER BY FirstName

*/

/*

-- 4.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 1 karakter olanlarý listeleyiniz...

select FirstName from Employees
Where FirstName Like '%A_E%'
ORDER BY FirstName

*/

/*
-- 5.SORU Çalýþanlarýmýn arasýnda adýnýn içinde A ve E harfi olan ve bu karakterler arasýnda yalnýzca 2 karakter olanlarý listeleyiniz... (Örnek: AyfEr, AskEr gibi)

select FirstName from Employees
Where FirstName Like '%A__E%'
ORDER BY FirstName

*/

/*
-- 6.SORU Employees tablosundan ID'si 2 ile 8 arasýnda olan çalýþanlarýn bilgilerini, FirstName kolonuna göre ARTAN sýrada sýralayýnýz (A'dan Z'ye)

select [EmployeeID],FirstName from Employees
Where [EmployeeID] BETWEEN 2 AND 8
ORDER BY FirstName 

*/

/*

-- 7.SORU Employees tablosundan, çalýþanlarýn, Adý, Soyadý, Doðum tarihi bilgilerini, BirthDate kolonuna göre ARTAN sýrada sýralayarak listeleyiniz...

select FirstName,LastName,BirthDate from Employees
order by BirthDate

*/

/*

-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 'Mevsim meyveleri taze tüketilirse faydalý olur.' açýklamasýyla birlikte ekleyiniz...

Select * from Categories
insert into Categories (CategoryName, Description) values ('Meyveler','Mevsim meyveleri taze tüketilirse faydalý olur.')

*/

/*

-- 9.SORU Employees tablosuna kendi bilgilerinizi ekleyiniz...

Select * from Employees
insert  Employees (FirstName, LastName, BirthDate) values ('Oðuzhan','KARAGÜZEL', 1994-4-30)

*/



/*

-- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 kiþi ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title

--tekrar bak


Select * from Employees
insert  Employees (FirstName, LastName, BirthDate) 
values 
('Aykut','TERZÝ', 1988-4-30),
('Ali Ozan','ÖZKUL', 1998-4-30),
('Eyüp','KAYATUAZÝ', 2000-4-30)
Select * from Employees

*/

/*

-- 11.SORU Çalýþanlar tablosundan ID'si 7 olan çalýþanýn soyadýný güncelleyiniz...

Select LastName from Employees
UPDATE Employees
SET LastName = 'Güncelle'
WHERE EmployeeID like 7
Select LastName,EmployeeID from Employees
order by EmployeeID

*/

/*

-- 12.SORU Çalýþanlar tablosundaki bütün çalýþanlarýn soyadýný güncelleyiniz...

UPDATE Employees
SET LastName = 'Güncelle'
Select LastName,EmployeeID from Employees
order by EmployeeID

*/


/*

-- 13.SORU Çalýþanlar tablosunda Unvaný 'Mr.' olanlarý 'Bay' olarak güncelleyiniz...

UPDATE Employees
SET TitleOfCourtesy = 'Bay'
WHERE TitleOfCourtesy like 'Mr.'
Select * from Employees
order by TitleOfCourtesy

*/

/*

-- 14.SORU Bayan çalýþanlar içerisinde görevi Sales Representative olanlarý Satýþ Temsilcisi olarak güncelleyiniz...

UPDATE Employees
SET Title = 'Satýþ Temsilcisi'
WHERE (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') and Title like 'Sales Representative'
Select * from Employees
order by TitleOfCourtesy

*/

/*

-- 15.SORU Çalýþanlar tablosundan ID'si 5 olan çalýþaný silelim...

DELETE FROM Employees WHERE EmployeeID like 10
Select * from Employees
order by EmployeeID

*/

/*

-- 16.SORU Çalýþanlar tablosundan unvaný bayan olan çalýþanlarý silmek istersek;

DELETE FROM Employees WHERE TitleOfCourtesy like 'bayan'
Select * from Employees
order by EmployeeID

*/

/*

-- 17.SORU Çalýþanlar tablosundaki TÜM verileri silelim...

DELETE FROM Employees
Select * from Employees
order by EmployeeID

*/
GO
DROP table Employees;
GO 

