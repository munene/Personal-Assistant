using Application.Interfaces.Service;
using Application.Schedule.Queries.GetScheduleEntries;
using Autofac;
using Presentation.ViewModels;
using Service.Sources;
using System;

namespace Specification.Shared
{
    public static class IoC
    {
        public static IContainer Container { get; set; }

        /// <summary>
        /// Initialize the IOC container and register the types
        /// </summary>
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GetScheduleEntryQuery>().As<IGetScheduleEntriesQuery>();
            builder.RegisterType<GoogleCalendarFetcher>().As<IScheduleFetcher>();
            builder.RegisterType<SchedulePageViewModel>();
            Container = builder.Build();
        }

        public static object ResolveType(Type type)
        {
            return Container.Resolve(type);
        }
    }
}
