using Domain.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Infrastructure
{
    public interface ISetTimer
    {
        void Execute(Entry entry);
    }
}
