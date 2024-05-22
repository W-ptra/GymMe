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
                if (roleCookie != null && usernameCookie != null)
                {
                    Session["Role"] = roleCookie.Value;
                    Session["Username"] = usernameCookie.Value;
                }

                if (Session["Role"] == null || Session["Username"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                if(Session["Role"].ToString() == "Customer")
                {
                    btn_to_home.Visible = false;
                    btn_to_manage_supplement.Visible = false;
                    btn_to_order_queue.Visible = false;
                    btn_to_transaction_report.Visible = false;
                }
                else if(Session["Role"].ToString() == "Admin")
                {
                    btn_order_supplement.Visible = false;
                    btn_history.Visible = false;
                }
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

        }

        protected void btn_change_password_Click(object sender, EventArgs e)
        {

        }
    }
}