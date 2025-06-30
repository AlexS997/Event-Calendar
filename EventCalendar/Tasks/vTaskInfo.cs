using EventCalendar.Class;
using EventCalendar.Menu;
using EventCalendar.Search;
using System;
using System.Data;
using Wisej.Web;

namespace EventCalendar.Tasks
{
	public partial class vTaskInfo : Form
	{
        SQLControl connTest = new SQLControl(Global.connTest);
        SQLControl connAna = new SQLControl(Global.connAna);

        public int _iD { get; set; }
        public string _category { get; set; }
        public bool _risolti { get; set; }
        public bool _chiamate { get; set; }


        public vTaskInfo()
		{
			InitializeComponent();
		}


        private void vTaskInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        

        private void LoadData()
        {
            if (_iD != 0)
            {

                string sqlQuery = "";

                if (_risolti == false && _chiamate == false)
                {
                    sqlQuery = "SELECT * FROM Tasks WHERE iD = '" + _iD + "'";
                }
                else if (_risolti == false && _chiamate)
                {
                    sqlQuery = "SELECT * FROM Chiamate WHERE iD = '" + _iD + "'";
                }

                if (_risolti && (_category == "Altro" || _category == "Ferie/Malattia"))
                {
                    sqlQuery = "SELECT * FROM Tasks WHERE iD IN (SELECT iD_Tasks FROM RisoltiChiamate WHERE iD = '" + _iD + "')";
                }
                else if (_risolti)
                {
                    sqlQuery = "SELECT * FROM Chiamate WHERE iD IN (SELECT iD_Chiamate FROM RisoltiChiamate WHERE iD = '" + _iD + "')";
                }


                connTest.ExecQuery(sqlQuery);

                if (connTest.HasException(true))
                {
                    MessageBox.Show(connTest.Exception);
                    return;
                }

                bsTask.DataSource = connTest.DBDT;

                this.Text = connTest.DBDT.Rows[0]["Category"].ToString() + " - Utente Currente: " + Global.Username;
                lblAddInfo.Text = "Inserito da " + connTest.DBDT.Rows[0]["Utente"].ToString() + " in data " + Convert.ToDateTime(connTest.DBDT.Rows[0]["InsertDate"]).ToString("dd/MM/yyyy");

                if (connTest.DBDT.Rows[0]["Category"].ToString() == "Ferie/Malattia" || connTest.DBDT.Rows[0]["Category"].ToString() == "Altro")
                {
                    flpDateTime.Size = new System.Drawing.Size(501, 37);

                    HideOnFerie(false);

                    if(Global.IsAdmin)
                    {
                        cboStato.Enabled = true;
                        cboStato.Items.Clear();
                        cboStato.Items.Add("Richiesta");
                        cboStato.Items.Add("Confermata");
                        cboStato.Items.Add("Annullato");
                        btnConferma.Visible = true;
                    }

                    dtpDate.Value = Convert.ToDateTime(connTest.DBDT.Rows[0]["Start"]);
                    dtpDateEnd.Value = Convert.ToDateTime(connTest.DBDT.Rows[0]["Finish"]);

                    cboStato.Text = connTest.DBDT.Rows[0]["Status"].ToString();
                }
                else
                {

                    if (connTest.DBDT.Rows[0]["Start"] != DBNull.Value)
                    {
                        dtpDate.Value = Convert.ToDateTime(connTest.DBDT.Rows[0]["Start"]);
                    }
                    else
                    {
                        // Handle the case where the Start date is null
                        dtpDate.Value = DateTime.MinValue;
                    }

                    if (connTest.DBDT.Rows[0]["Start"] != DBNull.Value && connTest.DBDT.Rows[0]["Finish"] != DBNull.Value)
                    {
                        cboStart.Text = Convert.ToDateTime(connTest.DBDT.Rows[0]["Start"]).ToString("HH:mm");
                        cboEnd.Text = Convert.ToDateTime(connTest.DBDT.Rows[0]["Finish"]).ToString("HH:mm");
                    }
                    else
                    {
                        cboStart.Text = string.Empty; // or handle the null case appropriately
                        cboEnd.Text = string.Empty; // or handle the null case appropriately
                    }

                    dtpDateEnd.Visible = false;
                    flpDateTime.Size = new System.Drawing.Size(501, 37);

                    cboStato.Text = connTest.DBDT.Rows[0]["Status"].ToString();
                    cboTecnico1.Text = connTest.DBDT.Rows[0]["Dip1"].ToString();
                    cboTecnico2.Text = connTest.DBDT.Rows[0]["Dip2"].ToString();
                    cboAutomezzo.Text = connTest.DBDT.Rows[0]["Automezzo"].ToString();
                }

                //if start date hour is <= 8 and finish date hour >= 17 it means that the task is all day
                if (Convert.ToDateTime(connTest.DBDT.Rows[0]["Start"]).Hour <= 8 && Convert.ToDateTime(connTest.DBDT.Rows[0]["Finish"]).Hour >= 17)
                {
                    chkAllDay.Checked = true;
                }

                txtTipo.Text = connTest.DBDT.Rows[0]["Category"].ToString();
                txtCliente.Text = connTest.DBDT.Rows[0]["Cliente"].ToString();

                chkEffettuato.Checked = connTest.DBDT.Rows[0]["Effettuato"] != DBNull.Value ? Convert.ToBoolean(connTest.DBDT.Rows[0]["Effettuato"]) : false;


                if (_category == "Altro" || _category == "Ferie/Malattia")
                {
                    txtNote.Text = connTest.DBDT.Rows[0]["Description"].ToString();
                }
                else
                {
                    txtEmail.Text = connTest.DBDT.Rows[0]["Email"].ToString();
                    txtTelefono.Text = connTest.DBDT.Rows[0]["Telefono"].ToString();
                    txtNote.Text = connTest.DBDT.Rows[0]["Note"].ToString();
                    chkChiamato.Checked = Convert.ToBoolean(connTest.DBDT.Rows[0]["Chiamato"]);
                }

                //btnConferma.Visible = false;

                if (string.IsNullOrEmpty(cboTecnico1.Text))
                {
                    FillCombo();
                }

                FillComboAutomezzi();
                DisableControls(true);
            }
            else
            {
                this.Text = _category + " - Utente Currente: " + Global.Username;
                lblAddInfo.Text = "";
                dtpDateEnd.Visible = false;
                cboStart.SelectedIndex = 0;
                cboEnd.SelectedIndex = 0;
                txtTipo.Text = _category;
                txtTipo.ReadOnly = true;

                FillComboAutomezzi();
                FillCombo();
                cboTecnico1.SelectedItem = Global.Username;
                cboTecnico1.Enabled = false;
                btnInfo.Enabled = false;
            }
        }


