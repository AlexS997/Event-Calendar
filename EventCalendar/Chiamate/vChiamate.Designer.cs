namespace EventCalendar.Chiamate
{
    partial class vChiamate
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
            this.splitContainer = new Wisej.Web.SplitContainer();
            this.dgvChiamate = new Wisej.Web.DataGridView();
            this.btnAdd = new Wisej.Web.Button();
            this.flpMain = new Wisej.Web.FlowLayoutPanel();
            this.flpDateTime = new Wisej.Web.FlowLayoutPanel();
            this.dtpDate = new Wisej.Web.DateTimePicker();
            this.cboStart = new Wisej.Web.ComboBox();
            this.cboEnd = new Wisej.Web.ComboBox();
            this.chkAllDay = new Wisej.Web.CheckBox();
            this.pBlue1 = new Wisej.Web.Panel();
            this.cboTipo = new Wisej.Web.ComboBox();
            this.panel = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.cboTecnico1 = new Wisej.Web.ComboBox();
            this.cboTecnico2 = new Wisej.Web.ComboBox();
            this.pClienti = new Wisej.Web.Panel();
            this.btnSearch = new Wisej.Web.Button();
            this.txtCliente = new Wisej.Web.TextBox();
            this.txtTelefono = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtNote = new Wisej.Web.TextBox();
            this.chkChiamato = new Wisej.Web.CheckBox();
            this.txtId = new Wisej.Web.TextBox();
            this.lblAddInfo = new Wisej.Web.Label();
            this.flpButtons = new Wisej.Web.FlowLayoutPanel();
            this.btnAssegna = new Wisej.Web.Button();
            this.btnConferma = new Wisej.Web.Button();
            this.btnClose = new Wisej.Web.Button();
            this.btnStampa = new Wisej.Web.Button();
            this.cboAutomezzo = new Wisej.Web.ComboBox();
            this.bsEvents = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiamate)).BeginInit();
            this.flpMain.SuspendLayout();
            this.flpDateTime.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pClienti.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvents)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.dgvChiamate);
            this.splitContainer.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flpMain);
            this.splitContainer.Panel2.Controls.Add(this.lblAddInfo);
            this.splitContainer.Panel2.Controls.Add(this.flpButtons);
            this.splitContainer.Size = new System.Drawing.Size(1173, 847);
            this.splitContainer.SplitterDistance = 449;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvChiamate
            // 
            this.dgvChiamate.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvChiamate.Dock = Wisej.Web.DockStyle.Top;
            this.dgvChiamate.Location = new System.Drawing.Point(0, 0);
            this.dgvChiamate.Name = "dgvChiamate";
            this.dgvChiamate.ReadOnly = true;
            this.dgvChiamate.ShowColumnVisibilityMenu = false;
            this.dgvChiamate.Size = new System.Drawing.Size(447, 558);
            this.dgvChiamate.TabIndex = 1;
            this.dgvChiamate.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dgvChiamate_CellFormatting);
            this.dgvChiamate.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgvChiamate_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(172, 578);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpMain
            // 
            this.flpMain.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpMain.Controls.Add(this.flpDateTime);
            this.flpMain.Controls.Add(this.pBlue1);
            this.flpMain.Controls.Add(this.cboTipo);
            this.flpMain.Controls.Add(this.panel);
            this.flpMain.Controls.Add(this.flowLayoutPanel1);
            this.flpMain.Controls.Add(this.cboAutomezzo);
            this.flpMain.Controls.Add(this.txtNote);
            this.flpMain.Controls.Add(this.chkChiamato);
            this.flpMain.Controls.Add(this.txtId);
            this.flpMain.FlowDirection = Wisej.Web.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(104, 60);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(513, 709);
            this.flpMain.TabIndex = 1;
            // 
            // flpDateTime
            // 
            this.flpDateTime.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpDateTime.Controls.Add(this.dtpDate);
            this.flpDateTime.Controls.Add(this.cboStart);
            this.flpDateTime.Controls.Add(this.cboEnd);
            this.flpDateTime.Controls.Add(this.chkAllDay);
            this.flpDateTime.Location = new System.Drawing.Point(3, 3);
            this.flpDateTime.Name = "flpDateTime";
            this.flpDateTime.Size = new System.Drawing.Size(501, 38);
            this.flpDateTime.TabIndex = 0;
            // 
            // dtpDate
            // 
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
            // pBlue1
            // 
            this.pBlue1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.pBlue1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.pBlue1.Location = new System.Drawing.Point(3, 47);
            this.pBlue1.Name = "pBlue1";
            this.pBlue1.Size = new System.Drawing.Size(501, 3);
            this.pBlue1.TabIndex = 5;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.cboTipo.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboTipo.Items.AddRange(new object[] {
            "Installazione",
            "Intervento",
            "Sopralluogo"});
            this.cboTipo.LabelText = "Tipo";
            this.cboTipo.Location = new System.Drawing.Point(138, 56);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(231, 53);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.Watermark = "Tipologia";
            // 
            // panel
            // 
            this.panel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.panel.Location = new System.Drawing.Point(3, 117);
            this.panel.Margin = new Wisej.Web.Padding(3, 5, 3, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(501, 3);
            this.panel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cboTecnico1);
            this.flowLayoutPanel1.Controls.Add(this.cboTecnico2);
            this.flowLayoutPanel1.Controls.Add(this.pClienti);
            this.flowLayoutPanel1.Controls.Add(this.txtTelefono);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 128);
            this.flowLayoutPanel1.Margin = new Wisej.Web.Padding(31, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 237);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.pClienti.Controls.Add(this.btnSearch);
            this.pClienti.Controls.Add(this.txtCliente);
            this.pClienti.Location = new System.Drawing.Point(3, 62);
            this.pClienti.Name = "pClienti";
            this.pClienti.Size = new System.Drawing.Size(448, 56);
            this.pClienti.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromName("@warning");
            this.btnSearch.ImageSource = "icon-search";
            this.btnSearch.Location = new System.Drawing.Point(413, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.ToolTipText = "Anagrafica Clienti";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.LabelText = "Cliente";
            this.txtCliente.Location = new System.Drawing.Point(0, 0);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(407, 53);
            this.txtCliente.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.LabelText = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(3, 124);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(219, 53);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(3, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(407, 53);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.LabelText = "Note";
            this.txtNote.Location = new System.Drawing.Point(3, 430);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(501, 209);
            this.txtNote.TabIndex = 3;
            // 
            // chkChiamato
            // 
            this.chkChiamato.Location = new System.Drawing.Point(3, 645);
            this.chkChiamato.Name = "chkChiamato";
            this.chkChiamato.Size = new System.Drawing.Size(86, 23);
            this.chkChiamato.TabIndex = 4;
            this.chkChiamato.Text = "Chiamato";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 674);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 2;
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.lblAddInfo.Dock = Wisej.Web.DockStyle.Top;
            this.lblAddInfo.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddInfo.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.lblAddInfo.Location = new System.Drawing.Point(0, 0);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(719, 42);
            this.lblAddInfo.TabIndex = 0;
            this.lblAddInfo.Text = "Inserito";
            this.lblAddInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.flpButtons.Controls.Add(this.btnAssegna);
            this.flpButtons.Controls.Add(this.btnConferma);
            this.flpButtons.Controls.Add(this.btnClose);
            this.flpButtons.Controls.Add(this.btnStampa);
            this.flpButtons.Location = new System.Drawing.Point(145, 775);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(430, 42);
            this.flpButtons.TabIndex = 2;
            // 
            // btnAssegna
            // 
            this.btnAssegna.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnAssegna.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAssegna.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnAssegna.Location = new System.Drawing.Point(3, 3);
            this.btnAssegna.Name = "btnAssegna";
            this.btnAssegna.Size = new System.Drawing.Size(100, 37);
            this.btnAssegna.TabIndex = 0;
            this.btnAssegna.Text = "Assegna";
            this.btnAssegna.Click += new System.EventHandler(this.btnAssegna_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromName("@success");
            this.btnConferma.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnConferma.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnConferma.Location = new System.Drawing.Point(109, 3);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(100, 37);
            this.btnConferma.TabIndex = 1;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnClose.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClose.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnClose.Location = new System.Drawing.Point(215, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Chiudi";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnStampa.Location = new System.Drawing.Point(321, 3);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(100, 37);
            this.btnStampa.TabIndex = 3;
            this.btnStampa.Text = "Stampa";
            // 
            // cboAutomezzo
            // 
            this.cboAutomezzo.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboAutomezzo.LabelText = "Automezzo";
            this.cboAutomezzo.Location = new System.Drawing.Point(3, 371);
            this.cboAutomezzo.Name = "cboAutomezzo";
            this.cboAutomezzo.Size = new System.Drawing.Size(176, 53);
            this.cboAutomezzo.TabIndex = 5;
            // 
            // bsEvents
            // 
            this.bsEvents.DataSource = typeof(EventCalendar.TableClass.TableChiamate);
            // 
            // vChiamate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 847);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(1175, 896);
            this.Name = "vChiamate";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Chiamate";
            this.Load += new System.EventHandler(this.vChiamate_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiamate)).EndInit();
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            this.flpDateTime.ResumeLayout(false);
            this.flpDateTime.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pClienti.ResumeLayout(false);
            this.pClienti.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer;
        private Wisej.Web.Button btnAdd;
        private Wisej.Web.BindingSource bsEvents;
        private Wisej.Web.DataGridView dgvChiamate;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.TextBox txtTelefono;
        private Wisej.Web.TextBox txtCliente;
        private Wisej.Web.TextBox txtNote;
        private Wisej.Web.Button btnAssegna;
        private Wisej.Web.Button btnStampa;
        private Wisej.Web.Button btnConferma;
        private Wisej.Web.Button btnClose;
        private Wisej.Web.Button btnSearch;
        private Wisej.Web.ComboBox cboTipo;
        private Wisej.Web.CheckBox chkChiamato;
        private Wisej.Web.ComboBox cboTecnico2;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.ComboBox cboTecnico1;
        private Wisej.Web.Panel pClienti;
        private Wisej.Web.FlowLayoutPanel flpButtons;
        private Wisej.Web.Label lblAddInfo;
        private Wisej.Web.Panel pBlue1;
        private Wisej.Web.Panel panel;
        private Wisej.Web.FlowLayoutPanel flpDateTime;
        private Wisej.Web.DateTimePicker dtpDate;
        private Wisej.Web.ComboBox cboStart;
        private Wisej.Web.ComboBox cboEnd;
        private Wisej.Web.CheckBox chkAllDay;
        private Wisej.Web.FlowLayoutPanel flpMain;
        private Wisej.Web.TextBox txtId;
        private Wisej.Web.ComboBox cboAutomezzo;
    }
}