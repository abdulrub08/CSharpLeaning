use Assignment ;
Declare @counter int;

set @counter =1;
while @counter <= 10
begin
print @counter ;
set @counter = @counter +1;
end;