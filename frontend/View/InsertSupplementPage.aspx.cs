using frontend.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class InsertSupplementPage : System.Web.UI.Page
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

            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplementPage.aspx");
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            String name = TB_Name.Text;
            String date = TB_Date.Text;
            int price = int.Parse(TB_Price.Text);
            int typeId = int.Parse(TB_TypeId.Text);

            label_message.Text = ManageSupplementController.insertSupplement(name, date, price, typeId);
        }
    }
}