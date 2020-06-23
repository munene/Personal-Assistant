using Domain.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Persistence
{
    public interface IGetScheduleEntry
    {
        Entry Exectute(int id);
    }
}
