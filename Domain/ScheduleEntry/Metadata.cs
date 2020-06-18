using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ScheduleEntry
{
    public class Metadata
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsAlarm { get; set; }
    }
}
