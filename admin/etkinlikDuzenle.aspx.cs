using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_etkinlikDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string islem;
    string ajandaId;
    protected void Page_Load(object sender, EventArgs e)
    {
        islem = Request.QueryString["islem"];
        ajandaId = Request.QueryString["ajandaId"];
        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Ajanda where ajandaId='" + ajandaId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
            Response.Redirect("etkinlikduzenle.aspx");
        }
        SqlCommand getir = new SqlCommand("Select * from Ajanda order by ajandaSaat asc", baglan.baglan());
        SqlDataReader etkinlikgetir = getir.ExecuteReader();
        Repeater1.DataSource = etkinlikgetir;
        Repeater1.DataBind();
    }
}