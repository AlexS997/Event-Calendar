using EventCalendar.Chiamate;
using EventCalendar.Class;
using EventCalendar.Menu;
using EventCalendar.Tasks;
using System;
using System.Data;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.FullCalendar;

namespace EventCalendar
{
    public partial class MainPage : Form
    {

        SQLControl conn = new SQLControl(Global.connTest);


        public MainPage()
        {
            InitializeComponent();

            AddEventToCalendar();

            monthCalendar.DateChanged += MonthCalendar_DateChanged;

        }

        private void DataLoad()
        {
            //Set the information to the combobox with the technicians

            string sqlQueryDipendente = "SELECT * FROM Utenti ORDER BY Nome";
            conn.ExecQuery(sqlQueryDipendente);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            cboDipendenti.Items.Clear();

            cboDipendenti.Items.Add("Tutti i dipendenti");

            foreach (DataRow row in conn.DBDT.Rows)
            {
                cboDipendenti.Items.Add(row["Nome"].ToString());
            }

            cboDipendenti.SelectedIndex = 0;

            /* ------------------- Set the number of the buttons with the number of the records in the database ------------------- */


            setButtonNumber("Chiamate where Start IS NULL", "Chiamate", btnChiamate);
            setButtonNumber("Disdette", "Disdetta", btnDisdetta);
            btnSospesi.Text = "Sospesi (0)";

            lblUsername.Text = Global.Username;

            fullCalendar1.MinTime = TimeSpan.Parse("08:30:00");

            menuBar.CssStyle = "border-radius:6%";

            /* -------------------- add in the splitbutton the items for the new task ------------------ */


            string query = "Select * from TaskTypes where TaskType = 'Altro' or TaskType = 'Intervento' or TaskType = 'Ferie/Malattia'";

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            foreach (DataRow row in conn.DBDT.Rows)
            {
                sbNew.MenuItems.Add(row["TaskType"].ToString());
            }

        }

        private void setButtonNumber(string table, string name, Button btnComponent)
        {

            string sqlQuery = "Select Count(*) from " + table;
            conn.ExecQuery(sqlQuery);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            btnComponent.Text = name + " (" + conn.DBDT.Rows[0][0].ToString() + ")";
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        // When the date is changed in the monthCalendar, change the date in the fullCalendar
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            fullCalendar1.CurrentDate = e.Start;
        }


        private void AddEventToCalendar()
        {
            // Query per ottenere eventi dalla tabella Tasks
            string queryTasks = "SELECT ID, Text, Description, Category, Start, Finish, Utente, Status FROM Tasks";
            conn.ExecQuery(queryTasks);

            if (conn.HasException(true))
            {
                MessageBox.Show("Error loading events from database.");
                return;
            }

            // Clear all events
            fullCalendar1.Events.Clear();

            // Aggiungi eventi dalla tabella Tasks
            foreach (DataRow row in conn.DBDT.Rows)
            {
                AddEventToCalendarFromRow(row, isChiamate: false);
            }

            // Query per ottenere eventi dalla tabella Chiamate
            string queryChiamate = "SELECT ID, Cliente, Note, Category, Start, Finish, Utente, Status, Effettuato, Dip1, Dip2 FROM Chiamate";
            conn.ExecQuery(queryChiamate);

            if (conn.HasException(true))
            {
                MessageBox.Show("Error loading events from database.");
                return;
            }

            // Aggiungi eventi dalla tabella Chiamate
            foreach (DataRow row in conn.DBDT.Rows)
            {
                AddEventToCalendarFromRow(row, isChiamate: true);
            }
        }

