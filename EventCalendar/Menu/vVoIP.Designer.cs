namespace EventCalendar.Menu
{
    partial class vVoIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vVoIP));
            this.pLogo = new Wisej.Web.Panel();
            this.pbLogo = new Wisej.Web.PictureBox();
            this.pUser = new Wisej.Web.Panel();
            this.pbAvatar = new Wisej.Web.PictureBox();
            this.lblUsername = new Wisej.Web.Label();
            this.menuBar = new Wisej.Web.MenuBar();
            this.mnuPlanning = new Wisej.Web.MenuItem();
            this.mnuImpostazioni = new Wisej.Web.MenuItem();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.btnLogout = new Wisej.Web.Button();
            this.flp = new Wisej.Web.FlowLayoutPanel();
            this.btnAddClient = new Wisej.Web.Button();
            this.btnAddUser = new Wisej.Web.Button();
            this.btn2 = new Wisej.Web.Button();
            this.btn3 = new Wisej.Web.Button();
            this.btn4 = new Wisej.Web.Button();
            this.btn5 = new Wisej.Web.Button();
            this.lblImpBase = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flp.SuspendLayout();
            this.SuspendLayout();
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
            // menuBar
            // 
            this.menuBar.Anchor = Wisej.Web.AnchorStyles.Right;
            this.menuBar.Location = new System.Drawing.Point(1379, 9);
            this.menuBar.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.mnuPlanning,
            this.mnuImpostazioni});
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(200, 40);
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
            // mnuImpostazioni
            // 
            this.mnuImpostazioni.Index = 1;
            this.mnuImpostazioni.Name = "mnuImpostazioni";
            this.mnuImpostazioni.Text = "Impostazioni";
            this.mnuImpostazioni.Click += new System.EventHandler(this.mnuImpostazioni_Click);
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
            this.splitContainer1.TabIndex = 4;
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
            this.btnLogout.TabIndex = 15;
            this.btnLogout.ToolTipText = "Logout";
            // 
            // flp
            // 
            this.flp.Controls.Add(this.btnAddClient);
            this.flp.Controls.Add(this.btnAddUser);
            this.flp.Controls.Add(this.btn2);
            this.flp.Controls.Add(this.btn3);
            this.flp.Controls.Add(this.btn4);
            this.flp.Controls.Add(this.btn5);
            this.flp.Controls.Add(this.lblImpBase);
            this.flp.Controls.Add(this.label1);
            this.flp.Controls.Add(this.label2);
            this.flp.Controls.Add(this.label3);
            this.flp.Controls.Add(this.label4);
            this.flp.Controls.Add(this.label5);
            this.flp.Location = new System.Drawing.Point(46, 29);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1001, 212);
            this.flp.TabIndex = 1;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnAddClient.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddClient.ImageSource = "Resources\\add-client.png";
            this.btnAddClient.Location = new System.Drawing.Point(3, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new Wisej.Web.Padding(30);
            this.btnAddClient.Size = new System.Drawing.Size(159, 149);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btnAddUser.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.ImageSource = "icon-settings";
            this.btnAddUser.Location = new System.Drawing.Point(168, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new Wisej.Web.Padding(30);
            this.btnAddUser.Size = new System.Drawing.Size(159, 149);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btn2.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn2.ImageSource = "icon-settings";
            this.btn2.Location = new System.Drawing.Point(333, 3);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new Wisej.Web.Padding(30);
            this.btn2.Size = new System.Drawing.Size(159, 149);
            this.btn2.TabIndex = 2;
            this.btn2.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btn3.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn3.ImageSource = "icon-settings";
            this.btn3.Location = new System.Drawing.Point(498, 3);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new Wisej.Web.Padding(30);
            this.btn3.Size = new System.Drawing.Size(159, 149);
            this.btn3.TabIndex = 3;
            this.btn3.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btn4.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn4.ImageSource = "icon-settings";
            this.btn4.Location = new System.Drawing.Point(663, 3);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new Wisej.Web.Padding(30);
            this.btn4.Size = new System.Drawing.Size(159, 149);
            this.btn4.TabIndex = 4;
            this.btn4.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromName("@gray-100");
            this.btn5.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn5.ImageSource = "icon-settings";
            this.btn5.Location = new System.Drawing.Point(828, 3);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new Wisej.Web.Padding(30);
            this.btn5.Size = new System.Drawing.Size(159, 149);
            this.btn5.TabIndex = 5;
            this.btn5.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // lblImpBase
            // 
            this.lblImpBase.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblImpBase.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblImpBase.Location = new System.Drawing.Point(3, 158);
            this.lblImpBase.Name = "lblImpBase";
            this.lblImpBase.Size = new System.Drawing.Size(158, 44);
            this.lblImpBase.TabIndex = 7;
            this.lblImpBase.Text = "Aggiungi Clienti";
            this.lblImpBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.label1.Location = new System.Drawing.Point(167, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.label2.Location = new System.Drawing.Point(331, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.label3.Location = new System.Drawing.Point(495, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.label4.Location = new System.Drawing.Point(659, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.label5.Location = new System.Drawing.Point(823, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vVoIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 662);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "vVoIP";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Tag = "VoIP";
            this.Text = "vVoIP";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vVoIP_Load);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel pLogo;
        private Wisej.Web.PictureBox pbLogo;
        private Wisej.Web.Panel pUser;
        private Wisej.Web.PictureBox pbAvatar;
        private Wisej.Web.Label lblUsername;
        private Wisej.Web.MenuBar menuBar;
        private Wisej.Web.MenuItem mnuPlanning;
        private Wisej.Web.MenuItem mnuImpostazioni;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.Button btnLogout;
        private Wisej.Web.FlowLayoutPanel flp;
        private Wisej.Web.Button btnAddClient;
        private Wisej.Web.Button btnAddUser;
        private Wisej.Web.Button btn2;
        private Wisej.Web.Button btn3;
        private Wisej.Web.Button btn4;
        private Wisej.Web.Button btn5;
        private Wisej.Web.Label lblImpBase;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
    }
}