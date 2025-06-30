using Dapper.Contrib.Extensions;

namespace EventCalendar.TableClass
{
    [Table("Clienti")]
    public class TableClienti
    {
        [ExplicitKey]
        public string Denom { get; set; }
        public string Ind { get; set; }
        public string Tel { get; set; }
        public string Loc { get; set; }
        public string Prov { get; set; }
        public string Cap { get; set; }
        public string PIva { get; set; }
        public string CF { get; set; }
        public string Note { get; set; }
        public string EMail { get; set; }

    }
}
