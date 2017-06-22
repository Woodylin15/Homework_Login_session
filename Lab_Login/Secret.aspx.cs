using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secret : System.Web.UI.Page
{   
    protected void Page_Load(object sender, EventArgs e)
    {        
        //if (Session["Account"] != null) {
        //    Response.Write("Welcome");
        //}
        //else {
        //    Response.Redirect("Login.aspx");
        //}

        if(Session["Account"] == null) {
            Response.Redirect("Login.aspx");
        }
        else {
            Label1.Text = "<h1>" + "哈囉" + Session["Account"] + "歡迎回來！"+"</h1>";
        }


    }

    protected void Button1_Click(object sender, EventArgs e) {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}