Public Class UserControl1
    Private constr As String
    Private tab As String
    Private WithEvents obj As LoginArea.Authentication
    Public Property ConnectionString As String
        Get
            Return constr
        End Get
        Set(ByVal value As String)
            constr = value
        End Set
    End Property
    Public Property TableUser As String
        Get
            Return tab
        End Get
        Set(ByVal value As String)
            tab = value
        End Set
    End Property
    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        obj = New LoginArea.Authentication()
        obj.ConnectionStr = ConnectionString
        If obj.checkAuth(Me.TextBox1.Text.Trim(), Me.TextBox2.Text.Trim(), TableUser) Then
            MessageBox.Show("Login Successfl")
        Else
            MessageBox.Show("Login Unsuccessfl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
