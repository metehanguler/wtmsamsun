<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="davetet.aspx.cs" Inherits="admin_davetet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="form-group">
        <label for="exampleInputEmail1">Davetli İsim</label>
        <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="50%"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Davetli Email (Birden Fazla Mail Adresini (,) ile ayırınız)</label>
        <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="50%"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Mesaj</label>
        <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="50%" Height="207px" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Davet Et" OnClick="Button1_Click" />
    </div>
</asp:Content>

