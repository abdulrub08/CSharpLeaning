using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default12 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static string[] GetCompletionList(string prefixText, int count, string contextKey)
    {
        string[] values = new string[count];
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            char c1, c2, c3;
            c1 = (char)rnd.Next(97, 121);
            c2 = (char)rnd.Next(97, 121);
            c3 = (char)rnd.Next(97, 121);
            values[i] = prefixText + c1.ToString() + c2.ToString() + c3.ToString();
        }
        return values;
    }


}
