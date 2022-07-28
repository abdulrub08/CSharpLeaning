Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnn As New SqlConnection(" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=student3;Data Source=vikas\SQLEXPRESS")
        Dim Sql As String
        Sql = "select loginname from userinfo where loginname='" & txtloginname.Text & "' and passward='" & txtpassword.Text & "'"
        Dim da As New SqlDataAdapter(Sql, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            g_loginname = txtloginname.Text
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid login name or Password")

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloginname.TextChanged

    End Sub

    Private Sub txtloginname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtloginname.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtloginname.Focus()
        End If
    End Sub

    Private Sub txtloginname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloginname.Enter
        txtloginname.SelectAll()
    End Sub

    Private Sub txtpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Enter
        txtpassword.SelectAll()
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class
