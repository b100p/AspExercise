using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspExercise
{
    public partial class DisplayOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CLientlbl.Text = Session["nbclient"].ToString();
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Auction.mdb");
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Orders Where Client=" + Session["nbclient"].ToString(), cn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cn.Close();

            //Label text = new Label();
            //HyperLink link = new HyperLink();
            //Label new_line = new Label();
            foreach(DataRow row in dt.Rows)
            {
                Label text = new Label();
                HyperLink link = new HyperLink();
                Label new_line = new Label();
                text.Text = row["Datee"].ToString() + "-> Order Nimber:";
                link.Text=row["Number"].ToString();
                link.NavigateUrl = "OrderDetails.aspx?ordernbr=" + row["Number"].ToString()+ "&lang=" + Request.QueryString["lang"].ToString();
                new_line.Text = "<br>";
                Page.Controls.Add(text);
                Page.Controls.Add(link);
                Page.Controls.Add(new_line);

            }

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