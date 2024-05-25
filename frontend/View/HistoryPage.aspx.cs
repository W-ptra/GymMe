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
    public partial class HistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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

                if (Session["Role"].ToString() == "Admin")
                {

                    btn_order_supplement.Visible = false;

                    localhost.GymMeWebService service = new localhost.GymMeWebService();
                    List<TransactionHeader> transactionHeaderList = json<List<TransactionHeader>>.decode(service.getAllTransactionHeader());
                    GV.DataSource = transactionHeaderList;
                    GV.DataBind();
                    
                }
                else if (Session["Role"].ToString() == "Customer")
                {
                    btn_to_home.Visible = false;
                    btn_to_manage_supplement.Visible = false;
                    btn_to_order_queue.Visible = false;
                    btn_to_transaction_report.Visible = false;

                    String userIdStr = Session["UserId"].ToString();
                    int userId = Convert.ToInt32(userIdStr);
                    localhost.GymMeWebService service = new localhost.GymMeWebService();
                    List<TransactionHeader> transactionHeaderList = json<List<TransactionHeader>>.decode(service.getAllTransactionHeaderById(userId));
                    GV.DataSource = transactionHeaderList;
                    GV.DataBind();
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

        protected void GV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String transactionId = GV.SelectedRow.Cells[1].Text;

            String redirect = String.Format("~/View/TransactionDetailPage.aspx?transactionId={0}&permission={1}", transactionId,true);

            Response.Redirect(redirect);
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
    }


}