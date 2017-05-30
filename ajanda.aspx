<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ajanda.aspx.cs" Inherits="ajanda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="section-ajenda" class="section-wrapper section-ajenda">
        <div class="row">
            <div class="col-md-12">
                <div class="section-title">
                    <h1>9-10 HAZİRAN KONFERANS PROGRAMI</h1>
                </div>
            </div>
        </div>
        <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow">
            <ItemTemplate>
                <div style="background-color: #dbdbdb; width: 70%; height: 130px; margin: 0 auto">
                    <div style="text-align: center; width: 30%; height: 130px; float: left; padding: 15px; border-right: 25px solid white; line-height: 2em">
                        <time>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ajandaSaat") %>'></asp:Label></time>
                    </div>
                    <div style="width: 60%; height: 130px; float: right">
                        <h2 style="padding: 10px;">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ajandaAd") %>'></asp:Label><br />
                        </h2>
                        <h5 style="padding: 10px;">
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("ajandaKonusmaci") %>'></asp:Label>
                        </h5>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>


    </section>
</asp:Content>

