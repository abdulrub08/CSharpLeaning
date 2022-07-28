Imports System
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports RemoteClassLibrary
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Chas As New HttpChannel(2222)
        ChannelServices.RegisterChannel(Chas, False)
        RemotingConfiguration.RegisterWellKnownServiceType(GetType(RemoteClass), "http://localhost:1111/rem", WellKnownObjectMode.SingleCall)



        Dim Obj As New RemoteClass
        Dim ds As New DataSet
        Dim cs As String = ""
        ds = Obj.LoadData("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=rms;Data Source=VIKAS\SQLEXPRESS", "select * from userinfo")

        DataGridView1.DataSource = ds.Tables(0)
        ChannelServices.UnregisterChannel(Chas)
    End Sub
End Class
