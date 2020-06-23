using Application.Schedule.Dtos;
using Domain.Schedule;
using System.Collections.Generic;

namespace Application.Interfaces.Service
{
    public interface IScheduleFetcher
    {
        List<EntryDto> GetEntriesFromSource();
    }
}
