Public Class bydate

    Private Sub btnsearchbydate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchbydate.Click
        Dim sql As String
        Dim ds As DataSet
        sql = "select *from generalquery where entrydate between '" & DateTimePicker1.Value & "'and '" & DateTimePicker2.Value & "'"
        ds = selectquery(sql)
        DataGridView1.DataSource = ds.Tables("a")

    End Sub
End Class