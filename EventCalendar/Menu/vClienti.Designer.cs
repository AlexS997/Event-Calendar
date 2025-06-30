namespace EventCalendar.Menu
{
    partial class vClienti
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
            this.dgvClienti = new Wisej.Web.DataGridView();
            this.btnAdd = new Wisej.Web.Button();
            this.bsClienti = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgvClienti.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClienti.Location = new System.Drawing.Point(0, 64);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.ReadOnly = true;
            this.dgvClienti.ShowColumnVisibilityMenu = false;
            this.dgvClienti.Size = new System.Drawing.Size(818, 495);
            this.dgvClienti.TabIndex = 2;
            this.dgvClienti.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dgvClienti_CellFormatting);
            this.dgvClienti.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgvClienti_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnAdd.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAdd.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnAdd.Location = new System.Drawing.Point(13, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Nuovo";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 559);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvClienti);
            this.MinimumSize = new System.Drawing.Size(820, 577);
            this.Name = "vClienti";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.vClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dgvClienti;
        private Wisej.Web.BindingSource bsClienti;
        private Wisej.Web.Button btnAdd;
    }
}