Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public cnn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=vikas\sqlexpress")

    Public Function ExecuteQuery(ByVal sql As String) As Integer
        Dim cm As New SqlCommand
        cm.Connection = cnn
        cm.CommandType = CommandType.Text
        cm.CommandText = sql
        Dim i As Integer
        cnn.Open()
        i = cm.ExecuteNonQuery()
        cnn.Close()
        Return i
    End Function
    Public Function SelectQuery(ByVal sql As String) As DataSet
        Dim da As New SqlDataAdapter(sql, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "a")
        Return ds

    End Function

End Module
