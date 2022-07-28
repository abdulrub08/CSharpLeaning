Public Class checkaccount
    Inherits Account
    Public Overrides Function withDraw(ByVal amt As Integer) As Boolean
        Dim overdraft As Integer = 500
        If AccountBal - overdraft > amt Then
            Return MyBase.withDraw(amt)
        Else
            Return False
        End If
    End Function

End Class
