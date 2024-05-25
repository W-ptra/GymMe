using frontend.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class UpdateSupplementPage : System.Web.UI.Page
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

                if (Request.QueryString["permission"] == null)
                {
                    Response.Redirect("~/View/ManageSupplementPage.aspx");
                }

                TB_Id.Text = Request.QueryString["supplementId"];
                TB_Name.Text = Request.QueryString["supplementName"];
                TB_Date.Text = Request.QueryString["date"];
                TB_Price.Text = Request.QueryString["price"];
                TB_TypeId.Text = Request.QueryString["typeId"];
            }
        }
        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplementPage.aspx");
        }
        protected void btn_update_Click(object sender, EventArgs e)
        {
            String id = TB_Id.Text;
            String name = TB_Name.Text;
            String date = TB_Date.Text;
            int price = int.Parse(TB_Price.Text);
            int typeId = int.Parse(TB_TypeId.Text);

            ManageSupplementController.updateSupplement(id, name, date, price, typeId);

            Response.Redirect("~/View/ManageSupplementPage.aspx");
        }
    }
}