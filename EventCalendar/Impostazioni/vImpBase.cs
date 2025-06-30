using EventCalendar.Class;
using System;
using System.Data;
using Wisej.Web;

namespace EventCalendar.Impostazioni
{
	public partial class vImpBase : Form
	{

		SQLControl conn = new SQLControl(Global.connTest);


        public vImpBase()
		{
			InitializeComponent();
        }


        private void vImpBase_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }


		private void LoadData()
		{
            string query = "SELECT * FROM StartWindows ORDER BY Window";
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            //cboWindow.Items.Clear();

            //cboWindow.Items.Add("Seleziona Window");

            foreach (DataRow row in conn.DBDT.Rows)
            {
                cboWindow.Items.Add(row["Window"].ToString());
            }

            /*----------------  Add current Start Window in cbo ----------------------*/

            query = "Select StartWindows from Utenti where iD = @iD";

            conn.AddParam("@iD", Global.iD);
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            if (conn.DBDT.Rows.Count > 0)
            {
                string startWindow = conn.DBDT.Rows[0]["StartWindows"].ToString();

                if (!string.IsNullOrEmpty(startWindow) && !cboWindow.Items.Contains(startWindow))
                {
                    cboWindow.Items.Add(startWindow);
                }

                cboWindow.SelectedItem = startWindow;
            }
            else
            {
                cboWindow.SelectedIndex = 0;
            }

            txtEmail.Text = Global.Email;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("The email cannot be empty!");
                txtEmail.Focus();
                return;
            }


            string query = "Update Utenti set Email = @Email, StartWindows = @StartWindows where iD = @iD";

            conn.AddParam("@Email", txtEmail.Text);
            conn.AddParam("@StartWindows", cboWindow.Text);
            conn.AddParam("@iD", Global.iD);
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            Global.Email = txtEmail.Text;
            MessageBox.Show("Salvataggio effettuato con successo");

            LoadData();
        }

    }
}
