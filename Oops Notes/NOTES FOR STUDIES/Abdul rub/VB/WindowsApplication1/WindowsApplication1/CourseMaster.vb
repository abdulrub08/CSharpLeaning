Imports System.Data
Public Class CourseMaster
    Public Sub ShowGridData()
        Dim ds As New DataSet
        Dim sql As String
        sql = "select id,coursename,coursefees,facultyname,duration,remark from CourseMaster"
        ds = SelectQuery(sql)
        DataGridView1.DataSource = ds.Tables("a")
    End Sub

    Private Sub CourseMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Enabled = False
        ShowGridData()
        mode = ""
        id = ""
        Clrct1(Me)
    End Sub
    Dim mode As String

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcoursename.TextChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcoursefees.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If btnexit.Text = "cancel" Then
            Panel2.Enabled = False
            btnadd.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = False
            btnexit.Text = "exit"
            Clrct1(Me)
        Else
            Me.Close()

        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Panel2.Enabled = True
        btnadd.Enabled = False
        btnsave.Enabled = True
        btnexit.Text = "Cancel"
        txtcoursename.Focus()
        mode = "save"

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcoursename.Text = "" Then
            MessageBox.Show("enter the course name")
            txtcoursename.Focus()
            Exit Sub
        End If
        If txtcoursefees.Text = "" Then
            MessageBox.Show("enter the course fees")
            txtcoursefees.Focus()
            Exit Sub
        End If
        If txtfacultyname.Text = "" Then
            MessageBox.Show("enter the Faculty name")
            txtfacultyname.Focus()
            Exit Sub

        End If
        If txtcourseduration.Text = "" Then
            MessageBox.Show("enter the course duration")
            txtcourseduration.Focus()
            Exit Sub
        End If

        If mode = "save" Then
            Dim sql As String
            sql = "insert into CourseMaster (coursename,coursefees,facultyname,duration,remark,entrydate,entryperson)values('" & txtcoursename.Text & "' , " & txtcoursefees.Text & " , '" & txtfacultyname.Text & "','" & txtcourseduration.Text & "' , '" & txtremark.Text & "' , '" & g_Cdate & "' , '" & g_loginname & "')"
            Dim i As Integer
            i = 0
            i = ExecuteQuery(sql)
            If i = 0 Then
                MessageBox.Show("data is not saved")
            Else
                Clrct1(Me)
                mode = ""
                id = ""
                ShowGridData()
                MessageBox.Show("data is saved")


                btnadd.Enabled = True
                btndelete.Enabled = False
                btnupdate.Enabled = False
                btnsave.Enabled = False
                btnexit.Text = "Exit"
            End If
        Else
            Dim sql As String
            sql = "update CourseMaster set coursename='" & txtcoursename.Text & "',coursefees=" & txtcoursefees.Text & ",facultyname='" & txtfacultyname.Text & "',duration='" & txtcourseduration.Text & "',remark='" & txtremark.Text & "' where id=" & id & ""
            Dim i As Integer
            i = 0
            i = ExecuteQuery(sql)
            If i = 0 Then
                MessageBox.Show("Data is not updated")
            Else

                MessageBox.Show("Data is updated")
                Clrct1(Me)
                mode = ""
                id = ""
                ShowGridData()
                btnadd.Enabled = True
                btndelete.Enabled = False
                btnupdate.Enabled = False
                btnsave.Enabled = False
                btnexit.Text = "Exit"
            End If
        End If

    End Sub

    Dim id As String

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim sql As String
        Dim i As Integer
        i = 0
        sql = "delete from CourseMaster where id ='" & id & "'"
        i = ExecuteQuery(sql)
        If i = 0 Then
            MessageBox.Show("data not is deleted")
        Else
            MessageBox.Show("data is deleted")
        End If
        ShowGridData()
        btndelete.Enabled = False
        btnadd.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btnexit.Enabled = "Cancle"
        Clrct1(Me)


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Panel2.Enabled = True
        btnadd.Enabled = False
        btnsave.Enabled = True
        btndelete.Enabled = True
        btnupdate.Enabled = False
        btnexit.Text = "Cancel"
        mode = "update"

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
      

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value

        txtcoursename.Text = DataGridView1.Item(1, i).Value
        txtcoursefees.Text = DataGridView1.Item(2, i).Value
        txtfacultyname.Text = DataGridView1.Item(3, i).Value
        txtcourseduration.Text = DataGridView1.Item(4, i).Value
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnsave.Enabled = False
        btnexit.Text = "Cancel"
    End Sub
End Class