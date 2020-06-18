using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Tests
{
    public class MetadataTests
    {
        [Fact]
        public void MetadataClassShouldContainCorrectProps()
        {
            var metadata = new ScheduleEntry.Metadata();
            var validProperties = new string[] { "ID", "Description", "IsAllDay", "IsAlarm" };

            // Check that each prop exists
            foreach (var property in validProperties)
            {
                Assert.NotNull(metadata.GetType().GetProperty(property));
            }

            // Count the number of properties
            Assert.Equal(validProperties.Length, metadata.GetType().GetProperties().Length);
        }
    }
}
