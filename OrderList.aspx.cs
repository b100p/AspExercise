using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercise
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                clientnbr.Text = Session["nbclient"].ToString();
                OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Auction.mdb");
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Orders where Client=" + Session["nbclient"].ToString() + " ", cn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                drpOrders.DataTextField = "Number";
                drpOrders.DataValueField = "Number";
                drpOrders.DataSource = dt;
                drpOrders.DataBind();
                cn.Close();
            }
        }

        protected void details_Click(object sender, EventArgs e)
        {
            Session["Orders"] = drpOrders.SelectedValue ;
            Response.Redirect("OrderDetails.aspx?lang="+ Request.QueryString["lang"].ToString());
        }
        protected override void InitializeCulture()
        {
            if (Request.QueryString["lang"] != null)
            {
                UICulture = Request.QueryString["lang"].ToString();
                Culture = Request.QueryString["lang"].ToString();
                base.InitializeCulture();
            }
        }
    }
}