--1    Display the  fullname of the employee  
 select CONCAT(FirstName,' ',LastName) AS FullName FROM Employees

 --2	Display the  customer details  who has Fax number
 select * from Customers where Fax is not Null

 --3 display the customer details whose name holds second letter as U
 select * from Customers where ContactName LIKE '_u%'

--4	select order Details where unit price is greater than 10 and less than 20
select  * from [Order Details] where UnitPrice>10 and UnitPrice<20

--5.	Display order details which contains shipping date and arrange the order by date
select  * from Orders where ShippedDate is not NULL  ORDER BY ShippedDate

--6.	Print the orders shipped by ship name 'La corne d'abondance' between 2 dates(Choose dates of your choice)

select * from orders where ShipName = 'La corne d''abondance'  and ShippedDate between '1996-06-10' and '1996-10-20' 


--7	Print the products supplied by 'Exotic Liquids'
--Exotic liquids in Suppliers supplier id 1
--check for products table with supplier id 1
select * from Products where SupplierID=
(select SupplierID from Suppliers where CompanyName = 'Exotic Liquids')

--8.	print the average quantity ordered for every product
select p.ProductName,AVG(od.Quantity) from Products p inner join [Order Details] od
on p.ProductID=od.ProductID  group by p.ProductName

--9.Print all the Shipping company name and the ship names if they are operational
--ShipperID and company name in shippers tble
--ship name and ShipVia=ShipperID in orders table
select o.ShipName,s.CompanyName FROM 
Orders o inner join Shippers s
ON s.ShipperID = o.ShipVia
WHERE o.ShipRegion is not NULL

--10.	Print all Employees with Manager Name
--Employees table employyeID,ReportsTo
select e.FirstName+' '+e.LastName AS 'Employee Name', m.FirstName+' '+m.LastName AS 'Manager Name' FROM
 Employees e inner join Employees m ON m.EmployeeID=e.ReportsTo

--11.	Print the bill for a given order id .bill should contain Productname, Categoryname,price after discount

select p.ProductName,c.CategoryName, od.UnitPrice*(1-od.Discount) AS 'DiscountedPrice' FROM
Products p join Categories c ON p.CategoryID=c.CategoryID 
inner join [Order Details] od ON od.ProductID=p.ProductID

--12. Write   a procedure that determines the customer who has placed the maximum number of orders
--Orders table has CustomerID 
--Customers table has CustomerID, get company name from it
CREATE PROC spMaxNumOrders
AS
BEGIN
select CompanyName from Customers where CustomerID=
(select TOP 1 CustomerID FROM Orders GROUP BY CustomerID ORDER BY count(OrderID) desc)
END

ALTER PROC spMaxNumOrders
AS
BEGIN
select CompanyName AS MaximumOrdersCustomer from Customers where CustomerID=
(select TOP 1 CustomerID FROM Orders GROUP BY CustomerID ORDER BY count(OrderID) desc)
END

exec spMaxNumOrders

--13
CREATE PROC spProdOutOfStock
AS
BEGIN
select ProductName FROM Products WHERE UnitsInStock = 0 
END

exec spProdOutOfStock