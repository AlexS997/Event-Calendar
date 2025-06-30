using Newtonsoft.Json;
using System;
using EventCalendar.Class;

namespace EventCalendar.Class
{

    [Serializable]
    public class AppConfiguration
    {
        public string CSTest { get; set; }
        public string CSAna { get; set; }
        public string CSSmartLab { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Server { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
        public int Esercizio { get; set; } = 0; 

        public AppConfiguration()
        { }

        public bool CaricaConfigurazione(string filename)
        {
            bool esito = false;

            // deserializza il file di configurazione e lo ritorna a chi l'ha chiamato
            if (string.IsNullOrWhiteSpace(filename)) { return false; }
            try
            {

                AppConfiguration appConfiguration = JsonConvert.DeserializeObject<AppConfiguration>(System.IO.File.ReadAllText(filename));
                Global.connTest = appConfiguration.CSTest;
                Global.connAna = appConfiguration.CSAna;
                Global.connSmart = appConfiguration.CSSmartLab;
                this.UserName = appConfiguration.UserName;
                this.Password = appConfiguration.Password;
                this.Server = appConfiguration.Server;
                this.Database = appConfiguration.Database;
                this.Esercizio = appConfiguration.Esercizio;
                esito = true;
            }
            catch (Exception)
            {

                esito = false;
            }

            return esito;

        }
    }
}
