using System;
using Dapper.Contrib.Extensions;

namespace EventCalendar.TableClass
{
    [Table("Utenti")]
    public class TableUtenti
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string StartWindows { get; set; }
        public bool isSuperUser { get; set; }
        public bool isAdministrator { get; set; }
        public bool isActive { get; set; }
    }
}
