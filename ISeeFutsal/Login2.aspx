<%@ Page Title="" Language="C#" MasterPageFile="~/Futsal.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="ISeeFutsal.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
    <h4 class="center">Login</h4>
    <div class="row">
        <div class="input-field col s12 m6 l4 offset-m2 offset-l4">
            <input id="username" type="email" class="validate" runat="server"/>
            <label for="username">Email</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12 m6 l4 offset-m2 offset-l4">
            <input id="password" type="password" class="validate" runat="server"/>
            <label for="password">Password</label>
        </div>
    </div>
    <div class ="row">
        <asp:Button ID="login" Cssclass="waves-effect waves-light btn-large col s6 m3 l2 offset-m2 offset-l4" 
                                                Text="Login" runat="server" OnClick="login_Click" />
        <a href="opretBruger.aspx" class="waves-effect waves-light btn-large col s6 m3 l2">Opret</a>
    </div>
    </div>
</asp:Content>
