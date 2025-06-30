using EventCalendar.Class;
using System;
using System.Data;
using System.Linq;
using Wisej.Web;

namespace EventCalendar.Impostazioni
{
	public partial class vUsers : Form
	{

		SQLControl conn = new SQLControl(Global.connTest);
        ButtonManager _buttonManager;

        // Declare a string variable to store the name of the table
        public string Table = "Utenti";

        // Declare a ClsTableSchema object
        private ClsTableSchema _tableSchema;



        public vUsers()
		{
			InitializeComponent();
            
            AbinaCampi();



            // Initialize ClsTableSchema with the connection and name of the table
            _tableSchema = new ClsTableSchema(Global.connTest, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);



            _buttonManager = new ButtonManager(bindingNavigator);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }


        private void vUsers_Load(object sender, EventArgs e)
        {
			LoadData();

            txtId.Visible = false;
        }


		private void LoadData()
		{
			string query = "Select * from Utenti";
            conn.ExecQuery(query);

			if (conn.HasException(true))
			{
                MessageBox.Show("Errore nel caricamento dei dati");
                return;
            }

            if (conn.DBDT.Rows.Count > 0)
            {
                LegiCampi(conn.DBDT);
            }

            bsUtenti.DataSource = conn.DBDT;

            ReadonlyControls(false);
        }


        private void LegiCampi(DataTable dt) 
        {
            txtId.Text = dt.Rows[0]["iD"].ToString();
            txtUser.Text = dt.Rows[0]["Username"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
            txtNome.Text = dt.Rows[0]["Nome"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();

            chkActive.Checked = Convert.ToBoolean(dt.Rows[0]["isActive"]);
            chkSuperuser.Checked = Convert.ToBoolean(dt.Rows[0]["isSuperUser"]);
            chkAdmin.Checked = Convert.ToBoolean(dt.Rows[0]["isAdministrator"]);
        }


        private void AbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsUtenti, "iD");
            txtUser.DataBindings.Add("Text", bsUtenti, "Username");
            txtPassword.DataBindings.Add("Text", bsUtenti, "Password");
            txtNome.DataBindings.Add("Text", bsUtenti, "Nome");
            txtEmail.DataBindings.Add("Text", bsUtenti, "Email");

            chkActive.DataBindings.Add("Checked", bsUtenti, "isActive");
            chkSuperuser.DataBindings.Add("Checked", bsUtenti, "isSuperUser");
            chkAdmin.DataBindings.Add("Checked", bsUtenti, "isAdministrator");

        }


        private void ReadonlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = x;
                }

                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = x;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            ReadonlyControls(true);
        }


        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }

                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }


        //a function to check if the password is valid
        private bool checkPassword()
        {
            bool result = true;

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("La password deve essere di almeno 8 caratteri.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                result = false;
                return result;
            }

            if (!txtPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La password deve contenere almeno un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                result = false;
                return result;
            }

            if (!txtPassword.Text.Any(char.IsUpper))
            {
                MessageBox.Show("La password deve contenere almeno una lettera maiuscola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                result = false;
                return result;
            }

            if (!txtPassword.Text.Any(char.IsSymbol) && !txtPassword.Text.Any(char.IsPunctuation))
            {
                MessageBox.Show("La password deve contenere almeno un simbolo tra quelli ammessi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                result = false;
                return result;
            }

            // la password non deve contenere il nome dell'utente
            if (txtPassword.Text.Contains(txtUser.Text))
            {
                MessageBox.Show("La password non deve contenere il nome utente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                result = false;
                return result;
            }

            // la password deve contenere almeno un carattere minuscolo
            if (!txtPassword.Text.Any(char.IsLower))
            {
                MessageBox.Show("La password deve contenere almeno una lettera minuscola.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;

                return result;
            }

            return result;
        }


        private bool Check()
        {
            bool result = true;

            if(string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Il campo Username è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                
                result = false;
                return result;
            }


            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Il campo Password è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();

                result = false;
                return result;
            }


            // check password validation
            if (checkPassword() == false)
            {
                result = false;
                return result;
            }


            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Il campo Nome è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

                result = false;
                return result;
            }


            // Check Email Format
            CheckEmail checkEmail = new CheckEmail();
            if (checkEmail.IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Formato Email non valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                result = false;
                return result;
            }

            return result;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }


            string query = "";

            if (txtId.Text == "")
            {
                query = "Insert into Utenti (Username, Password, Nome, Email, isActive, isSuperUser, isAdministrator, StartWindows) " +
                    "values (@Username, @Password, @Nome, @Email, @isActive, @isSuperUser, @isAdministrator, @StartWindows)";
            }
            else
            {
                query = "Update Utenti set Username = @Username, Password = @Password, Nome = @Nome, Email = @Email, isActive = @isActive, " +
                    "isSuperUser = @isSuperUser, isAdministrator = @isAdministrator where iD = @iD";
            }

            conn.AddParam("@iD", txtId.Text);
            conn.AddParam("@Username", txtUser.Text);
            conn.AddParam("@Password", txtPassword.Text);
            conn.AddParam("@Nome", txtNome.Text);
            conn.AddParam("@Email", txtEmail.Text);
            conn.AddParam("@isActive", chkActive.Checked);
            conn.AddParam("@isSuperUser", chkSuperuser.Checked);
            conn.AddParam("@isAdministrator", chkAdmin.Checked);
            conn.AddParam("@StartWindows", "Planning");

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati");
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadonlyControls(true);
        }


        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text); //bsUtenti.Find("iD", _iDUtente);
                ClearFields();
                LoadData();
                //bsUtenti.Position = pos;
                bsUtenti.Find("iD", pos);
            }
            else
            {
                LoadData();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete from Utenti where iD = @iD";
            conn.AddParam("@iD", txtId.Text);
            conn.ExecQuery(query);

            if (conn.HasException(true)) {
                MessageBox.Show("Errore nell'eliminazione dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