        private void AddEventToCalendarFromRow(DataRow row, bool isChiamate)
        {
            string title = isChiamate ? row["Cliente"].ToString() : row["Text"].ToString();
            string description = isChiamate ? row["Note"].ToString() : row["Description"].ToString();
            DateTime start = row.IsNull("Start") ? DateTime.MinValue : Convert.ToDateTime(row["Start"]);
            DateTime finish = row.IsNull("Finish") ? DateTime.MinValue : Convert.ToDateTime(row["Finish"]);
            string category = row["Category"].ToString();
            string status = row["Status"].ToString();
            string dip1 = isChiamate && row.Table.Columns.Contains("Dip1") ? row["Dip1"].ToString() : string.Empty;
            string dip2 = isChiamate && row.Table.Columns.Contains("Dip2") ? row["Dip2"].ToString() : string.Empty;
            string effettuato = isChiamate && row.Table.Columns.Contains("Effettuato") ? row["Effettuato"].ToString() : string.Empty;
            string user = row["Utente"].ToString();
            int taskId = Convert.ToInt32(row["Id"]);


            // Get the first letter of the category
            string categoryInitial;
            if (!string.IsNullOrEmpty(category))
            {
                if (category == "Intervento")
                {
                    categoryInitial = "N";
                }
                else
                {
                    categoryInitial = category.Substring(0, 1).ToUpper();
                }
            }
            else
            {
                categoryInitial = string.Empty;
            }

            Color eventColor;

            // Set the color of the event based on the category
            if (category == "Ferie/Malattia" || category == "Altro")
            {
                eventColor = Color.FromArgb(150, 255, 215, 0);
            }
            else if (category == "Intervento")
            {
                eventColor = Color.FromArgb(150, 255, 165, 0);
            }
            else
            {
                eventColor = Color.FromArgb(39, 159, 245, (int)0.64);  // Default color
            }


            // Set the color of the event based on the status and effettuato
            if ( effettuato == "True")
            {
                eventColor = Color.DarkOrchid;
            }
            else
            {
                if (status == "Aperto")
                {
                    eventColor = Color.FromArgb(30, 144, 255);
                    
                }
                else if (status == "Eseguito")
                {
                    eventColor = Color.FromArgb(148, 0, 211);
                }
                else if (status == "Concluso")
                {
                    eventColor = Color.FromArgb(0, 128, 0);
                }
                else if (status == "Rimandato")
                {
                    eventColor = Color.FromArgb(255, 0, 0);
                }
            }

            var eventData = new Event {};

            // Create the event and set the properties
            if (isChiamate)
            {
                eventData = new Event
                {
                    Title = $"[{categoryInitial}] {description} \n\n {dip1} - {dip2}",
                    Start = start,
                    End = finish,
                    BackgroundColor = eventColor,  // Event color
                    TextColor = status == "Aperto" && effettuato != "True" ? Color.White : Color.Black,        // Text color
                    Id = taskId.ToString(),
                    Editable = false,
                };
            }
            else
            {
                eventData = new Event
                {
                    Title = $"[{categoryInitial}] {description} - {user}",
                    Start = start,
                    End = finish,
                    BackgroundColor = eventColor,  // Event color
                    TextColor = Color.Black,        // Text color
                    Id = taskId.ToString(),
                    Editable = false,
                };
            }

                // add event to calendar
                fullCalendar1.Events.Add(eventData);
        }


        // Move to the next week in the calendar
        private void button_Click(object sender, EventArgs e)
        {
            fullCalendar1.Next();
            //move to next week in monthCalendar, highlight the week
            monthCalendar.SetDate(monthCalendar.SelectionStart.AddDays(7));
        }


        // Move to the previous week in the calendar
        private void button1_Click(object sender, EventArgs e)
        {
            fullCalendar1.Previous();
            //move to previous week in monthCalendar, highlight the week
            monthCalendar.SetDate(monthCalendar.SelectionStart.AddDays(-7));

        }


