-- Database Creation 
Create database Asses1_DB;
Use Asses1_DB;

-- Table Creation
Create Table Sales_Raw ( OrderId INT,
						 OrderDate VARCHAR(20),
						 CustomerName VARCHAR(100),
						 CustomerPhone VARCHAR(20),
						 CustomerCity VARCHAR(50),
						 ProductNames VARCHAR(200),
						 Quantities VARCHAR(100),
						 UnitPrices VARCHAR(100),
						 SalesPerson VARCHAR(100));

-- Insert data into table
Insert Into Sales_Raw Values
	(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai','Laptop,Mouse', '1,2', '55000,500', 'Anitha'),
	(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore','Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),
	(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai','Laptop', '1', '54000', 'Suresh'),
	(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad','Monitor,Mouse', '1,1', '12000,500', 'Anitha'),
	(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore','Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');

Select * From Sales_Raw;

-- Ques 1: Normalization
-- Three normalization Problem
-- 1. Attributes contains multiple value (no Atomicity) voilates 1NF
-- 2. Customer Name is repeating voilates 2NF (patial dependency)
-- 3. Every detail is in one table (orders, customer, product) voilates 3NF (transitive dependency)

Create Table Customer(CustomerId Int Primary Key Identity(101,1),
					  CustomerName VARCHAR(50) not null,
					  CustomerPhone VARCHAR(20),
					  CustomerCity VARCHAR(50));

Create Table SalesPerson( SalesPersonId Int Primary Key Identity(1,1),
						  SalesPersonName VARCHAR(100));

Create Table Product(ProductId Int Primary Key Identity(1001,1),
					 ProductName VARCHAR(100),
					 ProductPrice INT);

Create Table Orders(OrderId int primary key,
				    OrderDate VARCHAR(20),
				    CustomerId int,
				    SalesPersonId int
					foreign key (CustomerId) REFERENCES Customer(CustomerId),
                    foreign key (SalesPersonId) REFERENCES SalesPerson(SalesPersonId));

-- Ques 2: Third Highest Total Sales

with Totals as (
	select s.OrderId,
	SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
	from Sales_Raw s
	CROSS APPLY OPENJSON('["' + REPLACE(s.Quantities, ',', '","') + '"]') q
	CROSS APPLY OPENJSON('["' + REPLACE(s.UnitPrices, ',', '","') + '"]') p
	where q.[key] = p.[key]
	group by s.OrderId
)

Select OrderId, TotalSales
from (Select *,ROW_NUMBER() over (Order by TotalSales DESC) r
    from Totals
) t
Where r = 3;


-- Ques 3:
Select s.SalesPerson,
SUM(CAST(q.value as INT) * CAST(p.value as INT)) as TotalSales
from Sales_Raw s
CROSS APPLY OPENJSON('["' + REPLACE(s.Quantities, ',', '","') + '"]') q
CROSS APPLY OPENJSON('["' + REPLACE(s.UnitPrices, ',', '","') + '"]') p
where q.[key] = p.[key]
group by s.SalesPerson
having SUM(CAST(q.value as INT) * CAST(p.value as INT)) > 60000;

--Ques 4:
select CustomerName,
sum(cast(q.value as Int) * cast(p.value as Int)) as total_spent
from sales_raw s
cross apply openjson('["' + replace(s.Quantities, ',', '","') + '"]') q
cross apply openjson('["' + replace(s.UnitPrices, ',', '","') + '"]') p
where q.[key] = p.[key]
group by CustomerName
having sum(cast(q.value as int) * cast(p.value as int)) >
(
    select avg(customer_total)
    from (
        select customername,
               sum(cast(q2.value as int) * cast(p2.value as int)) as customer_total
        from sales_raw s2
        cross apply openjson('["' + replace(s2.Quantities, ',', '","') + '"]') q2
        cross apply openjson('["' + replace(s2.UnitPrices, ',', '","') + '"]') p2
        where q2.[key] = p2.[key]
        group by CustomerName
    ) x
);

-- Ques 5:
select orderid,
upper(customername) as customername,
month(cast(orderdate as date)) as order_month
from sales_raw
where year(cast(orderdate as date)) = 2026 and month(cast(orderdate as date)) = 1;
