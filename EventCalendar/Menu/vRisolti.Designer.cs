namespace EventCalendar.Menu
{
    partial class vRisolti
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
            this.cboTipo = new Wisej.Web.ComboBox();
            this.dgvSearch = new Wisej.Web.DataGridView();
            this.txtId = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboTipo.Items.AddRange(new object[] {
            "Tutte",
            "Sopralluogo",
            "Installazione",
            "Intervento",
            "Ferie/Malattia",
            "Altro",
            "King"});
            this.cboTipo.Label.Position = Wisej.Web.LabelPosition.Left;
            this.cboTipo.LabelText = "Tipo:";
            this.cboTipo.Location = new System.Drawing.Point(41, 34);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(185, 30);
            this.cboTipo.TabIndex = 10;
            this.cboTipo.SelectedItemChanged += new System.EventHandler(this.cboTipo_SelectedItemChanged);
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.Location = new System.Drawing.Point(0, 99);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.ShowColumnVisibilityMenu = false;
            this.dgvSearch.Size = new System.Drawing.Size(1043, 474);
            this.dgvSearch.TabIndex = 11;
            this.dgvSearch.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dgvSearch_CellFormatting);
            this.dgvSearch.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgvSearch_CellDoubleClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(915, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 12;
            // 
            // vRisolti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 573);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.cboTipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vRisolti";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Risolti - chiamate";
            this.Load += new System.EventHandler(this.vRisolti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.ComboBox cboTipo;
        private Wisej.Web.DataGridView dgvSearch;
        private Wisej.Web.TextBox txtId;
    }
}