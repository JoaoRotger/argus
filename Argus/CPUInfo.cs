using System.Diagnostics;
using System.Runtime.Versioning;

namespace Argus
{
    public class CpuInfo : ArgusMonitor
    {
        [SupportedOSPlatform("windows")]
        public override string GetInfo()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            return $"{cpuCounter.NextValue()}%";
        }
    }
}
