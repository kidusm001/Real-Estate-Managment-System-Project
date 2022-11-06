Create Database Real_Estate_Project
--ALTER DATABASE  Real_Estate_Project MODIFY NAME = Real_estate
Use Real_estate
--Create Tables
CREATE TABLE tblAdmin(
  adminId int IDENTITY(100,1),
  firstName varchar(20) NOT NULL,
  lastName varchar(20) NOT NULL,
  email varchar(50) UNIQUE NOT NULL,
  username varchar(30) UNIQUE NOT NULL,
  _password varchar(20) NOT NULL,
  CONSTRAINT PK_AID PRIMARY KEY (adminId)
);
Drop table tblAdmin

CREATE TABLE tblAdminPhoneNumber(
adminID int NOT NULL,
phoneNumber varchar(20) UNIQUE NOT NULL,
phoneType varchar(10) NOT NULL,
CONSTRAINT FK_AdminPhoneNumber FOREIGN KEY (adminID) REFERENCES tblAdmin(adminID)
);
Drop table tblAdminPhoneNumber
CREATE TABLE tblAgent(
  agentId int IDENTITY(200,1),
  firstName varchar(20) NOT NULL,
  lastName varchar(20) NOT NULL,
  email varchar(50) UNIQUE NOT NULL,
  username varchar(30) UNIQUE NOT NULL,
  _password varchar(20) NOT NULL,
  totalCommission money Default 0.0,
  commissionPercent decimal(5,2) NOT NULL,
  CONSTRAINT PK_AGENTID PRIMARY KEY (agentId)
);

CREATE TABLE tblAgentPhoneNumber(
agentId int NOT NULL,
phoneNumber varchar(20) UNIQUE NOT NULL,
phoneType varchar(10) NOT NULL,
CONSTRAINT FK_AgentPhoneNumber FOREIGN KEY (agentId) REFERENCES tblAgent(agentId)
);
--Drop table tblAgentPhoneNumber
CREATE TABLE tblClient(
  clientId int IDENTITY(800,1),
  firstName varchar(20) NOT NULL,
  lastName varchar(20) NOT NULL,
  email varchar(50) UNIQUE NOT NULL,
  username varchar(30) UNIQUE NOT NULL,
  _password varchar(20) NOT NULL,
  CONSTRAINT PK_CLIENTID PRIMARY KEY (clientId)
);

CREATE TABLE tblClientPhoneNumber(
clientId int NOT NULL,
phoneNumber varchar(20) UNIQUE NOT NULL,
phoneType varchar(10) NOT NULL,
CONSTRAINT FK_ClientPhoneNumber FOREIGN KEY (clientId) REFERENCES tblClient(clientId)
);
--Drop table tblClientPhoneNumber
CREATE TABLE tblCountry(
countryId int IDENTITY(300,1),
countryName varchar(70) UNIQUE NOT NULL,
CONSTRAINT PK_COUNTRYID PRIMARY KEY (countryId)
);

CREATE TABLE tblRegion(
RegionId int IDENTITY(400,1),
RegionName varchar(70) NOT NULL,
countryId int  NOT NULL,
CONSTRAINT PK_REGIONID PRIMARY KEY (RegionId),
CONSTRAINT FK_COUNTRYID FOREIGN KEY (countryId) REFERENCES tblCountry(countryId)
);

CREATE TABLE tblZone(
ZoneId int IDENTITY(500,1),
ZoneName varchar(70) NOT NULL,
RegionId int  NOT NULL,
CONSTRAINT PK_ZONEID PRIMARY KEY (ZoneId),
CONSTRAINT FK_REGIONID FOREIGN KEY (RegionId) REFERENCES tblRegion(RegionId)
);

CREATE TABLE tblWoreda(
WoredaId int IDENTITY(600,1),
WoredaName varchar(70) NOT NULL,
zoneId int  NOT NULL,
CONSTRAINT PK_WOREDAID PRIMARY KEY (WoredaId),
CONSTRAINT FK_ZONEID FOREIGN KEY (ZoneId) REFERENCES tblZone(ZoneId)
);

CREATE TABLE tblStreet(
StreetId int IDENTITY(700,1),
StreetName varchar(100) NOT NULL,
WoredaId int  NOT NULL,
CONSTRAINT PK_STREETID PRIMARY KEY (StreetId),
CONSTRAINT FK_WOREDAID FOREIGN KEY (WoredaId) REFERENCES tblWoreda(WoredaId)
);

CREATE TABLE tblPropertyType(
typeId int IDENTITY(1,1),
typeName varchar(30) NOT NULL,
CONSTRAINT PK_TYPEID PRIMARY KEY (typeId),
);


