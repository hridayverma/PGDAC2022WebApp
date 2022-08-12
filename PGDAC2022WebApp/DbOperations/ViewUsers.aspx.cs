using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PGDAC2022WebApp.DbOperations
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                     GetAllUsers();
        }
        //Logic to fecth data from database
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetAllUsers();
            
        }

        private void GetAllUsers()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-2BU6BCK;database=pgdac2022db;uid=sa;pwd=sql");
            string qry = "select * from userdetails";
            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            //DataTable table = new DataTable();
            //adapter.Fill(ds);//
            adapter.Fill(ds, "users");
            //Binding DataSet datatable data with gridview
            //GridView1.DataSource = ds.Tables[0];
            GridView1.DataSource = ds.Tables["users"];
            GridView1.DataBind();
            // msg.InnerHtml = "Total Record:" + ds.Tables["users"].Rows.Count;
            //msg.InnerHtml = ds.Tables["users"].Rows[0][2].ToString();
            // msg.InnerHtml = "Total Record:" + ds.Tables["users"].Columns.Count;

            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in ds.Tables["users"].Rows)
            {
                sb.Append(row[1] + "=>" + row[3] + "<br/>");
            }
            // msg.InnerHtml = sb.ToString();
        }
    }
}