Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class RemoteClass
    Inherits MarshalByRefObject
    Sub New() ''Constructor
        Console.WriteLine("Object created for the Remote Class")


    End Sub
    Public Function Hello(ByVal name As String) As String
        Console.WriteLine("Hello method is being processed......")
        Return "Hello" & name

    End Function
    Public Function LoadData(ByVal cs As String, ByVal query As String) As DataSet
        Dim da As New OleDbDataAdapter(query, cs)
        Dim ds As New DataSet
        da.Fill(ds, "tmpTabel")
        Return ds

    End Function
End Class