CREATE TABLE tblProperty(
propertyId int IDENTITY(1000,1),
propertySize decimal(10,2) NOT NULL,
typeId int NOT NULL,
ownerId int NOT NULL,
StreetId int NOT NULL,
CONSTRAINT PK_PROPERTYID PRIMARY KEY (propertyId),
CONSTRAINT FK_TYPEID FOREIGN KEY (typeId) REFERENCES tblPropertyType(typeId),
CONSTRAINT FK_OWNERID FOREIGN KEY (ownerId) REFERENCES tblClient(clientId),
CONSTRAINT FK_STREETID FOREIGN KEY (StreetId) REFERENCES tblStreet(StreetId)
);

CREATE TABLE tblForSell(
propertyId int NOT NULL,
isAvailable bit NOT NULL,
price money NOT NULL,
ownerId int NOT NULL,
agentId int NOT NULL,
CONSTRAINT FK_AgentSells FOREIGN KEY (agentId) REFERENCES tblAgent(agentId),
CONSTRAINT FK_PROPERTYID FOREIGN KEY (propertyId) REFERENCES tblProperty(propertyId),
CONSTRAINT FK_OWNERID2 FOREIGN KEY (ownerId) REFERENCES tblClient(clientId)
);

--Drop table tblForSell

CREATE TABLE tblSellHistory(
transactionId int IDENTITY(10000,1),
propertyId int NOT NULL,
sellerId int NOT NULL,
buyerId int NOT NULL,
dateSold Date DEFAULT GETDATE(),
agentId int NOT NULL,
price money NOT NULL,
CONSTRAINT FK_AgentSell FOREIGN KEY (agentId) REFERENCES tblAgent(agentId),
CONSTRAINT PK_TRANSACTIONID PRIMARY KEY (transactionId),
CONSTRAINT FK_PROPERTYID3 FOREIGN KEY (propertyId) REFERENCES tblProperty(propertyId),
CONSTRAINT FK_SELLERID FOREIGN KEY (sellerId) REFERENCES tblClient(clientId),
CONSTRAINT FK_BUYERID FOREIGN KEY (buyerId) REFERENCES tblClient(clientId)
);

--Drop table tblSellHistory

GO
-- Functions
Create Function udfGetAllAdmin()
RETURNS TABLE
AS
RETURN(
SELECT A.adminId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblAdmin A
LEFT JOIN tblAdminPhoneNumber HomeNumber
        ON A.adminID = HomeNumber.adminID AND HomeNumber.phoneType='home'
LEFT JOIN tblAdminPhoneNumber MobileNumber
		ON A.adminID = MobileNumber.adminID AND MobileNumber.phoneType='mobile'
)
GO
Create Function udfGetAllAgent()
RETURNS TABLE
AS
RETURN(
SELECT A.agentId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile,
A.totalCommission AS [Total Commissions], A.commissionPercent AS [Commission percent]
FROM tblAgent A
LEFT JOIN tblAgentPhoneNumber HomeNumber
        ON A.agentId = HomeNumber.agentId AND HomeNumber.phoneType='home'
LEFT JOIN tblAgentPhoneNumber MobileNumber
		ON A.agentId = MobileNumber.agentId AND MobileNumber.phoneType='mobile'
)
GO
Create Function udfGetAllClient()
RETURNS TABLE
AS
RETURN(
SELECT A.clientId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblClient A
LEFT JOIN tblClientPhoneNumber HomeNumber
        ON A.clientId = HomeNumber.clientId AND HomeNumber.phoneType='home'
LEFT JOIN tblClientPhoneNumber MobileNumber
		ON A.clientId = MobileNumber.clientId AND MobileNumber.phoneType='mobile'
)
GO
Create Function udfGetAllProperty()
RETURNS TABLE
AS
RETURN(
SELECT P.propertyId, P.propertySize, PropertyType.typeName ,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name]
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
)
GO

Create Function udfGetAllPropertyForSell()
RETURNS TABLE
AS
RETURN(
SELECT P.propertyId,P.propertySize,S.price,PropertyType.typeName,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name],Agent.agentId
,Agent.firstName+' '+Agent.lastName AS [Agent Name],HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblForSell S
JOIN tblProperty P
	ON S.propertyId=P.propertyId
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
JOIN tblAgent Agent
	ON S.agentId=Agent.agentId
LEFT JOIN tblAgentPhoneNumber HomeNumber
        ON S.agentId = HomeNumber.agentId AND HomeNumber.phoneType='home'
LEFT JOIN tblAgentPhoneNumber MobileNumber
		ON S.agentId = MobileNumber.agentId AND MobileNumber.phoneType='mobile'
