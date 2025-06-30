using EventCalendar.Class;
using EventCalendar.Tasks;
using System;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar.Menu
{
    public partial class vRisolti : Form
    {

        SQLControl conn = new SQLControl(Global.connTest);

        private void dgvSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }


        public vRisolti()
        {
            InitializeComponent();
        }


        private void vRisolti_Load(object sender, EventArgs e)
        {
            LoadData();

            txtId.Visible = false;
        }


        internal void LoadData()
        {

            string query = "";

            //a query to delete all the info from table RisoltiChiamate and reset the ID
            query = "DELETE FROM RisoltiChiamate DBCC CHECKIDENT ('RisoltiChiamate', RESEED, 0)";
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }


            //a query to insert into table RisoltiChiamate info from table Tasks using the ID
            query = "INSERT INTO RisoltiChiamate (iD_Tasks, DataIns, Cliente, Tipo, Status, Note) SELECT ID, InsertDate, Cliente, Category, Status, Description FROM Tasks";
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            //a query to insert into table RisoltiChiamate info from table Chiamate using the ID
            query = "INSERT INTO RisoltiChiamate (iD_Chiamate, DataIns, Cliente, Tipo, Status, Note) SELECT ID, InsertDate, Cliente, Category, Status, Note FROM Chiamate";
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            //a query to select all the info from table RisoltiChiamate
            query = "SELECT * FROM RisoltiChiamate";

            conn.ExecQuery(query);

            if (conn.HasException(true)) 
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            dgvSearch.DataSource = conn.DBDT;

            HideColumns();
        }

        //a method to hide the columns that are not needed
        private void HideColumns()
        {
            //dgvSearch.Columns[0].Visible = false;
            dgvSearch.Columns[1].Visible = false;
            dgvSearch.Columns[2].Visible = false;
        }


        //a method to search for the info in the table RisoltiChiamate using the selected item from the combobox
        private void cboTipo_SelectedItemChanged(object sender, System.EventArgs e)
        {
            
            string query = "";

            if (cboTipo.SelectedIndex == 0)
            {
                query = "SELECT * FROM RisoltiChiamate";
            }
            else
            {
                query = "SELECT * FROM RisoltiChiamate WHERE Tipo = @Tipo";
            }

            conn.AddParam("@Tipo", cboTipo.SelectedItem);

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            dgvSearch.DataSource = conn.DBDT;

        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearch.CurrentRow != null)
            {
                var selectedId = dgvSearch.CurrentRow.Cells[0].Value;

                // Set the selected ID to the txtId TextBox
                txtId.Text = selectedId.ToString();

                vTaskInfo f = new vTaskInfo();

                f._iD = Convert.ToInt32(txtId.Text);
                f._category = dgvSearch.CurrentRow.Cells["Tipo"].Value.ToString();
                f._risolti = true;
                f.ShowDialog();

            }
        }

    }
}
