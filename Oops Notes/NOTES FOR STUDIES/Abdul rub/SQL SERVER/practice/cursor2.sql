use Assignment;
declare @order_id int;
declare order_cursor cursor
for
select orderId from orders order by orderid;
open order_cursor;
fetch next from order_cursor into @order_id;

while @@FETCH_STATUS =0
begin
fetch next from order_cursor into @order_id;
end
close order_cursor
deallocate order_cursor;
