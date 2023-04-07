using System.Runtime.Versioning;
using Avalonia;
using Avalonia.Browser;

[assembly: SupportedOSPlatform("browser")]

namespace Hydrogen.Browser;

internal partial class Program
{
    private static void Main(string[] args) => BuildAvaloniaApp()
        .SetupBrowserAppAsync();

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}