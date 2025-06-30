namespace EventCalendar
{
    partial class vImpostazioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vImpostazioni));
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.btnLogout = new Wisej.Web.Button();
            this.menuBar = new Wisej.Web.MenuBar();
            this.mnuPlanning = new Wisej.Web.MenuItem();
            this.mnuVoIP = new Wisej.Web.MenuItem();
            this.pUser = new Wisej.Web.Panel();
            this.pbAvatar = new Wisej.Web.PictureBox();
            this.lblUsername = new Wisej.Web.Label();
            this.pLogo = new Wisej.Web.Panel();
            this.pbLogo = new Wisej.Web.PictureBox();
            this.flp = new Wisej.Web.FlowLayoutPanel();
            this.btnImpBase = new Wisej.Web.Button();
            this.btnAddUser = new Wisej.Web.Button();
            this.btnAutomezzi = new Wisej.Web.Button();
            this.btnClienti = new Wisej.Web.Button();
            this.btnImpClienti = new Wisej.Web.Button();
            this.btnCancellazione = new Wisej.Web.Button();
            this.lblImpBase = new Wisej.Web.Label();
            this.lblUsers = new Wisej.Web.Label();
            this.lblAutomezzi = new Wisej.Web.Label();
            this.lblClienti = new Wisej.Web.Label();
            this.lblImpClienti = new Wisej.Web.Label();
            this.lblCancellazione = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.flp.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.menuBar);
            this.splitContainer1.Panel1.Controls.Add(this.pUser);
            this.splitContainer1.Panel1.Controls.Add(this.pLogo);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flp);
            this.splitContainer1.Size = new System.Drawing.Size(1664, 662);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = Wisej.Web.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnLogout.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.btnLogout.ImageSource = "icon-exit";
            this.btnLogout.Location = new System.Drawing.Point(1592, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 46);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.ToolTipText = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuBar
            // 
            this.menuBar.Anchor = Wisej.Web.AnchorStyles.Right;
            this.menuBar.Location = new System.Drawing.Point(1430, 9);
            this.menuBar.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.mnuPlanning,
            this.mnuVoIP});
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(150, 40);
            this.menuBar.TabIndex = 13;
            this.menuBar.TabStop = false;
            // 
            // mnuPlanning
            // 
            this.mnuPlanning.Index = 0;
            this.mnuPlanning.Name = "mnuPlanning";
            this.mnuPlanning.Text = "Planning";
            this.mnuPlanning.Click += new System.EventHandler(this.mnuPlanning_Click);
            // 
            // mnuVoIP
            // 
            this.mnuVoIP.Index = 1;
            this.mnuVoIP.Name = "mnuVoIP";
            this.mnuVoIP.Text = "VoIP";
            this.mnuVoIP.Click += new System.EventHandler(this.mnuVoIP_Click);
            // 
            // pUser
            // 
            this.pUser.Anchor = Wisej.Web.AnchorStyles.Left;
            this.pUser.Controls.Add(this.pbAvatar);
            this.pUser.Controls.Add(this.lblUsername);
            this.pUser.Location = new System.Drawing.Point(209, -9);
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
            this.pLogo.Size = new System.Drawing.Size(207, 59);
            this.pLogo.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = Wisej.Web.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(207, 59);
            this.pbLogo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // flp
            // 
            this.flp.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flp.Controls.Add(this.btnImpBase);
            this.flp.Controls.Add(this.btnAddUser);
            this.flp.Controls.Add(this.btnAutomezzi);
            this.flp.Controls.Add(this.lblImpBase);
            this.flp.Controls.Add(this.lblUsers);
            this.flp.Controls.Add(this.lblAutomezzi);
            this.flp.Controls.Add(this.btnClienti);
            this.flp.Controls.Add(this.btnImpClienti);
            this.flp.Controls.Add(this.btnCancellazione);
            this.flp.Controls.Add(this.lblClienti);
            this.flp.Controls.Add(this.lblImpClienti);
            this.flp.Controls.Add(this.lblCancellazione);
            this.flp.Location = new System.Drawing.Point(514, 28);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(746, 566);
            this.flp.TabIndex = 0;
            // 
            // btnImpBase
            // 
            this.btnImpBase.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnImpBase.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnImpBase.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImpBase.ImageSource = "Resources\\process.png";
            this.btnImpBase.Location = new System.Drawing.Point(3, 3);
            this.btnImpBase.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.btnImpBase.Name = "btnImpBase";
            this.btnImpBase.Padding = new Wisej.Web.Padding(30);
            this.btnImpBase.Size = new System.Drawing.Size(220, 210);
            this.btnImpBase.TabIndex = 0;
            this.btnImpBase.Tag = "";
            this.btnImpBase.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnImpBase.ToolTipText = "Impostazioni Base";
            this.btnImpBase.Click += new System.EventHandler(this.btnImpBase_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnAddUser.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.ImageSource = "Resources\\profile.png";
            this.btnAddUser.Location = new System.Drawing.Point(256, 3);
            this.btnAddUser.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new Wisej.Web.Padding(30);
            this.btnAddUser.Size = new System.Drawing.Size(220, 210);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnAddUser.ToolTipText = "Impostazioni Dipendenti";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAutomezzi
            // 
            this.btnAutomezzi.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnAutomezzi.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAutomezzi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutomezzi.ImageSource = "Resources\\car.png";
            this.btnAutomezzi.Location = new System.Drawing.Point(509, 3);
            this.btnAutomezzi.Name = "btnAutomezzi";
            this.btnAutomezzi.Padding = new Wisej.Web.Padding(30);
            this.btnAutomezzi.Size = new System.Drawing.Size(220, 210);
            this.btnAutomezzi.TabIndex = 2;
            this.btnAutomezzi.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnAutomezzi.ToolTipText = "Impostazioni Automezzi";
            this.btnAutomezzi.Click += new System.EventHandler(this.btnAutomezzi_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.AllowHtml = true;
            this.btnClienti.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnClienti.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnClienti.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienti.ImageSource = "Resources\\customer.png";
            this.btnClienti.Location = new System.Drawing.Point(3, 296);
            this.btnClienti.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Padding = new Wisej.Web.Padding(30);
            this.btnClienti.Size = new System.Drawing.Size(220, 210);
            this.btnClienti.TabIndex = 3;
            this.btnClienti.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnClienti.ToolTipText = "Clienti";
            // 
            // btnImpClienti
            // 
            this.btnImpClienti.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnImpClienti.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnImpClienti.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImpClienti.ImageSource = "Resources\\impClienti.png";
            this.btnImpClienti.Location = new System.Drawing.Point(256, 296);
            this.btnImpClienti.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.btnImpClienti.Name = "btnImpClienti";
            this.btnImpClienti.Padding = new Wisej.Web.Padding(30);
            this.btnImpClienti.Size = new System.Drawing.Size(220, 210);
            this.btnImpClienti.TabIndex = 4;
            this.btnImpClienti.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // btnCancellazione
            // 
            this.btnCancellazione.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnCancellazione.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancellazione.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancellazione.ImageSource = "Resources\\dustbin.png";
            this.btnCancellazione.Location = new System.Drawing.Point(509, 296);
            this.btnCancellazione.Name = "btnCancellazione";
            this.btnCancellazione.Padding = new Wisej.Web.Padding(30);
            this.btnCancellazione.Size = new System.Drawing.Size(220, 210);
            this.btnCancellazione.TabIndex = 5;
            this.btnCancellazione.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // lblImpBase
            // 
            this.lblImpBase.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblImpBase.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblImpBase.Location = new System.Drawing.Point(3, 219);
            this.lblImpBase.Margin = new Wisej.Web.Padding(3, 3, 30, 30);
            this.lblImpBase.Name = "lblImpBase";
            this.lblImpBase.Size = new System.Drawing.Size(220, 44);
            this.lblImpBase.TabIndex = 6;
            this.lblImpBase.Text = "Impostazioni Base";
            this.lblImpBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsers
            // 
            this.lblUsers.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsers.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblUsers.Location = new System.Drawing.Point(256, 219);
            this.lblUsers.Margin = new Wisej.Web.Padding(3, 3, 30, 30);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(220, 44);
            this.lblUsers.TabIndex = 7;
            this.lblUsers.Text = "Users";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutomezzi
            // 
            this.lblAutomezzi.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAutomezzi.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblAutomezzi.Location = new System.Drawing.Point(509, 219);
            this.lblAutomezzi.Margin = new Wisej.Web.Padding(3, 3, 3, 30);
            this.lblAutomezzi.Name = "lblAutomezzi";
            this.lblAutomezzi.Size = new System.Drawing.Size(220, 44);
            this.lblAutomezzi.TabIndex = 8;
            this.lblAutomezzi.Text = "Automezzi";
            this.lblAutomezzi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClienti
            // 
            this.lblClienti.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblClienti.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblClienti.Location = new System.Drawing.Point(3, 512);
            this.lblClienti.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(220, 44);
            this.lblClienti.TabIndex = 9;
            this.lblClienti.Text = "Clienti";
            this.lblClienti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpClienti
            // 
            this.lblImpClienti.Font = new System.Drawing.Font("defaultBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblImpClienti.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblImpClienti.Location = new System.Drawing.Point(256, 512);
            this.lblImpClienti.Margin = new Wisej.Web.Padding(3, 3, 30, 3);
            this.lblImpClienti.Name = "lblImpClienti";
            this.lblImpClienti.Size = new System.Drawing.Size(220, 44);
            this.lblImpClienti.TabIndex = 10;
            this.lblImpClienti.Text = "Impostazioni Clienti";
            this.lblImpClienti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCancellazione
            // 
            this.lblCancellazione.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCancellazione.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblCancellazione.Location = new System.Drawing.Point(509, 512);
            this.lblCancellazione.Name = "lblCancellazione";
            this.lblCancellazione.Size = new System.Drawing.Size(220, 44);
            this.lblCancellazione.TabIndex = 11;
            this.lblCancellazione.Text = "Cancellazione";
            this.lblCancellazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vImpostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 662);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "vImpostazioni";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Tag = "Impostazioni";
            this.Text = "Impostazioni";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vImpostazioni_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Panel pUser;
        private Wisej.Web.PictureBox pbAvatar;
        private Wisej.Web.Label lblUsername;
        private Wisej.Web.Panel pLogo;
        private Wisej.Web.PictureBox pbLogo;
        private Wisej.Web.FlowLayoutPanel flp;
        private Wisej.Web.Button btnImpBase;
        private Wisej.Web.Button btnAddUser;
        private Wisej.Web.Button btnAutomezzi;
        private Wisej.Web.Button btnClienti;
        private Wisej.Web.Button btnImpClienti;
        private Wisej.Web.Button btnCancellazione;
        private Wisej.Web.MenuBar menuBar;
        private Wisej.Web.MenuItem mnuPlanning;
        private Wisej.Web.MenuItem mnuVoIP;
        private Wisej.Web.Button btnLogout;
        private Wisej.Web.Label lblImpBase;
        private Wisej.Web.Label lblUsers;
        private Wisej.Web.Label lblAutomezzi;
        private Wisej.Web.Label lblClienti;
        private Wisej.Web.Label lblImpClienti;
        private Wisej.Web.Label lblCancellazione;
    }
}