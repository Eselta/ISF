<%@ Page Title="" Language="C#" MasterPageFile="~/Futsal.Master" AutoEventWireup="true" CodeBehind="Hold.aspx.cs" Inherits="ISeeFutsal.Hold" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <ul class="collection">
            <li class="collection-header center"><h4>Hold</h4></li>
            <li class="collection-item avatar grey lighten-3 hoverable">
                <a href="HoldData.aspx"><img src="/Billeder/bb-logo.jpg" alt="" class="circle">
                <span class="title">Brøndby IF futsal</span>
                <p>Brøndby
                </p></a>
            </li>
        </ul>
    </div>
      <div class="fixed-action-btn">
    <a class="btn-floating btn-large blue">
      <i class="large material-icons">reorder</i>
    </a>
    <ul>
      <li><a class="btn-floating"><i class="material-icons green">add</i>Tilføj hold</a></li>
      <li><a class="btn-floating"><i class="material-icons red">delete</i>Fjern hold</a></li>
    </ul>
  </div>
</asp:Content>
