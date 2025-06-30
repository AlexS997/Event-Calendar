using EventCalendar.Class;
using Microsoft.Ajax.Utilities;
using System;
using Wisej.Web;

namespace EventCalendar
{
    public partial class AddTask : Form
    {
        SQLControl conn = new SQLControl(Global.connTest);

        public string _category { get; set; }

        public AddTask()
        {
            InitializeComponent();
        }


        private void AddTask_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            txtCategory.Text = _category;
            txtCategory.ReadOnly = true;

            cboHourStart.SelectedIndex = 0;
            cboMinStart.SelectedIndex = 0;
            cboHourFinish.SelectedIndex = 0;
            cboMinFinish.SelectedIndex = 0;

            if (Global.IsAdmin == false)
            {
                //for cboStato add only the first item
                cboStato.Items.Clear();
                cboStato.Items.Add("Richiesta");
            }
        }

        private bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(cboStato.Text))
            {
                MessageBox.Show("Il campo Stato è obbligatorio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStato.Focus();
                result = false;

                return result;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Il campo Descrizione è obbligatorio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                result = false;

                return result;
            }

            //if createStartDate() > createEndDate() show error
            if (dtpStart.Value >= dtpFinish.Value)
            {
                MessageBox.Show("La data di inizio non può essere uguale o maggiore della data di fine.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStart.Focus();
                result = false;

                return result;
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            createStartDate();
            createEndDate();

            if (Check() == false)
            {
                return;
            }

            string query = @"INSERT INTO Tasks (Text, Description, Category, Start, Finish, Utente, InsertDate, Status) VALUES 
                            (@Text, @Description, @Category, @Start, @Finish, @Utente, @InsertDate, @Status)";


            conn.AddParam("@Text", txtDescription.Text);
            conn.AddParam("@Description", txtDescription.Text);
            conn.AddParam("@Category", txtCategory.Text);
            conn.AddParam("@Start", dtpStart.Value);
            conn.AddParam("@Finish", dtpFinish.Value);
            conn.AddParam("@Utente", Global.Username);
            conn.AddParam("@InsertDate", DateTime.Now);
            conn.AddParam("@Status", cboStato.Text);

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show("Error");
                return;
            }

            MessageBox.Show("Event saved");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void createStartDate()
        {
            try
            {
                int hour = int.Parse(cboHourStart.Text);
                int minute = int.Parse(cboMinStart.Text);

                DateTime selectedDate = dtpStart.Value;

                // Create a new DateTime with values from cboHourStart and cboMinStart
                DateTime newDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, minute, 0);

                dtpStart.Value = newDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }

        }

        private void createEndDate()
        {
            try
            {
                int hour = int.Parse(cboHourFinish.Text);
                int minute = int.Parse(cboMinFinish.Text);

                DateTime selectedDate = dtpFinish.Value;

                // Create a new DateTime with values from cboHourFinish and cboMinFinish
                DateTime newDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, minute, 0);

                dtpFinish.Value = newDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void chkTG_CheckStateChanged(object sender, EventArgs e)
        {
            //set whole day task
            if (chkTG.Checked)
            {
                cboHourStart.Text = cboHourStart.Items[0].ToString();
                cboMinStart.Text = "30";

                //for cboHourFinish.Text add the last item from the list
                cboHourFinish.Text = cboHourFinish.Items[cboHourFinish.Items.Count - 1].ToString();
                cboMinFinish.Text = "30";

                DisableCntrols(true);

            }
            else
            {
                DisableCntrols(false);
            }
        }

        private void DisableCntrols(bool x)
        {
            foreach(Control c in this.Controls)
            {
                if(c is ComboBox && c.Name != "cboStato")
                {
                    ((ComboBox)c).Enabled = !x;
                }
            }
        }
    }
}
