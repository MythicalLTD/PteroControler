﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pterodactyl.Forms.Controller
{
    public partial class NewDatabase : Form
    {
        private string ServerId;
        public NewDatabase(string Serverid)
        {
            InitializeComponent();
            this.ServerId = Serverid;
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadddb_Click(object sender, EventArgs e)
        {
            if (txtpanelname.Text == "" && txtconfrom.Text == "")
            {
                Program.Alert("Please fill in all the required information", FrmAlert.enmType.Warning);
            }
            else
            {
                try
                {
                    var client = new RestClient(Pterodactyl.User.Info.panel_url);
                    var request = new RestRequest($"/api/client/servers/" + ServerId + "/databases", Method.POST);
                    request.AddHeader("Accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Authorization", $"Bearer {Pterodactyl.User.Info.panel_api_key}");
                    string requestBody = $"{{\"database\":\"{txtpanelname.Text}\",\"remote\":\"{txtconfrom.Text}\"}}";

                    request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

                    var response = client.Execute(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Program.Alert("Database created successfully!", FrmAlert.enmType.Succes);
                        this.Close();
                    }
                    else
                    {
                        Program.Alert("Error while creating your database!", FrmAlert.enmType.Error);
                        Program.logger.Log(Managers.LogType.Error, "[Forms.Controller.NewDatabase.cs]: " + response.ErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    Program.logger.Log(Managers.LogType.Error, "[Forms.Controller.NewDatabase.cs]: "+ex.Message);
                }
            }
        }
    }
}
