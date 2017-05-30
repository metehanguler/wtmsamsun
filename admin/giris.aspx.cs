using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_giris : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select * from Yonetici where yoneticiKullanici=@yoneticiKullanici and yoneticiSifre=@yoneticiSifre", baglan.baglan());
        cmd.Parameters.Add("yoneticiKullanici", TextBox1.Text);
        cmd.Parameters.Add("yoneticiSifre", TextBox2.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            Session["yoneticiKullanici"] = dr["yoneticiKullanici"];

            Response.Redirect("default.aspx");
        }
        else
        {
            Response.Write("<script>alert('Hatalı Giriş...')</script>");
        }
    }
}