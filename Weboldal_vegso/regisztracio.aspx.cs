using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

public static class SecurityHelper
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}

public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}

namespace Weboldal_vegso
{
    public partial class regisztracio : System.Web.UI.Page
    {
        protected void btnRegisztracio_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblRegUzenet.Text = "Felhasználónév és jelszó megadása kötelező.";
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(password);
            string filePath = Server.MapPath("~/App_Code/users.json");

            List<User> users;

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }

            if (users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                lblRegUzenet.Text = "Ez a felhasználónév már létezik.";
                return;
            }

            users.Add(new User { Username = username, PasswordHash = hashedPassword });

            string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);

            lblRegUzenet.Text = "Sikeres regisztráció!";
        }
        protected void btnVissza_Click(object sender, EventArgs e)
        {
            Response.Redirect("fooldal.aspx");
        }
    }
}
