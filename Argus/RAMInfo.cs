using System.Diagnostics;
using System.Management;
using System.Runtime.Versioning;

namespace Argus
{
    public class RamInfo : ArgusMonitor
    {
        [SupportedOSPlatform("windows")]
        public override string GetInfo()
        {
            ulong total = 0;
            ulong available = 0;

            var searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");
            foreach (var obj in searcher.Get())
            {
                total = (ulong)obj["TotalVisibleMemorySize"] * 1024;
                available = (ulong)obj["FreePhysicalMemory"] * 1024;
            }

            double usedPercent = 100.0 * (total - available) / total;
            return $"{usedPercent:F2}%";
        }
    }
}
