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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;

public partial class Reportforunitwiseitem : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CrystalReportViewer1_Init(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ReportDocument rd = new ReportDocument();

            string uploadFolderPath = "~/";
            string filePath = HttpContext.Current.Server.MapPath(uploadFolderPath);

            rd.Load(filePath + "/CrystalReportforUnititem.rpt");
            DataSet ds = new DataSet();
            ds = (DataSet)Session["mydataset"];
            rd.SetDataSource(ds.Tables["a"]);
            CrystalReportViewer1.ReportSource = rd;

        }
    }
}
