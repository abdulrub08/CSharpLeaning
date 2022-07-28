Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public g_loginname As String
    Public g_Cdate As Date
    Public g_ds As New DataSet

    Public Function ExecuteQuery(ByVal sql As String) As Integer
        Dim cm As New SqlCommand
        Dim cnn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=student3;Data Source=vikas\SQLEXPRESS")

        cm.CommandType = CommandType.Text
        cm.Connection = cnn
        cm.CommandText = Sql

        Dim i As Integer
        cnn.Open()
        i = cm.ExecuteNonQuery()
        cnn.Close()
        Return i

    End Function
    Public Function selectquery(ByVal sql As String) As DataSet
        Dim cnn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=student3;Data Source=vikas\SQLEXPRESS")
        Dim da As New SqlDataAdapter(sql, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "a")
        Return ds
    End Function

    Public Sub Clrct1(ByVal root As Control)
        For Each txt As Control In root.Controls
            Clrct1(txt)
            If TypeOf txt Is TextBox Then
                CType(txt, TextBox).Text = String.Empty
            End If
        Next
    End Sub
End Module
