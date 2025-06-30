namespace EventCalendar.Menu
{
    partial class vRicerca
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
            this.txtCliente = new Wisej.Web.TextBox();
            this.txtDip1 = new Wisej.Web.TextBox();
            this.txtDip2 = new Wisej.Web.TextBox();
            this.btnClienti = new Wisej.Web.Button();
            this.btnDip1 = new Wisej.Web.Button();
            this.btnDip2 = new Wisej.Web.Button();
            this.cboTipologia = new Wisej.Web.ComboBox();
            this.dtpStart = new Wisej.Web.DateTimePicker();
            this.dtpFine = new Wisej.Web.DateTimePicker();
            this.txtClear = new Wisej.Web.Button();
            this.btnCerca = new Wisej.Web.Button();
            this.dgvRicerca = new Wisej.Web.DataGridView();
            this.lblRecords = new Wisej.Web.Label();
            this.txtId = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRicerca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtCliente.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.txtCliente.Label.Position = Wisej.Web.LabelPosition.Left;
            this.txtCliente.LabelText = "Cliente";
            this.txtCliente.Location = new System.Drawing.Point(65, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(294, 30);
            this.txtCliente.TabIndex = 1;
            // 
            // txtDip1
            // 
            this.txtDip1.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtDip1.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtDip1.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.txtDip1.Label.Position = Wisej.Web.LabelPosition.Left;
            this.txtDip1.LabelText = "Dipendente 1";
            this.txtDip1.Location = new System.Drawing.Point(26, 76);
            this.txtDip1.Name = "txtDip1";
            this.txtDip1.Size = new System.Drawing.Size(333, 30);
            this.txtDip1.TabIndex = 2;
            // 
            // txtDip2
            // 
            this.txtDip2.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtDip2.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtDip2.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.txtDip2.Label.Position = Wisej.Web.LabelPosition.Left;
            this.txtDip2.LabelText = "Dipendente 2";
            this.txtDip2.Location = new System.Drawing.Point(26, 131);
            this.txtDip2.Name = "txtDip2";
            this.txtDip2.Size = new System.Drawing.Size(333, 30);
            this.txtDip2.TabIndex = 3;
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.Color.FromName("@table-row-background-odd");
            this.btnClienti.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClienti.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnClienti.Location = new System.Drawing.Point(375, 28);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(35, 25);
            this.btnClienti.TabIndex = 12;
            this.btnClienti.Text = "...";
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnDip1
            // 
            this.btnDip1.BackColor = System.Drawing.Color.FromName("@table-row-background-odd");
            this.btnDip1.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDip1.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnDip1.Location = new System.Drawing.Point(375, 78);
            this.btnDip1.Name = "btnDip1";
            this.btnDip1.Size = new System.Drawing.Size(35, 25);
            this.btnDip1.TabIndex = 13;
            this.btnDip1.Text = "...";
            this.btnDip1.Click += new System.EventHandler(this.btnDip1_Click);
            // 
            // btnDip2
            // 
            this.btnDip2.BackColor = System.Drawing.Color.FromName("@table-row-background-odd");
            this.btnDip2.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDip2.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnDip2.Location = new System.Drawing.Point(375, 133);
            this.btnDip2.Name = "btnDip2";
            this.btnDip2.Size = new System.Drawing.Size(35, 25);
            this.btnDip2.TabIndex = 14;
            this.btnDip2.Text = "...";
            this.btnDip2.Click += new System.EventHandler(this.btnDip2_Click);
            // 
            // cboTipologia
            // 
            this.cboTipologia.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboTipologia.Label.Font = new System.Drawing.Font("defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipologia.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.cboTipologia.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.cboTipologia.Label.Position = Wisej.Web.LabelPosition.Left;
            this.cboTipologia.LabelText = "Tipologia";
            this.cboTipologia.Location = new System.Drawing.Point(51, 184);
            this.cboTipologia.Name = "cboTipologia";
            this.cboTipologia.Size = new System.Drawing.Size(228, 30);
            this.cboTipologia.TabIndex = 15;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpStart.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpStart.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpStart.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.dtpStart.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpStart.LabelText = "Data start";
            this.dtpStart.Location = new System.Drawing.Point(48, 239);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(231, 30);
            this.dtpStart.TabIndex = 16;
            // 
            // dtpFine
            // 
            this.dtpFine.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFine.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFine.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpFine.Label.Padding = new Wisej.Web.Padding(0, 0, 20, 0);
            this.dtpFine.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpFine.LabelText = "Data fine";
            this.dtpFine.Location = new System.Drawing.Point(300, 239);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(237, 30);
            this.dtpFine.TabIndex = 17;
            // 
            // txtClear
            // 
            this.txtClear.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.txtClear.BackColor = System.Drawing.Color.FromName("@warning");
            this.txtClear.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtClear.Location = new System.Drawing.Point(647, 239);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(68, 30);
            this.txtClear.TabIndex = 18;
            this.txtClear.Text = "Svuota";
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnCerca.BackColor = System.Drawing.Color.FromName("@success");
            this.btnCerca.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCerca.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnCerca.Location = new System.Drawing.Point(566, 240);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(68, 28);
            this.btnCerca.TabIndex = 19;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // dgvRicerca
            // 
            this.dgvRicerca.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgvRicerca.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRicerca.Location = new System.Drawing.Point(0, 288);
            this.dgvRicerca.Name = "dgvRicerca";
            this.dgvRicerca.ReadOnly = true;
            this.dgvRicerca.ShowColumnVisibilityMenu = false;
            this.dgvRicerca.Size = new System.Drawing.Size(732, 302);
            this.dgvRicerca.TabIndex = 20;
            this.dgvRicerca.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dgvRicerca_CellFormatting);
            this.dgvRicerca.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgvRicerca_CellDoubleClick);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRecords.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.lblRecords.Location = new System.Drawing.Point(536, 28);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(98, 18);
            this.lblRecords.TabIndex = 21;
            this.lblRecords.Text = "Record Trovati:";
            this.lblRecords.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(615, 184);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 22;
            // 
            // vRicerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 590);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvRicerca);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.dtpFine);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboTipologia);
            this.Controls.Add(this.btnDip2);
            this.Controls.Add(this.btnDip1);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.txtDip2);
            this.Controls.Add(this.txtDip1);
            this.Controls.Add(this.txtCliente);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(734, 639);
            this.Name = "vRicerca";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Ricerca";
            this.Load += new System.EventHandler(this.vRicerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRicerca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtCliente;
        private Wisej.Web.TextBox txtDip1;
        private Wisej.Web.TextBox txtDip2;
        private Wisej.Web.Button btnClienti;
        private Wisej.Web.Button btnDip1;
        private Wisej.Web.Button btnDip2;
        private Wisej.Web.ComboBox cboTipologia;
        private Wisej.Web.DateTimePicker dtpStart;
        private Wisej.Web.DateTimePicker dtpFine;
        private Wisej.Web.Button txtClear;
        private Wisej.Web.Button btnCerca;
        private Wisej.Web.DataGridView dgvRicerca;
        private Wisej.Web.Label lblRecords;
        private Wisej.Web.TextBox txtId;
    }
}