using Xunit;

namespace Domain.Tests
{
    public class MetadataTests
    {
        [Fact]
        public void MetadataClassShouldContainCorrectProps()
        {
            var metadata = new Schedule.Metadata();
            var validProperties = new string[] { "Id", "Description", "IsAllDay", "IsAlarm", "UsesTimer", "Participants", "Links" };

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
