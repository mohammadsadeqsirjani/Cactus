# Cactus.Blade.Core

![Logo](Image/cactus-64.png)

## What is Cactus.Blade.Core

Cactus.Blade.Core is a simple utility that solves a common problem pragmatically - storing and accessing objects quickly in a .NET app. It is designed with a specific vision in mind: provide a **simple solution for persisting objects**, even between sessions, that is unobtrusive and requires zero configuration.

## Getting Started

### Installing

Once you're game, simply add it to your project [through NuGet](https://www.nuget.org/packages/Cactus.Blade.Core).

NuGet Package Manager:

```bash
    Install-Package Cactus.Blade.Core
```

NuGet CLI:

```bash
    nuget install Cactus.Blade.Core
```

### Prerequisites

The Cactus.Blade.Core library is built on **netstandard2.1**. This means it's compatible with .NET 5.x and up, .NET Core 2.x and up and traditional .NET 4.6.1 and higher. See the Microsoft [docs on .NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard#net-platforms-support).

For traditional .NET 4.6.1+, you also need to have a more recent version of NuGet installed (NuGet v4 and up), which comes out-of-the-box with the latest updated versions of Visual Studio 2019 and [JetBrains Rider](https://www.jetbrains.com/rider/).

Cactus.Blade.Core is Copyright &copy; 2020 Mohammad Sadeq Sirjani under the [MIT license](LICENSE.txt).
