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

        protected void Kijelentkezes_Click(object sender, EventArgs e)
        {
            Response.Redirect("bejelentkezes.aspx");
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

        protected void CMD_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe");

            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

        protected void Notepad_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");

            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }
        protected void Kepmetszo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("snippingtool.exe");

            }
            catch (Exception ex)
            {
                Response.Write("Hiba történt: " + ex.Message);
            }
        }

    }
}