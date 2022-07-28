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
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;

public partial class Captcha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //create object of Bitmap Class and set its width and height.
        Bitmap objBMP = new Bitmap(180, 51);
        //Create Graphics object and assign bitmap object to graphics' object.
        Graphics objGraphics = Graphics.FromImage(objBMP);
        objGraphics.Clear(Color.Aquamarine);
        objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
        Font objFont = new Font("Monotype Corsiva", 30, FontStyle.Italic);
        //genetating random 6 digit random number
        string randomStr = GeneratePassword();

        //set this random number in session
        Session.Add("randomStr", randomStr);
        objGraphics.DrawString(randomStr, objFont, Brushes.Chocolate, 2, 2);
        Response.ContentType = "image/GIF";
        objBMP.Save(Response.OutputStream, ImageFormat.Gif);
        objFont.Dispose();
        objGraphics.Dispose();
        objBMP.Dispose();
    }
    public string GeneratePassword()
    {

        // Below code describes how to create random numbers.some of the digits and letters
        // are ommited because they look same like "i","o","1","0","I","O".
        string allowedChars = "a,b,c,d,e,f,g,h,j,k,m,n,p,q,r,s,t,u,v,w,x,y,z,";
        allowedChars += "A,B,C,D,E,F,G,H,J,K,L,M,N,P,Q,R,S,T,U,V,W,X,Y,Z,";
        allowedChars += "2,3,4,5,6,7,8,9";

        char[] sep = { ',' };
        string[] arr = allowedChars.Split(sep);

        string passwordString = "";
        string temp;
        Random rand = new Random();
        for (int i = 0; i < 6; i++)
        {
            temp = arr[rand.Next(0, arr.Length)];
            passwordString += temp;
        }
        return passwordString;

    }
}