WHERE S.isAvailable=1
)
GO
--Stored procedures on tblAdmin
CREATE PROC spAddAdmin
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20)
AS
BEGIN
Insert into tblAdmin values(@Fname,@Lname,@Email,@Username,@password)
Declare @adminId int
Select @adminId=adminId from tblAdmin where username=@Username
Insert into tblAdminPhoneNumber values(@adminId,@phonenumber1,'home')
Insert into tblAdminPhoneNumber values(@adminId,@phonenumber2,'mobile')
End
GO
CREATE PROC spUpdateAdmin
@adminId int,
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20)
AS
BEGIN
IF EXISTS(SELECT adminId FROM tblAdmin WHERE adminId=@adminId)
BEGIN
UPDATE tblAdmin SET firstName=@Fname,lastName=@Lname,email=@Email,username=@Username,_password=@password WHERE adminId=@adminId;
UPDATE tblAdminPhoneNumber SET phoneNumber=@phonenumber1 WHERE adminId=@adminId AND phoneType='home';
UPDATE tblAdminPhoneNumber SET phoneNumber=@phonenumber2 WHERE adminId=@adminId AND phoneType='mobile';
END
ELSE
raiserror('no update', 16,1)
END

GO

CREATE PROC spDeleteAdmin
@adminId int
AS
BEGIN
IF EXISTS(SELECT adminId FROM tblAdmin WHERE adminId=@adminId)
BEGIN
DELETE FROM tblAdmin where adminId=@adminId;
DELETE FROM tblAdminPhoneNumber where adminId=@adminId;
END
ELSE
raiserror('no delete', 16,1)
END

GO 

CREATE PROC spSearchAdminByusername
@username varchar(20)
AS
BEGIN
IF EXISTS(SELECT username FROM tblAdmin WHERE username=@username)
BEGIN
SELECT A.adminId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblAdmin A
LEFT JOIN tblAdminPhoneNumber HomeNumber
        ON A.adminID = HomeNumber.adminID AND HomeNumber.phoneType='home'
LEFT JOIN tblAdminPhoneNumber MobileNumber
		ON A.adminID = MobileNumber.adminID AND MobileNumber.phoneType='mobile'
WHERE A.username=@username
END
ELSE
raiserror('NOT FOUND', 16,1)
END
GO

CREATE PROC spDisplayByAdminName
AS
BEGIN
SELECT A.adminId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblAdmin A
LEFT JOIN tblAdminPhoneNumber HomeNumber
        ON A.adminID = HomeNumber.adminID AND HomeNumber.phoneType='home'
LEFT JOIN tblAdminPhoneNumber MobileNumber
		ON A.adminID = MobileNumber.adminID AND MobileNumber.phoneType='mobile'
		ORDER BY A.firstName
END

GO
--CHECK THE CAPITALIZTIONS

CREATE PROC spAddAgent
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20),
@commissionPercent decimal(5,2)
AS
BEGIN
Insert into tblAgent (firstName,lastName,email,username,_password,commissionPercent) 
values(@Fname,@Lname,@Email,@Username,@password,@commissionPercent)
Declare @agentId int
Select @agentId=agentId from tblAgent where username=@Username
Insert into tblAgentPhoneNumber values(@agentId,@phonenumber1,'home')
Insert into tblAgentPhoneNumber values(@agentId,@phonenumber2,'mobile')
End

GO
CREATE PROC spUpdateAgentForAgent
@agentId int,
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20)
AS
BEGIN
IF EXISTS(SELECT agentId FROM tblAgent WHERE agentId=@agentId)
BEGIN
UPDATE tblAgent SET firstName=@Fname,lastName=@Lname,email=@Email,username=@Username,_password=@password WHERE agentId=@agentId;
UPDATE tblAgentPhoneNumber SET phoneNumber=@phonenumber1 WHERE agentId=@agentId AND phoneType='home';
UPDATE tblAgentPhoneNumber SET phoneNumber=@phonenumber2 WHERE agentId=@agentId AND phoneType='mobile';
END
ELSE
raiserror('no update', 16,1)
END

GO

CREATE PROC spDeleteAgent
@agentId int
AS
BEGIN
IF EXISTS(SELECT agentId FROM tblAgent WHERE agentId=@agentId)
BEGIN
DELETE FROM tblAgent where agentId=@agentId;
DELETE FROM tblAgentPhoneNumber where agentId=@agentId;
END
ELSE
raiserror('no delete', 16,1)
END

GO
CREATE PROC spUpdateAgentForAdmin
@agentId int,
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20),
@commissionPercent decimal(5,2)
AS
BEGIN
IF EXISTS(SELECT agentId FROM tblAgent WHERE agentId=@agentId)
BEGIN
UPDATE tblAgent SET firstName=@Fname,lastName=@Lname,email=@Email,username=@Username,_password=@password,commissionPercent=@commissionPercent 
WHERE agentId=@agentId;
UPDATE tblAgentPhoneNumber SET phoneNumber=@phonenumber1 WHERE agentId=@agentId AND phoneType='home';
UPDATE tblAgentPhoneNumber SET phoneNumber=@phonenumber2 WHERE agentId=@agentId AND phoneType='mobile';
END
ELSE
raiserror('no update', 16,1)
END

