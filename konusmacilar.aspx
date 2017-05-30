<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="konusmacilar.aspx.cs" Inherits="konusmacilar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="section-speaker" class="section-wrapper team gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>KONUŞMACILAR</h1>
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <ItemTemplate>

                        <div class="col-sm-6 col-md-3">
                            <figure class="thumbnail">
                                <a href="#">
                                    <asp:Image ID="Image1" runat="server" class="img-responsive" ImageUrl='<%# Eval("konusmaciResim") %>' />

                                    <figcaption class="caption text-center">
                                        <h3>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("konusmaciAd") %>'></asp:Label>

                                            <small>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("konusmaciSirket") %>'></asp:Label></small>
                                        </h3>
                                        <ul class="social-links">
                                            <li><a href='<%# Eval("konusmaciLinkedin") %>'><i class="fa fa-linkedin"></i></a></li>
                                            <li><a href='<%# Eval("konusmaciMail") %>'><i class="fa fa-envelope"></i></a></li>
                                        </ul>
                                    </figcaption>
                            </figure>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </section>
</asp:Content>

