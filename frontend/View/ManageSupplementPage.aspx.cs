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
    public partial class ManageSupplementPage : System.Web.UI.Page
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
                List<MsSupplement> supplementList = json<List<MsSupplement>>.decode(service.getSupplementList());
                GV.DataSource = supplementList;
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
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btn_InsertSupplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertSupplementPage.aspx");
        }

        protected void btn_delete(object sender, GridViewDeleteEventArgs e)
        {
            ;
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void btn_update(object sender, GridViewEditEventArgs e)
        {

            GridViewRow row = GV.Rows[e.NewEditIndex];
            String supplementId = row.Cells[1].Text;
            String supplementName = row.Cells[2].Text;
            String price = row.Cells[3].Text;
            String date = row.Cells[4].Text;
            String typeId = row.Cells[5].Text;

            String redirect = String.Format("~/View/UpdateSupplementPage.aspx?supplementId={0}&supplementName={1}&date={2}&price={3}&typeId={4}", supplementId, supplementName, price, date, typeId);
            Response.Redirect(redirect);            
        }
    }
}