use Assignment ;
Select Products.ProductID,Products.ProductName , Products.UnitPrice , Products.SupplierID  

From Products 
Where Products.SupplierID in (1,2);      