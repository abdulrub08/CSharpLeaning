Alter proc spOutputProc --do not use like this sp_and procname weuse it like this (spprocname)
@Num1 as int,
@Num2 as int,
@Result int OUTPUT
With Encryption
As 
Begin
set @Result=@Num1+@Num2
End

Declare @ExcParamval INT
exec spOutputProc 1,4,@ExcParamval OUTPUT
Select @ExcParamval

sp_helptext spOutputProc
