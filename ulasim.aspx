<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ulasim.aspx.cs" Inherits="ulasim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="section-venue" class="section-wrapper  gray-bg">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title">
                        <h1>Ulaşım</h1>
                    </div>
                </div>
            </div>
            <!-- /.row-->

            <div class="row">
                <div class="col-md-12">
                    <div id="googleMap"></div>
                </div>
            </div>
         
        </div>

    </section>
</asp:Content>

