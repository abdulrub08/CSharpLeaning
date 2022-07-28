Public Class bycourse

    Private Sub btnbycoursesearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbycoursesearch.Click
        Dim sql As String
        Dim ds As DataSet
        sql = "select *from generalquery where course='" & cmbcourse.SelectedValue & "'"
        ds = selectquery(sql)
        DataGridView1.DataSource = ds.Tables("a")
    End Sub

    Private Sub bycourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student3DataSet1.CourseMaster' table. You can move, or remove it, as needed.
        Me.CourseMasterTableAdapter.Fill(Me.Student3DataSet1.CourseMaster)

    End Sub
End Class