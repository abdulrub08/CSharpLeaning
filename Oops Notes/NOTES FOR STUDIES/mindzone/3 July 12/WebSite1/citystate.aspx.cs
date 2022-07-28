using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class citystate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlstate.Items.Clear();
        switch (ddlcountry.SelectedIndex)
        {
            case 0:
                ddlstate.Items.Add("uttarpradesh");
                ddlstate.Items.Add("delhi");
                ddlstate.Items.Add("madhyapradesh");
                ddlstate.Items.Add("andhrapradesh");
                break;
            case 1:
                ddlstate.Items.Add("washington");
                ddlstate.Items.Add("hawaii");

                break;

            case 2:
                ddlstate.Items.Add("gandhara");
                ddlstate.Items.Add("durbar");
                break;


        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        lblmsg.Text = txtname.Text + "lives in" + ddlstate.SelectedItem.ToString() + "which is located in" + ddlcountry.SelectedItem.ToString();
    }

    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlcountry.SelectedIndex == 0)
        {
            ddlcity.Items.Clear();
            switch (ddlstate.SelectedIndex)
            {
                case 0:
                    ddlcity.Items.Add("IndiaState1cityabs");
                    ddlcity.Items.Add("IndiaState1cityabs");
                    ddlcity.Items.Add("IndiaState1cityabs");
                    ddlcity.Items.Add("IndiaState1cityabs");
                    break;
                case 1:
                    ddlcity.Items.Add("IndiaState2cityabs");
                    ddlcity.Items.Add("IndiaStat2cityabs");
                    ddlcity.Items.Add("IndiaSta2cityabs");
                    ddlcity.Items.Add("IndiaState2cityabs");
                    break;
                case 2:
                    ddlcity.Items.Add("IndiaState3cityabs");
                    ddlcity.Items.Add("IndiaState3cityabs");
                    ddlcity.Items.Add("IndiaState3cityabs");
                    ddlcity.Items.Add("IndiaStat3cityabs");
                    break;
                case 3:
                    ddlcity.Items.Add("alsghbs");
                    ddlcity.Items.Add("aashfafas");
                    ddlcity.Items.Add("asjsdhfas");
                    ddlcity.Items.Add("aalsdidfhlsfasf");
                    break;
            }
        }
        if (ddlcountry.SelectedIndex == 1)
        {
            ddlcity.Items.Clear();
            switch (ddlstate.SelectedIndex)
            {
                case 0:
                    ddlcity.Items.Add("usaState1cityadsfagbs");
                    ddlcity.Items.Add("usaState1cityadsfagbs");
                    ddlcity.Items.Add("usaState1cityadsfagbs");
                    ddlcity.Items.Add("usaState1cityadsfagbs");
                    break;
                case 1:
                    ddlcity.Items.Add("usaState2cityadsfagbs");
                    ddlcity.Items.Add("usaState2cityadsfagbs");
                    ddlcity.Items.Add("usaState2cityadsfagbs");
                    ddlcity.Items.Add("usaState2cityadsfagbs");
                    break;
                //case 2:
                //    ddlcity.Items.Add("abhdass");
                //    ddlcity.Items.Add("aflshhsdas");
                //    ddlcity.Items.Add("askaufaukfas");
                //    ddlcity.Items.Add("aadsgsfasf");
                //    break;
                //case 3:
                //    ddlcity.Items.Add("alsghbs");
                //    ddlcity.Items.Add("aashfafas");
                //    ddlcity.Items.Add("asjsdhfas");
                //    ddlcity.Items.Add("aalsdidfhlsfasf");
                //    break;
            }
        }
        if (ddlcountry.SelectedIndex == 2)
        {
            ddlcity.Items.Clear();
            switch (ddlstate.SelectedIndex)
            {
                case 0:
                    ddlcity.Items.Add("adsf7656agbs");
                    ddlcity.Items.Add("afsdf0987aas");
                    ddlcity.Items.Add("vis");
                    ddlcity.Items.Add("aas41asfb2fasf");
                    break;
                case 1:
                    ddlcity.Items.Add("asmn32hbs");
                    ddlcity.Items.Add("afaza434,saass");
                    ddlcity.Items.Add("asf32hjhssas");
                    ddlcity.Items.Add("ass374a86sfasf");
                    break;
                //case 2:
                //    ddlcity.Items.Add("abhdass");
                //    ddlcity.Items.Add("aflshhsdas");
                //    ddlcity.Items.Add("askaufaukfas");
                //    ddlcity.Items.Add("aadsgsfasf");
                //    break;
                //case 3:
                //    ddlcity.Items.Add("alsghbs");
                //    ddlcity.Items.Add("aashfafas");
                //    ddlcity.Items.Add("asjsdhfas");
                //    ddlcity.Items.Add("aalsdidfhlsfasf");
                //    break;
            }
        }
    }
}