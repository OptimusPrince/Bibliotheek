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
    public partial class Overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            lblUserDetails.Text = "Welcome to the Calco Library, " + Session["username"];
            // Geleende boeken laden uit database...
            using (SqlConnection sqlCon = new SqlConnection("Data Source=5CD7092WDC;Initial Catalog=Login;Integrated Security=true;"))
            {
                sqlCon.Open();
                string query = "SELECT Name, Author FROM Books";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                gvBooksOnLoan.DataSource = table;
                gvBooksOnLoan.DataBind();
    
                sqlCon.Close();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnLibrary_Click(object sender, EventArgs e)
        {
            Response.Redirect("Library.aspx");
        }

        protected void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Placeholder!!
            Response.Redirect("Return.aspx");
        }


    }
}