using Application.Interfaces.Service;
using Autofac;
using Service.Sources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Shared
{
    public static class IoC
    {
        private static IContainer Container { get; set; }

        /// <summary>
        /// Initialize the IOC container and register the types
        /// </summary>
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GoogleCalendarFetcher>().As<IScheduleFetcher>();
            Container = builder.Build();
        }
    }
}
