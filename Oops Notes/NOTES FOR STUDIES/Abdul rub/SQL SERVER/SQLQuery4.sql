use Assignment ;
Select Customers.ContactName , Customers.CompanyName from Customers
Where Customers.CustomerID in 
(Select Orders.CustomerID 
from Orders 
Where Orders.OrderID in 
(
Select [Order Details].OrderID from [Order Details] 
where [Order Details].ProductID in 
(
Select Products.ProductID from Products 
where Products.ProductName = 'Chai'  )  )  )