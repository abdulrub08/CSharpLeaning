use Assignment ;
go
create trigger Trig1 
on employees
after update 
as
insert into Assignment.dbo.autidtable(id,operation,dopr) values(1001,'Update',GETDATE ());
