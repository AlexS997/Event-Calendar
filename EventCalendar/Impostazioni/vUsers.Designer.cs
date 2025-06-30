namespace EventCalendar.Impostazioni
{
    partial class vUsers
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
            this.txtUser = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtNome = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.bindingNavigator = new Wisej.Web.BindingNavigator(this.components);
            this.btnAdd = new Wisej.Web.Button();
            this.bsUtenti = new Wisej.Web.BindingSource(this.components);
            this.btnFirst = new Wisej.Web.Button();
            this.btnPreviews = new Wisej.Web.Button();
            this.separatorLeft = new Wisej.Web.Line();
            this.textBoxPosition = new Wisej.Web.TextBox();
            this.labelCount = new Wisej.Web.Label();
            this.separatorRight = new Wisej.Web.Line();
            this.btnNext = new Wisej.Web.Button();
            this.btnLast = new Wisej.Web.Button();
            this.separatorControl = new Wisej.Web.Line();
            this.btnEdit = new Wisej.Web.Button();
            this.btnSave = new Wisej.Web.Button();
            this.btnUndo = new Wisej.Web.Button();
            this.btnRefresh = new Wisej.Web.Button();
            this.btnDelete = new Wisej.Web.Button();
            this.txtId = new Wisej.Web.TextBox();
            this.chkAdmin = new Wisej.Web.CheckBox();
            this.chkSuperuser = new Wisej.Web.CheckBox();
            this.chkActive = new Wisej.Web.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtUser.LabelText = "Username";
            this.txtUser.Location = new System.Drawing.Point(38, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(281, 53);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(343, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(305, 53);
            this.txtPassword.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtNome.LabelText = "Nome";
            this.txtNome.Location = new System.Drawing.Point(38, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 53);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Label.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Label.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.txtEmail.LabelText = "Email";
            this.txtEmail.Location = new System.Drawing.Point(343, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 53);
            this.txtEmail.TabIndex = 3;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.btnAdd;
            this.bindingNavigator.AutoSize = true;
            this.bindingNavigator.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.bindingNavigator.BindingSource = this.bsUtenti;
            this.bindingNavigator.Controls.Add(this.btnFirst);
            this.bindingNavigator.Controls.Add(this.btnPreviews);
            this.bindingNavigator.Controls.Add(this.separatorLeft);
            this.bindingNavigator.Controls.Add(this.textBoxPosition);
            this.bindingNavigator.Controls.Add(this.labelCount);
            this.bindingNavigator.Controls.Add(this.separatorRight);
            this.bindingNavigator.Controls.Add(this.btnNext);
            this.bindingNavigator.Controls.Add(this.btnLast);
            this.bindingNavigator.Controls.Add(this.separatorControl);
            this.bindingNavigator.Controls.Add(this.btnAdd);
            this.bindingNavigator.Controls.Add(this.btnEdit);
            this.bindingNavigator.Controls.Add(this.btnSave);
            this.bindingNavigator.Controls.Add(this.btnUndo);
            this.bindingNavigator.Controls.Add(this.btnRefresh);
            this.bindingNavigator.Controls.Add(this.btnDelete);
            this.bindingNavigator.CountItem = this.labelCount;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = Wisej.Web.DockStyle.Bottom;
            this.bindingNavigator.Location = new System.Drawing.Point(0, 373);
            this.bindingNavigator.MoveFirstItem = this.btnFirst;
            this.bindingNavigator.MoveLastItem = this.btnLast;
            this.bindingNavigator.MoveNextItem = this.btnNext;
            this.bindingNavigator.MovePreviousItem = this.btnPreviews;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.textBoxPosition;
            this.bindingNavigator.Size = new System.Drawing.Size(685, 34);
            this.bindingNavigator.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageSource = "table-row-new";
            this.btnAdd.Location = new System.Drawing.Point(336, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.ToolTipText = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bsUtenti
            // 
            this.bsUtenti.DataSource = typeof(EventCalendar.TableClass.TableUtenti);
            // 
            // btnFirst
            // 
            this.btnFirst.ImageSource = "icon-first";
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(37, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.ToolTipText = "First";
            // 
            // btnPreviews
            // 
            this.btnPreviews.ImageSource = "icon-left";
            this.btnPreviews.Location = new System.Drawing.Point(46, 3);
            this.btnPreviews.Name = "btnPreviews";
            this.btnPreviews.Size = new System.Drawing.Size(37, 28);
            this.btnPreviews.TabIndex = 1;
            this.btnPreviews.ToolTipText = "Prev";
            // 
            // separatorLeft
            // 
            this.separatorLeft.Location = new System.Drawing.Point(89, 3);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorLeft.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorLeft.Size = new System.Drawing.Size(14, 28);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.AutoSize = false;
            this.textBoxPosition.Location = new System.Drawing.Point(109, 3);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(50, 28);
            this.textBoxPosition.TabIndex = 6;
            this.textBoxPosition.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.Location = new System.Drawing.Point(165, 3);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 28);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "di {0}";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorRight
            // 
            this.separatorRight.Location = new System.Drawing.Point(210, 3);
            this.separatorRight.Name = "separatorRight";
            this.separatorRight.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorRight.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorRight.Size = new System.Drawing.Size(14, 28);
            // 
            // btnNext
            // 
            this.btnNext.ImageSource = "icon-right";
            this.btnNext.Location = new System.Drawing.Point(230, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.ToolTipText = "Next";
            // 
            // btnLast
            // 
            this.btnLast.ImageSource = "icon-last";
            this.btnLast.Location = new System.Drawing.Point(273, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 28);
            this.btnLast.TabIndex = 3;
            this.btnLast.ToolTipText = "Last";
            // 
            // separatorControl
            // 
            this.separatorControl.Location = new System.Drawing.Point(316, 3);
            this.separatorControl.Name = "separatorControl";
            this.separatorControl.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorControl.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorControl.Size = new System.Drawing.Size(14, 28);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageSource = "table-row-editing";
            this.btnEdit.Location = new System.Drawing.Point(379, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 28);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageSource = "Resources\\check.png";
            this.btnSave.Location = new System.Drawing.Point(422, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.ToolTipText = "Salva";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.ImageSource = "icon-undo";
            this.btnUndo.Location = new System.Drawing.Point(465, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(37, 28);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.ToolTipText = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageSource = "icon-refresh";
            this.btnRefresh.Location = new System.Drawing.Point(508, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 28);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageSource = "icon-close";
            this.btnDelete.Location = new System.Drawing.Point(551, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(582, 337);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 5;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = false;
            this.chkAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAdmin.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.chkAdmin.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.chkAdmin.Location = new System.Drawing.Point(38, 202);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(100, 23);
            this.chkAdmin.TabIndex = 6;
            this.chkAdmin.Text = "Admin";
            // 
            // chkSuperuser
            // 
            this.chkSuperuser.AutoSize = false;
            this.chkSuperuser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSuperuser.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.chkSuperuser.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.chkSuperuser.Location = new System.Drawing.Point(38, 282);
            this.chkSuperuser.Name = "chkSuperuser";
            this.chkSuperuser.Size = new System.Drawing.Size(100, 23);
            this.chkSuperuser.TabIndex = 7;
            this.chkSuperuser.Text = "Superuser";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = false;
            this.chkActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActive.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.chkActive.ForeColor = System.Drawing.Color.FromName("@activeCaption");
            this.chkActive.Location = new System.Drawing.Point(38, 241);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(100, 23);
            this.chkActive.TabIndex = 8;
            this.chkActive.Text = "Active";
            // 
            // vUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 407);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkSuperuser);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 456);
            this.Name = "vUsers";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.vUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtUser;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtNome;
        private Wisej.Web.TextBox txtEmail;
        private Wisej.Web.BindingSource bsUtenti;
        private Wisej.Web.BindingNavigator bindingNavigator;
        private Wisej.Web.Button btnAdd;
        private Wisej.Web.Button btnFirst;
        private Wisej.Web.Button btnPreviews;
        private Wisej.Web.Line separatorLeft;
        private Wisej.Web.TextBox textBoxPosition;
        private Wisej.Web.Label labelCount;
        private Wisej.Web.Line separatorRight;
        private Wisej.Web.Button btnNext;
        private Wisej.Web.Button btnLast;
        private Wisej.Web.Line separatorControl;
        private Wisej.Web.Button btnDelete;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.TextBox txtId;
        private Wisej.Web.Button btnEdit;
        private Wisej.Web.Button btnUndo;
        private Wisej.Web.CheckBox chkAdmin;
        private Wisej.Web.CheckBox chkSuperuser;
        private Wisej.Web.CheckBox chkActive;
        private Wisej.Web.Button btnRefresh;
    }
}