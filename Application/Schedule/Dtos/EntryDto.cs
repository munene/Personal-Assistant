using Domain.Schedule;
using System;

namespace Application.Schedule.Dtos
{
    public class EntryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public MetadataDto Metadata { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
    }
}
