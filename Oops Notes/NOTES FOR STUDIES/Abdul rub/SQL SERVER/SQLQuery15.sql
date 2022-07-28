use Assignment ;
go
create proc InsertEmp
@empno decimal(4, 0),
@ename varchar(129)
as
Insert into SCOTT.EMP (EMPNO ,ENAME ) values(@empno , @ename );