GO
CREATE PROC spUpdateAgentcommissionPercent
@agentId int,
@commissionPercent decimal(5,2)
AS
BEGIN
IF EXISTS(SELECT agentId FROM tblAgent WHERE agentId=@agentId)
UPDATE tblAgent SET commissionPercent=@commissionPercent 
WHERE agentId=@agentId;
ELSE
raiserror('no update', 16,1)
END

GO

GO 

CREATE PROC spSearchAgentByusername
@username varchar(20)
AS
BEGIN
IF EXISTS(SELECT agentId FROM tblAgent WHERE username=@username)
BEGIN
SELECT A.agentId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile,
A.totalCommission AS [Total Commissions], A.commissionPercent AS [Commission percent]
FROM tblAgent A
LEFT JOIN tblAgentPhoneNumber HomeNumber
        ON A.agentId = HomeNumber.agentId AND HomeNumber.phoneType='home'
LEFT JOIN tblAgentPhoneNumber MobileNumber
		ON A.agentId = MobileNumber.agentId AND MobileNumber.phoneType='mobile'
WHERE A.username=@username
END
ELSE
raiserror('NOT FOUND', 16,1)
END

GO

CREATE PROC spDisplayAgentsByCommission
AS
BEGIN
SELECT A.agentId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile,
A.totalCommission AS [Total Commissions], A.commissionPercent AS [Commission percent]
FROM tblAgent A
LEFT JOIN tblAgentPhoneNumber HomeNumber
        ON A.agentId = HomeNumber.agentId AND HomeNumber.phoneType='home'
LEFT JOIN tblAgentPhoneNumber MobileNumber
		ON A.agentId = MobileNumber.agentId AND MobileNumber.phoneType='mobile'
		ORDER BY A.totalCommission DESC
END

GO

CREATE PROC spAddClient
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20)
AS
BEGIN
Insert into tblClient values(@Fname,@Lname,@Email,@Username,@password)
Declare @clientId int
Select @clientId=clientId from tblClient where username=@Username
Insert into tblClientPhoneNumber values(@clientId,@phonenumber1,'home')
Insert into tblClientPhoneNumber values(@clientId,@phonenumber2,'mobile')
End

GO

CREATE PROC spUpdateClient
@clientId int,
@Fname varchar(20),
@Lname varchar(20),
@Email varchar(50),
@Username varchar(30),
@password varchar(20),
@phonenumber1 varchar(20),
@phonenumber2 varchar (20)
AS
BEGIN
IF EXISTS(SELECT clientId FROM tblClient WHERE clientId=@clientId)
BEGIN
UPDATE tblClient SET firstName=@Fname,lastName=@Lname,email=@Email,username=@Username,_password=@password WHERE clientId=@clientId;
UPDATE tblClientPhoneNumber SET phoneNumber=@phonenumber1 WHERE clientId=@clientId AND phoneType='home';
UPDATE tblClientPhoneNumber SET phoneNumber=@phonenumber2 WHERE clientId=@clientId AND phoneType='mobile';
END
ELSE
raiserror('no update', 16,1)
END

GO

CREATE PROC spDeleteClient
@clientId int
AS
BEGIN
IF EXISTS(SELECT clientId FROM tblClient WHERE clientId=@clientId)
BEGIN
DELETE FROM tblClient where clientId=@clientId;
DELETE FROM tblClientPhoneNumber where clientId=@clientId;
END
ELSE
raiserror('no delete', 16,1)
END

GO 

CREATE PROC spSearchClientByusername
@username varchar(20)
AS
BEGIN
IF EXISTS(SELECT username FROM tblClient WHERE username=@username)
BEGIN
SELECT A.clientId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblClient A
LEFT JOIN tblClientPhoneNumber HomeNumber
        ON A.clientId = HomeNumber.clientId AND HomeNumber.phoneType='home'
LEFT JOIN tblClientPhoneNumber MobileNumber
		ON A.clientId = MobileNumber.clientId AND MobileNumber.phoneType='mobile'
WHERE A.username=@username
END
ELSE
raiserror('NOT FOUND', 16,1)
END

GO

CREATE PROC spDisplayByClientName
AS
BEGIN
SELECT A.clientId,A.firstName,A.lastName,A.email,A.username,HomeNumber.phoneNumber AS Home, MobileNumber.phoneNumber AS Mobile
FROM tblClient A
LEFT JOIN tblClientPhoneNumber HomeNumber
        ON A.clientId = HomeNumber.clientId AND HomeNumber.phoneType='home'
LEFT JOIN tblClientPhoneNumber MobileNumber
		ON A.clientId = MobileNumber.clientId AND MobileNumber.phoneType='mobile'
		ORDER BY A.firstName
END

GO

CREATE PROC spAddPropertyType
@typeName varchar(30)
AS
BEGIN
INSERT INTO tblPropertyType VALUES(@typeName)
END

