﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VitalsView.aspx.cs" Inherits="TDDSample.Web.VitalsView" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0">
        <tr><td>Username:</td><td><uc1:Header ID="Header1" runat="server" />
            </td></tr>
        <tr>
          <td>Name:</td>
          <td><asp:Textbox runat="server" id="nameTextbox" /></td>
        </tr>
        <tr>
          <td>SSN:</td>
          <td><asp:Textbox runat="server" id="ssnTextbox" /></td>
        </tr>
        <tr>
          <td> </td>
          <td><asp:Label runat="server" id="errorMessageLabel" CssClass="errorMsg"/></td>
        </tr>
        <tr>
          <td> </td>
          <td><asp:Button runat="server" id="okButton" Text="OK" OnClick="okButton_Click" /></td>
        </tr>
        </table>
        <hr/>
        <table>
        <tr>
            <td></td>
            <td><asp:DropDownList runat="server" ID="ddlTest"></asp:DropDownList>
                <asp:Button ID="btnGetUser" runat="server" OnClick="btnGetUser_Click" Text="Get User" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:GridView runat="server" ID="grdViewEmployee"></asp:GridView></td>
        </tr>
      </table>
    </div>
    </form>
</body>
</html>
