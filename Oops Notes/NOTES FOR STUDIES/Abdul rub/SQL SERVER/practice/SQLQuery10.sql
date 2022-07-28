create trigger auditinsert
on dbo.demo1
after insert 
as
insert into dbo.demoaudit(whenchanged,tablename,operation)
select getdate(),'demo1','insert'