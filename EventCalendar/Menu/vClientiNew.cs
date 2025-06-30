using EventCalendar.Class;
using System;
using System.Data;
using Wisej.Web;

namespace EventCalendar.Menu
{
	public partial class vClientiNew : Form
	{

        SQLControl connAna = new SQLControl(Global.connAna);

        // Declare a string variable to store the name of the table
        public string Table = "Clienti";

        // Declare a ClsTableSchema object
        private ClsTableSchema _tableSchema;

        public string _iD { get; set; }


        public vClientiNew()
		{
			InitializeComponent();

            // Initialize ClsTableSchema with the connection and name of the table
            _tableSchema = new ClsTableSchema(Global.connAna, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);

        }

        private void vClientiNew_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {

            if (!string.IsNullOrEmpty(_iD))
            {
                string query = "SELECT * FROM Clienti WHERE CodCli = @CodCli";

                connAna.AddParam("@CodCli", _iD);
                connAna.ExecQuery(query);

                if (connAna.HasException(true))
                {
                    MessageBox.Show(connAna.Exception);
                    return;
                }

                txtDenom.Text = connAna.DBDT.Rows[0]["Denom"].ToString();
                txtInd.Text = connAna.DBDT.Rows[0]["Ind"].ToString();
                txtTel.Text = connAna.DBDT.Rows[0]["Tel"].ToString();
                txtLoc.Text = connAna.DBDT.Rows[0]["Loc"].ToString();
                txtProv.Text = connAna.DBDT.Rows[0]["Prov"].ToString();
                txtCap.Text = connAna.DBDT.Rows[0]["Cap"].ToString();
                txtPIva.Text = connAna.DBDT.Rows[0]["PIva"].ToString();
                txtCF.Text = connAna.DBDT.Rows[0]["CF"].ToString();
                txtNote.Text = connAna.DBDT.Rows[0]["Note"].ToString();

            }
            else
            {
                txtInd.Text = "";
                txtDenom.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string GetLastElementFromColumn(string columnName)
        {
            string query = $"SELECT TOP 1 {columnName} FROM {Table} ORDER BY {columnName} DESC";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show(connAna.Exception);
                return null;
            }

            if (connAna.DBDT.Rows.Count > 0)
            {
                return connAna.DBDT.Rows[0][columnName].ToString();
            }

            return null;
        }


        private string ModifyAndIncrementElement(string element)
        {
            if (string.IsNullOrEmpty(element) || element.Length < 2)
            {
                throw new ArgumentException("Elemento non valido per la modifica.");
            }

            // Rimuovi il primo carattere
            string modifiedElement = element.Substring(1);

            // Incrementa il valore rimanente di 1
            if (int.TryParse(modifiedElement, out int numericValue))
            {
                numericValue++;
                return "C" + numericValue.ToString();
            }
            else
            {
                throw new ArgumentException("Il valore rimanente non è un numero valido.");
            }
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {

            string query = "";

            if (string.IsNullOrEmpty(_iD))
            {
                string lastElement = GetLastElementFromColumn("CodCli");
                string newElement = ModifyAndIncrementElement(lastElement);
                connAna.AddParam("@CodCli", newElement);

                query = "INSERT INTO Clienti (Denom, Ind, Tel, Loc, Prov, Cap, PIva, CF, Note, CodCli) " +
                            "VALUES (@Denom, @Ind, @Tel, @Loc, @Prov, @Cap, @PIva, @CF, @Note, @CodCli)";
            }
            else
            {
                connAna.AddParam("@CodCli", _iD);

                query = "UPDATE Clienti SET Denom = @Denom, Ind = @Ind, Tel = @Tel, Loc = @Loc, Prov = @Prov, " +
                    "Cap = @Cap, PIva = @PIva, CF = @CF, Note = @Note WHERE CodCli = @CodCli";
            }


            connAna.AddParam("@Denom", txtDenom.Text);
            connAna.AddParam("@Ind", txtInd.Text);
            connAna.AddParam("@Tel", txtTel.Text);
            connAna.AddParam("@Loc", txtLoc.Text);
            connAna.AddParam("@Prov", txtProv.Text);
            connAna.AddParam("@Cap", txtCap.Text);
            connAna.AddParam("@PIva", txtPIva.Text);
            connAna.AddParam("@CF", txtCF.Text);
            connAna.AddParam("@Note", txtNote.Text);
                

            //connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show(connAna.Exception);
                return;
            }

            MessageBox.Show("Informazioni salvate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}
