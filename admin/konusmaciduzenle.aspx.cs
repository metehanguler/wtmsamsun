using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_konusmaciduzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string islem;
    string konusmaciId;
    protected void Page_Load(object sender, EventArgs e)
    {
        islem = Request.QueryString["islem"];
        konusmaciId = Request.QueryString["konusmaciId"];
        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Konusmaci where konusmaciId='" + konusmaciId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }
        SqlCommand getir = new SqlCommand("Select * from Konusmaci order by konusmaciId desc", baglan.baglan());
        SqlDataReader duyurugetir = getir.ExecuteReader();
        Repeater1.DataSource = duyurugetir;
        Repeater1.DataBind();
    }
}