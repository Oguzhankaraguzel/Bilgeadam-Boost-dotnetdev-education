CREATE TABLE Musteriler
(
	MusteriID int PRIMARY KEY IDENTITY (1,1),
	MusteriAdi nvarchar (25) NOT NULL,
	MusteriSoyadi nvarchar (35) NOT NULL,
	
	
)

CREATE TABLE MusteriDetaylari
(
	MusteriID int unique Foreign Key REFERENCES Musteriler(MusteriID),
	Adres nvarchar (255),
	TelefonNo bigint,
	Sehir nvarchar (20),
	Ulke nvarchar (50) DEFAULT 'TÜRKÝYE',

	
)

CREATE TABLE Siparisler
(
	SiparislerID int primary key Identity (1,1),
	MusteriID int Foreign Key REFERENCES MusteriDetaylari(MusteriID),
	YemekSirketi nvarchar (100),
	Urun Nvarchar (50),
	Adet int not null,
	BirimFiyat decimal (12,2) not null,
	ToplamTutar decimal (18,2),
	SiparisTarihi datetime DEFAULT GETDATE()
)