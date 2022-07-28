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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
public partial class Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ReportDocument rd = new ReportDocument();
            if (Session["PageName"].ToString() == "PrintDoctorInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/DoctorInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintFloorInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/FloorInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintWingInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/WingInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintWardInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/WardInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintRoomInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/RoomInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintBedInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/BedInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintExpenseInfo")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/ExpenseInfoReport.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "VFeedback")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/VFeedback.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "VEnquiryForm")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/VEnquiryForm.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "VContactUs")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/VContactUs.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintBedDetails")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/PrintBedDetails.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintDoctorDetails")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/PrintDoctorDetails.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintExpenseDetails")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/PrintExpenseDetails.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintPaymentDetails")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/PrintPaymentDetails.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
            if (Session["PageName"].ToString() == "PrintDischargeSlip")
            {
                string UploadFolderPath = "~/";
                string FilePath = HttpContext.Current.Server.MapPath(UploadFolderPath);
                rd.Load(FilePath + "/PrintDischargeSlip.rpt");
                DataSet ds = new DataSet();
                ds = (DataSet)Session["MyDataset"];
                rd.SetDataSource(ds.Tables["a"]);
                CrystalReportViewer1.ReportSource = rd;
            }
        }

    }
}
