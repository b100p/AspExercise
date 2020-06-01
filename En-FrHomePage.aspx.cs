using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercise
{
    public partial class En_FrHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Auction.mdb");
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Clients ", cn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                drpClient.DataTextField = "Number";
                drpClient.DataValueField = "Number";
                drpClient.DataSource = dt;
                drpClient.DataBind();
                cn.Close();
            }
        }

        protected void orderlistbtn_Click(object sender, EventArgs e)
        {
            Session["nbclient"] = drpClient.SelectedValue;
            if (Request.QueryString["lang"] == null)
                Response.Redirect("OrderList.aspx?lang=En");
            else
               Response.Redirect("OrderList.aspx?lang=" + Request.QueryString["lang"].ToString());
        }

        protected void DisplayOrderbtn_Click(object sender, EventArgs e)
        {
            Session["nbclient"] = drpClient.SelectedValue;
            if (Request.QueryString["lang"] == null)
                Response.Redirect("DisplayOrder.aspx?lang=En");
            else
                Response.Redirect("DisplayOrder.aspx?lang=" + Request.QueryString["lang"].ToString());
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