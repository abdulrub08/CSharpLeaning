use Assignment ;
declare  emp_cur cursor for 
Select deptno,sal from SCOTT.EMP  ;
declare @dno as varchar(20);
declare @s as decimal(7, 2);
declare @sum as varchar(20);

open emp_cur;
fetch next from emp_cur into @dno,@s;
set @sum =0;
while @@FETCH_STATUS =0
begin
set @sum = @sum + CONVERT(int,@s) ;
fetch next from emp_cur into @dno,@s;
end;

close emp_cur
deallocate emp_cur;
print 'Total Salary Given ' + @sum;