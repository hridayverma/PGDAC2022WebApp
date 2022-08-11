using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PGDAC2022WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string usname=   TxtUserName.Text;//getting form data
            string password = TxtPassword.Text;
            //TxtUserName.
            if (usname.Equals("admin") && password.Equals("admin@123")){
                Response.Redirect("FAQ.aspx");//page to redirect
            }
            else
            {
                LblMessage.ForeColor = System.Drawing.Color.Red;
                LblMessage.Text = "Invalid username/password";
            }




        }
    }
}