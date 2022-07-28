use Assignment ;
go
create view Customer_Product123 as
Select c.ContactName , c.CompanyName, p.ProductName ,
p.UnitPrice from Customers as c , Orders as o , Products  as p, [Order Details] as od 
Where c.CustomerID = o.CustomerID and o.OrderID = od.OrderID  ;

    