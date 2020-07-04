using Application.Interfaces.Service;
using Application.Schedule.Dtos;
using Application.Schedule.Queries.GetScheduleEntries;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Application.Tests.Queries
{
    public class ScheduleEntryQueryTests
    {
        Mock<IScheduleFetcher> _entrySourceMock;
        List<EntryDto> _entries;
        GetScheduleEntryQuery _scheduleEntryQuery;

        public ScheduleEntryQueryTests()
        {
            _entries = new List<EntryDto>
            {
                new EntryDto
                {
                    From = DateTime.Now,
                    To = DateTime.Now.AddMinutes(30),
                    Id = 1,
                    Metadata = null,
                    Source = "Test",
                    Title = "Test One",
                    SourceId = "1"
                },
                new EntryDto
                {
                    From = DateTime.Now,
                    To = DateTime.Now.AddMinutes(30),
                    Id = 2,
                    Metadata = null,
                    Source = "Test",
                    Title = "Test Two",
                    SourceId = "2"
                },
                new EntryDto
                {
                    From = DateTime.Now,
                    To = DateTime.Now.AddMinutes(30),
                    Id = 3,
                    Metadata = null,
                    Source = "Test",
                    Title = "Test Three",
                    SourceId = "3"
                }
            };
            _entrySourceMock = new Mock<IScheduleFetcher>();
            _entrySourceMock.Setup(p => p.GetEntriesFromSource()).Returns(_entries);
            _scheduleEntryQuery = new GetScheduleEntryQuery(_entrySourceMock.Object);
        }

        [Fact]
        public void ShouldGetListOfEntries()
        {
            var entries = _scheduleEntryQuery.Execute();

            Assert.NotNull(entries);
            Assert.NotEmpty(entries);
        }
    }
}
