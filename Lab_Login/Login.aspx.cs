using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page{
    SqlConnection sCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ciying\Desktop\170619-master\Lab_Login\App_Data\AccountDatabase.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e){

    }
    protected void btnLogin_Click(object sender, EventArgs e){
        //if(btnLogin.Text == null) {
        //    lblPrompt.Text = "Please keyin your name.";
        //}
        //else {
        //    Session["Account"] = btnLogin.Text;
        //    Response.Redirect("Secret.aspx");
        //}

        sCon.Open();
        SqlCommand sCom = sCon.CreateCommand();
        sCom.CommandType = CommandType.Text;
        sCom.CommandText = "select * from Account where Account = '" +txtUserName.Text+ "' and password = '"+txtPassword.Text+"'";
        sCom.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(sCom);
        da.Fill(dt);
        foreach(DataRow dr in dt.Rows) {
            Session["Account"] = dr["Account"].ToString();
            Response.Redirect("Secret.aspx");
        }
        
        
    }
}