using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Bibliotheek
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("Overview.aspx");
            }

            lblError.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;            
            String password = txtPassword.Text;

            if(!username.Equals("") && !password.Equals(""))
            {
                using (SqlConnection sqlCon = new SqlConnection("Data Source=5CD7092WDC;Initial Catalog=Login;Integrated Security=true;"))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@username", username.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", password.Trim());
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if(count == 1)
                    {
                        Session["username"] = username.Trim();
                        Response.Redirect("Overview.aspx");
                    }
                    else
                    {
                        lblError.Text = "Incorrect username or password combination";
                        lblError.Visible = true;
                    }
                }
            }
            else
            {
                lblError.Text = "You didn't provide any login information, please provide and try again.";
                lblError.Visible = true;
            }
        }
    }
}