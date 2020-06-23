using Domain.Schedule;
using System.Collections.Generic;

namespace Application.Interfaces.Service
{
    public interface IFetchScheduleEntries
    {
        List<Entry> GetEntriesFromSource();
    }
}
