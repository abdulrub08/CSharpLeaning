sp_helptext spAddTwoNumber


Declare @DisplayResult int
exec spAddTwoNumber 2,3,@DisplayResult output
Select GetDate(),@DisplayResult


--Declare @ExcParamval INT
--exec spOutputProc 1,4,@ExcParamval OUTPUT