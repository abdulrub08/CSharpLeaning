Public Class byname

    Private Sub btnsearchname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchname.Click
        If txtbyname.Text = "" Then
            MessageBox.Show("Please Enter the student name")
            Exit Sub
        End If

        Dim sql As String
        Dim ds As DataSet
        sql = "select *from generalquery where studentname like '" & txtbyname.Text & "'"
        ds = selectquery(sql)
        DataGridView1.DataSource = ds.Tables("a")

    End Sub
End Class