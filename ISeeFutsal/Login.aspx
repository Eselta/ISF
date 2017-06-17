<%@ Page Title="" Language="C#" MasterPageFile="~/Futsal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ISeeFutsal.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container center-align">
        <table>
            <tr>
                <td>
                    <div class="input-field col s4">
                        <input type="text" class="validate" id="username" />
                        <label for="username">Username</label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="input-field col s4">
                        <input id="password" type="password" class="validate" />
                        <label for="passwrod">Password</label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="center-align">
                        <button class="waves-effect waves-light btn-large">Login</button>
                        <a class="waves-effect waves-light btn-large" href="opretBruger.aspx">Opret</a>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
