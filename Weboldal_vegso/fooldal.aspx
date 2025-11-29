<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fooldal.aspx.cs" Inherits="Weboldal_vegso.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style_fooldal/style.css" />
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">


        <asp:Button ID="button_elso" runat="server" Text="GT Web kliens" OnClick="GT_Web_kliens_Click" CssClass="button_elso" />
       <asp:Button ID="button_masodik" runat="server" Text="NOx, SO2 szabályozás" OnClick="NOx_Click" CssClass="button_masodik" />
        <asp:Button ID="button_harmadik" runat="server" Text="logikai tervek" OnClick="logikai_terv_Click" CssClass="button_harmadik" />
        <asp:Button ID="button_negyedik" runat="server" Text="Erőmű Karbantartási Osztály tárhely" OnClick="Eromu_Karbantartasi_Osztaly_tarhely_Click" CssClass="button_negyedik" />
        <asp:Button ID="button_ötödik" runat="server" Text="Naperőmű Visonta" OnClick="Naperomu_Visonta_Click" CssClass="button_ötödik" />
        <asp:Button ID="button_hatodik" runat="server" Text="Naperőmű Bükkábrány" OnClick="Naperomu_Bukkabrany_Click" CssClass="button_hatodik" />
        <asp:Button ID="button_hetedik" runat="server" Text="Vegy.és Körny.V.O. tárhely" OnClick="Vegy_és_Korny_V_O_tarhely_Click" CssClass="button_hetedik" />
        <asp:Button ID="button_nyolcadik" runat="server" Text="Turbina Rezgés" OnClick="Turbina_Rezges_Click" CssClass="button_nyolcadik" />
        <asp:Button ID="button_kilencedik" runat="server" Text="MEAC" OnClick="MEAC_Click" CssClass="button_kilencedik" />
        <asp:Button ID="button_tizedik" runat="server" Text="Blokki sémaképek" OnClick="Blokki_semakepek_Click" CssClass="button_tizedik" />
        <asp:Button ID="button_tizenegyedik" runat="server" Text="Áttekintő" OnClick="Attekinto_Click" CssClass="button_tizenegyedik" />
        <asp:Button ID="button_tizenkettedik" runat="server" Text="WinOS naplók" OnClick="WinOs_naplo_Click" CssClass="button_tizenkettedik" />
        <asp:Button ID="button_tizenharmadik" runat="server" Text="Ürik adatok" OnClick="urik_adatok_Click" CssClass="button_tizenharmadik" />
        <asp:Button ID="button_tizennegyedik" runat="server" Text="Trendek" OnClick="Trendek_Click" CssClass="button_tizennegyedik" />
        <asp:Button ID="button_tizenötödik" runat="server" Text="Egyéb programok" OnClick="Egyeb_Programok_Click" CssClass="button_tizenötödik" />
        <asp:Button ID="button_tizenhatodik" runat="server" Text="Tallózás FIR szerveren" OnClick="Tallozas_FIR_szerveren_Click" CssClass="button_tizenhatodik" />
        <asp:Button ID="button_tizenhetedik" runat="server" Text="Szolgálatvezetői naplók Kereskedelmi naplók" OnClick="Szolgalatvezetoi_naplok_Kereskedelmi_naplok_Click" CssClass="button_tizenhetedik" />
        <asp:Button ID="button_tizennyolcadik" runat="server" Text="Víz Lágyító" OnClick="Viz_Lagyito_Click" CssClass="button_tizennyolcadik" />
        <asp:Button ID="button_tizenkilencedik" runat="server" Text="Meghajtó csatlakozása" OnClick="Meghajto_csatlakozasa_Click" CssClass="button_tizenkilencedik" />
      



        <asp:Image ID="image_elso" runat="server" ImageUrl="~/Image/web.png" CssClass="image_elso"  />
        
                

                
         
        
    </form>
</body>
</html>
