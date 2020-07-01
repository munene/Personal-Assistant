using System;
using System.Collections.Generic;
using Moq;
using Application.Schedule.Dtos;
using Application.Interfaces.Service;
using Xunit;

namespace Presentation.ViewModels.Tests
{
    public class SchedulerViewModelTests
    {
        Mock<IScheduleFetcher> _entrySourceMock;
        List<EntryDto> _entries;
        SchedulePageViewModel _viewModel;

        public SchedulerViewModelTests()
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

            _viewModel = new SchedulePageViewModel(_entrySourceMock.Object);
        }

        [Fact]
        public void ShouldGetEntriesFromSource()
        {
            Assert.NotNull(_viewModel.Entries);
            Assert.NotEmpty(_viewModel.Entries);
        }
    }
}