        //a function to hide the controls when the category is "Ferie/Malattia" or "Altro"
        private void HideOnFerie(bool x)
        {
            cboStart.Visible = x;
            cboEnd.Visible = x;
            chkAllDay.Visible = x;
            flowLayoutPanel1.Visible = x;
            chkChiamato.Visible = x;
            chkEffettuato.Visible = x;
            btnConferma.Visible = x;
            cboStato.Enabled = x;
        }


        //Fill the comboboxes with the technicians from the database
        private void FillCombo()
        {
            string queryTecnico = "SELECT * FROM Utenti ORDER BY Nome";
            connTest.ExecQuery(queryTecnico);

            if (connTest.HasException(true))
            {
                MessageBox.Show(connTest.Exception);
                return;
            }

            cboTecnico1.Items.Clear();
            cboTecnico2.Items.Clear();

            cboTecnico1.Items.Add("Seleziona Dipendente");
            cboTecnico2.Items.Add("Seleziona Dipendente");

            foreach (DataRow row in connTest.DBDT.Rows)
            {
                cboTecnico1.Items.Add(row["Nome"].ToString());
                cboTecnico2.Items.Add(row["Nome"].ToString());
            }

            cboTecnico1.SelectedIndex = 0;
            cboTecnico2.SelectedIndex = 0;
        }


