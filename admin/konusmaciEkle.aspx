<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="konusmaciEkle.aspx.cs" Inherits="admin_konusmaciEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        <div class="clear"></div>
        <div class="form-group">
            <label for="exampleInputEmail1">Ad Soyad</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="50%"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Şirket</label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Email</label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Linkedin Profili</label>
            <asp:TextBox ID="TextBox4" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
        <div class="fileinput fileinput-new form-group" data-provides="fileinput">
            <label for="exampleInputEmail1">Konuşmacı Resmi</label>
            <span class="btn btn-default btn-file"><span></span><asp:FileUpload ID="FileUpload1" runat="server" /></span>
        </div>
        <div class="form-group">
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Kaydet" OnClick="Button1_Click" />
        </div>


  

</asp:Content>

