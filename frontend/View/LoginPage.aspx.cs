using frontend.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String password = TB_Password.Text;
            Boolean isRememberMe = CheckBox.Checked;

           

            String isSucessful = LoginController.login(username, password);

            if (isSucessful == "register sucessfully")
            {
                if (isRememberMe)
                {
                    // cookies yummy
                }

                Label_message.Text = isSucessful;
                //Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                Label_message.Text = isSucessful;
            }
        }
    }
}