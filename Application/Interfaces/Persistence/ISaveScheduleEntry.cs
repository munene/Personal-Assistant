using Domain.Schedule;

namespace Application.Interfaces.Persistence
{
    public interface ISaveScheduleEntry
    {
        void Execute(Entry entry);
    }
}