        //Fill the combobox with the automezzi from the database
        private void FillComboAutomezzi()
        {
            string queryTecnico = "SELECT * FROM Automezzi ORDER BY Nome";
            connTest.ExecQuery(queryTecnico);

            if (connTest.HasException(true))
            {
                MessageBox.Show(connTest.Exception);
                return;
            }

            cboAutomezzo.Items.Clear();

            cboAutomezzo.Items.Add("Seleziona Automezzo");

            foreach (DataRow row in connTest.DBDT.Rows)
            {
                cboAutomezzo.Items.Add(row["Nome"].ToString());
            }

            //cboAutomezzo.SelectedIndex = 0;
        }


        private void DisableControls(bool x)
        {

            foreach(Control c in flpMain.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
            }

            foreach(Control c in flpDateTime.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Enabled = !x;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = !x;
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Clienti";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show(connAna.Exception);
                return;
            }

            vSearch search = new vSearch();
            search._DT = connAna.DBDT;

            search.ShowDialog();

            var Row = search._ReturnRow;

            if (Row != 0)
            {
                txtCliente.Text = search._DT.Rows[Row]["Denom"].ToString();
                txtTelefono.Text = search._DT.Rows[Row]["Tel"].ToString();
                txtEmail.Text = search._DT.Rows[Row]["Email"].ToString();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool Check()
        {
            bool result = true;

            if (Convert.ToDateTime(cboStart.Text) >= Convert.ToDateTime(cboEnd.Text))
            {
                MessageBox.Show("L'orario di fine deve essere maggiore di quello di inizio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEnd.Focus();

                result = false;
                return result;
            }

            return result;
        }


        //a function to create the start and finish date, based on the selected time in the combobox and the selected date in the datetimepicker
        private void createDateStartFinish(ComboBox cbo, bool isStart)
        {
            try
            {

                if (chkAllDay.Checked == true && isStart == true) //create the start date based on the first time in the cboStart combobox
                {
                    string[] timeParts = cbo.Items[0].ToString().Split(':');
                    int startTimeHour = int.Parse(timeParts[0]);
                    int startTimeMin = int.Parse(timeParts[1]);

                    DateTime selectedDate = dtpDate.Value;

                    DateTime newDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, startTimeHour, startTimeMin, 0);

                    dtpDate.Value = newDateTime;
                }
                else if (chkAllDay.Checked == true && isStart == false) // create the finish date based on the last time in the cboEnd combobox
                {
                    string[] timeParts = cbo.Items[cbo.Items.Count - 1].ToString().Split(':');
                    int startTimeHour = int.Parse(timeParts[0]);
                    int startTimeMin = int.Parse(timeParts[1]);

                    DateTime selectedDate = dtpDate.Value;

                    DateTime newDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, startTimeHour, startTimeMin, 0);

                    dtpDate.Value = newDateTime;
                }
                else //create the start and finish date based on the selected time in the combobox
                {
                    string[] timeParts = cbo.Text.Split(':');
                    int startTimeHour = int.Parse(timeParts[0]);
                    int startTimeMin = int.Parse(timeParts[1]);

                    DateTime selectedDate = dtpDate.Value;

                    DateTime newDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, startTimeHour, startTimeMin, 0);

                    dtpDate.Value = newDateTime;

                }
            }
            catch (Exception)
            {

                return;
            }
        }


