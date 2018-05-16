DROP DATABASE IF EXISTS MyLaptopShop
CREATE DATABASE MyLaptopShop

CREATE TABLE [MyLaptopShop].[dbo].[Settings]
(
	[UseLogin] BIT NOT NULL
)

CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Forename] TEXT NOT NULL, 
	[Surname] TEXT NOT NULL,
	[Email] TEXT NULL,
	[Username] TEXT NOT NULL, 
	[Password] TEXT NOT NULL, 
	[PasswordChange] BOOL NOT NULL,
	[PasswordChangeDate] DATE NULL,
	[Level] INT NOT NULL DEFAULT 0, 
	[Status] INT NOT NULL DEFAULT 0, 
	[CreationDate] DATE NOT NULL,
	[Information] TEXT NULL   
)

CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Reference] TEXT NOT NULL, 
	[CompanyName] TEXT NOT NULL, 
	[Building] TEXT NULL, 
	[Street] TEXT NULL, 
	[Town] TEXT NOT NULL, 
	[County] TEXT NOT NULL,
	[Postcode] TEXT NOT NULL, 
	[Country] TEXT NOT NULL,
	[Fax] TEXT NULL, 
	[Telephone] TEXT NULL,
	[Email] TEXT NULL,
	[Website] TEXT NULL,
	[Status] INT NOT NULL DEFAULT 0,
	[CreationDate] DATE NOT NULL,
	[Information] TEXT NULL, 
	
)

CREATE TABLE [dbo].[Diary]
(
	[Id] INT NOT NULL PRIMARY KEY
)

CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY
)

CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Reference] INT NOT NULL
)

CREATE TABLE [dbo].[Refurbished]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Reference] INT NOT NULL
)

CREATE TABLE [dbo].[Documents]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Reference] INT NOT NULL
)

CREATE TABLE [dbo].[Parts]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Reference] INT NOT NULL
)
