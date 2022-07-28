using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService4ajax
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 

[System.Web.Script.Services.ScriptService]
public class WebService4ajax : System.Web.Services.WebService {
    public WebService4ajax () {    }
    [WebMethod]
    public string GetServerTime()
    {
        return DateTime.Now.ToString();
    }
}


