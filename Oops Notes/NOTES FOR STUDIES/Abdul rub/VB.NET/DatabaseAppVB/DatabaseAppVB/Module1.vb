Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public Function getConnection() As OleDbConnection
        Dim con As New OleDbConnection
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath() & "\" & "Employee.mdb"
        'con.ConnectionString = "Provider=SQLOLEDB;Data Source=WKT9;User id=sa;Password=doorodac;database=Assignment"
        con.ConnectionString = "Provider=OraOLEDB.Oracle.1;User ID=scott;Data Source=ora9i;Extended Properties=;Persist Security Info=True;Password=tiger"

        con.Open()
        Return con
    End Function
End Module
