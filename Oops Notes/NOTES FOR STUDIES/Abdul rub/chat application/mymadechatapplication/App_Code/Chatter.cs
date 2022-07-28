using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Chatter
/// </summary>
public class Chatter
{
       private Guid m_id;
    public Guid Id
    {
        get { return m_id; }
    }
    private string m_name;
    public string Name
    {
        get { return m_name; }
    }
    public static Dictionary<Guid, Chatter> ActiveChatters()
    {
        Dictionary<Guid, Chatter> retval = new Dictionary<Guid, Chatter>();
        if (HttpContext.Current.Application["Chatters"] != null)
        {
            List<Chatter> chatters = ((List<Chatter>)HttpContext.Current.Application["Chatters"]);
            foreach (Chatter chatter in chatters)
            {
                retval.Add(chatter.Id, chatter);
            }
        }
        return retval;
    }
    public void Join(chate chat)
    {
        chat.Chatters.Add(this);
    }
    public Chatter(Guid id, string name)
	{
		m_id = id;
        m_name = name;
	}
}
