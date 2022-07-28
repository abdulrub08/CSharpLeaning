Public Class Form1
    Dim WithEvents obj As checkaccount
    Dim flag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = New checkaccount
    End Sub

   

    Private Sub withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdraw.Click

    End Sub

    Private Sub open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open.Click
        flag = True
        obj.AccountName = Me.TextBox1.Text

    End Sub

    Private Sub deposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit.Click

    End Sub

    Private Sub status_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles status.Click

    End Sub
End Class
