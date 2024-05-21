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

            if (isSucessful == "Customer" || isSucessful == "Admin")
            {
                if (isRememberMe)
                {
                    HttpCookie newCookie = new HttpCookie("Role");
                    newCookie.Value = isSucessful;
                    newCookie.Expires = DateTime.Now.AddHours(1); //expired dalam 1 jam
                    Response.Cookies.Add(newCookie);
                }

                if(isSucessful == "Customer")
                {
                    Session["Role"] = "Customer";
                    Response.Redirect("~/View/OrderSupplementPage.aspx");
                }
                else if(isSucessful == "Admin")
                {
                    Session["Role"] = "Admin";
                    Response.Redirect("~/View/HomePage.aspx");
                }

                
                Label_message.Text = isSucessful;
              
            }
            else
            {
                Label_message.Text = isSucessful;
            }
        }

        protected void btn_to_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btn_to_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }
    }
}