Public Class Form7
    Dim WithEvents obj As CheckAccount
    Dim flag As Boolean
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = New CheckAccount
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        flag = True
        obj.AccountNo = Me.TextBox1.Text
        obj.AccountName = Me.TextBox2.Text
        obj.AccountBal = Me.TextBox3.Text
        If flag Then
            MessageBox.Show("Account Opened Successfully")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim amt As Integer
        amt = InputBox("Enter the Amount ")
        If obj.wihtDraw(amt) Then
            MessageBox.Show("WithDrawal is Successful")
        Else
            MessageBox.Show("WithDrawal is Unsuccessful")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim amt As Integer
        amt = InputBox("Enter the Amount ")
        If obj.Deposit(amt) Then
            MessageBox.Show("Deposit is Successful")
        Else
            MessageBox.Show("Deposit is Unsuccessful")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Acount No " & obj.AccountNo & vbCrLf & "Account Name " & obj.AccountName & vbCrLf & "Account Bal " & obj.AccountBal)
    End Sub

    Private Sub obj_errMsg(ByVal s As String) Handles obj.errMsg
        flag = False
        MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class