Public Class Account
    Private acc_name As String
    Private acc_bal As Integer
    Private acc_no As Integer
    Public Event errMsg(ByVal s As String)

    Public Overridable Function wihtDraw(ByVal amt As Integer) As Boolean
        If amt > acc_bal Then
            RaiseEvent errMsg("Invalid WihtDrawal")
            Return False
        End If
        acc_bal = acc_bal - amt
        Return True
    End Function
    Public Function Deposit(ByVal amt As Integer) As Boolean
        If amt < 0 Then
            RaiseEvent errMsg("Invalid Deposit")
            Return False
        End If
        acc_bal = acc_bal + amt
        Return True
    End Function
    Public Property AccountName()
        Get
            Return acc_name
        End Get
        Set(ByVal value)
            If value = "" Then
                RaiseEvent errMsg("Invalid Account Name ")
                Exit Property
            End If
            acc_name = value
        End Set
    End Property
    Public Property AccountNo()
        Get
            Return acc_no
        End Get
        Set(ByVal value)
            If IsNumeric(value) = False Then
                RaiseEvent errMsg("Invalid Account No ")
                Exit Property
            End If
            acc_no = value
        End Set
    End Property
    Public Property AccountBal()
        Get
            Return acc_bal
        End Get
        Set(ByVal value)
            If IsNumeric(value) = False Then
                RaiseEvent errMsg("Invalid Account Balance ")
                Exit Property
            End If
            acc_bal = value
        End Set
    End Property

End Class