        // on double click on an event, open the task info
        private void fullCalendar1_EventDoubleClick(object sender, EventClickEventArgs e)
        {

            vTaskInfo vti = new vTaskInfo();

            string taskId = e.Event.Id;

            int parsedId;
            if (string.IsNullOrEmpty(taskId))
            {
                MessageBox.Show("Invalid task ID: " + taskId);
                return;
            }
            else if (int.TryParse(taskId, out parsedId))
            {
                vti._iD = parsedId;

                // Determine if the event is from Tasks or Chiamate
                string queryTasks = "SELECT Category FROM Tasks WHERE ID = @ID";
                string queryChiamate = "SELECT Category FROM Chiamate WHERE ID = @ID";

                conn.AddParam("@ID", taskId);
                conn.ExecQuery(queryTasks);

                if (conn.HasException(true))
                {
                    MessageBox.Show("Error loading event from Tasks table.");
                    return;
                }

                // If the event is from Tasks
                if (conn.DBDT.Rows.Count > 0)
                {
                    vti._category = conn.DBDT.Rows[0]["Category"].ToString();
                }
                else //if the event is from Chiamate
                {

                    conn.AddParam("@ID", taskId);
                    conn.ExecQuery(queryChiamate);

                    if (conn.HasException(true))
                    {
                        MessageBox.Show("Error loading event from Chiamate table.");
                        return;
                    }

                    if (conn.DBDT.Rows.Count > 0)
                    {
                        vti._chiamate = true;
                        vti._category = conn.DBDT.Rows[0]["Category"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Event not found in either Tasks or Chiamate tables.");
                        return;
                    }
                }

                vti.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid task ID: " + taskId);
            }


        }

        private void btnChiamate_Click(object sender, EventArgs e)
        {
            vChiamate chiamate = new vChiamate();
            chiamate._Btn = btnChiamate.Name;
            chiamate.Text = "Chiamate - Utente Corrente: " + Global.Nome;
            chiamate.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            vLogin login = new vLogin();
            login.Show();
            this.Close();
        }

        private void fullCalendar1_EventClick(object sender, EventClickEventArgs e)
        {
            // Ottieni l'evento cliccato
            var clickedEvent = e.Event;

            string tooltipText = $"Titolo: {clickedEvent.Title}\nData: {clickedEvent.Start.ToShortDateString()}\nOrario: " +
                $"{clickedEvent.Start.ToShortTimeString()} - {clickedEvent.End.ToShortTimeString()}";

            ToolTip toolTip = new ToolTip();
            toolTip.Show(tooltipText, MousePosition);
        }


        // Show or hide the legend
        private void btnLegenda_Click(object sender, EventArgs e)
        {
            pLegend.Visible = !pLegend.Visible;
        }


        private void btnDisdetta_Click(object sender, EventArgs e)
        {
            vChiamate chiamate = new vChiamate();
            chiamate._Btn = btnDisdetta.Name;
            chiamate.Text = "Disdette - Utente Corrente: " + Global.Nome;
            chiamate.ShowDialog();
        }

        private void btnSospesi_Click(object sender, EventArgs e)
        {
            vChiamate chiamate = new vChiamate();
            chiamate._Btn = btnSospesi.Name;
            chiamate.Text = "Sospesi - Utente Corrente: " + Global.Nome;
            chiamate.ShowDialog();
        }


        // When the selected item in the combobox changes, filter the events in the calendar
        private void cboDipendenti_SelectedItemChanged(object sender, EventArgs e)
        {

            string selectedUser = cboDipendenti.SelectedItem.ToString();

            string queryTasks;
            string queryChiamate;

            if (selectedUser == "Tutti i dipendenti")
            {
                queryTasks = "SELECT ID, Text, Description, Category, Start, Finish, Utente, Status FROM Tasks";
                queryChiamate = "SELECT ID, Cliente, Note, Category, Start, Finish, Utente, Status, Dip1, Dip2 FROM Chiamate";
            }
            else
            {
                queryTasks = "SELECT ID, Text, Description, Category, Start, Finish, Utente, Status FROM Tasks WHERE Utente = @Utente";
                queryChiamate = "SELECT ID, Cliente, Note, Category, Start, Finish, Utente, Status , Dip1, Dip2 FROM Chiamate WHERE Utente = @Utente";
                conn.AddParam("@Utente", selectedUser);
            }

            // Esegui la query per la tabella Tasks
            conn.ExecQuery(queryTasks);

            if (conn.HasException(true))
            {
                MessageBox.Show("Error loading events from database.");
                return;
            }

            // Clear all events
            fullCalendar1.Events.Clear();

            // Aggiungi eventi dalla tabella Tasks
            foreach (DataRow row in conn.DBDT.Rows)
            {
                AddEventToCalendarFromRow(row, isChiamate: false);
            }

            // Aggiungi il parametro @Utente per la query Chiamate se necessario
            if (selectedUser != "Tutti i dipendenti")
            {
                conn.AddParam("@Utente", selectedUser);
            }

            // Esegui la query per la tabella Chiamate
            conn.ExecQuery(queryChiamate);

            if (conn.HasException(true))
            {
                MessageBox.Show("Error loading events from database.");
                return;
            }

            // Aggiungi eventi dalla tabella Chiamate
            foreach (DataRow row in conn.DBDT.Rows)
            {
                AddEventToCalendarFromRow(row, isChiamate: true);
            }

        }



        private void mnuImpostazioni_Click(object sender, EventArgs e)
        {
            vImpostazioni imp = new vImpostazioni();
            imp.ShowDialog();
        }

        private void mnuVoip_Click(object sender, EventArgs e)
        {
            vVoIP voip = new vVoIP();
            voip.ShowDialog();
        }

        private void mnuClienti_Click(object sender, EventArgs e)
        {
            vClienti clienti = new vClienti();
            clienti.ShowDialog();
        }

        private void mnuRicerca_Click(object sender, EventArgs e)
        {
            vRicerca ricerca = new vRicerca();
            ricerca.ShowDialog();
        }

        private void sbNew_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            //if the sbnew item text is Ferie/Malattia then open AddTask
            if (e.Item.Text == "Ferie/Malattia" || e.Item.Text == "Altro")
            {
                AddTask addTask = new AddTask();

                addTask.Text = e.Item.Text + " - Current User: " + Global.Username;

                addTask._category = e.Item.Text;


                // Show AddTask and wait for confirmation
                if (addTask.ShowDialog() == DialogResult.OK)
                {
                    // After save event, refresh the calendar
                    AddEventToCalendar();
                }
            }
            else if (e.Item.Text == "Intervento")
            {
                vTaskInfo vti = new vTaskInfo();
                vti._iD = 0;
                vti._category = e.Item.Text;
                vti.ShowDialog();

            }
            else
            {
                MessageBox.Show("Not implemented yet");
            }
        }

        private void mnuRisolti_Click(object sender, EventArgs e)
        {
            vRisolti risolti = new vRisolti();
            risolti.ShowDialog();
        }

        // Refresh the calendar
        internal void btnAggiorna_Click(object sender, EventArgs e)
        {

            AddEventToCalendar();
           
            setButtonNumber("Chiamate where Start IS NULL", "Chiamate", btnChiamate);
            setButtonNumber("Disdette", "Disdetta", btnDisdetta);
            btnSospesi.Text = "Sospesi (0)";

        }


        // When the selected item in the combobox changes, change the calendar view
        private void cboCalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the calendar view based on the selected item in the combobox
            switch (cboCalType.SelectedItem.ToString())
            {
                case "Agenda Week":
                    fullCalendar1.View = ViewType.AgendaWeek;
                    break;
                case "Basic Week":
                    fullCalendar1.View = ViewType.BasicWeek;
                    break;
                case "List Week":
                    fullCalendar1.View = ViewType.ListWeek;
                    break;
                case "Timeline Week":
                    fullCalendar1.View = ViewType.TimelineWeek;
                    break;
                default:
                    fullCalendar1.View = ViewType.AgendaWeek;
                    break;
            }
        }
    }
}
