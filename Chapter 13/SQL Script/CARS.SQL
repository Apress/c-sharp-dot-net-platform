if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Orders_Customers]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT FK_Orders_Customers
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Orders_Inventory]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT FK_Orders_Inventory
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetPetName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetPetName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Orders]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Orders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Customers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Customers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Inventory]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Inventory]
GO

CREATE DATABASE [Cars]  ON (NAME = N'Cars_Data', FILENAME =N'C:\MSSQL7\Data\Cars_Data.MDF' , 
SIZE = 2, FILEGROWTH = 10%) 

LOG ON (NAME = N'Cars_Log', FILENAME= N'C:\MSSQL7\Data\Cars_Log.LDF' , 
SIZE = 1, FILEGROWTH = 10%)
GO
use[Cars]
CREATE TABLE [dbo].[Customers] (
	[FirstName] [char] (20) NULL ,
	[LastName] [char] (20) NULL ,
	[CustID] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Inventory] (
	[CarID] [int] NOT NULL ,
	[Make] [char] (20) NULL ,
	[Color] [char] (20) NULL ,
	[PetName] [char] (20) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Orders] (
	[OrderID] [int] NOT NULL ,
	[CarID] [int] NULL ,
	[CustID] [int] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customers] WITH NOCHECK ADD 
	CONSTRAINT [PK_Customers] PRIMARY KEY  CLUSTERED 
	(
		[CustID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Inventory] WITH NOCHECK ADD 
	CONSTRAINT [PK_Inventory] PRIMARY KEY  CLUSTERED 
	(
		[CarID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Orders] WITH NOCHECK ADD 
	CONSTRAINT [PK_Orders] PRIMARY KEY  CLUSTERED 
	(
		[OrderID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Orders] ADD 
	CONSTRAINT [FK_Orders_Customers] FOREIGN KEY 
	(
		[CustID]
	) REFERENCES [dbo].[Customers] (
		[CustID]
	),
	CONSTRAINT [FK_Orders_Inventory] FOREIGN KEY 
	(
		[CarID]
	) REFERENCES [dbo].[Inventory] (
		[CarID]
	)
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE GetPetName
@carID int,
@petName char(20) output

AS

SELECT @petName = PetName from Inventory where CarID = @carID


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO
use[Cars]
INSERT INTO Inventory (carID, Make, Color, PetName)
VALUES (0, 'BMW', 'Red', 'Chucky')
GO

INSERT INTO Inventory (carID, Make, Color, PetName)
VALUES (1, 'BMW', 'Green', 'Snake')
GO

INSERT INTO Inventory (carID, Make, Color, PetName)
VALUES (2, 'Viper', 'Red', 'Zippy')
GO

INSERT INTO Inventory (carID, Make, Color, PetName)
VALUES (3, 'BMW', 'Pink', 'Buddha')
GO

INSERT INTO Inventory (carID, Make, Color, PetName)
VALUES (4, 'Colt', 'Rust', 'Rusty')
GO

INSERT INTO Customers (custID, FirstName, LastName)
VALUES (0, 'Mike', 'Larson')
GO

INSERT INTO Customers (custID, FirstName, LastName)
VALUES (1, 'Amy', 'Smith')
GO

INSERT INTO Customers (custID, FirstName, LastName)
VALUES (2, 'Kandi', 'Nash')
GO

INSERT INTO Orders (orderID, custID, carID)
VALUES (0, 0, 0)
GO

INSERT INTO Orders (orderID, custID, carID)
VALUES (1, 1, 4)
GO