GO

CREATE PROC spUpdatePropertyType
@typeId int,
@typeName VARCHAR(30)
AS
BEGIN
IF EXISTS(SELECT typeId FROM tblPropertyType WHERE typeId=@typeId)
BEGIN
UPDATE tblPropertyType SET typeName=@typeName WHERE typeId=@typeId;

END
ELSE
raiserror('no update', 16,1)
END

GO

CREATE PROC spDeletePropertyType
@typeId int
AS
BEGIN
IF EXISTS(SELECT typeId FROM tblPropertyType WHERE typeId=@typeId)
BEGIN
DELETE FROM tblProperty where typeId=@typeId;
DELETE FROM tblPropertyType where typeId=@typeId;

END
ELSE
raiserror('no delete', 16,1)
END

GO

CREATE PROC spSearchByPropertyType
@typename varchar(30)
AS
BEGIN
SELECT P.propertyId, P.propertySize, PropertyType.typeName ,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name]
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
	WHERE PropertyType.typeName=@typename
END

GO

CREATE PROC spDisplayAllTypes
AS
BEGIN
SELECT * FROM tblPropertyType
END

GO
CREATE PROC spAddCountry
@Name varchar(70)
AS
BEGIN
INSERT INTO tblCountry VALUES(@Name)
END

GO
CREATE PROC spUpdateCountry
@previousName varchar(70),
@NewName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblCountry WHERE countryName=@previousName)
BEGIN
UPDATE tblCountry SET countryName=@NewName WHERE countryName=@previousName
END
ELSE
raiserror('COUNTRY NOT UPDATED', 16,1)
END

GO
CREATE PROC spDeleteCountry
@previousName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblCountry WHERE countryName=@previousName)
BEGIN
DELETE FROM tblCountry WHERE countryName=@previousName
END
ELSE
raiserror('COUNTRY NOT DELETE', 16,1)
END

GO
CREATE PROC spAddRegion
@Name varchar(70),
@foreginKeyName varchar(70)
AS
BEGIN
DECLARE @foreginKeyId int
SELECT @foreginKeyId=countryId FROM tblCountry WHERE countryName=@foreginKeyName
INSERT INTO tblRegion VALUES(@Name,@foreginKeyId)
END

GO
CREATE PROC spUpdateRegion
@previousName varchar(70),
@NewName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblRegion WHERE RegionName=@previousName)
BEGIN
UPDATE tblRegion SET RegionName=@NewName WHERE RegionName=@previousName
END
ELSE
raiserror('REGION NOT UPDATED', 16,1)
END

GO
CREATE PROC spDeleteRegion
@previousName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblRegion WHERE RegionName=@previousName)
BEGIN
DELETE FROM tblRegion WHERE RegionName=@previousName
END
ELSE
raiserror('REGION NOT DELETED', 16,1)
END

GO

CREATE PROC spAddZone
@Name varchar(70),
@foreginKeyName varchar(70)
AS
BEGIN
DECLARE @foreginKeyId int
SELECT @foreginKeyId=RegionId FROM tblRegion WHERE RegionName=@foreginKeyName
INSERT INTO tblZone VALUES(@Name,@foreginKeyId)
END

GO
CREATE PROC spUpdateZone
@previousName varchar(70),
@NewName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblZone WHERE ZoneName=@previousName)
BEGIN
UPDATE tblZone SET ZoneName=@NewName WHERE ZoneName=@previousName
END
ELSE
raiserror('Zone NOT UPDATED', 16,1)
END

GO
CREATE PROC spDeleteZone
@previousName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblZone WHERE ZoneName=@previousName)
BEGIN
DELETE FROM tblZone WHERE ZoneName=@previousName
END
ELSE
raiserror('Zone NOT DELETED', 16,1)
END

GO

CREATE PROC spAddWoreda
@Name varchar(70),
@foreginKeyName varchar(70)
AS
BEGIN
DECLARE @foreginKeyId int
SELECT @foreginKeyId=ZoneId FROM tblZone WHERE ZoneName=@foreginKeyName
INSERT INTO tblWoreda VALUES(@Name,@foreginKeyId)
END

GO
CREATE PROC spUpdateWoreda
@previousName varchar(70),
@NewName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblWoreda WHERE WoredaName=@previousName)
BEGIN
UPDATE tblWoreda SET WoredaName=@NewName WHERE WoredaName=@previousName
END
ELSE
raiserror('Woreda NOT UPDATED', 16,1)
END

GO
CREATE PROC spDeleteWoreda
@previousName varchar(70)
AS
BEGIN
IF EXISTS(SELECT * FROM tblWoreda WHERE WoredaName=@previousName)
BEGIN
DELETE FROM tblWoreda WHERE WoredaName=@previousName
END
ELSE
raiserror('Woreda NOT DELETED', 16,1)
END

