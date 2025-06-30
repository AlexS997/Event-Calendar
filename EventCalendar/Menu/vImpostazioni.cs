using EventCalendar.Class;
using EventCalendar.Impostazioni;
using EventCalendar.Menu;
using System;
using System.Drawing;
using Wisej.Web;

namespace EventCalendar
{
    public partial class vImpostazioni : Form
    {
        
        
        public vImpostazioni()
        {
            InitializeComponent();
        }


        private void vImpostazioni_Load(object sender, EventArgs e)
        {
            LoadData();

            lblUsername.Text = Global.Username;
        }


        private void LoadData()
        {
            if (Global.IsSuperUser == true || Global.IsAdmin == true)
            {
                ControlsShow(true);

                //place flp at the center of the form
                flp.Location = new Point((ClientSize.Width - flp.Width) / 2, (ClientSize.Height - flp.Height) / 3);
            }
            else
            {
                ControlsShow(false);
                //change the size and location of FlowLayoutPanel
                flp.Size = new Size(400, 400);
                flp.Location = new Point(46, 29);
            }
        }


        private void ControlsShow(bool x)
        {
            foreach (Control c in flp.Controls)
            {
                if (c is Button)
                {
                    if(c.Name == "btnImpBase")
                    {
                        continue;
                    }

                    c.Visible = x;
                }
                if (c is Label)
                {
                    if (c.Name == "lblImpBase")
                    {
                        continue;
                    }

                    c.Visible = x;
                }
            }
        }


        private void btnImpBase_Click(object sender, EventArgs e)
        {
            vImpBase impBase = new vImpBase();
            impBase.ShowDialog();
        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            vUsers users = new vUsers();
            users.ShowDialog();
        }

        private void mnuPlanning_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuVoIP_Click(object sender, EventArgs e)
        {
            vVoIP voip = new vVoIP();
            voip.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            vLogin login = new vLogin();
            login.Show();
            this.Close();
        }

        private void btnAutomezzi_Click(object sender, EventArgs e)
        {
            vAutomezzi automezzi = new vAutomezzi();
            automezzi.Text = "Automezzi - Utente Corrente: " + Global.Nome;
            automezzi.ShowDialog();
        }
    }
}
