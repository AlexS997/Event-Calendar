using EventCalendar.Class;
using System;
using System.Data;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar.Search
{
    public partial class vSearch : Form
    {
        public DataTable _DT { get; set; }
        public int _ReturnRow { get; set; }

        internal string _Name = "";

        public vSearch()
        {
            InitializeComponent();
        }

        private void vSearch_Load(object sender, EventArgs e)
        {
            if(_Name == "")
            {
                dgvSearch.DataSource = _DT;
            }
            else
            {
                SQLControl search = new SQLControl(Global.connAna);

                string query = "SELECT * FROM Clienti WHERE Denom = '" + _Name + "'";

                search.ExecQuery(query);

                if (search.HasException(true))
                {
                    MessageBox.Show(search.Exception);
                    return;
                }

                dgvSearch.DataSource = search.DBDT;

            }
        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                if (dgvSearch.SelectedRows.Count > 0)
                {
                    int filteredIndex = dgvSearch.SelectedRows[0].Index;

                    DataRowView rowView = (DataRowView)dgvSearch.SelectedRows[0].DataBoundItem;
                    DataRow row = rowView.Row;

                    _ReturnRow = _DT.Rows.IndexOf(row);
                }
                else
                {
                    MessageBox.Show("Seleziona una riga prima di procedere.");
                }
                this.Close();
            }
        }

        private void dgvSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }
    }
}
