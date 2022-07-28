Public Class CheckAccount
    Inherits Account
    Public Overrides Function wihtDraw(ByVal amt As Integer) As Boolean
        Dim overDraft As Integer = 500
        If AccountBal - overDraft > amt Then
            Return MyBase.wihtDraw(amt)
        Else
            Return (False)
        End If
    End Function

End Class
