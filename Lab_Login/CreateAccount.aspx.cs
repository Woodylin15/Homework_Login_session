using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class CreateAccount : System.Web.UI.Page {
    SqlConnection sCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ciying\Desktop\170619-master\Lab_Login\App_Data\AccountDatabase.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void button_Click(object sender, EventArgs e) {
        sCon.Open();
        SqlCommand sCom = sCon.CreateCommand();
        sCom.CommandType = System.Data.CommandType.Text;
        sCom.CommandText = "insert into Account values('" +userAccount.Text+ "','" +userPassword.Text+ "','" +actualName.Text+ "','" +age.Text+ "')";
        sCom.ExecuteNonQuery();

        sCon.Close();

        Response.Redirect("Login.aspx");
    }
}