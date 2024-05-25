using backend.Module;
using frontend.Controller;
using frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie roleCookie = Request.Cookies["Role"];
                HttpCookie usernameCookie = Request.Cookies["Username"];
                HttpCookie userIdCookie = Request.Cookies["UserId"];
                if (roleCookie != null  && usernameCookie != null)
                {
                    Session["Role"] = roleCookie.Value;
                    Session["Username"] = usernameCookie.Value;
                    Session["UserId"] = userIdCookie.Value;
                }

                if (Session["Role"] == null || Session["Username"] == null || Session["UserId"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                String sessionRole = Session["Role"].ToString();
                String sessionUsername = Session["Username"].ToString();
                //String sessionUserId = Session["UserId"].ToString();

                if (sessionRole == "Customer")
                {
                    btn_to_home.Visible = false;
                    btn_to_manage_supplement.Visible = false;
                    btn_to_order_queue.Visible = false;
                    btn_to_transaction_report.Visible = false;
                }
                else if(sessionRole == "Admin")
                {
                    btn_order_supplement.Visible = false;
                    
                }

                localhost.GymMeWebService service = new localhost.GymMeWebService();
                MsUser user = json<MsUser>.decode(service.getUser(sessionUsername));

                TB_UserID.Text = user.UserID.ToString();
                TB_Username.Text = user.UserName.ToString();
                TB_Email.Text = user.UserEmail.ToString();
                TB_Gender.Text = user.UserGender.ToString();
                TB_DOB.Text = user.UserDOB.ToString();
                TB_Role.Text = user.UserRole.ToString();
            }
        }
        protected void btn_order_supplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderSupplementPage.aspx");
        }

        protected void btn_history_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HistoryPage.aspx");
        }

        protected void btn_profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage.aspx");
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btn_to_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void btn_to_manage_supplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplementPage.aspx");
        }

        protected void btn_to_queue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionQueuePage.aspx");
        }

        protected void btn_to_transaction_report_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionDetailPage.aspx");
        }

        protected void btn_update_profile_Click(object sender, EventArgs e)
        {
            String id = TB_UserID.Text;
            String username = TB_Username.Text;
            String email = TB_Email.Text;
            String DOB = TB_DOB.Text;
            String gender = TB_Gender.Text;
            String role = TB_Role.Text;

            label_password_change.Text = ProfileController.updateProfileValidation(id,username, email, DOB, gender, role);
            Response.Redirect("~/View/ProfilePage.aspx");
        }

        protected void btn_change_password_Click(object sender, EventArgs e)
        {
            String username = TB_Username.Text;
            String oldPassword = TB_OldPassword.Text;
            String newPassword = TB_NewPassword.Text;

            Boolean isSucessfull = ProfileController.updateNewPassword(username, oldPassword, newPassword);

            if (isSucessfull)
            {
                label_password_change.Text = "Password has been change sucessfully";
            }
            else
            {
                label_password_change.Text = "Old password doesn't correct";
            }
        }
    }
}