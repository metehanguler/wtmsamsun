<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="biletal.aspx.cs" Inherits="biletal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="section-pricing" class="section-wrapper pricing-section gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>Bilet Al</h1>
                        <p>Aramızda olmak için sen de hemen bir bilet al</p>
                    </div>
                </div>
            </div>

        <div class="form-group">
            <label for="exampleInputEmail1">Ad Soyad</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="50%"></asp:TextBox>

        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Mail</label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Telefon</label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Şehir</label>
            <asp:TextBox ID="TextBox4" runat="server" class="form-control" Width="50%"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Bilet Al" BorderColor="#009900" BorderStyle="Solid" BorderWidth="1px" OnClick="Button1_Click" />
        </div>
        </div>
        

    </section>
</asp:Content>

