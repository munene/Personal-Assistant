﻿using System;
using System.Collections.Generic;
using Moq;
using Application.Schedule.Dtos;
using Application.Interfaces.Service;
using Xunit;
using Application.Schedule.Queries.GetScheduleEntries;

namespace Presentation.ViewModels.Tests
{
    public class SchedulerViewModelTests
    {
        Mock<IGetScheduleEntriesQuery> _entrySourceMock;
        List<EntryDto> _entries;
        SchedulePageViewModel _viewModel;

        public SchedulerViewModelTests()
        {
            _entrySourceMock = new Mock<IGetScheduleEntriesQuery>();
            _entrySourceMock.Setup(p => p.Execute()).Callback(() =>
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
            });

            _viewModel = new SchedulePageViewModel(_entrySourceMock.Object);
        }

        [Fact]
        public void ShouldGetEntriesFromSource()
        {
            _viewModel.GetScheduleEntries();
            Assert.NotNull(_entries);
            Assert.NotEmpty(_entries);
            Assert.Equal(3, _entries.Count);
        }
    }
}
