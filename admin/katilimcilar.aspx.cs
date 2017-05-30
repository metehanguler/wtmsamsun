using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_katilimcilar : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string islem;
    string davetliId;
    protected void Page_Load(object sender, EventArgs e)
    {
        islem = Request.QueryString["islem"];
        davetliId = Request.QueryString["davetliId"];
        if (islem=="sil")
        {
            SqlCommand sil = new SqlCommand("delete from Davetli where davetliId='"+davetliId+"'",baglan.baglan());
            sil.ExecuteNonQuery();
            Response.Redirect("katilimcilar.aspx");
        }
        
        SqlCommand getir = new SqlCommand("Select * from Davetli order by davetliId desc", baglan.baglan());
        SqlDataReader dgetir = getir.ExecuteReader();
        Repeater1.DataSource = dgetir;
        Repeater1.DataBind();
    }
}