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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkSelectAll.Checked == true)
        {
            for (int i = 0; i < chklhobbies.Items.Count; i++)
            {
                chklhobbies.Items[i].Selected = true;
            }
        }
        else
        {
            for (int i = 0; i < chklhobbies.Items.Count; i++)
            {
                chklhobbies.Items[i].Selected = false;
            }
        }
    
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string hobby="";
        for(int i=0;i<chklhobbies.Items.Count;i++)
        {
            if(chklhobbies.Items[i].Selected==true)
            {
                if (i == 0)
                {
                    hobby = hobby + chklhobbies.Items[i].ToString(); 
                }
                else
                {
                    hobby = hobby + ","+chklhobbies.Items[i].ToString(); 
                    
                }

            }
        }
        lblmsg.Text=txtname.Text+" likes "+hobby;
    }
}
