using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Weboldal_vegso
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                // Nincs bejelentkezve → vissza a bejelentkezés oldalra
                Response.Redirect("bejelentkezes.aspx");
            }
        }

        protected void Calc_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");

            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void GT_Web_kliens_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch(Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void NOx_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void logikai_terv_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Eromu_Karbantartasi_Osztaly_tarhely_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Naperomu_Visonta_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Naperomu_Bukkabrany_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Vegy_és_Korny_V_O_tarhely_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Turbina_Rezges_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void MEAC_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Blokki_semakepek_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Attekinto_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void WinOs_naplo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void urik_adatok_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Trendek_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Egyeb_Programok_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Tallozas_FIR_szerveren_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Szolgalatvezetoi_naplok_Kereskedelmi_naplok_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Viz_Lagyito_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Meghajto_csatlakozasa_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("");
            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }


    }
}