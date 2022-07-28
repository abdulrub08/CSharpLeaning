
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        List<Chatter> chatters = new List<Chatter>();
        chatters.Add(new Chatter(new Guid("CD863C27-2CEE-45fd-A2E0-A69E62B816B9"), "RAJ"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Bhavana"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Amit"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Deepak"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Manish"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Sachin"));
        chatters.Add(new Chatter(Guid.NewGuid(), "Puja"));
        Application.Add("Chatters", chatters);

        List<chate> chats = new List<chate>();
        chats.Add(new chate());
        Application.Add("Chats", chats);
        foreach (KeyValuePair<Guid, Chatter> chatter in Chatter.ActiveChatters())
        {
            chatter.Value.Join(chate.ActiveChats()[0]);
        }

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
