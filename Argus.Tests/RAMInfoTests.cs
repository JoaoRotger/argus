using Xunit;
using Argus;
using System.Runtime.Versioning;

namespace Argus.Tests
{
    public class RamInfoTests
    {
        [SupportedOSPlatform("windows")]
        [Fact]
        public void RamUsage_ShouldReturnValueWithPercentSign()
        {
            var ram = new RamInfo();
            string result = ram.GetInfo();
            Xunit.Assert.Contains("%", result);
        }
    }
}
