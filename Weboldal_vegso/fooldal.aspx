<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fooldal.aspx.cs" Inherits="Weboldal_vegso.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style_fooldal/style.css" />
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">

        <asp:Button ID="button_ötödik" runat="server" Text="Kijelentkezés" OnClick="Kijelentkezes_Click" CssClass="button_ötödik" />

        <asp:Button ID="button_elso" runat="server" Text="Számológép" OnClick="Calc_Click" CssClass="button_elso" />
        <asp:Button ID="button_masodik" runat="server" Text="Parancssor" OnClick="CMD_Click" CssClass="button_masodik" />
        <asp:Button ID="button_harmadik" runat="server" Text="Jegyzettömb" OnClick="Notepad_Click" CssClass="button_harmadik" />
        <asp:Button ID="button_negyedik" runat="server" Text="Képmetsző" OnClick="Kepmetszo_Click" CssClass="button_negyedik" />
       
        



        <asp:Image ID="image_elso" runat="server" ImageUrl="~/Image/calc.png" CssClass="image_elso"  />
        <asp:Image ID="image_masodik" runat="server" ImageUrl="~/Image/cmd_kep.png" CssClass="image_masodik"  />
        <asp:Image ID="image_harmadik" runat="server" ImageUrl="~/Image/notepad.jpg" CssClass="image_harmadik"  />
        <asp:Image ID="image_negyedik" runat="server" ImageUrl="~/Image/Képmetszo.jpg" CssClass="image_negyedik"  />
        
                

                
         
        
    </form>
</body>
</html>
