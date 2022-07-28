using System;
using System.Collections;
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
using System.IO;
using System.Net;


public partial class ForgotPassword : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sql = "select loginName,mobileno from UserInfo where loginname='" + txtUserName.Text + "'";

        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        int a = 0;
        string mobno = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                mobno = row[1].ToString();
                a = 1;
                break;
                
            }
        }
        if (a == 0)
        {
            lblmsg.Text = "Incorrect Login Name";
        }
        else
        {
            string newpwd = txtUserName.Text + DateTime.Now.Day;
            send("7275675028", "silver225", newpwd,mobno);
            lblmsg.Text = "Password Sent on your registered mobile no";

            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(newpwd);

            data = x.ComputeHash(data);
            string md5hash = System.Text.Encoding.ASCII.GetString(data);
            //Label1.Text = md5hash;
            string sql1 = "update userinfo set password='" + md5hash + "' where loginname='" + txtUserName.Text + "'";
            int k = 0;
            k = cs.DML(sql1);

        }
       
    }
}
