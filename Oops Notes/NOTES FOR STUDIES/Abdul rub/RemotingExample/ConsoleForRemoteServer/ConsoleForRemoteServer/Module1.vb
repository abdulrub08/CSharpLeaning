Imports System
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports RemoteClassLibrary
Module Module1

    Sub Main()
        Dim Ch As New HttpChannel(1111)
        ChannelServices.RegisterChannel(Ch, False)
        Dim remoteObject As New RemoteClass
        RemotingServices.Marshal(remoteObject, "rem")
        Console.WriteLine("Server started at : http://localhost:1111/rem")
        Console.WriteLine("Press Enter to stop the Server.")
        Console.ReadKey()
        RemotingServices.Disconnect(remoteObject)
        ChannelServices.UnregisterChannel(Ch)
    End Sub

End Module
