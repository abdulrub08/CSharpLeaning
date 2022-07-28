Public Class bymobileNo

    Private Sub bymobileNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbymobileno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbymobileno.Click
        If txtmobileno.Text = "" Then
            MessageBox.Show("Please Enter the 10 digit Mobile No ")
            Exit Sub
        End If
        Dim sql As String
        Dim ds As DataSet
        sql = "select *from generalquery where mobileno='" & txtmobileno.Text & "'"
        ds = selectquery(sql)
        DataGridView1.DataSource = ds.Tables("a")

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class