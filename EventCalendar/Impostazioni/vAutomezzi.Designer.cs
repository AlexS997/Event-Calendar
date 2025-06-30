namespace EventCalendar.Impostazioni
{
    partial class vAutomezzi
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
            this.btnAdd = new Wisej.Web.Button();
            this.dgv = new Wisej.Web.DataGridView();
            this.flpButtons = new Wisej.Web.FlowLayoutPanel();
            this.btnSalva = new Wisej.Web.Button();
            this.btnDelete = new Wisej.Web.Button();
            this.btnClose = new Wisej.Web.Button();
            this.chkStato = new Wisej.Web.CheckBox();
            this.pBlue1 = new Wisej.Web.Panel();
            this.txtAutomezzo = new Wisej.Web.TextBox();
            this.txtTarga = new Wisej.Web.TextBox();
            this.dtpBollo = new Wisej.Web.DateTimePicker();
            this.dtpAssicurazione = new Wisej.Web.DateTimePicker();
            this.dtpTagliando = new Wisej.Web.DateTimePicker();
            this.dtpCollaudo = new Wisej.Web.DateTimePicker();
            this.dtpCinghia = new Wisej.Web.DateTimePicker();
            this.dtpGomme = new Wisej.Web.DateTimePicker();
            this.nCollaudo = new Wisej.Web.NumericUpDown();
            this.nGomme = new Wisej.Web.NumericUpDown();
            this.nCinghia = new Wisej.Web.NumericUpDown();
            this.nTagliando = new Wisej.Web.NumericUpDown();
            this.nKm = new Wisej.Web.NumericUpDown();
            this.bsAutomezzi = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCollaudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGomme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCinghia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTagliando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutomezzi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer.Panel1.Controls.Add(this.dgv);
            this.splitContainer.Panel1MinSize = 350;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.nKm);
            this.splitContainer.Panel2.Controls.Add(this.nTagliando);
            this.splitContainer.Panel2.Controls.Add(this.nCinghia);
            this.splitContainer.Panel2.Controls.Add(this.nGomme);
            this.splitContainer.Panel2.Controls.Add(this.nCollaudo);
            this.splitContainer.Panel2.Controls.Add(this.flpButtons);
            this.splitContainer.Panel2.Controls.Add(this.chkStato);
            this.splitContainer.Panel2.Controls.Add(this.pBlue1);
            this.splitContainer.Panel2.Controls.Add(this.txtAutomezzo);
            this.splitContainer.Panel2.Controls.Add(this.txtTarga);
            this.splitContainer.Panel2.Controls.Add(this.dtpBollo);
            this.splitContainer.Panel2.Controls.Add(this.dtpAssicurazione);
            this.splitContainer.Panel2.Controls.Add(this.dtpTagliando);
            this.splitContainer.Panel2.Controls.Add(this.dtpCollaudo);
            this.splitContainer.Panel2.Controls.Add(this.dtpCinghia);
            this.splitContainer.Panel2.Controls.Add(this.dtpGomme);
            this.splitContainer.Panel2MinSize = 500;
            this.splitContainer.Size = new System.Drawing.Size(1202, 661);
            this.splitContainer.SplitterDistance = 366;
            this.splitContainer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAdd.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnAdd.Location = new System.Drawing.Point(148, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.Dock = Wisej.Web.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.ShowColumnVisibilityMenu = false;
            this.dgv.Size = new System.Drawing.Size(364, 430);
            this.dgv.TabIndex = 0;
            this.dgv.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flpButtons.Controls.Add(this.btnSalva);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnClose);
            this.flpButtons.Location = new System.Drawing.Point(248, 582);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(322, 42);
            this.flpButtons.TabIndex = 15;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromName("@success");
            this.btnSalva.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSalva.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnSalva.Location = new System.Drawing.Point(3, 3);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 37);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "Conferma";
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromName("@danger");
            this.btnDelete.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDelete.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.btnDelete.Location = new System.Drawing.Point(109, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnClose.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClose.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.btnClose.Location = new System.Drawing.Point(215, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Chiudi";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkStato
            // 
            this.chkStato.Anchor = Wisej.Web.AnchorStyles.Top;
            this.chkStato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStato.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.chkStato.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.chkStato.Location = new System.Drawing.Point(199, 528);
            this.chkStato.Name = "chkStato";
            this.chkStato.Size = new System.Drawing.Size(68, 23);
            this.chkStato.TabIndex = 14;
            this.chkStato.Text = "Attivo";
            // 
            // pBlue1
            // 
            this.pBlue1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pBlue1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.pBlue1.Location = new System.Drawing.Point(50, 159);
            this.pBlue1.Name = "pBlue1";
            this.pBlue1.Size = new System.Drawing.Size(707, 3);
            this.pBlue1.TabIndex = 2;
            // 
            // txtAutomezzo
            // 
            this.txtAutomezzo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtAutomezzo.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutomezzo.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtAutomezzo.LabelText = "Automezzo";
            this.txtAutomezzo.Location = new System.Drawing.Point(295, 29);
            this.txtAutomezzo.Name = "txtAutomezzo";
            this.txtAutomezzo.Size = new System.Drawing.Size(241, 53);
            this.txtAutomezzo.TabIndex = 0;
            // 
            // txtTarga
            // 
            this.txtTarga.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtTarga.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTarga.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtTarga.LabelText = "Targa";
            this.txtTarga.Location = new System.Drawing.Point(295, 88);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(241, 53);
            this.txtTarga.TabIndex = 1;
            // 
            // dtpBollo
            // 
            this.dtpBollo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpBollo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpBollo.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpBollo.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpBollo.Label.Padding = new Wisej.Web.Padding(0, 0, 31, 0);
            this.dtpBollo.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpBollo.LabelText = "Scadenza Bollo";
            this.dtpBollo.Location = new System.Drawing.Point(199, 185);
            this.dtpBollo.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpBollo.Name = "dtpBollo";
            this.dtpBollo.Size = new System.Drawing.Size(272, 30);
            this.dtpBollo.TabIndex = 3;
            // 
            // dtpAssicurazione
            // 
            this.dtpAssicurazione.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpAssicurazione.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpAssicurazione.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpAssicurazione.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpAssicurazione.Label.Padding = new Wisej.Web.Padding(0, 0, 8, 0);
            this.dtpAssicurazione.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpAssicurazione.LabelText = "Scad Assicurazione";
            this.dtpAssicurazione.Location = new System.Drawing.Point(199, 233);
            this.dtpAssicurazione.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpAssicurazione.Name = "dtpAssicurazione";
            this.dtpAssicurazione.Size = new System.Drawing.Size(272, 30);
            this.dtpAssicurazione.TabIndex = 4;
            // 
            // dtpTagliando
            // 
            this.dtpTagliando.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpTagliando.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpTagliando.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpTagliando.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpTagliando.Label.Padding = new Wisej.Web.Padding(0, 0, 32, 0);
            this.dtpTagliando.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpTagliando.LabelText = "Data Tagliando";
            this.dtpTagliando.Location = new System.Drawing.Point(199, 425);
            this.dtpTagliando.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpTagliando.Name = "dtpTagliando";
            this.dtpTagliando.Size = new System.Drawing.Size(272, 30);
            this.dtpTagliando.TabIndex = 11;
            // 
            // dtpCollaudo
            // 
            this.dtpCollaudo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpCollaudo.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpCollaudo.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpCollaudo.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpCollaudo.Label.Padding = new Wisej.Web.Padding(0, 0, 8, 0);
            this.dtpCollaudo.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpCollaudo.LabelText = "Scadenza Collaudo";
            this.dtpCollaudo.Location = new System.Drawing.Point(199, 281);
            this.dtpCollaudo.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpCollaudo.Name = "dtpCollaudo";
            this.dtpCollaudo.Size = new System.Drawing.Size(272, 30);
            this.dtpCollaudo.TabIndex = 5;
            // 
            // dtpCinghia
            // 
            this.dtpCinghia.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpCinghia.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpCinghia.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpCinghia.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpCinghia.Label.Padding = new Wisej.Web.Padding(0, 0, 26, 0);
            this.dtpCinghia.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpCinghia.LabelText = "Cambio Cinghia";
            this.dtpCinghia.Location = new System.Drawing.Point(199, 377);
            this.dtpCinghia.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpCinghia.Name = "dtpCinghia";
            this.dtpCinghia.Size = new System.Drawing.Size(272, 30);
            this.dtpCinghia.TabIndex = 9;
            // 
            // dtpGomme
            // 
            this.dtpGomme.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dtpGomme.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpGomme.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dtpGomme.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.dtpGomme.Label.Padding = new Wisej.Web.Padding(0, 0, 23, 0);
            this.dtpGomme.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dtpGomme.LabelText = "Cambio Gomme";
            this.dtpGomme.Location = new System.Drawing.Point(199, 329);
            this.dtpGomme.Margin = new Wisej.Web.Padding(3, 15, 3, 3);
            this.dtpGomme.Name = "dtpGomme";
            this.dtpGomme.Size = new System.Drawing.Size(272, 30);
            this.dtpGomme.TabIndex = 7;
            // 
            // nCollaudo
            // 
            this.nCollaudo.Anchor = Wisej.Web.AnchorStyles.Top;
            this.nCollaudo.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nCollaudo.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.nCollaudo.Label.Position = Wisej.Web.LabelPosition.Left;
            this.nCollaudo.LabelText = "Km";
            this.nCollaudo.Location = new System.Drawing.Point(502, 281);
            this.nCollaudo.Maximum = new decimal(100000);
            this.nCollaudo.Name = "nCollaudo";
            this.nCollaudo.Size = new System.Drawing.Size(127, 30);
            this.nCollaudo.TabIndex = 16;
            // 
            // nGomme
            // 
            this.nGomme.Anchor = Wisej.Web.AnchorStyles.Top;
            this.nGomme.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nGomme.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.nGomme.Label.Position = Wisej.Web.LabelPosition.Left;
            this.nGomme.LabelText = "Km";
            this.nGomme.Location = new System.Drawing.Point(502, 329);
            this.nGomme.Maximum = new decimal(100000);
            this.nGomme.Name = "nGomme";
            this.nGomme.Size = new System.Drawing.Size(127, 30);
            this.nGomme.TabIndex = 17;
            // 
            // nCinghia
            // 
            this.nCinghia.Anchor = Wisej.Web.AnchorStyles.Top;
            this.nCinghia.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nCinghia.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.nCinghia.Label.Position = Wisej.Web.LabelPosition.Left;
            this.nCinghia.LabelText = "Km";
            this.nCinghia.Location = new System.Drawing.Point(502, 377);
            this.nCinghia.Maximum = new decimal(100000);
            this.nCinghia.Name = "nCinghia";
            this.nCinghia.Size = new System.Drawing.Size(127, 30);
            this.nCinghia.TabIndex = 18;
            // 
            // nTagliando
            // 
            this.nTagliando.Anchor = Wisej.Web.AnchorStyles.Top;
            this.nTagliando.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nTagliando.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.nTagliando.Label.Position = Wisej.Web.LabelPosition.Left;
            this.nTagliando.LabelText = "Km";
            this.nTagliando.Location = new System.Drawing.Point(502, 425);
            this.nTagliando.Maximum = new decimal(100000);
            this.nTagliando.Name = "nTagliando";
            this.nTagliando.Size = new System.Drawing.Size(127, 30);
            this.nTagliando.TabIndex = 19;
            // 
            // nKm
            // 
            this.nKm.Anchor = Wisej.Web.AnchorStyles.Top;
            this.nKm.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nKm.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.nKm.Label.Padding = new Wisej.Web.Padding(0, 0, 59, 0);
            this.nKm.Label.Position = Wisej.Web.LabelPosition.Left;
            this.nKm.LabelText = "Km Attuali";
            this.nKm.Location = new System.Drawing.Point(199, 474);
            this.nKm.Maximum = new decimal(100000);
            this.nKm.Name = "nKm";
            this.nKm.Size = new System.Drawing.Size(272, 30);
            this.nKm.TabIndex = 20;
            // 
            // bsAutomezzi
            // 
            this.bsAutomezzi.DataSource = typeof(EventCalendar.TableClass.TableAutomezzi);
            // 
            // vAutomezzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 661);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(1204, 710);
            this.Name = "vAutomezzi";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Automezzi";
            this.Load += new System.EventHandler(this.vAutomezzi_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nCollaudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGomme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCinghia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTagliando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAutomezzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.SplitContainer splitContainer;
        private Wisej.Web.DataGridView dgv;
        private Wisej.Web.Button btnAdd;
        private Wisej.Web.TextBox txtAutomezzo;
        private Wisej.Web.TextBox txtTarga;
        private Wisej.Web.DateTimePicker dtpBollo;
        private Wisej.Web.DateTimePicker dtpAssicurazione;
        private Wisej.Web.DateTimePicker dtpCollaudo;
        private Wisej.Web.DateTimePicker dtpGomme;
        private Wisej.Web.DateTimePicker dtpCinghia;
        private Wisej.Web.DateTimePicker dtpTagliando;
        private Wisej.Web.Panel pBlue1;
        private Wisej.Web.CheckBox chkStato;
        private Wisej.Web.Button btnSalva;
        private Wisej.Web.BindingSource bsAutomezzi;
        private Wisej.Web.FlowLayoutPanel flpButtons;
        private Wisej.Web.Button btnDelete;
        private Wisej.Web.Button btnClose;
        private Wisej.Web.NumericUpDown nCollaudo;
        private Wisej.Web.NumericUpDown nKm;
        private Wisej.Web.NumericUpDown nTagliando;
        private Wisej.Web.NumericUpDown nCinghia;
        private Wisej.Web.NumericUpDown nGomme;
    }
}