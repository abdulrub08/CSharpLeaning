Imports System.Data
Public Class registrationform

    Private Sub registrationform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student3DataSet2.generalquery' table. You can move, or remove it, as needed.
        Me.GeneralqueryTableAdapter.Fill(Me.Student3DataSet2.generalquery)

    End Sub

    Private Sub btnsearchdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchdate.Click
        Dim sql As String
        Dim ds As DataSet
        sql = "select *from generalquery where entrydate between '" & DateTimePicker1.Value & "'and '" & DateTimePicker2.Value & "'"
        ds = selectquery(sql)
        DataGridView1.DataSource = ds.Tables("a")

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        btnadd.Enabled = False
        btnsave.Enabled = True
        btnexit.Text = "Cancel"
        made = "save"

    End Sub
    Dim made As String

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If btnadd.Text = "cancel" Then
            btnadd.Visible = True
            btnexit.Text = "Exit"
        Else
            Me.Close()

        End If

    End Sub
    Dim id As String


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sql As String
        Dim i As Integer
        i = 0
        sql = "delete from registration where id ='" & id & "'"
        i = ExecuteQuery(sql)
        If i = 0 Then
            MessageBox.Show("data not is deleted")
        Else
            MessageBox.Show("data is deleted")

        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub cmbstudentname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstudentname.SelectedIndexChanged

    End Sub
End Class

