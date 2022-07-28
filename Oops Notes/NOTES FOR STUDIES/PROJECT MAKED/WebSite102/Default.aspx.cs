using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //GD
    public void send(string uid, string password, string message, string no)
    {
        HttpWebRequest myReq =
        (HttpWebRequest)WebRequest.Create("http://ubaid.tk/sms/sms.aspx?uid=" + uid + "&pwd=" + password +
        "&msg=" + message + "&phone=" + no + "&provider=way2sms");

        HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());

        string responseString = respStreamReader.ReadToEnd();
        respStreamReader.Close();
        myResp.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        send("7275675028", "123Solden225", TextBox2.Text, TextBox1.Text);
        Label1.Text = "Message Sent";
  
    }
}
