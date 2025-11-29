<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regisztracio.aspx.cs" Inherits="Weboldal_vegso.regisztracio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Regisztráció</title>
    <link rel="stylesheet" href="Style_regisztracio/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="regisztracio_contener">
            <h2>Regisztráció</h2>

            <asp:TextBox ID="txtUsername" runat="server" placeholder="Felhasználónév"></asp:TextBox><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Jelszó"></asp:TextBox><br />

            <asp:Button ID="btnRegisztracio" runat="server" Text="Regisztráció" OnClick="btnRegisztracio_Click" /><br /><br />

            <asp:Button ID="btnVissza" runat="server" Text="Vissza" OnClick="btnVissza_Click" /><br /><br />

            <!-- Ez jeleníti meg az üzeneteket -->
            <asp:Label ID="lblRegUzenet" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
