using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    private chate m_chat = chate.ActiveChats()[0];
    private Chatter m_chatter = Chatter.ActiveChatters()[new Guid("CD863C27-2CEE-45fd-A2E0-A69E62B816B9")];
    protected void Page_Load(object sender, EventArgs e)
    {
        _UpdateChatterList();
        _UpdateChatMessageList();
    }
    private void _UpdateChatMessageList()
    {
        ChatMessageList.DataSource = m_chat.Messages;
        ChatMessageList.DataBind();
    }
    private void _UpdateChatterList()
    {
        ChattersBulletedList.DataSource = m_chat.Chatters;
        ChattersBulletedList.DataTextField = "Name";
        ChattersBulletedList.DataBind();
    }
    protected void SendButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(NewMessageTextBox.Text))
        {
            string messageSent = m_chat.SendMessage(m_chatter, NewMessageTextBox.Text);
            NewMessageTextBox.Text = string.Empty;
        }
        _UpdateChatterList();
        _UpdateChatMessageList();
    }
}
