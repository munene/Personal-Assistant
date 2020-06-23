using Application.Schedule.Dtos;
using System.Collections.Generic;
using Application.Interfaces.Service;
using Prism.Mvvm;

namespace Presentation.ViewModels
{
    public class ScheduleViewModel : BindableBase
    {
        public List<EntryDto> Entries { get; set; }
        public ScheduleViewModel(IScheduleFetcher scheduleFetcher)
        {
            Entries = scheduleFetcher.GetEntriesFromSource();
        }
    }
}
