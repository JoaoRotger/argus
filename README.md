# Argus

**Argus** is a modular C# library for system monitoring. Inspired by the mythological all-seeing figure, it collects real-time information on CPU usage, RAM, temperature, and other resources.

## Features

- [x] CPU usage (%)
- [x] RAM usage (%)
- [x] Temperature
- [ ] Disk, Network, GPU (planned)

## Structure

Each type of system information is in its own class, derived from `SystemMonitor`.

## Tests

Unit tests using xUnit are in `Argus.Tests`.

### Running the tests

In Visual Studio:
- Open the **Test > Run All Tests** menu
- Or right-click on `Argus.Tests` > Run Tests

## Requirements

- .NET 8.0
- Windows
- Microsoft.VisualBasic (for RAM info)

## License

MIT
