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

            localhost.GymMeWebService service = new localhost.GymMeWebService();
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

        protected void GV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_ID.Text = GV.SelectedRow.Cells[1].Text;
            TB_Name.Text = GV.SelectedRow.Cells[2].Text;
            TB_Expiry.Text = GV.SelectedRow.Cells[3].Text;
            TB_Price.Text = GV.SelectedRow.Cells[4].Text;
        }

        protected void btn_increaseQuantity_Click(object sender, EventArgs e)
        {
            String quantityStr = TB_Quantity.Text;
            int quantity = int.Parse(quantityStr);
            if (quantity > 999) return;
            quantity += 1;
            TB_Quantity.Text = quantity.ToString();
        }

        protected void btn_decressQuantity_Click(object sender, EventArgs e)
        {
            String quantityStr = TB_Quantity.Text;
            int quantity = int.Parse(quantityStr);
            if (quantity < 1) return;
            quantity -= 1;
            TB_Quantity.Text = quantity.ToString();
        }

        protected void btn_addToCart_Click(object sender, EventArgs e)
        {
            String quantityStr = TB_Quantity.Text;
            int quantity = int.Parse(quantityStr);
            if(quantity < 1)
            {
                label_message_add.Text = "Quantity can't negative or 0";
            }
        }

        protected void btn_clearCart_Click(object sender, EventArgs e)
        {
            
        }
    }
}