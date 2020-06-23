using Domain.Schedule;
using Moq;
using Service.Sources;
using System;
using System.Collections.Generic;
using Xunit;

namespace Service.Tests
{
    public class ExternalScheduleEntrySourceTests
    {
        Mock<IEntrySource> _entrySourceMock;
        List<Entry> _entries;

        public ExternalScheduleEntrySourceTests()
        {
            _entries = new List<Entry>
            {
                new Entry
                {
                    From = DateTime.Now,
                    To = DateTime.Now.AddMinutes(30),
                    Id = 1,
                    Metadata = null,
                    Source = "Test",
                    Title = "Test One",
                    SourceId = "1"
                },
                new Entry
                {
                    From = DateTime.Now,
                    To = DateTime.Now.AddMinutes(30),
                    Id = 2,
                    Metadata = null,
                    Source = "Test",
                    Title = "Test Two",
                    SourceId = "2"
                },
                new Entry
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
            _entrySourceMock = new Mock<IEntrySource>();
            _entrySourceMock.Setup(p => p.GetEntries()).Returns(_entries);
        }

        //[Fact]
        //public void ShouldReturnScheduleEntriesFromGoogleCalendar()
        //{
        //    var source = new GoogleCalendarEntrySource();
        //    var entries = source.GetEntries();
        //    Assert.Equal(_entries, entries);
        //}
    }
}
