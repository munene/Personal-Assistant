using Application.Schedule.Dtos;
using System.Collections.Generic;
using Application.Interfaces.Service;
using Prism.Mvvm;
using Application.Schedule.Queries.GetScheduleEntries;

namespace Presentation.ViewModels
{
    public class SchedulePageViewModel : BindableBase
    {
        IGetScheduleEntriesQuery _getScheduleEntriesQuery;
        public SchedulePageViewModel(IGetScheduleEntriesQuery getScheduleEntriesQuery)
        {
            _getScheduleEntriesQuery = getScheduleEntriesQuery;
        }

        public List<EntryDto> Entries { get; set; }
        public string EntriesCount { get; set; } = "3";

        public void GetScheduleEntries()
        {
            Entries = _getScheduleEntriesQuery.Execute();
        }
    }
}