GO

CREATE PROC spAddStreet
@Name varchar(100),
@foreginKeyName varchar(70)
AS
BEGIN
DECLARE @foreginKeyId int
SELECT @foreginKeyId=WoredaId FROM tblWoreda WHERE WoredaName=@foreginKeyName
INSERT INTO tblStreet VALUES(@Name,@foreginKeyId)
END

GO
CREATE PROC spUpdateStreet
@previousName varchar(100),
@NewName varchar(100)
AS
BEGIN
IF EXISTS(SELECT * FROM tblStreet WHERE StreetName=@previousName)
BEGIN
UPDATE tblStreet SET StreetName=@NewName WHERE StreetName=@previousName
END
ELSE
raiserror('Street NOT UPDATED', 16,1)
END

GO
CREATE PROC spDeleteStreet
@previousName varchar(100)
AS
BEGIN
IF EXISTS(SELECT * FROM tblStreet WHERE StreetName=@previousName)
BEGIN
DELETE FROM tblStreet WHERE StreetName=@previousName
END
ELSE
raiserror('Street NOT DELETED', 16,1)
END

GO
CREATE PROC spAddProperty
@propertySize decimal(10,2),
@typeId int,
@ownerId int,
@countryName varchar(70),
@regionName varchar(70),
@zoneName varchar(70),
@woredaName varchar(70),
@streetName varchar(100)
AS
BEGIN
DECLARE @countryId int, @regionId int, @zoneId int,@woredaId int,@StreetId int
IF NOT EXISTS (SELECT * FROM tblCountry WHERE countryName=@countryName)
BEGIN
EXEC spAddCountry @countryName
END
SELECT @countryId=countryId FROM tblCountry WHERE countryName=@countryName
IF NOT EXISTS (SELECT * FROM tblRegion WHERE RegionName=@regionName)
BEGIN
EXEC spAddRegion @regionName,@countryName
END
SELECT @regionId=RegionId FROM tblRegion WHERE RegionName=@regionName
IF NOT EXISTS (SELECT * FROM tblZone WHERE ZoneName=@zoneName)
BEGIN
EXEC spAddZone @zoneName,@regionName
END
SELECT @zoneId=ZoneId FROM tblZone WHERE ZoneName=@zoneName
IF NOT EXISTS (SELECT * FROM tblWoreda WHERE WoredaName=@woredaName)
BEGIN
EXEC spAddWoreda @woredaName,@zoneName
END
SELECT @woredaId=WoredaId FROM tblWoreda WHERE WoredaName=@woredaName
IF NOT EXISTS (SELECT * FROM tblStreet WHERE StreetName=@streetName)
BEGIN
EXEC spAddStreet @streetName,@woredaName
END
SELECT @StreetId=StreetId FROM tblStreet WHERE StreetName=@streetName
Insert into tblProperty values(@propertySize,@typeId,@ownerId,@StreetId)
End

GO

CREATE PROC spUpdateProperty
@propertyId int,
@propertySize decimal(10,2),
@typeName VARCHAR(30),
@ownerId int,
@countryName varchar(70),
@regionName varchar(70),
@zoneName varchar(70),
@woredaName varchar(70),
@streetName varchar(100)
AS
BEGIN
DECLARE @OldcountryName varchar(70), @OldregionName varchar(70), @oldzoneName varchar(70),@oldworedaName varchar(70),@OldStreetName varchar(100),
@typeId int
SELECT @OldStreetName=Street.StreetName,@oldworedaName=Woreda.WoredaName,@oldzoneName=Zones.ZoneName,
	@OldregionName=Region.RegionName,@OldcountryName=Country.countryName
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
	WHERE P.propertyId=@propertyId
EXEC spUpdateCountry @OldcountryName,@countryName
EXEC spUpdateRegion @OldregionName,@regionName
EXEC spUpdateZone @oldzoneName,@zoneName
EXEC spUpdateWoreda @oldworedaName,@woredaName
EXEC spUpdateStreet @OldStreetName,@streetName
DECLARE @streetId int
SELECT @streetId=StreetId FROM tblStreet WHERE StreetName=@streetName
IF EXISTS(SELECT * FROM tblPropertyType WHERE typeName=@typeName)
	BEGIN
	SELECT @typeId=typeId FROM tblPropertyType WHERE typeName=@typeName
	END
ELSE
	BEGIN
	EXEC spAddPropertyType @typeName
	SELECT @typeId=typeId FROM tblPropertyType WHERE typeName=@typeName
	END
UPDATE tblProperty SET propertySize=@propertySize, typeId=@typeId,ownerId=@ownerId,StreetId=@streetId WHERE propertyId=@propertyId
End

GO

CREATE PROC spSearchPropertyByPropertyId
@propertyId int
AS
BEGIN
SELECT P.propertyId, P.propertySize, PropertyType.typeName ,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name]
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
	WHERE P.propertyId=@propertyId
