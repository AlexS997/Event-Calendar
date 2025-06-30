using EventCalendar.Class;
using EventCalendar.Search;
using EventCalendar.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar.Menu
{
	public partial class vRicerca : Form
	{

        SQLControl connAna = new SQLControl(Global.connAna);
        SQLControl conn = new SQLControl(Global.connTest);

        private void dgvRicerca_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }

        public vRicerca()
		{
			InitializeComponent();
		}

        private void vRicerca_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            string query = "Select * from TaskTypes where TaskType != 'Altro' and TaskType != 'Ferie/Malattia'";

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            // Add "Tutti" item to combobox
            cboTipologia.Items.Add("Tutti");

            foreach (DataRow row in conn.DBDT.Rows)
            {
                //add TaskType to combobox
                cboTipologia.Items.Add(row["TaskType"].ToString());
            }

            txtId.Visible = false;
        }

        private void btnClienti_Click(object sender, EventArgs e)
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
            }

        }

        private void btnDip1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Username, Nome, Email FROM Utenti";
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            vSearch search = new vSearch();
            search._DT = conn.DBDT;

            search.ShowDialog();

            var Row = search._ReturnRow;

            if (Row != 0)
            {
                txtDip1.Text = search._DT.Rows[Row]["Nome"].ToString();
            }
        }

        private void btnDip2_Click(object sender, EventArgs e)
        {
            string query = "SELECT Username, Nome, Email FROM Utenti";
            conn.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            vSearch search = new vSearch();
            search._DT = conn.DBDT;

            search.ShowDialog();

            var Row = search._ReturnRow;

            if (Row != 0)
            {
                txtDip2.Text = search._DT.Rows[Row]["Nome"].ToString();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            lblRecords.Visible = false;

            dgvRicerca.DataSource = null;
        }

        private void ClearFields()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }

                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {

            string query = "SELECT iD, Category, Status, Cliente, Note, FORMAT(Start, 'dd/MM/yyyy') AS Data_Start, FORMAT(Finish, 'dd/MM/yyyy') AS Data_Finish " +
                            "FROM Chiamate WHERE Start >= @Start AND Finish <= @Finish";

            // Add conditions to query based on user input
            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(txtCliente.Text))
            {
                conditions.Add("Cliente = @Cliente");
            }

            if (!string.IsNullOrEmpty(txtDip1.Text))
            {
                conditions.Add("Dip1 = @Dip1");
            }

            if (!string.IsNullOrEmpty(txtDip2.Text))
            {
                conditions.Add("Dip2 = @Dip2");
            }

            if (!string.IsNullOrEmpty(cboTipologia.Text) && cboTipologia.SelectedIndex != 0)
            {
                conditions.Add("Category = @Category");
            }

            if (conditions.Count > 0)
            {
                query += " AND " + string.Join(" AND ", conditions);
            }

            conn.AddParam("@Category", cboTipologia.Text);
            conn.AddParam("@Dip1", txtDip1.Text);
            conn.AddParam("@Dip2", txtDip2.Text);
            conn.AddParam("@Cliente", txtCliente.Text);
            conn.AddParam("@Start", dtpStart.Value);
            conn.AddParam("@Finish", dtpFine.Value);
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            dgvRicerca.DataSource = conn.DBDT;

            lblRecords.Visible = true;
            lblRecords.Text = "Record Trovati: " + conn.RecordCount;

        }

        private void dgvRicerca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                vTaskInfo taskInfo = new vTaskInfo();

                // Aggiungi il valore della colonna id nel controllo txtId
                txtId.Text = dgvRicerca.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                taskInfo._iD = Convert.ToInt32(txtId.Text);
                taskInfo._chiamate = true;

                taskInfo.ShowDialog();
            }

        }
    }
}
