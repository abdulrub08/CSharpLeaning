use Assignment ;
 select Products.ProductID ,Products .ProductName ,Products.QuantityPerUnit 
 from Products 
 where Products.SupplierID =1003 and Products.QuantityPerUnit <=10