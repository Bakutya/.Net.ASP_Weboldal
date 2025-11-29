<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bejelentkezes.aspx.cs" Inherits="Weboldal_vegso.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style_bejelentkezes/style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="login-container">
    <h2>Bejelentkezés</h2>
            <asp:TextBox ID="txtUsername" runat="server"  placeholder="Felhasználónév"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password" placeholder="Jelszó"></asp:TextBox>
            <asp:Button ID="btnBejelentkezes" runat="server"  Text="Bejelentkezés" OnClick="btnBejelentkezes_Click" />
           <asp:Button ID="btnRegisztracio" runat="server" Text="Regisztráció" OnClick="btnRegisztracio_Click" />
            <asp:Label ID="lblLoginUzenet" runat="server" ForeColor="Red" />

    

</div>

    </form>
</body>
</html>
