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
    public partial class TransactionDetailPage : System.Web.UI.Page
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
                
                String idStr = Request.QueryString["transactionId"];
                
                
                if (Request.QueryString["permission"] == null)
                {
                    Response.Redirect("~/View/HistoryPage.aspx");
                }
                int id = int.Parse(idStr);
                
                localhost.GymMeWebService service = new localhost.GymMeWebService();
                List<TransactionDetail> TDlist = json<List<TransactionDetail>>.decode(service.getAllTransactionDetailById(id));
                GV.DataSource = TDlist;
                GV.DataBind();
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HistoryPage.aspx");
        }
    }
}