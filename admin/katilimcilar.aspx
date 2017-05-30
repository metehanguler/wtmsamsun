<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="katilimcilar.aspx.cs" Inherits="admin_katilimcilar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table class="table table-hover">
        <thead>
            <tr>
                <th>#</th>
                <th>İsim</th>
                <th>Mail</th>
                <th>İşlem</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr>
                <th scope="row"><asp:Label ID="Label3" runat="server" Text='<%# Container.ItemIndex + 1 %>'></asp:Label></th>
                <td>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("davetliAd") %>'></asp:Label></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("davetliMail") %>'></asp:Label></td>
                    <td><a href="katilimcilar.aspx?davetliId=<%#Eval("davetliId") %>&islem=sil" style="color: red; margin-left: 15px">Sil</a>
                </td>
            </tr>
        </ItemTemplate>

    </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