        private void btnConferma_Click(object sender, EventArgs e)
        {

            // this if happens when the Admin confirms the task inserted by an user
            if (_risolti == false && _chiamate == false)
            {
                string query = "UPDATE Tasks SET Status = @Status WHERE iD = @iD";

                connTest.AddParam("@iD", _iD);
                connTest.AddParam("@Status", cboStato.Text);

                connTest.ExecQuery(query);

                if (connTest.HasException(true))
                {
                    MessageBox.Show(connTest.Exception);
                    return;
                }

                MessageBox.Show("Elemento modificato correttamente.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            { 

                if (Check() == false)
                {
                    return;
                }

                string query = "";

                if (_iD == 0)
                {

                    query = "Insert into Chiamate (Category, Cliente, Telefono, Email, Note, Utente, InsertDate, Start, Finish, Chiamato, Status, Effettuato) " +
                        "Values (@Category, @Cliente, @Telefono, @Email, @Note, @Utente, @InsertDate, @Start, @Finish, @Chiamato, @Status, @Effettuato)";

                    connTest.AddParam("@Category", txtTipo.Text);
                    connTest.AddParam("@Cliente", txtCliente.Text);
                    connTest.AddParam("@Telefono", txtTelefono.Text);
                    connTest.AddParam("@Email", txtEmail.Text);
                    connTest.AddParam("@Note", txtNote.Text);
                    connTest.AddParam("@Utente", Global.Username);
                    connTest.AddParam("@InsertDate", DateTime.Now);
                    //connTest.AddParam("@Text", cboTecnico1.Text);

                    createDateStartFinish(cboStart, true);
                    connTest.AddParam("@Start", dtpDate.Value);
                    createDateStartFinish(cboEnd, false);
                    connTest.AddParam("@Finish", dtpDate.Value);

                    connTest.AddParam("@Effettuato", chkEffettuato.Checked);
                    connTest.AddParam("@Chiamato", chkChiamato.Checked);
                    connTest.AddParam("@Status", cboStato.Text);

                    connTest.ExecQuery(query);

                    if (connTest.HasException(true))
                    {
                        MessageBox.Show(connTest.Exception);
                        return;
                    }

                    MessageBox.Show("Inserito correttamente.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {


                    if(_risolti)
                    {
                        query = "SELECT * FROM Chiamate WHERE iD IN (SELECT iD_Chiamate FROM RisoltiChiamate WHERE iD = '" + _iD + "')";

                        connTest.ExecQuery(query);

                        if (!connTest.HasException(true) && connTest.DBDT.Rows.Count > 0)
                        {
                            _iD = Convert.ToInt32(connTest.DBDT.Rows[0]["iD"]);
                        }

                        connTest.AddParam("@iD", _iD);
                    }
                    else
                    {
                        connTest.AddParam("@iD", _iD);
                    }

                    query = "UPDATE Chiamate SET Note = @Note, Status = @Status, Chiamato = @Chiamato, Effettuato = @Effettuato WHERE iD = @iD";
                    
                    connTest.AddParam("@Chiamato", chkChiamato.Checked);
                    connTest.AddParam("@Effettuato", chkEffettuato.Checked);
                    connTest.AddParam("@Status", cboStato.Text);
                    connTest.AddParam("@Note", txtNote.Text);

                    connTest.ExecQuery(query);

                    if (connTest.HasException(true))
                    {
                        MessageBox.Show(connTest.Exception);
                        return;
                    }

                    MessageBox.Show("Elemento modificato correttamente.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if(_risolti)
                    {

                    }
                }

            }


            // Ricarica la MainPage
            MainPage mainPage = (MainPage)Application.OpenForms["MainPage"];
            if (mainPage != null)
            {
                mainPage.btnAggiorna_Click(sender, e);
            }


            // ricaricare le informazioni da vRisolti
            if (_risolti)
            {
                // Ricarica il form vRisolti
                vRisolti vRisoltiForm = (vRisolti)Application.OpenForms["vRisolti"];
                if (vRisoltiForm != null)
                {
                    vRisoltiForm.LoadData();
                }
            }

            this.Close();

        }


        private void chkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllDay.Checked)
            {
                cboStart.SelectedIndex = 0;
                cboStart.Enabled = false;
                cboEnd.SelectedIndex = cboEnd.Items.Count - 1;
                cboEnd.Enabled = false;
            }
            else
            {
                cboStart.SelectedIndex = 0;
                cboEnd.SelectedIndex = 0;
                cboStart.Enabled = true;
                cboEnd.Enabled = true;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            vSearch search = new vSearch();
            search._Name = txtCliente.Text;
            search.ShowDialog();
        }
    }
}
