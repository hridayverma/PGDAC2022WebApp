using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;//provider namespace for SQL Server DB
using System.Data;

namespace PGDAC2022WebApp.DbOperations
{
    public partial class DbConnection : System.Web.UI.Page
    {
        static  SqlConnection con;//null

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)            {
                Response.Write("First request");
                con = new SqlConnection("server=DESKTOP-2BU6BCK;database=pgdac2022db;uid=sa;pwd=sql");
            }
            else            {
                Response.Write("PostBack Request");
            }
        }
        //to connect with DB
        protected void Button1_Click(object sender, EventArgs e)
        {            
            if (con.State == ConnectionState.Closed) {
                con.Open();
                Response.Write("Connected with DB Successfully!!");
            }
            else
                Response.Write("Already Connected with DB Server!!");

        }
        //to check connection
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {               
                Response.Write("Connection state is open");
            }
            else
                Response.Write("Connection state is closed");
        }
        //to disconnect from DB
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Response.Write("Disconnected from DB Server");
            }
            else
                Response.Write("Already Disconnected from DB Server");
        }
    }
}