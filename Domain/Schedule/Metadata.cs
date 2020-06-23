using System.Collections.Generic;

namespace Domain.Schedule
{
    public class Metadata
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsAlarm { get; set; }
        public bool UsesTimer { get; set; }
        public List<Participant> Participants { get; set; }
        public List<string> Links { get; set; }
    }
}
