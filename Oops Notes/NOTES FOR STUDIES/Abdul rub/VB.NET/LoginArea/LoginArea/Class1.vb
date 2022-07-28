Imports System.Data
Imports System.Data.OleDb
Public Class Authentication
    Private conStr As String
    Public Event errMsh(ByVal s As String)
    Public Property ConnectionStr As String
        Get
            Return conStr
        End Get
        Set(ByVal value As String)
            conStr = value
        End Set
    End Property
    Private Function getConnetion() As OleDbConnection
        Dim con As New OleDbConnection
        con.ConnectionString = ConnectionStr
        con.Open()
        Return con
    End Function
    Public Function checkAuth(ByVal uid As String, ByVal pwd As String, ByVal tab As String) As Boolean
        Dim flag As Boolean
        Dim con As OleDbConnection = getConnetion()
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader = Nothing
        cmd = New OleDbCommand("Select * from " & tab & " where uid=? and pwd=?", con)
        cmd.Parameters.Add("", OleDbType.VarChar).Value = uid.Trim()
        cmd.Parameters.Add("", OleDbType.VarChar).Value = pwd.Trim()
        Try
            dr = cmd.ExecuteReader
            flag = dr.Read
        Catch ex As Exception
            RaiseEvent errMsh(ex.Message)
        Finally
            If Not con Is Nothing Then
                con.Close()
            End If

            If Not dr Is Nothing Then
                dr.Close()
            End If

        End Try
        Return flag
    End Function
End Class
