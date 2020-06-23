using System;

namespace Domain.Schedule
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Metadata Metadata { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
    }
}
