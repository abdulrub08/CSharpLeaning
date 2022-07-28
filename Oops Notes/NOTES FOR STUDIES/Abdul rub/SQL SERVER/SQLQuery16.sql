use Assignment ;
declare @empno decimal(4, 0);
declare @ename varchar(129);

set @empno = 123;
set @ename = 'ALOK KUMAR';
exec InsertEmp @empno , @ename ;
