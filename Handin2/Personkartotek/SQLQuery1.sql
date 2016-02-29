INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES ('8240', 'Risskov', '2b', 'LandOfMilkAndHoney')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Joachim', 'Derpo', 'Carpentier', 'Mig Selv', 1)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (8240, 'Risskov', '2', 'Buddingevej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Ole', 'Derpo', 'Carlsen', 'Ven', 2)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (2970, 'Kokkedal', '706', 'Enebærhaven')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Joachim', '', 'Andersen', 'Kollega', 3)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (8000, 'Aarhus C', '201', 'Bandagervej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Terese', 'Carlos', 'Bundstrup', 'Ven', 4)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (2980, 'Hørsholm', '1b', 'Tjørnevej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Mie', 'Derpo', 'Carpentier', 'Kæreste', 5)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (1000, 'Vesterbro', '123', 'Gammel Kongevej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Helle', '', 'Søvndal', 'Ven', 6)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (3464, 'Christianshavn', '107', 'Pisserenden')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Markise', '', 'Lukkes', 'Ven', 7)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (8240, 'Risskov', '2b', 'LandOfMilkAndHoney')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Joachim', 'Derpo', 'Carpentier', 'Kollega', 8)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (2550, 'Rungsted', '178', 'Piet Heins vej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Lasse', 'Bang', 'Rimmer', 'Ven', 9)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (7654, 'Moderna', '56b', 'Glistrupvej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Birgitte', 'Birgitte', 'Begøje', 'Kollega', 10)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (1908, 'Solkysten', '1', 'Ussel-Mammon vej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Simon', '', 'Spies', 'Kæreste', 11)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (8888, 'Leasy', '235', 'Randersvej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Peter', 'Håndværker', 'Manden', 'Ven', 12)

INSERT INTO dbo.Address (Country, Town, Street, unnamed) VALUES (6438, 'Palæokost', '2b', 'Sundhedsvej')
INSERT INTO dbo.Person (FirstName, MiddelName, LastName, unnamed, AddressId) VALUES ('Thomas', 'Ryge', 'Petersen', 'Ven', 13)

SELECT * FROM Person

INSERT INTO dbo.Phone ( PhoneId, Phonenumber, PhoneType, PersonId) VALUES ( 5, 60185500, 'Mobil', 5)
INSERT INTO dbo.Phone ( PhoneId, Phonenumber, PhoneType, PersonId) VALUES ( 2, 88888888, 'Hjemmenummer', 2)
INSERT INTO dbo.Phone ( PhoneId, Phonenumber, PhoneType, PersonId) VALUES ( 3, 13653686, 'Mobil', 3)
INSERT INTO dbo.Phone ( PhoneId, Phonenumber, PhoneType, PersonId) VALUES ( 4, 45784530, 'Mobil', 4)

SELECT * FROM Person

SELECT * FROM Adress

DELETE FROM Adress WHERE AddressId > 13

UPDATE Person
SET unnamed = 'Familie'
WHERE unnamed = 'Kæreste'
GO

SELECT * FROM Person

DELETE FROM Person WHERE PersonId > 13