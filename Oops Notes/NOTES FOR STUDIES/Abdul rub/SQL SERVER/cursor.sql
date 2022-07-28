DECLARE @order_num INT;
DECLARE order_cursor CURSOR
FOR
SELECT orderID FROM Orders ORDER By orderID;
OPEN order_cursor;
FETCH NEXT FROM order_cursor INTO @order_num;
while @@FETCH_STATUS =0
begin
fetch next from order_cursor into @order_num;
end
close order_cursor
deallocate order_cursor;


