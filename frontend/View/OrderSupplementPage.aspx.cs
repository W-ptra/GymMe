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
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie roleCookie = Request.Cookies["Role"];
                HttpCookie usernameCookie = Request.Cookies["Username"];
                HttpCookie userIdCookie = Request.Cookies["UserId"];
                if (roleCookie != null && userIdCookie != null && userIdCookie != null)
                {
                    Session["Role"] = roleCookie.Value;
                    Session["Username"] = usernameCookie.Value;
                    Session["UserId"] = userIdCookie.Value;
                }

                if (Session["Role"] == null || Session["Username"] == null || Session["UserId"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                if (Session["Role"].ToString() == "Admin")
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }
            }

            int userId = int.Parse(Session["UserId"].ToString());

            localhost.GymMeWebService service = new localhost.GymMeWebService();
            List<MsSupplement> supplementList = json<List<MsSupplement>>.decode(service.getSupplementList());
            List<MsCart> cartList = json<List<MsCart>>.decode(service.getCartList(userId));
            GV_Cart.DataSource = cartList;
            GV.DataSource = supplementList;
            GV_Cart.DataBind();
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
            if (quantity < 2) return;
            quantity -= 1;
            TB_Quantity.Text = quantity.ToString();
        }

        protected void btn_addToCart_Click(object sender, EventArgs e)
        {

            String quantityStr = TB_Quantity.Text;
            String userIdStr = Session["UserId"].ToString();
            String supplementIdStr = TB_ID.Text;
            int quantity = int.Parse(quantityStr);
            int userId = int.Parse(userIdStr);
            int supplementId = int.Parse(supplementIdStr);

            label_message_add.Text = OrderSupplementController.addCartItem(userId,supplementId,quantity);
            Response.Redirect("~/View/OrderSupplementPage.aspx");
        }

        protected void btn_clearCart_Click(object sender, EventArgs e)
        {
            String userIdStr = Session["UserId"].ToString();
            int userId = int.Parse(userIdStr);

            localhost.GymMeWebService service = new localhost.GymMeWebService();
            service.clearCart(userId);
            Response.Redirect("~/View/OrderSupplementPage.aspx");
        }

        protected void btn_checkOut_Click(object sender, EventArgs e)
        {
            String userIdStr = Session["UserId"].ToString();
            int userId = int.Parse(userIdStr);
            OrderSupplementController.checkoutTransaction(userId);         
            Response.Redirect("~/View/OrderSupplementPage.aspx");
        }
    }
}