using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using ADODemo1.Models;
namespace ADODemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Connection()
        {
           string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
           ViewBag.Message = cs;
           ViewBag.Message2 = ConfigurationManager.AppSettings["filename"].ToString();
           DBContext ctx = new DBContext();
           ctx.OpenConnection();

           ctx.ClosedConnection();
            return View();
        }
    }
}