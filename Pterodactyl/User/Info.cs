﻿using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
#pragma warning disable
namespace Pterodactyl.Pterodactyl.User
{
    public class Info
    {
        public static string? panel_url;
        public static string? panel_id;
        public static string? panel_api_key;
        public static string? panel_email;
        public static string? panel_password;
        public static string? panel_username;
        public static string? panel_first_name;
        public static string? panel_last_name;
        public static string? panel_admin;
        public static string? panel_avatar;
        public static string panel_language = "en";
        private static async Task<string?> GetUserInfo(string apiKey, Uri panelUri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = panelUri;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("/api/client/account");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        return jsonResponse;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.User.Info.cs]: \n" + ex.Message);
                    return null;
                }
            }
        }
        public static async         Task
Get(string panelUrl, string apiKey, string password)
        {
            if (!Uri.TryCreate(panelUrl, UriKind.Absolute, out Uri panelUri))
            {
                Program.Alert("Invalid Pterodactyl Panel URL", Forms.FrmAlert.enmType.Error);
                Program.logger.Log(Managers.LogType.Warning, "[Pterodactyl.User.Info.cs] Pterodactyl url is not well formatted");
            }
            bool loginSuccess = await Login.Check(apiKey, panelUri);
            if (loginSuccess)
            {
                try
                {
                    string userInfo = await GetUserInfo(apiKey, panelUri);
                    if (userInfo != null)
                    {
                        JObject userObject = JObject.Parse(userInfo);
                        JObject attributes = (JObject)userObject["attributes"];
                        panel_id = attributes["id"].ToString();
                        panel_admin = attributes["admin"].ToString();
                        panel_username = attributes["username"].ToString();
                        panel_email = attributes["email"].ToString();
                        panel_first_name = attributes["first_name"].ToString();
                        panel_last_name = attributes["last_name"].ToString();
                        panel_language = attributes["language"].ToString();

                    }
                    else
                    {
                        Program.Alert("Login failed", Forms.FrmAlert.enmType.Error);
                        Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.User.Info.cs]: No user info received");
                    }
                }
                catch (Exception ex)
                {
                    Program.logger.Log(Managers.LogType.Error, "[Pterodactyl.User.Info.cs]: \n" + ex.Message);
                    Program.Alert("Login failed", Forms.FrmAlert.enmType.Error);
                }
                panel_url = panelUrl;
                panel_api_key = apiKey;
            }
        }
    }
}
