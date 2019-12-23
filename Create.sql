CREATE TABLE dbo.Position
(
PositionID INT NOT NULL PRIMARY KEY,
PositionName VARCHAR(20) NULL,
Salary INT NULL,
Duties VARCHAR(100)  NULL,
Requirements VARCHAR(100) NULL
);

CREATE TABLE dbo.Worker
(
WorkerID INT NOT NULL PRIMARY KEY,
FIO VARCHAR(100) NULL,
Age INT NULL,
Adress VARCHAR (50) NULL,
PhoneNum VARCHAR (15) NULL,
Passport VARCHAR(9) NULL,
PK_Position INT NULL,
FOREIGN KEY (PK_Position) REFERENCES Position(PositionID)
);

CREATE TABLE dbo.Model
(
ModelId INT NOT NULL PRIMARY KEY,
ModelName VARCHAR(50) NULL,
Manufacturer VARCHAR(20) NULL,
YearOfManufacture VARCHAR (50) NULL,
InspectionDate DATE NULL
);


CREATE TABLE dbo.ServicedShops
(
ServicedShopsId INT NOT NULL PRIMARY KEY,
ShopName VARCHAR(20) NULL,
Adress VARCHAR (50) NULL,
PhoneNum VARCHAR (11) NULL,
);

CREATE TABLE dbo.Service
(
ServiceId INT NOT NULL PRIMARY KEY,
ServiceName VARCHAR(20)  NULL,
Price INT NULL, 
);

CREATE TABLE dbo.Client
(
ClientID INT NOT NULL PRIMARY KEY,
FIO VARCHAR(100) NULL,
Adress VARCHAR (50) NULL,
PhoneNum VARCHAR (15) NULL
);

CREATE TABLE dbo.Spares
(
SparesId INT NOT NULL PRIMARY KEY,
SpareName VARCHAR(20)  NULL,
Price INT NULL, 
Existence BIT NULL,
PK_Shop INT NULL,
FOREIGN KEY (PK_Shop) REFERENCES ServicedShops(ServicedShopsId)
);

CREATE TABLE dbo.Orders
(
OrdersId INT NOT NULL PRIMARY KEY,
PK_Service INT  NULL,
PK_Client INT NULL,
PK_Worker INT  NULL,
EtecutionMark VARCHAR (10)  NULL,
Price INT  NULL,
OrderDate DATE  NULL,
ReturnDate DATE  NULL,
PK_Model INT  NULL,
FOREIGN KEY (PK_Service) REFERENCES Service(ServiceID),
FOREIGN KEY (PK_Client) REFERENCES Client(ClientID),
FOREIGN KEY (PK_Worker) REFERENCES Worker(WorkerID),
FOREIGN KEY (PK_Model) REFERENCES Model(ModelID)
);

CREATE TABLE dbo.SpareManufacturer
(
SpareManufacturerId INT NOT NULL PRIMARY KEY,
ManufacturerName VARCHAR(20)  NULL,
Adress VARCHAR(50) NULL, 
PhoneNum VARCHAR(11) NULL, 
PK_Shop INT NULL,
FOREIGN KEY (PK_Shop) REFERENCES ServicedShops(ServicedShopsId)
);

CREATE TABLE dbo.SpareForOrder
(
PK_Orders INT NULL,
PK_Spare INT NULL,
FOREIGN KEY (PK_Spare) REFERENCES Spares(SparesId),
FOREIGN KEY (PK_Orders) REFERENCES Orders(OrdersID)
);

CREATE TABLE dbo.Auth
(
Auth_ID INT NOT NULL PRIMARY KEY,
AuthLogin VARCHAR(20) NULL,
AuthPass VARCHAR(20) NULL
);