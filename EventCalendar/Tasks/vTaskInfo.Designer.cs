namespace EventCalendar.Tasks
{
    partial class vTaskInfo
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
            this.lblAddInfo = new Wisej.Web.Label();
            this.flpMain = new Wisej.Web.FlowLayoutPanel();
            this.flpDateTime = new Wisej.Web.FlowLayoutPanel();
            this.dtpDate = new Wisej.Web.DateTimePicker();
            this.cboStart = new Wisej.Web.ComboBox();
            this.cboEnd = new Wisej.Web.ComboBox();
            this.chkAllDay = new Wisej.Web.CheckBox();
            this.dtpDateEnd = new Wisej.Web.DateTimePicker();
            this.pBlue1 = new Wisej.Web.Panel();
            this.txtTipo = new Wisej.Web.TextBox();
            this.panel = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.cboTecnico1 = new Wisej.Web.ComboBox();
            this.cboTecnico2 = new Wisej.Web.ComboBox();
            this.pClienti = new Wisej.Web.Panel();
            this.btnSearch = new Wisej.Web.Button();
            this.txtCliente = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.cboAutomezzo = new Wisej.Web.ComboBox();
            this.txtTelefono = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtNote = new Wisej.Web.TextBox();
            this.flpBottom = new Wisej.Web.FlowLayoutPanel();
            this.chkChiamato = new Wisej.Web.CheckBox();
            this.chkEffettuato = new Wisej.Web.CheckBox();
            this.cboStato = new Wisej.Web.ComboBox();
            this.btnConferma = new Wisej.Web.Button();
            this.btnClose = new Wisej.Web.Button();
            this.btnStampa = new Wisej.Web.Button();
            this.btnInfo = new Wisej.Web.Button();
            this.bsTask = new Wisej.Web.BindingSource(this.components);
            this.flpMain.SuspendLayout();
            this.flpDateTime.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pClienti.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTask)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.lblAddInfo.Dock = Wisej.Web.DockStyle.Top;
            this.lblAddInfo.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddInfo.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.lblAddInfo.Location = new System.Drawing.Point(0, 0);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(839, 42);
            this.lblAddInfo.TabIndex = 0;
            this.lblAddInfo.Text = "Inserito";
            this.lblAddInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMain
            // 
            this.flpMain.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpMain.Controls.Add(this.flpDateTime);
            this.flpMain.Controls.Add(this.pBlue1);
            this.flpMain.Controls.Add(this.txtTipo);
            this.flpMain.Controls.Add(this.panel);
            this.flpMain.Controls.Add(this.flowLayoutPanel1);
            this.flpMain.Controls.Add(this.txtNote);
            this.flpMain.Controls.Add(this.flpBottom);
            this.flpMain.FlowDirection = Wisej.Web.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(163, 58);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(513, 688);
            this.flpMain.TabIndex = 1;
            // 
            // flpDateTime
            // 
            this.flpDateTime.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpDateTime.AutoSize = true;
            this.flpDateTime.Controls.Add(this.dtpDate);
            this.flpDateTime.Controls.Add(this.cboStart);
            this.flpDateTime.Controls.Add(this.cboEnd);
            this.flpDateTime.Controls.Add(this.chkAllDay);
            this.flpDateTime.Controls.Add(this.dtpDateEnd);
            this.flpDateTime.Location = new System.Drawing.Point(11, 3);
            this.flpDateTime.Name = "flpDateTime";
            this.flpDateTime.Size = new System.Drawing.Size(485, 72);
            this.flpDateTime.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpDate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(3, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(110, 30);
            this.dtpDate.TabIndex = 0;
            // 
            // cboStart
            // 
            this.cboStart.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboStart.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30"});
            this.cboStart.Label.Position = Wisej.Web.LabelPosition.Left;
            this.cboStart.LabelText = "dalle";
            this.cboStart.Location = new System.Drawing.Point(119, 3);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(120, 30);
            this.cboStart.TabIndex = 1;
            // 
            // cboEnd
            // 
            this.cboEnd.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboEnd.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30"});
            this.cboEnd.Label.Position = Wisej.Web.LabelPosition.Left;
            this.cboEnd.LabelText = "alle";
            this.cboEnd.Location = new System.Drawing.Point(245, 3);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(120, 30);
            this.cboEnd.TabIndex = 2;
            // 
            // chkAllDay
            // 
            this.chkAllDay.AutoSize = false;
            this.chkAllDay.Location = new System.Drawing.Point(371, 3);
            this.chkAllDay.Name = "chkAllDay";
            this.chkAllDay.Size = new System.Drawing.Size(111, 30);
            this.chkAllDay.TabIndex = 3;
            this.chkAllDay.Text = "tutto il giorno ";
            this.chkAllDay.CheckedChanged += new System.EventHandler(this.chkAllDay_CheckedChanged);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpDateEnd.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpDateEnd.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpDateEnd.LabelText = "a";
            this.dtpDateEnd.Location = new System.Drawing.Point(3, 39);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(121, 30);
            this.dtpDateEnd.TabIndex = 4;
            // 
            // pBlue1
            // 
            this.pBlue1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.pBlue1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.pBlue1.Location = new System.Drawing.Point(3, 81);
            this.pBlue1.Name = "pBlue1";
            this.pBlue1.Size = new System.Drawing.Size(501, 3);
            this.pBlue1.TabIndex = 1;
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtTipo.LabelText = "Tipo";
            this.txtTipo.Location = new System.Drawing.Point(109, 90);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(289, 53);
            this.txtTipo.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.panel.Location = new System.Drawing.Point(3, 151);
            this.panel.Margin = new Wisej.Web.Padding(3, 5, 3, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(501, 3);
            this.panel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cboTecnico1);
            this.flowLayoutPanel1.Controls.Add(this.cboTecnico2);
            this.flowLayoutPanel1.Controls.Add(this.pClienti);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 162);
            this.flowLayoutPanel1.Margin = new Wisej.Web.Padding(31, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(471, 249);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cboTecnico1
            // 
            this.cboTecnico1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboTecnico1.LabelText = "Tecnico";
            this.cboTecnico1.Location = new System.Drawing.Point(3, 3);
            this.cboTecnico1.Name = "cboTecnico1";
            this.cboTecnico1.Size = new System.Drawing.Size(219, 53);
            this.cboTecnico1.TabIndex = 0;
            this.cboTecnico1.Watermark = "Tecnico 1";
            // 
            // cboTecnico2
            // 
            this.cboTecnico2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboTecnico2.LabelText = "    ";
            this.cboTecnico2.Location = new System.Drawing.Point(228, 3);
            this.cboTecnico2.Name = "cboTecnico2";
            this.cboTecnico2.Size = new System.Drawing.Size(219, 53);
            this.cboTecnico2.TabIndex = 1;
            this.cboTecnico2.Watermark = "Tecnico 2";
            // 
            // pClienti
            // 
            this.pClienti.Controls.Add(this.btnInfo);
            this.pClienti.Controls.Add(this.btnSearch);
            this.pClienti.Controls.Add(this.txtCliente);
            this.pClienti.Location = new System.Drawing.Point(3, 62);
            this.pClienti.Name = "pClienti";
            this.pClienti.Padding = new Wisej.Web.Padding(3, 0, 0, 0);
            this.pClienti.Size = new System.Drawing.Size(459, 56);
            this.pClienti.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnSearch.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnSearch.ImageSource = "icon-search";
            this.btnSearch.Location = new System.Drawing.Point(383, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.ToolTipText = "Anagrafica Clienti";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.LabelText = "Cliente";
            this.txtCliente.Location = new System.Drawing.Point(3, 0);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(375, 53);
            this.txtCliente.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboAutomezzo);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 63);
            this.panel1.TabIndex = 3;
            // 
            // cboAutomezzo
            // 
            this.cboAutomezzo.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboAutomezzo.LabelText = "Automezzo";
            this.cboAutomezzo.Location = new System.Drawing.Point(225, 6);
            this.cboAutomezzo.Name = "cboAutomezzo";
            this.cboAutomezzo.Size = new System.Drawing.Size(219, 53);
            this.cboAutomezzo.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.LabelText = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(3, 7);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(216, 53);
            this.txtTelefono.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(3, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 53);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.LabelText = "Note";
            this.txtNote.Location = new System.Drawing.Point(3, 417);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(501, 209);
            this.txtNote.TabIndex = 5;
            // 
            // flpBottom
            // 
            this.flpBottom.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpBottom.AutoSize = true;
            this.flpBottom.Controls.Add(this.chkChiamato);
            this.flpBottom.Controls.Add(this.chkEffettuato);
            this.flpBottom.Controls.Add(this.cboStato);
            this.flpBottom.Location = new System.Drawing.Point(55, 632);
            this.flpBottom.Name = "flpBottom";
            this.flpBottom.Size = new System.Drawing.Size(396, 36);
            this.flpBottom.TabIndex = 6;
            // 
            // chkChiamato
            // 
            this.chkChiamato.AutoSize = false;
            this.chkChiamato.Location = new System.Drawing.Point(3, 3);
            this.chkChiamato.Name = "chkChiamato";
            this.chkChiamato.Size = new System.Drawing.Size(90, 30);
            this.chkChiamato.TabIndex = 0;
            this.chkChiamato.Text = "Chiamato";
            // 
            // chkEffettuato
            // 
            this.chkEffettuato.AutoSize = false;
            this.chkEffettuato.Location = new System.Drawing.Point(99, 3);
            this.chkEffettuato.Name = "chkEffettuato";
            this.chkEffettuato.Size = new System.Drawing.Size(135, 30);
            this.chkEffettuato.TabIndex = 1;
            this.chkEffettuato.Text = "Lavoro Effettuato";
            // 
            // cboStato
            // 
            this.cboStato.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboStato.Items.AddRange(new object[] {
            "Aperto",
            "Concluso",
            "Rimandato"});
            this.cboStato.Label.Position = Wisej.Web.LabelPosition.Left;
            this.cboStato.LabelText = "Stato";
            this.cboStato.Location = new System.Drawing.Point(240, 3);
            this.cboStato.Name = "cboStato";
            this.cboStato.Size = new System.Drawing.Size(153, 30);
            this.cboStato.TabIndex = 2;
            // 
            // btnConferma
            // 
            this.btnConferma.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnConferma.BackColor = System.Drawing.Color.FromName("@success");
            this.btnConferma.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnConferma.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnConferma.Location = new System.Drawing.Point(161, 777);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(100, 37);
            this.btnConferma.TabIndex = 2;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnClose.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClose.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnClose.Location = new System.Drawing.Point(576, 777);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Chiudi";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnStampa.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnStampa.Location = new System.Drawing.Point(470, 777);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(100, 37);
            this.btnStampa.TabIndex = 3;
            this.btnStampa.Text = "Stampa";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromName("@warning");
            this.btnInfo.ImageSource = "icon-question";
            this.btnInfo.Location = new System.Drawing.Point(420, 22);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(31, 31);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.ToolTipText = "Info Cliente";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // bsTask
            // 
            this.bsTask.DataSource = typeof(EventCalendar.TableClass.TableTasks);
            // 
            // vTaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 840);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.lblAddInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(841, 889);
            this.Name = "vTaskInfo";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.vTaskInfo_Load);
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            this.flpDateTime.ResumeLayout(false);
            this.flpDateTime.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pClienti.ResumeLayout(false);
            this.pClienti.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpBottom.ResumeLayout(false);
            this.flpBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Label lblAddInfo;
        private Wisej.Web.FlowLayoutPanel flpMain;
        private Wisej.Web.FlowLayoutPanel flpDateTime;
        private Wisej.Web.DateTimePicker dtpDate;
        private Wisej.Web.ComboBox cboEnd;
        private Wisej.Web.CheckBox chkAllDay;
        private Wisej.Web.Panel pBlue1;
        private Wisej.Web.Panel panel;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.ComboBox cboTecnico1;
        private Wisej.Web.ComboBox cboTecnico2;
        private Wisej.Web.Panel pClienti;
        private Wisej.Web.Button btnSearch;
        private Wisej.Web.TextBox txtCliente;
        private Wisej.Web.TextBox txtTelefono;
        private Wisej.Web.TextBox txtNote;
        private Wisej.Web.CheckBox chkChiamato;
        private Wisej.Web.BindingSource bsTask;
        private Wisej.Web.TextBox txtTipo;
        private Wisej.Web.ComboBox cboStart;
        private Wisej.Web.DateTimePicker dtpDateEnd;
        private Wisej.Web.CheckBox chkEffettuato;
        private Wisej.Web.FlowLayoutPanel flpBottom;
        private Wisej.Web.ComboBox cboStato;
        private Wisej.Web.Button btnConferma;
        private Wisej.Web.Button btnClose;
        private Wisej.Web.Button btnStampa;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.ComboBox cboAutomezzo;
        private Wisej.Web.Button btnInfo;
    }
}