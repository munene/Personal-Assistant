using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Schedule.Dtos
{
    public class MetadataDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsAlarm { get; set; }
        public bool UsesTimer { get; set; }
        public List<ParticipantDto> Participants { get; set; }
        public List<string> Links { get; set; }
    }
}
