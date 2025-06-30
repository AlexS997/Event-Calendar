using EventCalendar.Class;
using EventCalendar.VoIP;
using System;
using Wisej.Web;

namespace EventCalendar.Menu
{
	public partial class vVoIP : Form
	{
		public vVoIP()
		{
			InitializeComponent();
		}

        private void vVoIP_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Global.Username;
        }


        private void mnuPlanning_Click(object sender, EventArgs e)
        {
			this.Close();
        }


        private void mnuImpostazioni_Click(object sender, EventArgs e)
        {
            vImpostazioni imp = new vImpostazioni();
            imp.ShowDialog();
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            vClientiVoIP cv = new vClientiVoIP();
            cv.ShowDialog();
        }
    }
}
