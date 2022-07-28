use practiceapp;
select*from demo1
begin transaction; 
delete from demo1 where demo1.messageid =2;
select * from demo1
rollback;
select * from demo1
