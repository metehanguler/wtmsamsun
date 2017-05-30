using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_konusmaciEkle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("giris.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("/img/" + FileUpload1.FileName));
            SqlCommand ekle = new SqlCommand("insert into Konusmaci (konusmaciAd,konusmaciSirket,konusmaciResim,konusmaciLinkedin,konusmaciMail) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','/img/'+'" + FileUpload1.FileName + "','"+TextBox4.Text+"','mailto:'+'"+TextBox3.Text+"')", baglan.baglan());
            ekle.ExecuteNonQuery();
            Response.Write("<script>alert('İçerik Eklendi')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = ""; 
        }
    }
}