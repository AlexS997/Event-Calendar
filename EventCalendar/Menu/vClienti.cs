using EventCalendar.Class;
using System;
using Wisej.Web;
using System.Drawing;

namespace EventCalendar.Menu
{
	public partial class vClienti : Form
	{

		SQLControl connAna = new SQLControl(Global.connAna);
        
        private void dgvClienti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }

        public vClienti()
		{
			InitializeComponent();
		}

        private void vClienti_Load(object sender, EventArgs e)
        {
			LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT CodCli, Denom, Ind FROM Clienti order by Denom";

            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show(connAna.Exception);
                return;
            }

            bsClienti.DataSource = connAna.DBDT;
            dgvClienti.DataSource = bsClienti;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vClientiNew frm = new vClientiNew();
            frm.Text = "Nuovo Cliente";
            frm.ShowDialog();
        }

        private void dgvClienti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClienti.CurrentRow != null)
            {
                vClientiNew f = new vClientiNew();
                f._iD = dgvClienti.CurrentRow.Cells["CodCli"].Value.ToString();

                f.Text = "Modifica Cliente";
                f.ShowDialog();
                LoadData();

                // deve ritornare al record selezionato
                foreach (DataGridViewRow row in dgvClienti.Rows)
                {
                    if (row.Cells["CodCli"].Value.ToString() == f._iD.ToString())
                    {
                        dgvClienti.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

    }
}
