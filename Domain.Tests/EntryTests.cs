using Xunit;

namespace Domain.Tests
{
    public class EntryTests
    {
        [Fact]
        public void DomainShouldContainCorrectProps()
        {
            var scheduleEntry = new Schedule.Entry();
            var validProperties = new string[] { "Id", "Title", "From", "To", "Metadata", "Source", "SourceId" };

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
