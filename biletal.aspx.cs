using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.IO;

public partial class biletal : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand ekle = new SqlCommand("insert into Davetli (davetliAd,davetliMail,davetliTel,davetliSehir) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", baglan.baglan());
        ekle.ExecuteNonQuery();

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("samsunkonferans@gmail.com");
        mail.To.Add(TextBox2.Text);
        mail.Subject = "Samsun Bilişim Konferansı 2017";
        mail.Body = "Merhaba " + TextBox1.Text + " Bize katıldığın için teşekkür ederiz. 9 Haziran'da sizi aramızda görmekten mutluluk duyarız.";
        SmtpClient sc = new SmtpClient();
        sc.Port = 587;
        sc.Host = "smtp.gmail.com";
        sc.EnableSsl = true;
        sc.Credentials = new NetworkCredential("samsunkonferans@gmail.com", "pasw0rd1");
        sc.Send(mail);
        Response.Write("<script>alert('Bilet Alındı')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}