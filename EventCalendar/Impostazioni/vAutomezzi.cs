using EventCalendar.Class;
using System;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar.Impostazioni
{
    public partial class vAutomezzi : Form
    {
        
        SQLControl conn = new SQLControl(Global.connTest);

        private bool add = false;


        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
        }
        

        public vAutomezzi()
        {
            InitializeComponent();
        }


        private void vAutomezzi_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowPanelComponents(false);
        }


        private void LoadData()
        {
            string query = "SELECT Targa, Nome, StatoAttivazione FROM Automezzi order by Nome";

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            bsAutomezzi.DataSource = conn.DBDT;
            dgv.DataSource = bsAutomezzi;
            
        }


        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                string targa = row.Cells["Targa"].Value?.ToString();

                if (!string.IsNullOrEmpty(targa))
                {
                    string query = "SELECT * FROM Automezzi WHERE Targa = @Targa";
                    conn.AddParam("@Targa", targa);
                    conn.ExecQuery(query);

                    if (conn.HasException(true))
                    {
                        MessageBox.Show(conn.Exception);
                        return;
                    }

                    if (conn.DBDT.Rows.Count > 0)
                    {
                        var dataRow = conn.DBDT.Rows[0];

                        txtAutomezzo.Text = dataRow["Nome"].ToString();
                        txtTarga.Text = dataRow["Targa"].ToString();
                        dtpBollo.Value = DateTime.TryParse(dataRow["BolloDateScad"].ToString(), out DateTime bolloDate) ? bolloDate : DateTime.Now;
                        dtpAssicurazione.Value = DateTime.TryParse(dataRow["AssicurazioneDateScad"].ToString(), out DateTime assicurazioneDate) ? assicurazioneDate : DateTime.Now;
                        dtpCollaudo.Value = DateTime.TryParse(dataRow["CollaudoDateScad"].ToString(), out DateTime collaudoDate) ? collaudoDate : DateTime.Now;
                        nCollaudo.Value = dataRow["CollaudoKm"] != DBNull.Value ? Convert.ToDecimal(dataRow["CollaudoKm"]) : 0;
                        dtpGomme.Value = DateTime.TryParse(dataRow["GommeDate"].ToString(), out DateTime gommeDate) ? gommeDate : DateTime.Now;
                        nGomme.Value = dataRow["GommeKm"] != DBNull.Value ? Convert.ToDecimal(dataRow["GommeKm"]) : 0;
                        dtpCinghia.Value = DateTime.TryParse(dataRow["CinghiaDate"].ToString(), out DateTime cinghiaDate) ? cinghiaDate : DateTime.Now;
                        nCinghia.Value = dataRow["CinghiaKm"] != DBNull.Value ? Convert.ToDecimal(dataRow["CinghiaKm"]) : 0;
                        dtpTagliando.Value = DateTime.TryParse(dataRow["TagliandoDate"].ToString(), out DateTime tagliandoDate) ? tagliandoDate : DateTime.Now;
                        nTagliando.Value = dataRow["TagliandoKm"] != DBNull.Value ? Convert.ToDecimal(dataRow["TagliandoKm"]) : 0;
                        nKm.Value = dataRow["KmAttuali"] != DBNull.Value ? Convert.ToDecimal(dataRow["KmAttuali"]) : 0;
                        chkStato.Checked = dataRow["StatoAttivazione"] != DBNull.Value && Convert.ToBoolean(dataRow["StatoAttivazione"]);
                    }
                }

                txtTarga.Enabled = false;
                add = false;
                LocationFLP();
                ShowPanelComponents(true);
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            add = true;
            LocationFLP();
            ShowPanelComponents(true);
            txtTarga.Enabled = true;
        }


        private bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtAutomezzo.Text))
            {
                MessageBox.Show("Inserire il nome dell'automezzo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutomezzo.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtTarga.Text))
            {
                MessageBox.Show("Inserire la targa dell'automezzo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarga.Focus();
                result = false;
                return result;
            }

            if(nKm.Value == 0)
            {
                MessageBox.Show("Inserire i km attuali dell'automezzo", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nKm.Focus();
                result = false;
                return result;
            }

            return result;
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (add)
            {
                query = "Insert into Automezzi (Nome, Targa, BolloDateScad, AssicurazioneDateScad, CollaudoDateScad, CollaudoKm, " +
                            "GommeDate, GommeKm, CinghiaDate, CinghiaKm, TagliandoDate, TagliandoKm, KmAttuali, StatoAttivazione) " +
                        "values (@Nome, @Targa, @BolloDateScad, @AssicurazioneDateScad, @CollaudoDateScad, @CollaudoKm, " +
                            "@GommeDate, @GommeKm, @CinghiaDate, @CinghiaKm, @TagliandoDate, @TagliandoKm, @KmAttuali, @StatoAttivazione)";
            }
            else
            {
                query = "Update Automezzi set Nome = @Nome, BolloDateScad = @BolloDateScad, AssicurazioneDateScad = @AssicurazioneDateScad, " +
                            "CollaudoDateScad = @CollaudoDateScad, CollaudoKm = @CollaudoKm, GommeDate = @GommeDate, GommeKm = @GommeKm, " +
                            "CinghiaDate = @CinghiaDate, CinghiaKm = @CinghiaKm, TagliandoDate = @TagliandoDate, TagliandoKm = @TagliandoKm, " +
                            "KmAttuali = @KmAttuali, StatoAttivazione = @StatoAttivazione where Targa = @Targa";
            }

            conn.AddParam("@Nome", txtAutomezzo.Text);
            conn.AddParam("@Targa", txtTarga.Text);
            conn.AddParam("@BolloDateScad", dtpBollo.Value);
            conn.AddParam("@AssicurazioneDateScad", dtpAssicurazione.Value);
            conn.AddParam("@CollaudoDateScad", dtpCollaudo.Value);
            conn.AddParam("@CollaudoKm", nCollaudo.Value);
            conn.AddParam("@GommeDate", dtpGomme.Value);
            conn.AddParam("@GommeKm", nGomme.Value);
            conn.AddParam("@CinghiaDate", dtpCinghia.Value);
            conn.AddParam("@CinghiaKm", nCinghia.Value);
            conn.AddParam("@TagliandoDate", dtpTagliando.Value);
            conn.AddParam("@TagliandoKm", nTagliando.Value);
            conn.AddParam("@KmAttuali", nKm.Value);
            conn.AddParam("@StatoAttivazione", chkStato.Checked);

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            MessageBox.Show("Automezzo salvato correttamente", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

            ShowPanelComponents(false);
        }


        private void ClearFields()
        {
            foreach (Control control in splitContainer.Panel2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
            }
        }


        //change the location of FlowLayoutPanel with buttons
        private void LocationFLP()
        {
            if (add)
            {
                btnDelete.Visible = false;
                flpButtons.Location = new Point((splitContainer.Panel2.Width - flpButtons.Width / 2) / 2, 582);
            }
            else
            {
                btnDelete.Visible = true;
                flpButtons.Location = new Point((splitContainer.Panel2.Width - flpButtons.Width) / 2, 582);
            }
        }


        //show or hide the components in panel2
        private void ShowPanelComponents(bool x)
        {
            foreach(Control c in splitContainer.Panel2.Controls)
            {
                c.Visible = x;
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From Automezzi Where Targa = @Targa";

            conn.AddParam("@Targa", txtTarga.Text);
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show(conn.Exception);
                return;
            }

            MessageBox.Show("Automezzo eliminato correttamente", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LoadData();
            ShowPanelComponents(false);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
