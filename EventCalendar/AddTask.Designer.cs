namespace EventCalendar
{
    partial class AddTask
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
            this.dtpStart = new Wisej.Web.DateTimePicker();
            this.bsTasks = new Wisej.Web.BindingSource(this.components);
            this.dtpFinish = new Wisej.Web.DateTimePicker();
            this.txtDescription = new Wisej.Web.TextBox();
            this.btnSave = new Wisej.Web.Button();
            this.cboHourStart = new Wisej.Web.ComboBox();
            this.cboMinStart = new Wisej.Web.ComboBox();
            this.cboHourFinish = new Wisej.Web.ComboBox();
            this.cboMinFinish = new Wisej.Web.ComboBox();
            this.cboStato = new Wisej.Web.ComboBox();
            this.chkTG = new Wisej.Web.CheckBox();
            this.txtCategory = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.DataBindings.Add(new Wisej.Web.Binding("Value", this.bsTasks, "Start", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.dtpStart.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpStart.LabelText = "Start";
            this.dtpStart.Location = new System.Drawing.Point(48, 195);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 53);
            this.dtpStart.TabIndex = 3;
            // 
            // bsTasks
            // 
            this.bsTasks.DataSource = typeof(EventCalendar.TableClass.TableTasks);
            // 
            // dtpFinish
            // 
            this.dtpFinish.DataBindings.Add(new Wisej.Web.Binding("Value", this.bsTasks, "Finish", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.dtpFinish.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtpFinish.LabelText = "Finish";
            this.dtpFinish.Location = new System.Drawing.Point(48, 283);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(160, 53);
            this.dtpFinish.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Description", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.txtDescription.LabelText = "Description";
            this.txtDescription.Location = new System.Drawing.Point(48, 110);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(452, 53);
            this.txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboHourStart
            // 
            this.cboHourStart.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Category", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboHourStart.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboHourStart.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cboHourStart.LabelText = "Hour";
            this.cboHourStart.Location = new System.Drawing.Point(236, 195);
            this.cboHourStart.Name = "cboHourStart";
            this.cboHourStart.Size = new System.Drawing.Size(71, 53);
            this.cboHourStart.TabIndex = 4;
            // 
            // cboMinStart
            // 
            this.cboMinStart.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Category", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboMinStart.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboMinStart.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cboMinStart.LabelText = "Min";
            this.cboMinStart.Location = new System.Drawing.Point(325, 195);
            this.cboMinStart.Name = "cboMinStart";
            this.cboMinStart.Size = new System.Drawing.Size(71, 53);
            this.cboMinStart.TabIndex = 5;
            // 
            // cboHourFinish
            // 
            this.cboHourFinish.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Category", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboHourFinish.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboHourFinish.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cboHourFinish.LabelText = "Hour";
            this.cboHourFinish.Location = new System.Drawing.Point(236, 283);
            this.cboHourFinish.Name = "cboHourFinish";
            this.cboHourFinish.Size = new System.Drawing.Size(71, 53);
            this.cboHourFinish.TabIndex = 7;
            // 
            // cboMinFinish
            // 
            this.cboMinFinish.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Category", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboMinFinish.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboMinFinish.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cboMinFinish.LabelText = "Min";
            this.cboMinFinish.Location = new System.Drawing.Point(325, 283);
            this.cboMinFinish.Name = "cboMinFinish";
            this.cboMinFinish.Size = new System.Drawing.Size(71, 53);
            this.cboMinFinish.TabIndex = 8;
            // 
            // cboStato
            // 
            this.cboStato.DataBindings.Add(new Wisej.Web.Binding("Text", this.bsTasks, "Text", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.cboStato.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cboStato.Items.AddRange(new object[] {
            "Richiesta",
            "Confermata",
            "Annullato"});
            this.cboStato.LabelText = "Stato";
            this.cboStato.Location = new System.Drawing.Point(288, 30);
            this.cboStato.Name = "cboStato";
            this.cboStato.Size = new System.Drawing.Size(212, 53);
            this.cboStato.TabIndex = 1;
            // 
            // chkTG
            // 
            this.chkTG.Location = new System.Drawing.Point(48, 371);
            this.chkTG.Name = "chkTG";
            this.chkTG.Size = new System.Drawing.Size(114, 23);
            this.chkTG.TabIndex = 9;
            this.chkTG.Text = "Tutto il Giorno";
            this.chkTG.CheckStateChanged += new System.EventHandler(this.chkTG_CheckStateChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.LabelText = "Category";
            this.txtCategory.Location = new System.Drawing.Point(48, 31);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(224, 53);
            this.txtCategory.TabIndex = 0;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 423);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.chkTG);
            this.Controls.Add(this.cboStato);
            this.Controls.Add(this.cboMinFinish);
            this.Controls.Add(this.cboHourFinish);
            this.Controls.Add(this.cboMinStart);
            this.Controls.Add(this.cboHourStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
            this.MinimumSize = new System.Drawing.Size(554, 472);
            this.Name = "AddTask";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DateTimePicker dtpStart;
        private Wisej.Web.DateTimePicker dtpFinish;
        private Wisej.Web.TextBox txtDescription;
        private Wisej.Web.BindingSource bsTasks;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.ComboBox cboHourStart;
        private Wisej.Web.ComboBox cboMinStart;
        private Wisej.Web.ComboBox cboHourFinish;
        private Wisej.Web.ComboBox cboMinFinish;
        private Wisej.Web.ComboBox cboStato;
        private Wisej.Web.CheckBox chkTG;
        private Wisej.Web.TextBox txtCategory;
    }
}