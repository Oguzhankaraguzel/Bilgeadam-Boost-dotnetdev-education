USE Northwind
/*
1.SORU �al��anlar�m�n aras�nda ad�n�n ilk harfi A veya R olanlar� listeleyiniz...

SELECT FirstName FROM Employees
WHERE FirstName LIKE 'A%' OR FirstName LIKE 'R%'

where frstname like '[AR]%' i�e yar�yor. k��eli parantez veya anlam� ta��r
*/

/*
-- 2.SORU �al��anlar�m�n aras�nda soyad�n�n i�inde A harfi ge�enleri listeleyelim...

SELECT LastName FROM Employees
WHERE LastName LIKE '%A%' 

*/

/*
-- 3.SORU �al��anlar�m�n aras�nda ad� alfabetik olarak B ile S aras�nda olanlar� listeleyiniz...

select FirstName from Employees
WHERE SUBSTRING(FirstName, 1, 1) BETWEEN 'B' AND 'S'
ORDER BY FirstName

*/

/*

-- 4.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 1 karakter olanlar� listeleyiniz...

select FirstName from Employees
Where FirstName Like '%A_E%'
ORDER BY FirstName

*/

/*
-- 5.SORU �al��anlar�m�n aras�nda ad�n�n i�inde A ve E harfi olan ve bu karakterler aras�nda yaln�zca 2 karakter olanlar� listeleyiniz... (�rnek: AyfEr, AskEr gibi)

select FirstName from Employees
Where FirstName Like '%A__E%'
ORDER BY FirstName

*/

/*
-- 6.SORU Employees tablosundan ID'si 2 ile 8 aras�nda olan �al��anlar�n bilgilerini, FirstName kolonuna g�re ARTAN s�rada s�ralay�n�z (A'dan Z'ye)

select [EmployeeID],FirstName from Employees
Where [EmployeeID] BETWEEN 2 AND 8
ORDER BY FirstName 

*/

/*

-- 7.SORU Employees tablosundan, �al��anlar�n, Ad�, Soyad�, Do�um tarihi bilgilerini, BirthDate kolonuna g�re ARTAN s�rada s�ralayarak listeleyiniz...

select FirstName,LastName,BirthDate from Employees
order by BirthDate

*/

/*

-- 8.SORU Kategoriler tablosuna 'Meyveler' kategorisini, 'Mevsim meyveleri taze t�ketilirse faydal� olur.' a��klamas�yla birlikte ekleyiniz...

Select * from Categories
insert into Categories (CategoryName, Description) values ('Meyveler','Mevsim meyveleri taze t�ketilirse faydal� olur.')

*/

/*

-- 9.SORU Employees tablosuna kendi bilgilerinizi ekleyiniz...

Select * from Employees
insert  Employees (FirstName, LastName, BirthDate) values ('O�uzhan','KARAG�ZEL', 1994-4-30)

*/



/*

-- 10.SORU Tek bir INSERT komutu ile Employees tablosuna 3 ki�i ekleyiniz... FirstName, LastName, TitleOfCourtesy, Title

--tekrar bak


Select * from Employees
insert  Employees (FirstName, LastName, BirthDate) 
values 
('Aykut','TERZ�', 1988-4-30),
('Ali Ozan','�ZKUL', 1998-4-30),
('Ey�p','KAYATUAZ�', 2000-4-30)
Select * from Employees

*/

/*

-- 11.SORU �al��anlar tablosundan ID'si 7 olan �al��an�n soyad�n� g�ncelleyiniz...

Select LastName from Employees
UPDATE Employees
SET LastName = 'G�ncelle'
WHERE EmployeeID like 7
Select LastName,EmployeeID from Employees
order by EmployeeID

*/

/*

-- 12.SORU �al��anlar tablosundaki b�t�n �al��anlar�n soyad�n� g�ncelleyiniz...

UPDATE Employees
SET LastName = 'G�ncelle'
Select LastName,EmployeeID from Employees
order by EmployeeID

*/


/*

-- 13.SORU �al��anlar tablosunda Unvan� 'Mr.' olanlar� 'Bay' olarak g�ncelleyiniz...

UPDATE Employees
SET TitleOfCourtesy = 'Bay'
WHERE TitleOfCourtesy like 'Mr.'
Select * from Employees
order by TitleOfCourtesy

*/

/*

-- 14.SORU Bayan �al��anlar i�erisinde g�revi Sales Representative olanlar� Sat�� Temsilcisi olarak g�ncelleyiniz...

UPDATE Employees
SET Title = 'Sat�� Temsilcisi'
WHERE (TitleOfCourtesy like 'Ms.' or TitleOfCourtesy like 'Mrs.') and Title like 'Sales Representative'
Select * from Employees
order by TitleOfCourtesy

*/

/*

-- 15.SORU �al��anlar tablosundan ID'si 5 olan �al��an� silelim...

DELETE FROM Employees WHERE EmployeeID like 10
Select * from Employees
order by EmployeeID

*/

/*

-- 16.SORU �al��anlar tablosundan unvan� bayan olan �al��anlar� silmek istersek;

DELETE FROM Employees WHERE TitleOfCourtesy like 'bayan'
Select * from Employees
order by EmployeeID

*/

/*

-- 17.SORU �al��anlar tablosundaki T�M verileri silelim...

DELETE FROM Employees
Select * from Employees
order by EmployeeID

*/
GO
DROP table Employees;
GO 

