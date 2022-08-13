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
    public partial class ManageUsers : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-2BU6BCK; database=pgdac2022db;uid=sa;pwd=sql");
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter adapter;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //find user logic
        //Using DataReader
        protected  void BtnSearch_Click(object sender, EventArgs e)
        {
            //search query
            //parametrized query
            string searchQry = "select fullname,email,mobile,address " +
                               "from userdetails where userid=@id";
            cmd = new SqlCommand(searchQry, con);
            cmd.Parameters.AddWithValue("@id", TxtUserId.Text);//setting parameter value for qry
            con.Open();
            dtr = cmd.ExecuteReader();//getting datareader reference

            //dtr.HasRows
            if (dtr.Read()) {
                TxtFullName.Text = dtr[0].ToString();
                TxtEmail.Text = dtr[1].ToString();
                TxtMobile.Text = dtr[2].ToString();
                //TxtAddress.Text = dtr[3].ToString();
                //dtr.Close();
                //con.Close();
                TxtAddress.Text = dtr.GetString(3);
                Label1.Text = "";
            }
            else  {
                Label1.Text = "No Record found!!!";
            }
            con.Close();

        }
        //update logic
        protected async void BtnUpdate_Click(object sender, EventArgs e)
        {
            string updateQry = "update userdetails set " +
                           "fullname=@name,email=@email,mobile=@mobile,address=@address" +
                           " where userid=@id";
           // cmd = new SqlCommand(updateQry, con);

            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@name",TxtFullName.Text),
            new SqlParameter("@email",TxtEmail.Text),
            new SqlParameter("@mobile", TxtMobile.Text),
            new SqlParameter("@address", TxtAddress.Text),
            new SqlParameter("@id", TxtUserId.Text)
            };
            /*
            cmd.Parameters.AddRange(parameters);

            await con.OpenAsync();//Asynchronous open method call
            int res= await cmd.ExecuteNonQueryAsync();//Asynchronous ExecuteNonQuery method call
            con.Close();*/
            //Businesslogic call for update
            int res = BusinessLogic.ExecuteQry(updateQry, parameters);
            if(res>0)
              Label1.Text = "Record updated Successfully!!!!";
        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            BusinessLogic.FillGrid("select * from userdetails", GridView1);
        }
    }
}