Create Proc spAddTwoNumber
@Num1 int,
@Num2 int,
@Result int Output
With Encryption
As
Begin
set  @Result= @Num1+ @Num2;
End







