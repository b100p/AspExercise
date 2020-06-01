using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercise
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Orders"] == null)
                Session["Orders"] = Request.QueryString["ordernbr"];
            Orderlbl.Text = Session["Orders"].ToString();
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Auction.mdb");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            OleDbCommand cmd = new OleDbCommand("select Item,Quantity,OrderedPrice from OrdersDetails Where OrdersDetails.Order=" + Session["Orders"].ToString(), cn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cn.Close();
            OrderDetials.DataSource = dt;
            OrderDetials.DataBind();
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