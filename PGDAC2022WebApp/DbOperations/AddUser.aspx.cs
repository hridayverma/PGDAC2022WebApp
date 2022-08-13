using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace PGDAC2022WebApp.DbOperations
{
    public partial class AddUser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-2BU6BCK; database=pgdac2022db;uid=sa;pwd=sql");
        SqlCommand cmd;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                BindMaxUserID();
            }
        }

        //insert logic
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //for string data '"+controlvalue+"',
            //for numeric data "+controlvalue+"
            //normal/concatnated query
            string qry = "insert into userdetails values('"+TxtFullName.Text+"','"+TxtPassword.Text+"','"+TxtEmail.Text+"',"+TxtMobile.Text+",'"+TxtAddress.Text+"')";
            //without business logic
            /* cmd = new SqlCommand(qry, con);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();*/
            BusinessLogic.ExecuteQry(qry);//using businesslogic method
            Label1.Text = "User Details Saved Successfully!!!!";
            ClearText();//to reset textboxes current values
            BindMaxUserID();

        }
        private void BindMaxUserID() { //method to get Max UserId

            string qry = "select max(userid)+1 from userdetails";
            cmd = new SqlCommand(qry, con);
            con.Open();
            object userid = cmd.ExecuteScalar();
            con.Close();
            if (TxtUserId.ReadOnly) {
                TxtUserId.ReadOnly = false;
            }
            TxtUserId.Text = userid.ToString();
            TxtUserId.ReadOnly = true;
        }
        private void ClearText()
        {
            TxtFullName.Text = "";
            TxtEmail.Text = "";
            TxtMobile.Text = "";
            TxtAddress.Text = "";
        }

    }
}