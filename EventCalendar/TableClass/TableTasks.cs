using System;
using Dapper.Contrib.Extensions;

namespace EventCalendar.TableClass
{

    [Table("Tasks")]
    public class TableTasks
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
