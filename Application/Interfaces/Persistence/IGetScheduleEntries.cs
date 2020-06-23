using Domain.Schedule;
using System.Collections.Generic;

namespace Application.Interfaces.Persistence
{
    public interface IGetScheduleEntries
    {
        List<Entry> Execute();
    }
}
