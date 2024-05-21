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
    public partial class OrderSupplement : System.Web.UI.Page
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

                if(Session["Role"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                if (Session["Role"].ToString() == "Admin")
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
            }

            GymMeService.GymMeWebService service = new GymMeService.GymMeWebService();
            List<MsSupplement> supplementList = json<List<MsSupplement>>.decode(service.getSupplementList());
            GV.DataSource = supplementList;
            GV.DataBind();
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
    }
}