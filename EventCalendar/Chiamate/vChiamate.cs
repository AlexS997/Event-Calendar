using EventCalendar.Class;
using EventCalendar.Search;
using System;
using System.Data;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar.Chiamate
{
    public partial class vChiamate : Form
    {

        SQLControl Chiamate = new SQLControl(Global.connTest);
        SQLControl ClientiKing = new SQLControl(Global.connAna);

        internal string _Btn = "";
        
        private void dgvChiamate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }

        public vChiamate()
        {
            InitializeComponent();
        }

        private void vChiamate_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowPanel2Components(false);
            chkAllDay.CheckedChanged += chkAllDay_CheckedChanged;
            txtId.Visible = false;
        }

        private void LoadData()
        {
            string query = "";

            if (_Btn == "btnChiamate")
            {
                query = "Select * from Chiamate where Start IS NULL order by InsertDate";
            }
            else if(_Btn == "btnDisdetta")
            {
                //clear and fill cboTipo with element "Disdetta"
                cboTipo.Items.Clear();
                cboTipo.Items.Add("Disdetta");

                query = "Select * from Disdette";
            }
            else if(_Btn == "btnSospesi")
            {
                query = "Select * from Tasks order by Start";
            }

            Chiamate.ExecQuery(query);

            if (Chiamate.HasException(true))
            {
                MessageBox.Show(Chiamate.Exception);
                return;
            }

            bsEvents.DataSource = Chiamate.DBDT;
            dgvChiamate.DataSource = bsEvents;

            hideColumn("Utente");
            hideColumn("InsertDate");
            hideColumn("ID");

            FillCombo();
            FillComboAutomezzi();
        }

        //a function to hide a column in the datagridview
        private void hideColumn(string columnName)
        {
            if (dgvChiamate.Columns.Contains(columnName))
            {
                dgvChiamate.Columns[columnName].Visible = false;
            }
        }

        // function to fill the combobox with the information from the database
        private void FillCombo()
        {
            string queryTecnico = "SELECT * FROM Utenti ORDER BY Nome";
            Chiamate.ExecQuery(queryTecnico);

            if (Chiamate.HasException(true))
            {
                MessageBox.Show(Chiamate.Exception);
                return;
            }

            cboTecnico1.Items.Clear();
            cboTecnico2.Items.Clear();

            cboTecnico1.Items.Add("Seleziona Dipendente");
            cboTecnico2.Items.Add("Seleziona Dipendente");

            foreach (DataRow row in Chiamate.DBDT.Rows)
            {
                cboTecnico1.Items.Add(row["Nome"].ToString());
                cboTecnico2.Items.Add(row["Nome"].ToString());
            }

            cboTecnico1.SelectedIndex = 0;
            cboTecnico2.SelectedIndex = 0;
        }

        private void FillComboAutomezzi()
        {
            string queryTecnico = "SELECT * FROM Automezzi ORDER BY Nome";
            Chiamate.ExecQuery(queryTecnico);

            if (Chiamate.HasException(true))
            {
                MessageBox.Show(Chiamate.Exception);
                return;
            }

            cboAutomezzo.Items.Clear();

            //cboAutomezzo.Items.Add("Seleziona Automezzo");

            foreach (DataRow row in Chiamate.DBDT.Rows)
            {
                cboAutomezzo.Items.Add(row["Nome"].ToString());
            }

            //cboAutomezzo.SelectedIndex = 0;
        }


        private void ShowPanel2Components(bool x) // show/hide all components in splitContainer.Panel2
        {
            foreach (Control control in splitContainer.Panel2.Controls)
            {
                control.Visible = x;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.ToolTipText == "Anagrafica Clienti")
            {
                vSearch search = new vSearch();

                string query = "SELECT CodCli, Denom, Tel, EMail FROM Clienti WHERE Stato = 'A'";
                ClientiKing.ExecQuery(query);

                if (ClientiKing.HasException(true))
                {
                    MessageBox.Show(ClientiKing.Exception);
                    return;
                }

                search._DT = ClientiKing.DBDT;
                search.ShowDialog();

                var Row = search._ReturnRow;

                if (Row != 0)
                {
                    txtCliente.Text = search._DT.Rows[Row]["Denom"].ToString();
                    txtTelefono.Text = search._DT.Rows[Row]["Tel"].ToString();
                    txtEmail.Text = search._DT.Rows[Row]["EMail"].ToString();
                }
            }
            else
            {
                vSearch search = new vSearch();
                search._Name = txtCliente.Text;
                search.ShowDialog();

            }
        }

        private void dgvChiamate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvChiamate.Rows[e.RowIndex];

                if (_Btn == "btnChiamate")
                {
                    string iD = row.Cells["iD"].Value?.ToString();
                    string cliente = row.Cells["Cliente"].Value?.ToString();
                    string telefono = row.Cells["Telefono"].Value?.ToString();
                    string email = row.Cells["Email"].Value?.ToString();
                    string note = row.Cells["Note"].Value?.ToString();
                    string utente = row.Cells["Utente"].Value?.ToString();
                    string dip1 = row.Cells["Dip1"].Value?.ToString();
                    string dip2 = row.Cells["Dip2"].Value?.ToString();
                    bool chiamato = row.Cells["Chiamato"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Chiamato"].Value);
                    string automezzo = row.Cells["Automezzo"].Value?.ToString();


                    //add date in datetimepicker
                    string dataStart = row.Cells["Start"].Value?.ToString();
                    if (!string.IsNullOrEmpty(dataStart) && DateTime.TryParse(dataStart, out DateTime parsedDate))
                    {
                        dtpDate.Value = parsedDate;
                    }
                    else
                    {
                        //do not set the date
                        dtpDate.Value = DateTime.MinValue;
                    }

                    //dtpDate.Value = DateTime.Parse(dataStart);



                    //add start time in combobox
                    string start = row.Cells["Start"].Value?.ToString();

                    if (!string.IsNullOrEmpty(start))
                    {
                        cboStart.Text = Convert.ToDateTime(start).ToString("HH:mm");
                    }

                    //add finish time in combobox
                    string finish = row.Cells["Finish"].Value?.ToString();

                    if (!string.IsNullOrEmpty(finish))
                    {
                        cboEnd.Text = Convert.ToDateTime(finish).ToString("HH:mm");
                    }



                    string tipo = row.Cells["Category"].Value?.ToString();
                    string dataInsert = row.Cells["InsertDate"].Value?.ToString();

                    cboTipo.Text = tipo ?? string.Empty;
                    txtCliente.Text = cliente ?? string.Empty;
                    txtTelefono.Text = telefono ?? string.Empty;
                    txtEmail.Text = email ?? string.Empty;
                    txtNote.Text = note ?? string.Empty;
                    txtId.Text = iD ?? string.Empty;
                    cboTecnico1.Text = dip1 ?? string.Empty;
                    cboTecnico2.Text = dip2 ?? string.Empty;
                    cboAutomezzo.Text = automezzo ?? string.Empty;

                    chkChiamato.Checked = chiamato;

                    string dataInsertFormatted = DateTime.Parse(dataInsert).ToString("dd/MM/yyyy");
                    lblAddInfo.Text = "Inserito da " + utente + " in data " + dataInsertFormatted;
                }
                else if (_Btn == "btnDisdetta")
                {
                    string iD = row.Cells["iD"].Value?.ToString();
                    string cliente = row.Cells["Cliente"].Value?.ToString();
                    string telefono = row.Cells["Telefono"].Value?.ToString();
                    string email = row.Cells["Email"].Value?.ToString();
                    string note = row.Cells["Note"].Value?.ToString();
                    string utente = row.Cells["Utente"].Value?.ToString();

                    string tipo = row.Cells["Tipo"].Value?.ToString();
                    string dataInsert = row.Cells["DataInsert"].Value?.ToString();

                    cboTipo.Text = tipo ?? string.Empty;
                    txtCliente.Text = cliente ?? string.Empty;
                    txtTelefono.Text = telefono ?? string.Empty;
                    txtEmail.Text = email ?? string.Empty;
                    txtNote.Text = note ?? string.Empty;
                    txtId.Text = iD ?? string.Empty;

                    string dataInsertFormatted = DateTime.Parse(dataInsert).ToString("dd/MM/yyyy");
                    lblAddInfo.Text = "Inserito da " + utente + " in data " + dataInsertFormatted;

                }
                else if (_Btn == "btnSospesi")
                {
                    string start = row.Cells["Start"].Value?.ToString();
                    string finish = row.Cells["Finish"].Value?.ToString();
                    string user = row.Cells["Utente"].Value?.ToString();
                    string insertDate = row.Cells["InsertDate"].Value?.ToString();


                    lblAddInfo.Text = "Inserito da " + user + " in data " + insertDate;
                    dtpDate.Value = DateTime.Parse(start);
                    cboStart.Text = DateTime.Parse(start).ToString("HH:mm");
                    cboEnd.Text = DateTime.Parse(finish).ToString("HH:mm");
                }

                ShowPanel2Components(true);
                personalVisible(true);

                //center the panel
                flpButtons.Location = new Point(145, 775);

                //change the button's client tooltip text and image if a client is selected 
                btnSearch.ToolTipText = "Info Clienti";
                btnSearch.ImageSource = "icon-question";
            }

            disableOnEdit();
        }

        //disable the fields if the logged user is not the one who inserted the record
        private void disableOnEdit()
        {
            if (lblAddInfo.Text.Contains(Global.Username))
            {
                dtpDate.Enabled = true;
                cboStart.Enabled = true;
                cboEnd.Enabled = true;
                chkAllDay.Enabled = true;
            }
            else
            {
                dtpDate.Enabled = false;
                cboStart.Enabled = false;
                cboEnd.Enabled = false;
                chkAllDay.Enabled = false;
            }
        }

        //empty all fields
        private void ClearFields()
        {
            foreach (Control c in flpMain.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    c.Text = "";
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            foreach (Control c in pClienti.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowPanel2Components(true);
            personalVisible(false);
            ClearFields();

            //center the panel
            flpButtons.Location = new Point(260, 775);

            btnSearch.ToolTipText = "Anagrafica Clienti";
            btnSearch.ImageSource = "icon-search";
        }

        private void personalVisible(bool x)
        {
            cboTecnico1.Visible = x;
            cboTecnico2.Visible = x;
            btnAssegna.Visible = x;
            btnStampa.Visible = x;
            lblAddInfo.Visible = x;
            flpDateTime.Visible = x;
            pBlue1.Visible = x;
            cboAutomezzo.Visible = x;
        }

        private void chkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            cboStart.Enabled = !chkAllDay.Checked;
            cboEnd.Enabled = !chkAllDay.Checked;
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
                else if(chkAllDay.Checked == true && isStart == false) // create the finish date based on the last time in the cboEnd combobox
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
            catch(Exception)
            {
                
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            bool result = true;

            if(cboTecnico1.SelectedIndex == 0 && cboTecnico2.SelectedIndex != 0)
            {
                MessageBox.Show("Selezionare il primo tecnico.");
                result = false;
                return result;
            }

            return result;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        { 
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (_Btn == "btnChiamate")
            {

                if (txtId.Text == "")
                {
                    query = "Insert into Chiamate (Category, Cliente, Telefono, Email, Note, Utente, InsertDate, Chiamato) " +
                                "values (@Tipo, @Cliente, @Telefono, @Email, @Note, @Utente, @DataInsert, @Chiamato)";
                }
                else
                {                    
                    query = "Update Chiamate set Category = @Tipo, Cliente = @Cliente, Telefono = @Telefono, Email = @Email, " +
                        "Note = @Note, Start = @DataStart, Finish = @DataFine, Chiamato = @Chiamato, Dip1 = @Dip1, Dip2 = @Dip2, Automezzo = @Automezzo where ID = @ID";
                }
            }
            else if (_Btn == "btnDisdetta")
            {
                if (txtId.Text == "")
                {
                    query = "Insert into Disdette (Tipo, Cliente, Telefono, Email, Note, Utente, DataInsert) " +
                                "values (@Tipo, @Cliente, @Telefono, @Email, @Note, @Utente, @DataInsert)";
                }
                else
                {
                    query = "Update Disdette set Tipo = @Tipo, Cliente = @Cliente, Telefono = @Telefono, Email = @Email, " +
                        "Note = @Note, DataStart = @DataStart, DataFine = @DataFine where ID = @ID";
                }
            }
            else
            {
                return;
            }

            Chiamate.AddParam("@ID", txtId.Text);

            Chiamate.AddParam("@Tipo", cboTipo.Text);
            Chiamate.AddParam("@Cliente", txtCliente.Text);
            Chiamate.AddParam("@Telefono", txtTelefono.Text);
            Chiamate.AddParam("@Email", txtEmail.Text);
            Chiamate.AddParam("@Note", txtNote.Text);
            Chiamate.AddParam("@Utente", Global.Username);
            Chiamate.AddParam("@DataInsert", DateTime.Now);
            Chiamate.AddParam("@Chiamato", chkChiamato.Checked);
            Chiamate.AddParam("@Dip1", cboTecnico1.Text);
            Chiamate.AddParam("@Dip2", cboTecnico2.Text);
            Chiamate.AddParam("@Automezzo", cboAutomezzo.Text);

            createDateStartFinish(cboStart, true);
            Chiamate.AddParam("@DataStart", dtpDate.Value);
            createDateStartFinish(cboEnd, false);
            Chiamate.AddParam("@DataFine", dtpDate.Value);

            Chiamate.ExecQuery(query);

            if (Chiamate.HasException(true))
            {
                MessageBox.Show(Chiamate.Exception);
                return;
            }

            MessageBox.Show("Operazione completata con successo.");
            LoadData();
            ShowPanel2Components(false);

            // Ricarica la MainPage
            MainPage mainPage = (MainPage)Application.OpenForms["MainPage"];
            if (mainPage != null)
            {
                mainPage.btnAggiorna_Click(sender, e);
            }
        }

        private void btnAssegna_Click(object sender, EventArgs e)
        {

        }
    }
}
