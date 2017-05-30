using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_etkinlikguncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string ajandaId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ajandaId = Request.QueryString["ajandaId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Ajanda where ajandaId = '" + ajandaId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["ajandaAd"].ToString();
            TextBox2.Text = row["ajandaSaat"].ToString();
            TextBox3.Text = row["ajandaKonusmaci"].ToString();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlCommand cmkguncelle = new SqlCommand("update Ajanda Set ajandaAd='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "', ajandaSaat='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "', ajandaKonusmaci='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "' where ajandaId='" + ajandaId + "'", baglan.baglan());
        cmkguncelle.ExecuteNonQuery();
        Response.Write("<script>alert('Güncellendi')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";


    }
}