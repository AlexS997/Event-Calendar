namespace EventCalendar
{
    partial class MainPage
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.splitContainer = new Wisej.Web.SplitContainer();
            this.sbNew = new Wisej.Web.SplitButton();
            this.pAcMenu = new Wisej.Web.Panel();
            this.monthCalendar = new Wisej.Web.MonthCalendar();
            this.button1 = new Wisej.Web.Button();
            this.button = new Wisej.Web.Button();
            this.fullCalendar1 = new Wisej.Web.Ext.FullCalendar.FullCalendar();
            this.pLegend = new Wisej.Web.Panel();
            this.cboCalType = new Wisej.Web.ComboBox();
            this.flpLegenda = new Wisej.Web.FlowLayoutPanel();
            this.label = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.label8 = new Wisej.Web.Label();
            this.label9 = new Wisej.Web.Label();
            this.label10 = new Wisej.Web.Label();
            this.label11 = new Wisej.Web.Label();
            this.label12 = new Wisej.Web.Label();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.btnAggiorna = new Wisej.Web.Button();
            this.menuBar = new Wisej.Web.MenuBar();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.mnuImpostazioni = new Wisej.Web.MenuItem();
            this.mnuVoip = new Wisej.Web.MenuItem();
            this.mnuClienti = new Wisej.Web.MenuItem();
            this.mnuRicerca = new Wisej.Web.MenuItem();
            this.mnuRisolti = new Wisej.Web.MenuItem();
            this.pUser = new Wisej.Web.Panel();
            this.pbAvatar = new Wisej.Web.PictureBox();
            this.lblUsername = new Wisej.Web.Label();
            this.pLogo = new Wisej.Web.Panel();
            this.pbLogo = new Wisej.Web.PictureBox();
            this.btnSospesi = new Wisej.Web.Button();
            this.btnLegenda = new Wisej.Web.Button();
            this.cboDipendenti = new Wisej.Web.ComboBox();
            this.bsDipendenti = new Wisej.Web.BindingSource(this.components);
            this.btnDisdetta = new Wisej.Web.Button();
            this.btnChiamate = new Wisej.Web.Button();
            this.btnLogout = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pAcMenu.SuspendLayout();
            this.pLegend.SuspendLayout();
            this.flpLegenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDipendenti)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromName("@light");
            this.splitContainer.Panel1.Controls.Add(this.sbNew);
            this.splitContainer.Panel1.Controls.Add(this.pAcMenu);
            this.splitContainer.Panel1.Controls.Add(this.button1);
            this.splitContainer.Panel1.Controls.Add(this.button);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.fullCalendar1);
            this.splitContainer.Panel2.Controls.Add(this.pLegend);
            this.splitContainer.Size = new System.Drawing.Size(1948, 690);
            this.splitContainer.SplitterDistance = 347;
            this.splitContainer.TabIndex = 0;
            // 
            // sbNew
            // 
            this.sbNew.Anchor = Wisej.Web.AnchorStyles.Top;
            this.sbNew.BackColor = System.Drawing.Color.FromName("@table-row-background-focused-selected");
            this.sbNew.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sbNew.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.sbNew.Location = new System.Drawing.Point(117, 606);
            this.sbNew.Name = "sbNew";
            this.sbNew.Size = new System.Drawing.Size(100, 37);
            this.sbNew.TabIndex = 6;
            this.sbNew.Text = "New";
            this.sbNew.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.sbNew_ItemClicked);
            // 
            // pAcMenu
            // 
            this.pAcMenu.Controls.Add(this.monthCalendar);
            this.pAcMenu.Dock = Wisej.Web.DockStyle.Top;
            this.pAcMenu.Location = new System.Drawing.Point(0, 0);
            this.pAcMenu.Name = "pAcMenu";
            this.pAcMenu.Size = new System.Drawing.Size(345, 509);
            this.pAcMenu.TabIndex = 5;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = Wisej.Web.DockStyle.Fill;
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.Margin = new Wisej.Web.Padding(0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(345, 509);
            this.monthCalendar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromName("@table-row-background-focused-selected");
            this.button1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.button1.Location = new System.Drawing.Point(14, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prev";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button
            // 
            this.button.Anchor = Wisej.Web.AnchorStyles.Top;
            this.button.BackColor = System.Drawing.Color.FromName("@table-row-background-focused-selected");
            this.button.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.button.Location = new System.Drawing.Point(227, 515);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 37);
            this.button.TabIndex = 1;
            this.button.Text = "Next";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // fullCalendar1
            // 
            this.fullCalendar1.AllDayText = " ";
            this.fullCalendar1.Dock = Wisej.Web.DockStyle.Fill;
            this.fullCalendar1.FirstDayOfWeek = Wisej.Web.Day.Monday;
            this.fullCalendar1.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fullCalendar1.Location = new System.Drawing.Point(0, 69);
            this.fullCalendar1.MaxTime = System.TimeSpan.Parse("18:30:00");
            this.fullCalendar1.Name = "fullCalendar1";
            this.fullCalendar1.NextDayThreshold = System.TimeSpan.Parse("08:30:00");
            this.fullCalendar1.ResourceAreaWidth = "40%";
            this.fullCalendar1.SchedulerLicenseKey = "CC-Attribution-NonCommercial-NoDerivatives";
            this.fullCalendar1.ScrollTime = System.TimeSpan.Parse("08:30:00");
            this.fullCalendar1.ShowEventToolTips = true;
            this.fullCalendar1.Size = new System.Drawing.Size(1596, 619);
            this.fullCalendar1.SlotDuration = System.TimeSpan.Parse("00:15:00");
            this.fullCalendar1.SlotLabelFormat = "kk:mm";
            this.fullCalendar1.SlotLabelInterval = System.TimeSpan.Parse("00:30:00");
            this.fullCalendar1.TabIndex = 0;
            this.fullCalendar1.Text = "fullCalendar1";
            this.fullCalendar1.TimeFormat = "kk:mm";
            this.fullCalendar1.View = Wisej.Web.Ext.FullCalendar.ViewType.ListWeek;
            this.fullCalendar1.EventClick += new Wisej.Web.Ext.FullCalendar.EventClickEventHandler(this.fullCalendar1_EventClick);
            this.fullCalendar1.EventDoubleClick += new Wisej.Web.Ext.FullCalendar.EventClickEventHandler(this.fullCalendar1_EventDoubleClick);
            // 
            // pLegend
            // 
            this.pLegend.Controls.Add(this.cboCalType);
            this.pLegend.Controls.Add(this.flpLegenda);
            this.pLegend.Dock = Wisej.Web.DockStyle.Top;
            this.pLegend.Location = new System.Drawing.Point(0, 0);
            this.pLegend.Name = "pLegend";
            this.pLegend.Size = new System.Drawing.Size(1596, 69);
            this.pLegend.TabIndex = 1;
            // 
            // cboCalType
            // 
            this.cboCalType.Anchor = Wisej.Web.AnchorStyles.Right;
            this.cboCalType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboCalType.Items.AddRange(new object[] {
            "Agenda Week",
            "Basic Week",
            "List Week",
            "Timeline Week"});
            this.cboCalType.Location = new System.Drawing.Point(1406, 20);
            this.cboCalType.Name = "cboCalType";
            this.cboCalType.Size = new System.Drawing.Size(176, 30);
            this.cboCalType.TabIndex = 1;
            this.cboCalType.Watermark = "Calendar style";
            this.cboCalType.SelectedIndexChanged += new System.EventHandler(this.cboCalType_SelectedIndexChanged);
            // 
            // flpLegenda
            // 
            this.flpLegenda.Controls.Add(this.label);
            this.flpLegenda.Controls.Add(this.label1);
            this.flpLegenda.Controls.Add(this.label2);
            this.flpLegenda.Controls.Add(this.label3);
            this.flpLegenda.Controls.Add(this.label4);
            this.flpLegenda.Controls.Add(this.label5);
            this.flpLegenda.Controls.Add(this.label6);
            this.flpLegenda.Controls.Add(this.label7);
            this.flpLegenda.Controls.Add(this.label8);
            this.flpLegenda.Controls.Add(this.label9);
            this.flpLegenda.Controls.Add(this.label10);
            this.flpLegenda.Controls.Add(this.label11);
            this.flpLegenda.Controls.Add(this.label12);
            this.flpLegenda.Location = new System.Drawing.Point(8, 8);
            this.flpLegenda.Name = "flpLegenda";
            this.flpLegenda.Size = new System.Drawing.Size(612, 55);
            this.flpLegenda.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 18);
            this.label.TabIndex = 1;
            this.label.Text = "Legenda Stato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromName("@table-row-background-focused-selected");
            this.label1.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.label1.Location = new System.Drawing.Point(105, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "aperto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.label2.Location = new System.Drawing.Point(153, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "eseguito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromName("@success");
            this.label3.Location = new System.Drawing.Point(213, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "chiuso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromName("@invalid");
            this.label4.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.label4.Location = new System.Drawing.Point(261, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "annullato";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(325, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "ferie / malattia / altro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(458, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "intervento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Legenda Tipologia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "(S) sopralluogo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "(I) installazione";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "(N) intervento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "(F) ferie/malattia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "(A) altro";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.splitContainer1.Panel1.Controls.Add(this.btnAggiorna);
            this.splitContainer1.Panel1.Controls.Add(this.menuBar);
            this.splitContainer1.Panel1.Controls.Add(this.pUser);
            this.splitContainer1.Panel1.Controls.Add(this.pLogo);
            this.splitContainer1.Panel1.Controls.Add(this.btnSospesi);
            this.splitContainer1.Panel1.Controls.Add(this.btnLegenda);
            this.splitContainer1.Panel1.Controls.Add(this.cboDipendenti);
            this.splitContainer1.Panel1.Controls.Add(this.btnDisdetta);
            this.splitContainer1.Panel1.Controls.Add(this.btnChiamate);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer);
            this.splitContainer1.Size = new System.Drawing.Size(1948, 771);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnAggiorna.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnAggiorna.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAggiorna.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnAggiorna.ImageSource = "icon-refresh";
            this.btnAggiorna.Location = new System.Drawing.Point(1385, 20);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(37, 35);
            this.btnAggiorna.TabIndex = 12;
            this.btnAggiorna.ToolTipText = "Aggiorna il contenuto del Planning";
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // menuBar
            // 
            this.menuBar.Anchor = Wisej.Web.AnchorStyles.Right;
            this.menuBar.Location = new System.Drawing.Point(1432, 17);
            this.menuBar.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1});
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(70, 40);
            this.menuBar.TabIndex = 11;
            this.menuBar.TabStop = false;
            // 
            // menuItem1
            // 
            this.menuItem1.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.mnuImpostazioni,
            this.mnuVoip,
            this.mnuClienti,
            this.mnuRicerca,
            this.mnuRisolti});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "Menu";
            // 
            // mnuImpostazioni
            // 
            this.mnuImpostazioni.Index = 0;
            this.mnuImpostazioni.Name = "mnuImpostazioni";
            this.mnuImpostazioni.Text = "Impostazioni";
            this.mnuImpostazioni.Click += new System.EventHandler(this.mnuImpostazioni_Click);
            // 
            // mnuVoip
            // 
            this.mnuVoip.Index = 1;
            this.mnuVoip.Name = "mnuVoip";
            this.mnuVoip.Text = "VoIP";
            this.mnuVoip.Click += new System.EventHandler(this.mnuVoip_Click);
            // 
            // mnuClienti
            // 
            this.mnuClienti.Index = 2;
            this.mnuClienti.Name = "mnuClienti";
            this.mnuClienti.Text = "Clienti";
            this.mnuClienti.Click += new System.EventHandler(this.mnuClienti_Click);
            // 
            // mnuRicerca
            // 
            this.mnuRicerca.Index = 3;
            this.mnuRicerca.Name = "mnuRicerca";
            this.mnuRicerca.Text = "Ricerca";
            this.mnuRicerca.Click += new System.EventHandler(this.mnuRicerca_Click);
            // 
            // mnuRisolti
            // 
            this.mnuRisolti.Index = 4;
            this.mnuRisolti.Name = "mnuRisolti";
            this.mnuRisolti.Text = "Risolti";
            this.mnuRisolti.Click += new System.EventHandler(this.mnuRisolti_Click);
            // 
            // pUser
            // 
            this.pUser.Anchor = Wisej.Web.AnchorStyles.Left;
            this.pUser.Controls.Add(this.pbAvatar);
            this.pUser.Controls.Add(this.lblUsername);
            this.pUser.Location = new System.Drawing.Point(209, 0);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(337, 76);
            this.pUser.TabIndex = 10;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = Wisej.Web.AnchorStyles.Left;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(19, 14);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(44, 46);
            this.pbAvatar.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblUsername.Font = new System.Drawing.Font("defaultBold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(72, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(262, 26);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "t";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.pLogo.Controls.Add(this.pbLogo);
            this.pLogo.Dock = Wisej.Web.DockStyle.Left;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(207, 76);
            this.pLogo.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = Wisej.Web.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(207, 76);
            this.pbLogo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // btnSospesi
            // 
            this.btnSospesi.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnSospesi.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnSospesi.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSospesi.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnSospesi.Location = new System.Drawing.Point(1779, 14);
            this.btnSospesi.Name = "btnSospesi";
            this.btnSospesi.Size = new System.Drawing.Size(91, 46);
            this.btnSospesi.TabIndex = 8;
            this.btnSospesi.Text = "Sospesi";
            this.btnSospesi.ToolTipText = "Mostra elenco Sospesi";
            this.btnSospesi.Click += new System.EventHandler(this.btnSospesi_Click);
            // 
            // btnLegenda
            // 
            this.btnLegenda.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnLegenda.BackColor = System.Drawing.Color.FromName("@success");
            this.btnLegenda.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.btnLegenda.ImageSource = "icon-paste";
            this.btnLegenda.Location = new System.Drawing.Point(1511, 14);
            this.btnLegenda.Name = "btnLegenda";
            this.btnLegenda.Size = new System.Drawing.Size(52, 46);
            this.btnLegenda.TabIndex = 7;
            this.btnLegenda.ToolTipText = "Info Legenda";
            this.btnLegenda.Click += new System.EventHandler(this.btnLegenda_Click);
            // 
            // cboDipendenti
            // 
            this.cboDipendenti.Anchor = Wisej.Web.AnchorStyles.Right;
            this.cboDipendenti.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsDipendenti, "Text", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboDipendenti.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboDipendenti.Location = new System.Drawing.Point(1154, 23);
            this.cboDipendenti.Name = "cboDipendenti";
            this.cboDipendenti.Size = new System.Drawing.Size(218, 30);
            this.cboDipendenti.TabIndex = 3;
            this.cboDipendenti.Watermark = "Tutti i dipendenti";
            this.cboDipendenti.SelectedItemChanged += new System.EventHandler(this.cboDipendenti_SelectedItemChanged);
            // 
            // bsDipendenti
            // 
            this.bsDipendenti.DataSource = typeof(EventCalendar.TableClass.TableTasks);
            // 
            // btnDisdetta
            // 
            this.btnDisdetta.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnDisdetta.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnDisdetta.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDisdetta.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnDisdetta.Location = new System.Drawing.Point(1676, 14);
            this.btnDisdetta.Name = "btnDisdetta";
            this.btnDisdetta.Size = new System.Drawing.Size(91, 46);
            this.btnDisdetta.TabIndex = 2;
            this.btnDisdetta.Text = "Disdetta";
            this.btnDisdetta.ToolTipText = "Mostra elenco Disdetta";
            this.btnDisdetta.Click += new System.EventHandler(this.btnDisdetta_Click);
            // 
            // btnChiamate
            // 
            this.btnChiamate.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnChiamate.BackColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnChiamate.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnChiamate.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnChiamate.Location = new System.Drawing.Point(1573, 14);
            this.btnChiamate.Name = "btnChiamate";
            this.btnChiamate.Size = new System.Drawing.Size(91, 46);
            this.btnChiamate.TabIndex = 1;
            this.btnChiamate.Text = "Chiamate";
            this.btnChiamate.ToolTipText = "Mostra elenco Chiamate";
            this.btnChiamate.Click += new System.EventHandler(this.btnChiamate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnLogout.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.btnLogout.ImageSource = "icon-exit";
            this.btnLogout.Location = new System.Drawing.Point(1880, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 46);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.ToolTipText = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1948, 771);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Tag = "Planning";
            this.Text = "Window1";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pAcMenu.ResumeLayout(false);
            this.pLegend.ResumeLayout(false);
            this.pLegend.PerformLayout();
            this.flpLegenda.ResumeLayout(false);
            this.flpLegenda.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDipendenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer;
        private Wisej.Web.MonthCalendar monthCalendar;
        private Wisej.Web.Ext.FullCalendar.FullCalendar fullCalendar1;
        private Wisej.Web.Button button;
        private Wisej.Web.Button button1;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Button btnLogout;
        private Wisej.Web.Button btnChiamate;
        private Wisej.Web.Button btnDisdetta;
        private Wisej.Web.ComboBox cboDipendenti;
        private Wisej.Web.BindingSource bsDipendenti;
        private Wisej.Web.Label lblUsername;
        private Wisej.Web.Panel pLegend;
        private Wisej.Web.Button btnLegenda;
        private Wisej.Web.FlowLayoutPanel flpLegenda;
        private Wisej.Web.Label label;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label6;
        private Wisej.Web.Label label7;
        private Wisej.Web.Label label8;
        private Wisej.Web.Label label9;
        private Wisej.Web.Label label10;
        private Wisej.Web.Label label11;
        private Wisej.Web.Label label12;
        private Wisej.Web.Button btnSospesi;
        private Wisej.Web.Panel pLogo;
        private Wisej.Web.PictureBox pbLogo;
        private Wisej.Web.Panel pUser;
        private Wisej.Web.PictureBox pbAvatar;
        private Wisej.Web.Panel pAcMenu;
        private Wisej.Web.MenuBar menuBar;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem mnuImpostazioni;
        private Wisej.Web.MenuItem mnuVoip;
        private Wisej.Web.MenuItem mnuClienti;
        private Wisej.Web.MenuItem mnuRicerca;
        private Wisej.Web.SplitButton sbNew;
        private Wisej.Web.MenuItem mnuRisolti;
        private Wisej.Web.Button btnAggiorna;
        private Wisej.Web.ComboBox cboCalType;
    }
}

