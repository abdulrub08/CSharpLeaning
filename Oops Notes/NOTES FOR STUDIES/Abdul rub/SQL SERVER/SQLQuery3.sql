use Assignment ;
Select Products.SupplierID , COUNT(*)
from Products where Products.UnitPrice >=10  Group by Products .SupplierID 
having COUNT(*) > =2 ; 