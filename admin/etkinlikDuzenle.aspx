<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="etkinlikDuzenle.aspx.cs" Inherits="admin_etkinlikDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <table class="table">
        <thead>
            <tr>
                <th>#</th>
                <th>Etkinlik Adı</th>
                <th>Saat</th>
                <th>Etkinlik Konuşmacısı</th>
                <th>İşlem</th>
            </tr>
        </thead>
        <tbody>
        <asp:Repeater ID="Repeater1" runat="server" >
            
            <ItemTemplate>
                    <tr>
                        <th>
                            <asp:Label ID="Label3" runat="server" Text='<%# Container.ItemIndex + 1 %>'></asp:Label></th>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ajandaAd") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ajandaSaat") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("ajandaKonusmaci") %>'></asp:Label></td>

                        <td><a href="etkinlikguncelle.aspx?ajandaId=<%#Eval("ajandaId") %>">Düzenle</a>
                            <a href="etkinlikduzenle.aspx?ajandaId=<%#Eval("ajandaId") %>&islem=sil" style="color: red; margin-left: 15px">Sil</a>
                        </td>
                    </tr>
            </ItemTemplate>
        </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

