

CREATE TABLE Sales_Raw

(

    OrderID INT,

    OrderDate VARCHAR(20),

    CustomerName VARCHAR(100),

    CustomerPhone VARCHAR(20),

    CustomerCity VARCHAR(50),

    ProductNames VARCHAR(200),   -- Multiple products comma-separated

    Quantities VARCHAR(100),     -- Multiple quantities comma-separated

    UnitPrices VARCHAR(100),     -- Multiple prices comma-separated

    SalesPerson VARCHAR(100)

);

INSERT INTO Sales_Raw VALUES

(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

 

(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',

 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

 

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop', '1', '54000', 'Suresh'),

 

(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',

 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

 

(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',

 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');

CREATE TABLE CustomerMaster
(
    CustID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    PhoneNumber VARCHAR(20), 
    City VARCHAR(50)
);

CREATE TABLE ProductMaster
(
    PID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    CurrentPrice DECIMAL(10,2)
);

CREATE TABLE SalesMaster
(
    SID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50)
);

CREATE TABLE CustomerOrderDetails
(
    OID INT PRIMARY KEY, 
    CID INT,
    SID INT,
    OrderDate DATE,
    FOREIGN KEY (CID) REFERENCES CustomerMaster(CustID),
    FOREIGN KEY (SID) REFERENCES SalesMaster(SID)
);

CREATE TABLE OrderDetails
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    OID INT,
    PID INT,
    Qty INT,
    
    SoldPrice DECIMAL(10,2), 
    FOREIGN KEY (OID) REFERENCES CustomerOrderDetails(OID),
    FOREIGN KEY (PID) REFERENCES ProductMaster(PID)
);


INSERT INTO CustomerMaster (Name, PhoneNumber, City) VALUES
('Ravi Kumar', '9876543210', 'Chennai'),
('Priya Sharma', '9123456789', 'Bangalore'),
('John Peter', '9988776655', 'Hyderabad');

INSERT INTO ProductMaster (Name, CurrentPrice) VALUES
('Laptop', 55000),
('Mouse', 500),
('Keyboard', 1500),
('Monitor', 12000);

INSERT INTO SalesMaster (Name) VALUES
('Anitha'),
('Suresh');

INSERT INTO CustomerOrderDetails (OID, CID, SID, OrderDate) VALUES
(101, 1, 1, '2024-01-05'),
(102, 2, 1, '2024-01-06'),
(103, 1, 2, '2024-01-10'),
(104, 3, 1, '2024-02-01'),
(105, 2, 2, '2024-02-10');

INSERT INTO OrderDetails (OID, PID, Qty, SoldPrice) VALUES
(101, 1, 1, 55000),
(101, 2, 2, 500),
(102, 3, 1, 1500),
(102, 2, 1, 500),
(103, 1, 1, 54000), 
(104, 4, 1, 12000),
(104, 2, 1, 500),
(105, 1, 1, 56000), 
(105, 3, 1, 1500);

SELECT TOP 1 TotalAmount
FROM (
    SELECT TOP 3
        od.OID,
        SUM(od.Qty * od.SoldPrice) AS TotalAmount
    FROM OrderDetails od
    GROUP BY od.OID
    ORDER BY TotalAmount DESC
) AS TopThreeOrders
ORDER BY TotalAmount ASC;


SELECT
    sm.Name AS SalesPerson,
    SUM(od.Qty * od.SoldPrice) AS TotalRevenue
FROM OrderDetails od
JOIN CustomerOrderDetails cod ON od.OID = cod.OID
JOIN SalesMaster sm ON cod.SID = sm.SID
GROUP BY sm.Name
HAVING SUM(od.Qty * od.SoldPrice) > 60000;

SELECT
    cm.Name AS CustomerName,
    SUM(od.Qty * od.SoldPrice) AS TotalSpent
FROM OrderDetails od
JOIN CustomerOrderDetails cod ON od.OID = cod.OID
JOIN CustomerMaster cm ON cod.CID = cm.CustID
GROUP BY cm.Name
HAVING SUM(od.Qty * od.SoldPrice) >
(
    
    SELECT AVG(CustomerTotal)
    FROM (
        SELECT
            cod2.CID,
            SUM(od2.Qty * od2.SoldPrice) AS CustomerTotal
        FROM CustomerOrderDetails cod2
        JOIN OrderDetails od2 ON cod2.OID = od2.OID
        GROUP BY cod2.CID
    ) AS AvgCalc
);


SELECT
    UPPER(cm.Name) AS CustomerName,
    DATENAME(MONTH, cod.OrderDate) AS OrderMonth
FROM CustomerMaster cm
JOIN CustomerOrderDetails cod ON cm.CustID = cod.CID
WHERE cod.OrderDate >= '2024-01-01' AND cod.OrderDate <= '2024-01-31';