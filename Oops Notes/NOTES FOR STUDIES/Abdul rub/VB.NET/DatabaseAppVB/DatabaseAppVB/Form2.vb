Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim WithEvents obj As LoginArea.Authentication
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UserControl11.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath() & "\" & "Employee.mdb"
        Me.UserControl11.TableUser = "User123"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As Form1
        obj = New LoginArea.Authentication()
        obj.ConnectionStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath() & "\" & "Employee.mdb"
        If obj.checkAuth(Me.TextBox1.Text.Trim(), Me.TextBox2.Text.Trim(), "User123") Then
            MessageBox.Show("Welcome to Employee Form")
            frm = New Form1
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    
End Class