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
public partial class admin_davetet : System.Web.UI.Page
{    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox3.Text = "Ondokuz Mayıs Üniversitesi kapsamında 9 Haziran Tarihinde düzenlenecek olan Bilişim Konferansına katılmanızdan onur duyarız." + "\n" + "Yer : Atatürk Kültür ve Kongre Merkezi" + "\n" +"Tarih : 9 Haziran";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand ekle = new SqlCommand("insert into Davetiye (davetliAd,davetliMail) values ('" + TextBox1.Text + "','" + TextBox2.Text + "')", baglan.baglan());
        ekle.ExecuteNonQuery();

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("samsunkonferans@gmail.com");
        mail.To.Add(TextBox2.Text);
        mail.Subject = "Samsun Bilişim Konferansı 2017 Davetiyesi";
        mail.Body = TextBox3.Text;
        SmtpClient sc = new SmtpClient();
        sc.Port = 587;
        sc.Host = "smtp.gmail.com";
        sc.EnableSsl = true;
        sc.Credentials = new NetworkCredential("samsunkonferans@gmail.com", "pasw0rd1");
        sc.Send(mail);
        Response.Write("<script>alert('Davetiye Gönderildi')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";

    }
}