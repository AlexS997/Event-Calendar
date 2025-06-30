using EventCalendar.Class;
using EventCalendar.Menu;
using System;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar
{
    public partial class vLogin : Form
    {
        public AppConfiguration AppConfiguration { get; set; } = new AppConfiguration();

        public vLogin()
        {
            InitializeComponent();

            string ConfigFile = Application.StartupPath + @"\Appconfiguration.json";
            // controlla se il file esiste se non esiste esce dal programma
            if (!System.IO.File.Exists(ConfigFile))
            {
                MessageBox.Show("File di configurazione non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                //carica configurazzione
                if (!AppConfiguration.CaricaConfigurazione(ConfigFile))
                {
                    MessageBox.Show("Errore nel caricamento del file di configurazione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            pFooter.BackColor = Color.FromArgb(100, 100, 100, (int)0.61);

            lblFooter.Text = "© " + DateTime.Now.Year + " Etruria Wi-Fi S.r.l.";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Inserisci il tuo nome utente e la tua password.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQLControl sqlControl = new SQLControl(Global.connTest);
                string sqlQuery = "SELECT * FROM Utenti WHERE Username = @Username AND Password = @Password";

                sqlControl.AddParam("@Username", txtUser.Text);
                sqlControl.AddParam("@Password", txtPassword.Text);
                sqlControl.ExecQuery(sqlQuery);

                if (sqlControl.HasException(true))
                {
                    MessageBox.Show("Errore durante il login", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (sqlControl.RecordCount > 0)
                {
                    Global.Username = sqlControl.DBDT.Rows[0]["Username"].ToString();
                    Global.Password = sqlControl.DBDT.Rows[0]["Password"].ToString();
                    Global.iD = sqlControl.DBDT.Rows[0]["iD"].ToString();
                    Global.Nome = sqlControl.DBDT.Rows[0]["Nome"].ToString();
                    Global.Email = sqlControl.DBDT.Rows[0]["Email"].ToString();
                    Global.IsSuperUser = (bool)sqlControl.DBDT.Rows[0]["isSuperUser"];
                    Global.IsAdmin = (bool)sqlControl.DBDT.Rows[0]["isAdministrator"];
                    Global.IsActive = (bool)sqlControl.DBDT.Rows[0]["isActive"];
                    Global.Window = sqlControl.DBDT.Rows[0]["StartWindows"].ToString();

                    if (Global.IsActive == false)
                    {
                        MessageBox.Show("Utente non attivo, non è possibile continuare");
                        txtPassword.Text = "";
                        txtUser.Text = "";
                        txtUser.Focus();
                        return;
                    }

                    MainPage planningForm = new MainPage();
                    planningForm.Show();


                    /* ------ Open Custom Window by User ------ */
                    if (Global.Window == "Planning")
                    {                        
                        this.Close();
                    }
                    else if (Global.Window == "Impostazioni")
                    {
                        vImpostazioni impostazioniForm = new vImpostazioni();
                        impostazioniForm.Show();
                        this.Close();
                    }
                    else if (Global.Window == "VoIP")
                    {
                        vVoIP voipForm = new vVoIP();
                        voipForm.Show();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                    txtPassword.Text = "";
                    txtUser.Text = "";
                }

            }
        }

        // Enter key press
        private void vLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        //hide or show password
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                pbAvatar.Image = Properties.Resources.eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                pbAvatar.Image = Properties.Resources.eye_open;
            }
        }
    }
}
