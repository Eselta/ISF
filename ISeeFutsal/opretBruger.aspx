<%@ Page Title="" Language="C#" MasterPageFile="~/Futsal.Master" AutoEventWireup="true" CodeBehind="opretBruger.aspx.cs" Inherits="ISeeFutsal.opretBruger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <h4 class="center-align">Opret bruger</h4>
            <div class="row">
                <div class="input-field col s12 m8 l4 offset-m2 offset-l2">
                    <input runat="server" id="firstname" type="text" class="validate" />
                    <label for="firstname">Fornavn</label>
                </div>
            
                <div class="input-field col s12 m8 l4 offset-m2">
                    <input runat="server" id="lastname" type="text" class="validate" />
                    <label for="lastname">Efternavn</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m8 offset-m2">
                    <input runat="server" id="phone" type="tel" class="validate" />
                    <label for="phone">Telefonnummer</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m8 offset-m2">
                    <input runat="server" id="email" type="email" class="validate" />
                    <label for="Email">E-mail</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m8 offset-m2">
                    <input id="confirmEmail" type="email" class="validate" />
                    <label for="confirmEmail">Gentag E-mail</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m8 offset-m2">
                    <input runat="server" id="password" type="password" class="validate" />
                    <label for="Password">Kodeord</label>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12 m8 offset-m2">
                    <input id="confirmPassword" type="password" class="validate" />
                    <label for="confirmPassword">Gentag Kodeord</label>
                </div>
            </div>
            <div class="row">
                <div class="col s4 offset-s5">
                    <asp:Button CssClass="waves-light waves-effect btn-large" ID="opretBtn" runat="server" Text="Opret" OnClick="opretBtn_Click" />
                </div>
            </div>
        </div>
</asp:Content>
