using Xunit;

namespace Domain.Tests
{
    public class ScheduleEntryTests
    {
        [Fact]
        public void DomainShouldContainCorrectProps()
        {
            var scheduleEntry = new ScheduleEntry.ScheduleEntry();
            var validProperties = new string[] { "ID", "Title", "Start", "End", "Metadata" };

            // Check that each prop exists
            foreach (var property in validProperties)
            {
                Assert.NotNull(scheduleEntry.GetType().GetProperty(property));
            }

            // Count the number of properties
            Assert.Equal(validProperties.Length, scheduleEntry.GetType().GetProperties().Length);
        }
    }
}
