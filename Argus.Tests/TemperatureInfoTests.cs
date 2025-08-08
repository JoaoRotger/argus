using Xunit;
using Argus;

namespace Argus.Tests
{
    public class TemperatureInfoTests
    {
        [Fact]
        public void GetTemperatures_ShouldReturnAtLeastOneSensor()
        {
            var tempInfo = new TemperatureInfo();
            var temps = tempInfo.GetTemperatures();

            Xunit.Assert.NotNull(temps);
            Xunit.Assert.NotEmpty(temps);
        }
    }
}
