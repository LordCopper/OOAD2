﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AllaBolagScrubber.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="mindiv" runat="server" > </div>

        <input id="Text1" type="text" runat="server"  /> <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                             <asp:ListItem Text="Eniro" Value="Eniro"></asp:ListItem>
            <asp:ListItem Text="Allabolag" Value="Allabolag"></asp:ListItem>
                                                         </asp:DropDownList>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="knappKlickad" OnClick="Button1_Click"/>
    
    </div>
    </form>
</body>
</html>