END

GO
CREATE PROC spDeletePropertForSell
@propertyId int
AS
BEGIN
IF EXISTS(SELECT * FROM tblForSell WHERE propertyId=@propertyId)
BEGIN
DELETE FROM tblForSell WHERE propertyId=@propertyId
END
ELSE
raiserror('PROPERTY NOT DELETED FROM FOR SELL LISTING', 16,1)
END
GO
CREATE PROC spDeleteProperty
@propertyId int
AS
BEGIN
IF EXISTS(SELECT * FROM tblProperty WHERE propertyId=@propertyId)
BEGIN
DELETE FROM tblProperty WHERE propertyId=@propertyId
EXEC spDeletePropertForSell @propertyId
END
ELSE
raiserror('PROPERTY NOT DELETED', 16,1)
END

GO

CREATE PROC spListForSell
@propertyId int,
@isAvailable bit,
@price money,
@ownerId int,
@agentId int
AS
BEGIN
INSERT INTO tblForSell VALUES (@propertyId,@isAvailable,@price,@ownerId,@agentId)
END

GO

CREATE PROC spUpdateAgentonForSell
@agentId int,
@propertyId INT
AS
BEGIN
UPDATE tblForSell SET agentId=@agentId WHERE propertyId=@propertyId
END
GO
CREATE PROC spUpdateOwneronForSell
@ownerId int,
@propertyId INT
AS
BEGIN
UPDATE tblForSell SET ownerId=@ownerId WHERE propertyId=@propertyId
END
GO
CREATE PROC spPropertytoBeSoldByAgent
@agentId int
AS
BEGIN
SELECT P.propertyId, P.propertySize, PropertyType.typeName ,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name],F.price,F.isAvailable
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
JOIN tblForSell F
	ON P.propertyId=F.propertyId
	WHERE F.agentId=@agentId
END

GO

CREATE PROC spPropertytoBeSoldByOwner
@ownerId int
AS
BEGIN
SELECT P.propertyId, P.propertySize, PropertyType.typeName ,Own.firstName+' '+Own.lastName AS [Owner Name], Street.StreetName AS [Street Name],
Woreda.WoredaName,Zones.ZoneName AS [Zone Name],Region.RegionName AS [Region Name],Country.countryName AS [country Name],F.price,F.isAvailable, 
A.firstName+' '+A.lastName AS [Agent Name]
FROM tblProperty P
JOIN tblPropertyType PropertyType 
	ON P.typeId=PropertyType.typeId
JOIN tblClient Own
	ON P.ownerId=Own.clientId
JOIN tblStreet Street
	ON P.StreetId=Street.StreetId
JOIN tblWoreda Woreda
	ON Street.WoredaId=Woreda.WoredaId
JOIN tblZone Zones
	ON Woreda.zoneId=Zones.ZoneId
JOIN tblRegion Region
	ON Zones.RegionId=Region.RegionId
JOIN tblCountry Country
	ON Region.countryId=Country.countryId
JOIN tblForSell F
	ON P.propertyId=F.propertyId
JOIN tblAgent A
	ON A.agentId=F.agentId
	WHERE F.ownerId=@ownerId
END

GO

CREATE PROC spAddSoldProperty
@propertyId int,
@sellerId int,
@buyerId int,
@dateSold Date,
@agentId int,
@price money
AS
BEGIN
IF EXISTS(SELECT propertyId FROM tblForSell WHERE propertyId=@propertyId)
BEGIN
INSERT INTO tblSellHistory VALUES (@propertyId,@sellerId,@buyerId,@dateSold,@agentId,@price)
END
ELSE
raiserror('PROPERTY DOES NOT EXIST IN SELL LISTING', 16,1)
END

GO

CREATE PROC spUpdateSoldProperty
@transactionId int,
@propertyId int,
@sellerId int,
@buyerId int,
@dateSold Date,
@agentId int,
@price money
AS
BEGIN
IF EXISTS(SELECT transactionId FROM tblSellHistory WHERE transactionId=@transactionId)
BEGIN
UPDATE tblSellHistory SET propertyId=@propertyId,sellerId=@sellerId,buyerId=@buyerId,dateSold=@dateSold,
agentId=@agentId WHERE transactionId=@transactionId
END
ELSE
raiserror('TRANSACTION DOES NOT EXIST', 16,1)
END

GO

CREATE PROC spDeleteSoldProperty
@transactionId int
AS
BEGIN
IF EXISTS(SELECT transactionId FROM tblSellHistory WHERE transactionId=@transactionId)
BEGIN
DELETE FROM tblSellHistory WHERE transactionId=@transactionId
END
END

