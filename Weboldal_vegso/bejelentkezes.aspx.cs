using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using Newtonsoft.Json;

namespace Weboldal_vegso
{
    public partial class login : Page
    {
        public class UserData
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
        }

        protected void btnRegisztracio_Click(object sender, EventArgs e)
        {
            Response.Redirect("regisztracio.aspx");
        }

        



        protected void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblLoginUzenet.Text = "Kérlek, add meg a felhasználónevet és a jelszót.";
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(password);
            string filePath = Server.MapPath("~/App_Code/users.json");

            List<UserData> users;

            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<UserData>>(json) ?? new List<UserData>();
            }
            else
            {
                users = new List<UserData>();
            }

            var user = users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.PasswordHash == hashedPassword
            );

            if (user != null)
            {
                Session["Username"] = user.Username;
                lblLoginUzenet.ForeColor = System.Drawing.Color.Green;
                lblLoginUzenet.Text = "Sikeres bejelentkezés!";
                Response.Redirect("fooldal.aspx"); // csak siker esetén irányít át
            }
            else
            {
                lblLoginUzenet.Text = "Hibás felhasználónév vagy jelszó.";
            }
        }

    }
}
