﻿namespace PteroController
{
    partial class FrmServerController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.navbar = new System.Windows.Forms.Panel();
            this.lblappname = new System.Windows.Forms.Label();
            this.appicon = new System.Windows.Forms.PictureBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.sidenav = new System.Windows.Forms.Panel();
            this.btndbs = new Guna.UI2.WinForms.Guna2Button();
            this.btnsftp = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsole = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.PageDB = new System.Windows.Forms.TabPage();
            this.pageConsole = new System.Windows.Forms.TabPage();
            this.pnlsvlimits = new System.Windows.Forms.Panel();
            this.lblsvlimit = new System.Windows.Forms.Label();
            this.lblram = new System.Windows.Forms.Label();
            this.lblcpu = new System.Windows.Forms.Label();
            this.lbldisk = new System.Windows.Forms.Label();
            this.pcsvimg = new System.Windows.Forms.PictureBox();
            this.pnlconsole = new System.Windows.Forms.Panel();
            this.svstart = new System.Windows.Forms.PictureBox();
            this.commandTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.svrestart = new System.Windows.Forms.PictureBox();
            this.btnsend = new Guna.UI2.WinForms.Guna2Button();
            this.svshutdown = new System.Windows.Forms.PictureBox();
            this.psvkill = new System.Windows.Forms.PictureBox();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.pnlsvinfo = new System.Windows.Forms.Panel();
            this.svnode = new System.Windows.Forms.Label();
            this.lblsvip = new System.Windows.Forms.Label();
            this.svname = new System.Windows.Forms.Label();
            this.lblsvinfo = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).BeginInit();
            this.sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.Pages.SuspendLayout();
            this.PageDB.SuspendLayout();
            this.pageConsole.SuspendLayout();
            this.pnlsvlimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcsvimg)).BeginInit();
            this.pnlconsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svshutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psvkill)).BeginInit();
            this.pnlsvinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 840000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.navbar.Controls.Add(this.lblappname);
            this.navbar.Controls.Add(this.appicon);
            this.navbar.Controls.Add(this.lblmin);
            this.navbar.Controls.Add(this.lblexit);
            resources.ApplyResources(this.navbar, "navbar");
            this.navbar.Name = "navbar";
            // 
            // lblappname
            // 
            resources.ApplyResources(this.lblappname, "lblappname");
            this.lblappname.BackColor = System.Drawing.Color.Transparent;
            this.lblappname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblappname.Name = "lblappname";
            // 
            // appicon
            // 
            resources.ApplyResources(this.appicon, "appicon");
            this.appicon.Name = "appicon";
            this.appicon.TabStop = false;
            // 
            // lblmin
            // 
            resources.ApplyResources(this.lblmin, "lblmin");
            this.lblmin.BackColor = System.Drawing.Color.Transparent;
            this.lblmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblmin.Name = "lblmin";
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            resources.ApplyResources(this.lblexit, "lblexit");
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblexit.Name = "lblexit";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.sidenav.Controls.Add(this.guna2VSeparator1);
            this.sidenav.Controls.Add(this.btndbs);
            this.sidenav.Controls.Add(this.btnsftp);
            this.sidenav.Controls.Add(this.btnconsole);
            this.sidenav.Controls.Add(this.guna2Separator2);
            this.sidenav.Controls.Add(this.guna2Button1);
            this.sidenav.Controls.Add(this.btnlogin);
            this.sidenav.Controls.Add(this.pictureBox4);
            this.sidenav.Controls.Add(this.pictureBox3);
            this.sidenav.Controls.Add(this.pictureBox2);
            this.sidenav.Controls.Add(this.guna2Separator1);
            this.sidenav.Controls.Add(this.label2);
            this.sidenav.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.sidenav, "sidenav");
            this.sidenav.Name = "sidenav";
            // 
            // btndbs
            // 
            this.btndbs.Animated = true;
            this.btndbs.BackColor = System.Drawing.Color.Transparent;
            this.btndbs.BorderColor = System.Drawing.Color.Transparent;
            this.btndbs.BorderRadius = 10;
            this.btndbs.CheckedState.Parent = this.btndbs;
            this.btndbs.CustomImages.Parent = this.btndbs;
            this.btndbs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btndbs, "btndbs");
            this.btndbs.ForeColor = System.Drawing.Color.White;
            this.btndbs.HoverState.Parent = this.btndbs;
            this.btndbs.Image = ((System.Drawing.Image)(resources.GetObject("btndbs.Image")));
            this.btndbs.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btndbs.ImageSize = new System.Drawing.Size(28, 28);
            this.btndbs.Name = "btndbs";
            this.btndbs.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btndbs.ShadowDecoration.Parent = this.btndbs;
            this.btndbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndbs.TextOffset = new System.Drawing.Point(30, 0);
            this.btndbs.Click += new System.EventHandler(this.btndbs_Click);
            // 
            // btnsftp
            // 
            this.btnsftp.Animated = true;
            this.btnsftp.BackColor = System.Drawing.Color.Transparent;
            this.btnsftp.BorderColor = System.Drawing.Color.Transparent;
            this.btnsftp.BorderRadius = 10;
            this.btnsftp.CheckedState.Parent = this.btnsftp;
            this.btnsftp.CustomImages.Parent = this.btnsftp;
            this.btnsftp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btnsftp, "btnsftp");
            this.btnsftp.ForeColor = System.Drawing.Color.White;
            this.btnsftp.HoverState.Parent = this.btnsftp;
            this.btnsftp.Image = ((System.Drawing.Image)(resources.GetObject("btnsftp.Image")));
            this.btnsftp.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnsftp.ImageSize = new System.Drawing.Size(28, 28);
            this.btnsftp.Name = "btnsftp";
            this.btnsftp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsftp.ShadowDecoration.Parent = this.btnsftp;
            this.btnsftp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsftp.TextOffset = new System.Drawing.Point(30, 0);
            this.btnsftp.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnconsole
            // 
            this.btnconsole.Animated = true;
            this.btnconsole.BackColor = System.Drawing.Color.Transparent;
            this.btnconsole.BorderColor = System.Drawing.Color.Transparent;
            this.btnconsole.BorderRadius = 10;
            this.btnconsole.CheckedState.Parent = this.btnconsole;
            this.btnconsole.CustomImages.Parent = this.btnconsole;
            this.btnconsole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            resources.ApplyResources(this.btnconsole, "btnconsole");
            this.btnconsole.ForeColor = System.Drawing.Color.White;
            this.btnconsole.HoverState.Parent = this.btnconsole;
            this.btnconsole.Image = ((System.Drawing.Image)(resources.GetObject("btnconsole.Image")));
            this.btnconsole.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnconsole.ImageSize = new System.Drawing.Size(28, 28);
            this.btnconsole.Name = "btnconsole";
            this.btnconsole.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnconsole.ShadowDecoration.Parent = this.btnconsole;
            this.btnconsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsole.TextOffset = new System.Drawing.Point(30, 0);
            this.btnconsole.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Separator2
            // 
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-75, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(30, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderRadius = 10;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnlogin.ImageSize = new System.Drawing.Size(28, 28);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.TextOffset = new System.Drawing.Point(30, 0);
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.navbar;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2Button2, resources.GetString("guna2Button2.ToolTip"));
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataTable, "dataTable");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.dataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTable.ThemeStyle.HeaderStyle.Height = 25;
            this.dataTable.ThemeStyle.ReadOnly = true;
            this.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.dataTable.ThemeStyle.RowsStyle.Height = 22;
            this.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            this.dataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTable_CellMouseClick);
            // 
            // Pages
            // 
            resources.ApplyResources(this.Pages, "Pages");
            this.Pages.AllowTransitions = false;
            this.Pages.Controls.Add(this.pageConsole);
            this.Pages.Controls.Add(this.PageDB);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.PageDB;
            this.Pages.PageIndex = 1;
            this.Pages.PageName = "PageDB";
            this.Pages.PageTitle = "Database";
            this.Pages.SelectedIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Pages.Transition = animation1;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // PageDB
            // 
            this.PageDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.PageDB.Controls.Add(this.guna2Button2);
            this.PageDB.Controls.Add(this.dataTable);
            resources.ApplyResources(this.PageDB, "PageDB");
            this.PageDB.Name = "PageDB";
            // 
            // pageConsole
            // 
            this.pageConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.pageConsole.Controls.Add(this.pnlsvinfo);
            this.pageConsole.Controls.Add(this.pnlconsole);
            this.pageConsole.Controls.Add(this.pcsvimg);
            this.pageConsole.Controls.Add(this.pnlsvlimits);
            resources.ApplyResources(this.pageConsole, "pageConsole");
            this.pageConsole.Name = "pageConsole";
            // 
            // pnlsvlimits
            // 
            this.pnlsvlimits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.pnlsvlimits.Controls.Add(this.lbldisk);
            this.pnlsvlimits.Controls.Add(this.lblcpu);
            this.pnlsvlimits.Controls.Add(this.lblram);
            this.pnlsvlimits.Controls.Add(this.lblsvlimit);
            resources.ApplyResources(this.pnlsvlimits, "pnlsvlimits");
            this.pnlsvlimits.Name = "pnlsvlimits";
            // 
            // lblsvlimit
            // 
            resources.ApplyResources(this.lblsvlimit, "lblsvlimit");
            this.lblsvlimit.Name = "lblsvlimit";
            // 
            // lblram
            // 
            resources.ApplyResources(this.lblram, "lblram");
            this.lblram.Name = "lblram";
            // 
            // lblcpu
            // 
            resources.ApplyResources(this.lblcpu, "lblcpu");
            this.lblcpu.Name = "lblcpu";
            // 
            // lbldisk
            // 
            resources.ApplyResources(this.lbldisk, "lbldisk");
            this.lbldisk.Name = "lbldisk";
            // 
            // pcsvimg
            // 
            resources.ApplyResources(this.pcsvimg, "pcsvimg");
            this.pcsvimg.Name = "pcsvimg";
            this.pcsvimg.TabStop = false;
            // 
            // pnlconsole
            // 
            this.pnlconsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.pnlconsole.Controls.Add(this.consoleTextBox);
            this.pnlconsole.Controls.Add(this.psvkill);
            this.pnlconsole.Controls.Add(this.svshutdown);
            this.pnlconsole.Controls.Add(this.btnsend);
            this.pnlconsole.Controls.Add(this.svrestart);
            this.pnlconsole.Controls.Add(this.commandTextBox);
            this.pnlconsole.Controls.Add(this.svstart);
            resources.ApplyResources(this.pnlconsole, "pnlconsole");
            this.pnlconsole.Name = "pnlconsole";
            this.pnlconsole.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // svstart
            // 
            resources.ApplyResources(this.svstart, "svstart");
            this.svstart.Name = "svstart";
            this.svstart.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svstart, resources.GetString("svstart.ToolTip"));
            this.svstart.Click += new System.EventHandler(this.svstart_Click);
            // 
            // commandTextBox
            // 
            this.commandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.commandTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.commandTextBox.BorderRadius = 12;
            this.commandTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commandTextBox.DefaultText = "";
            this.commandTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commandTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commandTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandTextBox.DisabledState.Parent = this.commandTextBox;
            this.commandTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.commandTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commandTextBox.FocusedState.Parent = this.commandTextBox;
            this.commandTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.commandTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commandTextBox.HoverState.Parent = this.commandTextBox;
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.PasswordChar = '\0';
            this.commandTextBox.PlaceholderText = "";
            this.commandTextBox.SelectedText = "";
            this.commandTextBox.ShadowDecoration.Parent = this.commandTextBox;
            // 
            // svrestart
            // 
            resources.ApplyResources(this.svrestart, "svrestart");
            this.svrestart.Name = "svrestart";
            this.svrestart.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svrestart, resources.GetString("svrestart.ToolTip"));
            this.svrestart.Click += new System.EventHandler(this.svrestart_Click);
            // 
            // btnsend
            // 
            this.btnsend.Animated = true;
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.btnsend.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderRadius = 10;
            this.btnsend.CheckedState.Parent = this.btnsend;
            this.btnsend.CustomImages.Parent = this.btnsend;
            this.btnsend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            resources.ApplyResources(this.btnsend, "btnsend");
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.HoverState.Parent = this.btnsend;
            this.btnsend.Name = "btnsend";
            this.btnsend.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsend.ShadowDecoration.Parent = this.btnsend;
            this.guna2HtmlToolTip1.SetToolTip(this.btnsend, resources.GetString("btnsend.ToolTip"));
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // svshutdown
            // 
            resources.ApplyResources(this.svshutdown, "svshutdown");
            this.svshutdown.Name = "svshutdown";
            this.svshutdown.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svshutdown, resources.GetString("svshutdown.ToolTip"));
            this.svshutdown.Click += new System.EventHandler(this.svshutdown_Click);
            // 
            // psvkill
            // 
            resources.ApplyResources(this.psvkill, "psvkill");
            this.psvkill.Name = "psvkill";
            this.psvkill.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.psvkill, resources.GetString("psvkill.ToolTip"));
            this.psvkill.Click += new System.EventHandler(this.svkill_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this.consoleTextBox, "consoleTextBox");
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            // 
            // pnlsvinfo
            // 
            this.pnlsvinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.pnlsvinfo.Controls.Add(this.lblsvinfo);
            this.pnlsvinfo.Controls.Add(this.svname);
            this.pnlsvinfo.Controls.Add(this.lblsvip);
            this.pnlsvinfo.Controls.Add(this.svnode);
            resources.ApplyResources(this.pnlsvinfo, "pnlsvinfo");
            this.pnlsvinfo.Name = "pnlsvinfo";
            // 
            // svnode
            // 
            resources.ApplyResources(this.svnode, "svnode");
            this.svnode.Name = "svnode";
            // 
            // lblsvip
            // 
            resources.ApplyResources(this.lblsvip, "lblsvip");
            this.lblsvip.Name = "lblsvip";
            // 
            // svname
            // 
            resources.ApplyResources(this.svname, "svname");
            this.svname.Name = "svname";
            // 
            // lblsvinfo
            // 
            resources.ApplyResources(this.lblsvinfo, "lblsvinfo");
            this.lblsvinfo.Name = "lblsvinfo";
            // 
            // guna2VSeparator1
            // 
            resources.ApplyResources(this.guna2VSeparator1, "guna2VSeparator1");
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            // 
            // FrmServerController
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServerController";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.sidenav.ResumeLayout(false);
            this.sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.Pages.ResumeLayout(false);
            this.PageDB.ResumeLayout(false);
            this.pageConsole.ResumeLayout(false);
            this.pnlsvlimits.ResumeLayout(false);
            this.pnlsvlimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcsvimg)).EndInit();
            this.pnlconsole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svshutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psvkill)).EndInit();
            this.pnlsvinfo.ResumeLayout(false);
            this.pnlsvinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label lblappname;
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Panel sidenav;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnconsole;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnsftp;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Button btndbs;
        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Bunifu.UI.WinForms.BunifuPages Pages;
        private System.Windows.Forms.TabPage pageConsole;
        private System.Windows.Forms.Panel pnlsvinfo;
        private System.Windows.Forms.Label lblsvinfo;
        private System.Windows.Forms.Label svname;
        private System.Windows.Forms.Label lblsvip;
        private System.Windows.Forms.Label svnode;
        private System.Windows.Forms.Panel pnlconsole;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.PictureBox psvkill;
        private System.Windows.Forms.PictureBox svshutdown;
        private Guna.UI2.WinForms.Guna2Button btnsend;
        private System.Windows.Forms.PictureBox svrestart;
        private Guna.UI2.WinForms.Guna2TextBox commandTextBox;
        private System.Windows.Forms.PictureBox svstart;
        private System.Windows.Forms.PictureBox pcsvimg;
        private System.Windows.Forms.Panel pnlsvlimits;
        private System.Windows.Forms.Label lbldisk;
        private System.Windows.Forms.Label lblcpu;
        private System.Windows.Forms.Label lblram;
        private System.Windows.Forms.Label lblsvlimit;
        private System.Windows.Forms.TabPage PageDB;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}

