using Xunit;
using Argus;
using System.Runtime.Versioning;

namespace Argus.Tests
{
    public class CpuInfoTests
    {
        [Fact]
        [SupportedOSPlatform("windows")]
        public void CpuUsage_ShouldReturnValueWithPercentSign()
        {
            var cpu = new CpuInfo();
            string result = cpu.GetInfo();
            Xunit.Assert.Contains("%", result);
        }
    }
}
