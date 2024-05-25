using backend.Module;
using frontend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie roleCookie = Request.Cookies["Role"];
                if (roleCookie != null)
                {
                    Session["Role"] = roleCookie.Value;
                }

                if (Session["Role"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                if (Session["Role"].ToString() == "Customer")
                {
                    Response.Redirect("~/View/OrderSupplementPagePage.aspx");
                }

                localhost.GymMeWebService service = new localhost.GymMeWebService();
                List<MsUser> userList = json<List<MsUser>>.decode(service.getAllUser());
                GV.DataSource = userList;
                GV.DataBind();
            }

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
            HttpCookie roleCookie = Request.Cookies["Role"];
            HttpCookie usernameCookie = Request.Cookies["Username"];
            HttpCookie userIdCookie = Request.Cookies["UserId"];

            if (roleCookie != null || usernameCookie != null || userIdCookie != null)
            {
                roleCookie.Expires = DateTime.Now.AddDays(-1);
                usernameCookie.Expires = DateTime.Now.AddDays(-1);
                userIdCookie.Expires = DateTime.Now.AddDays(-1);

                Response.Cookies.Add(roleCookie);
                Response.Cookies.Add(usernameCookie);
                Response.Cookies.Add(userIdCookie);
            }

            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}