using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PGDAC2022WebApp.DbOperations
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Logic to fecth data from database
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-2BU6BCK;database=pgdac2022db;uid=sa;pwd=sql");
            string qry = "select * from userdetails";
            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
    }
}