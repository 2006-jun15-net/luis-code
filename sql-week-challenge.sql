CREATE TABLE Customers(
	CustomerID INT IDENTITY(1, 1) NOT NULL,
	FirstName NVARCHAR(200) NOT NULL,
	LastName NVARCHAR(200) NOT NULL,
	CardNumber NVARCHAR(16) NOT NULL,
	CONSTRAINT PK_Customers PRIMARY KEY (CustomerID)
);

CREATE TABLE Products(
	ProductID INT IDENTITY(1, 1) NOT NULL,
	Name NVARCHAR(200) NOT NULL,
	Price NUMERIC(10,2) NOT NULL,
	CONSTRAINT PK_Products PRIMARY KEY (ProductID)
);

CREATE TABLE Orders(
	OrderID INT IDENTITY(1, 1) NOT NULL,
	CustomerID INT NOT NULL,
	ProductID INT NOT NULL,
	
	CONSTRAINT PK_Orders PRIMARY KEY (OrderID), 
	CONSTRAINT FK_Orders_Customers_CustomerID FOREIGN KEY (CustomerID)
		REFERENCES Customers (CustomerID),
	CONSTRAINT FK_Orders_Products_ProductID FOREIGN KEY (ProductID)
		REFERENCES Products (ProductID)
	
);


INSERT INTO Customers (FirstName,LastName,CardNumber) VALUES
	('Sam', 'Smith', '1234123412341234'),
	('George', 'Hansen', '1234123412341234'),
	('Janice', 'Lu', '1234123412341234')

GO 

INSERT INTO Products(Name, Price) VALUES
	('Sandwich', 5.99),
	('Bike', 75 ),
	('Jeans', 30.00)

GO

INSERT INTO Orders (ProductID, CustomerID) VALUES
	(1,1),
	(2,1),
	(3,2)
;
GO

INSERT INTO Products(Name, Price) VALUES
	('iPhone', 200)
GO

INSERT INTO Customers(FirstName,LastName, CardNumber) VALUES
	('Tina', 'Smith', '1234123412341234')
GO

INSERT INTO Orders (ProductID, CustomerID) VALUES
	(4,4)
GO

SELECT * 
FROM customers as c
	JOIN orders as o on c.customerID = o.customerID
WHERE c.FirstName = 'Tina' and c.LastName = 'Smith'


SELECT SUM(p.price)
FROM Products as p
	JOIN Orders as o on o.productID = p.productID
WHERE p.name = 'iphone'

UPDATE Products
SET price = 250
WHERE name = 'iPhone'

SELECT *
FROM Products






