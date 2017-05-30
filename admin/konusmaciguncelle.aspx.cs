using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_konusmaciguncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string konusmaciId;
    protected void Page_Load(object sender, EventArgs e)
    {
        konusmaciId = Request.QueryString["konusmaciId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Konusmaci where konusmaciId = '" + konusmaciId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["konusmaciAd"].ToString();
            TextBox2.Text = row["konusmaciSirket"].ToString();
            TextBox3.Text = row["konusmaciMail"].ToString();
            TextBox4.Text = row["konusmaciLinkedin"].ToString();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("/img/" + FileUpload1.FileName));
            SqlCommand cmkguncelle = new SqlCommand("update Konusmaci Set konusmaciAd='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "', konusmaciSirket='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "', konusmaciMail='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "', konusmaciResim ='/img/'+ '" + FileUpload1.FileName + "',konusmaciLinkedin='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "' where konusmaciId='" + konusmaciId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
            Response.Write("<script>alert('Güncellendi')</script>");


        }
        else
        {
            SqlCommand cmkguncelle = new SqlCommand("update Konusmaci Set konusmaciAd='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "', konusmaciSirket='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "', konusmaciMail='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "', konusmaciLinkedin='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "'  where konusmaciId='" + konusmaciId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
            Response.Write("<script>alert('Başlık ve İçerik Güncellendi')</script>");
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = ""; 
    }
}
