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
                    localhost.GymMeWebService service = new localhost.GymMeWebService();
                    List<TransactionHeader> transactionHeaderList = json<List<TransactionHeader>>.decode(service.getAllTransactionHeader());
                    GV.DataSource = transactionHeaderList;
                    GV.DataBind();
                    
                }
                else if (Session["Role"].ToString() == "Customer")
                {
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
            String userId = GV.SelectedRow.Cells[2].Text;
            String transactionDate = GV.SelectedRow.Cells[3].Text;
            String status = GV.SelectedRow.Cells[4].Text;

            String redirect = String.Format("~/View/TransactionDetailPage.aspx?transactionId={1}", transactionId, userId, transactionDate, status);

            Response.Redirect(redirect);
        }
    }


}