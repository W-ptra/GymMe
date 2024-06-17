using frontend.Dataset;
using frontend.Model;
using frontend.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontend.View
{
    public partial class ViewTransactionsReportPage : System.Web.UI.Page
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
                    Response.Redirect("~/View/OrderSupplementPage.aspx");
                }
 
            }
            MyCrystalReport myCrystalReport = new MyCrystalReport();

            GymMeSQLDatabaseEntities5 db = new GymMeSQLDatabaseEntities5();

            DataSet1 dataSet1 = getData((from x in db.TransactionHeaders select x).ToList());

            myCrystalReport.SetDataSource(dataSet1);
            CrystalReportViewer1.ReportSource = myCrystalReport;
        }
        public DataSet1 getData(List<TransactionHeader> transactionHeaders) 
        {
            DataSet1 dataSet = new DataSet1();
            var headerTable = dataSet.TransactionHeader;
            var detailTable = dataSet.TransactionDetail;
            foreach(TransactionHeader th in transactionHeaders)
            {
                var headerRow = headerTable.NewRow();
                headerRow["TransactionId"] = th.TransactionID;
                headerRow["TransactionDate"] = th.TransactionDate;
                headerTable.Rows.Add(headerRow);
                foreach(TransactionDetail td in th.TransactionDetails)
                {
                    var detailRow = detailTable.NewRow();
                    detailRow["TransactionId"] = td.TransactionID;
                    detailRow["SupplementId"] = td.SupplementID;
                    detailTable.Rows.Add(detailRow);

                }
            }
            return dataSet;
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
            Response.Redirect("~/View/ViewTransactionsReportPage.aspx");
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

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}