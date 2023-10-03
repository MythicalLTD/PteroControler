﻿using Microsoft.Win32;
using PteroController.Pterodactyl;

namespace PteroController.Handlers
{
    public class RegistryHandler
    {
        private const string RegistryAccountBasePath = "Software\\MythicalSystems\\PteroController\\Sessions";
        private const string RegistrySettingsBasePath = "Software\\MythicalSystems\\PteroController\\Settings";


        public void CreateAccountData(string sessionName, string url, string password, string apiKey)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey($"{RegistryAccountBasePath}\\{sessionName}"))
                {
                    key.SetValue("panel_url", url);
                    key.SetValue("panel_pwd", password);
                    key.SetValue("api_key", apiKey);
                }
            } catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Handlers.RegistryHandler.cs]: \n" + ex.Message);
            }
        }
        public List<string> ListSessions()
        {

            try
            {
                List<string> sessionInfo = new List<string>();

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryAccountBasePath))
                {
                    if (key != null)
                    {
                        foreach (string sessionName in key.GetSubKeyNames())
                        {
                            string panelUrl = key.OpenSubKey(sessionName)?.GetValue("panel_url")?.ToString();
                            if (!string.IsNullOrEmpty(panelUrl))
                            {
                                string displayText = $"{sessionName} ({panelUrl})";
                                sessionInfo.Add(displayText);
                            }
                        }
                    }
                }

                return sessionInfo;
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Handlers.RegistryHandler.cs]: \n" + ex.Message);
                return null;
            }
        }
        public SessionInfo GetSessionInfo(string sessionName)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey($"{RegistryAccountBasePath}\\{sessionName}"))
                {
                    if (key != null)
                    {
                        string panelUrl = key.GetValue("panel_url")?.ToString();
                        string panelPwd = key.GetValue("panel_pwd")?.ToString();
                        string apiKey = key.GetValue("api_key")?.ToString();

                        return new SessionInfo
                        {
                            PanelUrl = panelUrl,
                            PanelPwd = panelPwd,
                            ApiKey = apiKey
                        };
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Program.logger.Log(Managers.LogType.Error, "[Handlers.RegistryHandler.cs]: \n" + ex.Message);
                return null;
            }
        }
        public void DeleteAccountData(string sessionName)
        {
            Registry.CurrentUser.DeleteSubKeyTree($"{RegistryAccountBasePath}\\{sessionName}");
        }
    }
}
