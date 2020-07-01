using Application.Schedule.Dtos;
using System.Collections.Generic;
using Application.Interfaces.Service;
using Prism.Mvvm;

namespace Presentation.ViewModels
{
    public class SchedulePageViewModel : BindableBase
    {
        public SchedulePageViewModel()
        {

        }

        public List<EntryDto> Entries { get; set; }
        public string EntriesCount { get; set; } = "3";
        public SchedulePageViewModel(IScheduleFetcher scheduleFetcher)
        {
            Entries = scheduleFetcher.GetEntriesFromSource();
        }
    }
}
