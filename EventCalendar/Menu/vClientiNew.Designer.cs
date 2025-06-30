namespace EventCalendar.Menu
{
    partial class vClientiNew
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
            this.txtDenom = new Wisej.Web.TextBox();
            this.txtInd = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtProv = new Wisej.Web.TextBox();
            this.txtCF = new Wisej.Web.TextBox();
            this.txtNote = new Wisej.Web.TextBox();
            this.txtLoc = new Wisej.Web.TextBox();
            this.txtCap = new Wisej.Web.TextBox();
            this.txtPIva = new Wisej.Web.TextBox();
            this.txtTel = new Wisej.Web.TextBox();
            this.btnSalva = new Wisej.Web.Button();
            this.btnClose = new Wisej.Web.Button();
            this.bsClienti = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenom
            // 
            this.txtDenom.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Denom", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtDenom.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtDenom.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtDenom.LabelText = "Denom";
            this.txtDenom.Location = new System.Drawing.Point(26, 28);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.Size = new System.Drawing.Size(341, 53);
            this.txtDenom.TabIndex = 0;
            // 
            // txtInd
            // 
            this.txtInd.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Ind", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtInd.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtInd.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtInd.LabelText = "Ind";
            this.txtInd.Location = new System.Drawing.Point(26, 92);
            this.txtInd.Name = "txtInd";
            this.txtInd.Size = new System.Drawing.Size(341, 53);
            this.txtInd.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "EMail", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtEmail.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(384, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 53);
            this.txtEmail.TabIndex = 1;
            // 
            // txtProv
            // 
            this.txtProv.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Prov", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtProv.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtProv.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtProv.LabelText = "Prov";
            this.txtProv.Location = new System.Drawing.Point(384, 166);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(72, 53);
            this.txtProv.TabIndex = 5;
            // 
            // txtCF
            // 
            this.txtCF.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtCF.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "CF", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtCF.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCF.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtCF.LabelText = "C. Fiscale";
            this.txtCF.Location = new System.Drawing.Point(198, 245);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(169, 53);
            this.txtCF.TabIndex = 8;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtNote.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Note", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtNote.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtNote.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtNote.LabelText = "Note";
            this.txtNote.Location = new System.Drawing.Point(26, 319);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(669, 118);
            this.txtNote.TabIndex = 9;
            // 
            // txtLoc
            // 
            this.txtLoc.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Loc", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtLoc.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoc.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtLoc.LabelText = "Loc";
            this.txtLoc.Location = new System.Drawing.Point(159, 166);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(208, 53);
            this.txtLoc.TabIndex = 4;
            // 
            // txtCap
            // 
            this.txtCap.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Cap", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtCap.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCap.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtCap.LabelText = "Cap";
            this.txtCap.Location = new System.Drawing.Point(26, 166);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(117, 53);
            this.txtCap.TabIndex = 6;
            // 
            // txtPIva
            // 
            this.txtPIva.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "PIva", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtPIva.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPIva.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtPIva.LabelText = "P. IVA";
            this.txtPIva.Location = new System.Drawing.Point(26, 245);
            this.txtPIva.Name = "txtPIva";
            this.txtPIva.Size = new System.Drawing.Size(154, 53);
            this.txtPIva.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsClienti, "Tel", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtTel.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTel.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtTel.LabelText = "Telefono";
            this.txtTel.Location = new System.Drawing.Point(384, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(311, 53);
            this.txtTel.TabIndex = 3;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnSalva.BackColor = System.Drawing.Color.FromName("@success");
            this.btnSalva.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSalva.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnSalva.Location = new System.Drawing.Point(26, 483);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(80, 37);
            this.btnSalva.TabIndex = 10;
            this.btnSalva.Text = "Salva";
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.btnClose.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClose.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnClose.Location = new System.Drawing.Point(615, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Chiudi";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bsClienti
            // 
            this.bsClienti.DataSource = typeof(EventCalendar.TableClass.TableClienti);
            // 
            // vClientiNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 543);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPIva);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtInd);
            this.Controls.Add(this.txtDenom);
            this.MinimumSize = new System.Drawing.Size(722, 592);
            this.Name = "vClientiNew";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "New Client";
            this.Load += new System.EventHandler(this.vClientiNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtDenom;
        private Wisej.Web.TextBox txtInd;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.TextBox txtProv;
        private Wisej.Web.TextBox txtCF;
        private Wisej.Web.TextBox txtNote;
        private Wisej.Web.TextBox txtLoc;
        private Wisej.Web.TextBox txtCap;
        private Wisej.Web.TextBox txtPIva;
        private Wisej.Web.TextBox txtTel;
        private Wisej.Web.Button btnSalva;
        private Wisej.Web.Button btnClose;
        private Wisej.Web.BindingSource bsClienti;
    }
}