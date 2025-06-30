using Dapper.Contrib.Extensions;
using System;

namespace EventCalendar.TableClass
{

    [Table("Automezzi")]

    public class TableAutomezzi
    {
        [ExplicitKey]
        public string Targa { get; set; }
        public string Nome { get; set; }
        public DateTime BolloDateScad { get; set; }
        public DateTime AssicurazioneDateScad { get; set; }
        public DateTime CollaudoDateScad { get; set; }
        public int CollaudoKm { get; set; }
        public DateTime GommeDate { get; set; }
        public int GommeKm { get; set; }
        public DateTime CinghiaDate { get; set; }
        public int CinghiaKm { get; set; }
        public DateTime TagliandoDate { get; set; }
        public int TagliandoKm { get; set; }
        public int KmAttuali { get; set; }
        public bool StatoAttivazione { get; set; }
    }
}
