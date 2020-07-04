using Application.Interfaces.Service;
using Application.Schedule.Dtos;
using System.Collections.Generic;

namespace Application.Schedule.Queries.GetScheduleEntries
{
    public interface IGetScheduleEntriesQuery
    {
        List<EntryDto> Execute();
    }
}
