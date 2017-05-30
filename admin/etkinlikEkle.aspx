<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="etkinlikEkle.aspx.cs" Inherits="admin_etkinlikEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="clear"></div>
        <div class="form-group">
            <label for="exampleInputEmail1">Etkinlik Açıklaması</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="50%"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Etkinlik Saati - (örn:13:00)</label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
            <div class="form-group">
            <label for="exampleInputEmail1">Etkinlik Konuşmacısı</label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
       
        <div class="form-group">
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Kaydet" OnClick="Button1_Click"  />
        </div>
</asp:Content>

