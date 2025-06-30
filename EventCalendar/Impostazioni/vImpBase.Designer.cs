namespace EventCalendar.Impostazioni
{
    partial class vImpBase
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
            this.btnSalva = new Wisej.Web.Button();
            this.txtEmail = new Wisej.Web.TextBox();
            this.btnClose = new Wisej.Web.Button();
            this.pBlue1 = new Wisej.Web.Panel();
            this.cboWindow = new Wisej.Web.ComboBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(26, 237);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 37);
            this.btnSalva.TabIndex = 0;
            this.btnSalva.Text = "Salva";
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = Wisej.Web.AnchorStyles.Bottom;
            this.txtEmail.Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(78, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 53);
            this.txtEmail.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(314, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pBlue1
            // 
            this.pBlue1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pBlue1.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.pBlue1.Location = new System.Drawing.Point(37, 120);
            this.pBlue1.Name = "pBlue1";
            this.pBlue1.Size = new System.Drawing.Size(377, 3);
            this.pBlue1.TabIndex = 6;
            // 
            // cboWindow
            // 
            this.cboWindow.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboWindow.Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cboWindow.LabelText = "Selezione all\'avvio";
            this.cboWindow.Location = new System.Drawing.Point(76, 26);
            this.cboWindow.Name = "cboWindow";
            this.cboWindow.Size = new System.Drawing.Size(152, 53);
            this.cboWindow.TabIndex = 7;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // vImpBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 300);
            this.Controls.Add(this.cboWindow);
            this.Controls.Add(this.pBlue1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalva);
            this.MinimumSize = new System.Drawing.Size(445, 349);
            this.Name = "vImpBase";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Impostazioni Base";
            this.Load += new System.EventHandler(this.vImpBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button btnSalva;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.Button btnClose;
        private Wisej.Web.Panel pBlue1;
        private Wisej.Web.ComboBox cboWindow;
        private Wisej.Web.ContextMenu contextMenu1;
    }
}