GO
CREATE PROC spDisplayAllSoldProperty
AS
BEGIN
SELECT S.transactionId,S.propertyId,Seller.firstName+' '+Seller.lastName AS [Seller Name],
Buyer.firstName+' '+Buyer.lastName AS[Buyer Name],S.dateSold,A.firstName+' '+A.lastName AS [Agent Name],S.price
FROM tblSellHistory S
JOIN tblClient Seller
	ON S.sellerId=Seller.clientId
JOIN tblClient Buyer
	ON S.buyerId=Buyer.clientId
JOIN tblAgent A
	ON S.agentId=A.agentId
END

GO

CREATE PROC spSearchTransaction
@transactionId INT
AS
BEGIN
IF EXISTS(SELECT transactionId FROM tblSellHistory WHERE transactionId=@transactionId)
BEGIN
SELECT S.transactionId,S.propertyId,Seller.firstName+' '+Seller.lastName AS [Seller Name],
Buyer.firstName+' '+Buyer.lastName AS[Buyer Name],S.dateSold,A.firstName+' '+A.lastName AS [Agent Name],S.price
FROM tblSellHistory S
JOIN tblClient Seller
	ON S.sellerId=Seller.clientId
JOIN tblClient Buyer
	ON S.buyerId=Buyer.clientId
JOIN tblAgent A
	ON S.agentId=A.agentId
	WHERE S.transactionId=@transactionId
END
ELSE
raiserror('TRANSACTION DOES NOT EXIST', 16,1)
END

GO
CREATE PROC spAddCommission
@agentId int,
@propertyId int
AS
BEGIN
DECLARE @totalCommission money,@temp money,@price money,@commissionPercent decimal(5,2),@mid money
IF EXISTS(SELECT agentId FROM tblAgent WHERE agentId=@agentId)
BEGIN
	IF EXISTS(SELECT propertyId FROM tblSellHistory WHERE propertyId=@propertyId)
	BEGIN
	SELECT @temp=A.totalCommission,@price=S.price,@commissionPercent=A.commissionPercent
    FROM  tblAgent A
	JOIN tblSellHistory S
		ON A.agentId=S.agentId
		WHERE A.agentId=@agentId AND S.propertyId=@propertyId
	SET @mid= @price*@commissionPercent
	SET @totalCommission=@temp+@mid
	UPDATE tblAgent SET totalCommission=@totalCommission WHERE agentId=@agentId
	END
	ELSE
	RAISERROR('PROPERTY NOT FOUND',16,1)
END
ELSE
RAISERROR('AGENT NOT FOUND',16,1)
END

GO
CREATE TRIGGER trgAgentCommission
ON tblSellHistory
AFTER INSERT
AS
BEGIN
DECLARE @agentId int,@propertyId int
SELECT TOP 1 @agentId=agentId,@propertyId=propertyId FROM inserted ORDER BY transactionId DESC
EXEC spAddCommission @agentId,@propertyId
END

GO

CREATE FUNCTION udfProperName(@name varchar(20))
RETURNS varchar(20)
AS
BEGIN
DECLARE @properName varchar(20)
SET @properName= UPPER(LEFT(@name,1))+LOWER(RIGHT(@name,LEN(@name)-1))
RETURN @properName
END


GO

CREATE TRIGGER trgAddAdmin
ON tblAdmin
AFTER INSERT
AS
BEGIN
IF EXISTS(SELECT * FROM INSERTED WHERE email NOT LIKE '%_@__%.__%')
	ROLLBACK TRANSACTION
ELSE
	BEGIN
	UPDATE tblAdmin
		SET firstName = dbo.udfProperName(firstName), lastName = dbo.udfProperName(lastName)
		WHERE adminId = (SELECT adminId FROM inserted)
	END
END

GO
CREATE TRIGGER trgAddAgent
ON tblAgent
AFTER INSERT
AS
BEGIN
IF EXISTS(SELECT * FROM INSERTED WHERE email NOT LIKE '%_@__%.__%')
	ROLLBACK TRANSACTION
ELSE
	BEGIN
	UPDATE tblAgent
		SET firstName = dbo.udfProperName(firstName), lastName = dbo.udfProperName(lastName)
		WHERE agentId = (SELECT agentId FROM inserted)
	END
END

GO

CREATE TRIGGER trgAddClient
ON tblClient
AFTER INSERT
AS
BEGIN
IF EXISTS(SELECT * FROM INSERTED WHERE email NOT LIKE '%_@__%.__%')
	ROLLBACK TRANSACTION
ELSE
	BEGIN
	UPDATE tblClient
		SET firstName = dbo.udfProperName(firstName), lastName = dbo.udfProperName(lastName)
		WHERE clientId = (SELECT clientId FROM inserted)
	END
END

GO

CREATE TRIGGER trgAddPropertyType
ON tblPropertyType
AFTER INSERT
AS 
BEGIN
UPDATE tblPropertyType
		SET typeName = dbo.udfProperName(typeName)
		WHERE typeId = (SELECT typeId FROM inserted)
END