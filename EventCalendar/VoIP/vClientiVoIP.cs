using EventCalendar.Class;
using System;
using System.Data;
using Wisej.Web;

namespace EventCalendar.VoIP
{
	public partial class vClientiVoIP : Form
	{

        SQLControl conn = new SQLControl(Global.connTest);

        public vClientiVoIP()
		{
			InitializeComponent();
		}

        private void vClienti_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sqlQueryDipendente = "SELECT * FROM VoiPofferte ORDER BY Descrizione";
            conn.ExecQuery(sqlQueryDipendente);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            //cboOfferta.Items.Clear();
            //cboOfferta.Items.Add("Seleziona Offerta");

            foreach (DataRow row in conn.DBDT.Rows)
            {
                cboOfferta.Items.Add(row["Descrizione"].ToString());
            }

            cboOfferta.SelectedIndex = 0;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }


            /* ---------------------------------- Not Finished --------------------------------- */

            string query = "Insert into VoiPCliente (nome, password, voip, portabilita, migrazione, migrazioneport, datainizio, " +
                                    "dataport, datadisdetta, tipo, seriale, offerta, lastdata, fatturazione, stato) " +
                           "values (@nome, @password, @voip, @portabilita, @migrazione, @migrazioneport, @datainizio, " +
                                    "@dataport, @datadisdetta, @tipo, @seriale, @offerta, @lastdata, @fatturazione, @stato)";

            conn.AddParam("@password", txtPassword.Text);
            conn.AddParam("@nome", txtNome.Text);

            conn.AddParam("@migrazione", txtCodiceMigrEsterno.Text);
            conn.AddParam("@migrazioneport", txtCodiceMigrEtruria.Text);
            conn.AddParam("@tipo", txtTipoTelefono.Text);
            conn.AddParam("@seriale", txtSerialeTelefono.Text);

            conn.AddParam("@dataport", dtpPort.Text);

            /* -------------------------------------------------------------------------------- */

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati Salvati con Successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            LoadData();

        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
            }
        }

        private bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Inserire il Nome", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

                result = false;
                return result;
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
