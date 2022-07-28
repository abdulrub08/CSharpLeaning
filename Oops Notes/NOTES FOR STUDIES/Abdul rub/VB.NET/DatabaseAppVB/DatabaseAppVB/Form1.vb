Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Dim ds As New DataSet
    Dim pos As Integer
    Private Sub populateDataset()
        Dim con As OleDbConnection = Module1.getConnection()
        Dim adp As OleDbDataAdapter
        adp = New OleDbDataAdapter("Select * from emp", con)
        ds.Clear()
        adp.Fill(ds, "emp")
        con.Close()
    End Sub
    Private Sub populateDatasetXml()
        Dim fs As FileStream
        Dim sr As StreamReader
        fs = New FileStream(Application.StartupPath() & "\" & "Test.xml", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        ds.Clear()
        ds.ReadXml(sr)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call populateDatasetXml()
        Call populateDataset()
        pos = 0
        Call ShowEmp(pos)
    End Sub
    Private Sub ShowEmp(ByVal pos As Integer)
        If pos >= 0 And pos <= ds.Tables(0).Rows.Count - 1 Then
            Me.TextBox1.Text = ds.Tables("emp").Rows(pos).Item("empno")
            Me.TextBox2.Text = ds.Tables("emp").Rows(pos).Item("ename")
            Me.TextBox3.Text = ds.Tables("emp").Rows(pos).Item("sal")
            Me.TextBox4.Text = ds.Tables("emp").Rows(pos).Item("job")
            Me.Button6.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If pos < ds.Tables(0).Rows.Count - 1 Then
            pos = pos + 1
            Call ShowEmp(pos)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If pos > 0 Then
            pos = pos - 1
            Call ShowEmp(pos)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If ds.Tables(0).Rows.Count > 0 Then
            pos = 0
            Call ShowEmp(pos)
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ds.Tables(0).Rows.Count > 0 Then
            pos = ds.Tables(0).Rows.Count - 1
            Call ShowEmp(pos)
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.Button6.Enabled = True
        Me.TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim con As OleDbConnection = getConnection()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand("Insert Into emp(empno,ename,sal,job) values(?,?,?,?)", con)
        cmd.Parameters.Add("", OleDbType.Integer).Value = Integer.Parse(Me.TextBox1.Text)
        cmd.Parameters.Add("", OleDbType.VarChar).Value = Me.TextBox2.Text
        cmd.Parameters.Add("", OleDbType.Integer).Value = Integer.Parse(Me.TextBox3.Text)
        cmd.Parameters.Add("", OleDbType.VarChar).Value = Me.TextBox4.Text

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
        Call populateDataset()
        Button4_Click(sender, e)


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
    End Sub
End Class
