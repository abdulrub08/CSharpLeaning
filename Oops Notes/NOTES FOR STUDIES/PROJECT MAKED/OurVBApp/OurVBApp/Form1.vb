Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim sql As String
        sql = "select * from userinfo where empid='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        ds = SelectQuery(sql)
        If (ds.Tables("a").Rows.Count > 0) Then
            MDIParent1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid ")

        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
End Class
