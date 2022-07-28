Imports System
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports RemoteClassLibrary
Module Module1

    Sub Main()
        Dim ch As New HttpChannel(0)
        ChannelServices.RegisterChannel(ch, False)
        RemotingConfiguration.RegisterWellKnownClientType(GetType(RemoteClassLibrary.RemoteClass), "http://localhost:1111/rem")


        Dim Obj As New RemoteClassLibrary.RemoteClass
        Console.WriteLine(Obj.Hello("Vikas"))
        ChannelServices.UnregisterChannel(ch)
        Console.ReadKey()
    End Sub

End Module
