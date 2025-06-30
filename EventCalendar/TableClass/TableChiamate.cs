using System;
using Dapper.Contrib.Extensions;

namespace EventCalendar.TableClass
{
    [Table("Chiamate")]
    public class TableChiamate
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Events { get; set; }
        public DateTime Date { get; set; }
    }
}
