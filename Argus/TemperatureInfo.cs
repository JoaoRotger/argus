using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;

namespace Argus
{
    public class TemperatureInfo
    {
        public List<(string SensorName, float TemperatureCelsius)> GetTemperatures()
        {
            var temps = new List<(string, float)>();
            var computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMotherboardEnabled = true
            };

            computer.Open();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                    {
                        temps.Add((sensor.Name, sensor.Value.Value));
                    }
                }
            }

            computer.Close();
            return temps;
        }
    }
}
