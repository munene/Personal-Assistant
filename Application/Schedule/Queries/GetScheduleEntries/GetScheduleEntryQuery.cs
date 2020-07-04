using Application.Interfaces.Service;
using Application.Schedule.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Schedule.Queries.GetScheduleEntries
{
    public class GetScheduleEntryQuery : IGetScheduleEntriesQuery
    {
        IScheduleFetcher _scheduleFetcher;

        public GetScheduleEntryQuery(IScheduleFetcher scheduleFetcher)
        {
            _scheduleFetcher = scheduleFetcher;
        }
        public List<EntryDto> Execute()
        {
            return _scheduleFetcher.GetEntriesFromSource();
        }
    }
}
