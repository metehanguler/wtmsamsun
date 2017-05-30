<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="admin_giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/giris.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <div class="login-triangle"></div>

            <h2 class="login-header">Giriş Paneli</h2>

            <div class="login-container" runat="server">
                <p>
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
                <p>
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
