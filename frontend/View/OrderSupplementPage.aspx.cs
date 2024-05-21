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
            if (Session["Role"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
        }

        protected void btn_order_supplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderSupplementPage");
        }

        protected void btn_history_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HistoryPage");
        }

        protected void btn_profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage");
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/LoginPage");
        }
    }
}