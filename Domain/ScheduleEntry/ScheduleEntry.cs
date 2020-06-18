using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ScheduleEntry
{
    public class ScheduleEntry
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Metadata Metadata { get; set; }
    }
}
