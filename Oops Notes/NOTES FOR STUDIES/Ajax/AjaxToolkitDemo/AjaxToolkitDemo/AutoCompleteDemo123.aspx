<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutoCompleteDemo123.aspx.cs" Inherits="AjaxToolkitDemo.AutoCompleteDemo123" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat =server language ="c#" >
        [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
        public static string[] GetCompletionList(string prefixText, int count, string contextKey)
        {
            // Create array of movies  
            string[] movies = { "Star Wars", "Star Trek", "Superman", "Memento", "Shrek", "Shrek II" };

            // Return matching movies  
            return (from m in movies where m.StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase) select m).Take(count).ToArray();
        }  
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">  
    </asp:ToolkitScriptManager>  
      
    <asp:TextBox ID="txtMovie" runat="server" AutoCompleteType =DisplayName  ></asp:TextBox>  
      
    <asp:AutoCompleteExtender   
        ID="AutoCompleteExtender1"   
        TargetControlID="txtMovie"   
        runat="server" UseContextKey="True" />  
    </div>
    </form>
</body>
</html>
