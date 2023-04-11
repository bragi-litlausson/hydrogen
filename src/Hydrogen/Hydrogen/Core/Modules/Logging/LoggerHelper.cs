using System;
using Serilog;

namespace Hydrogen.Core.Modules.Logging;

public static class LoggerHelper
{
    public static void Initialize()
    {
        Log.Logger = new LoggerConfiguration()
#if DEBUG
            .MinimumLevel.Verbose()
            .WriteTo.Debug()
            .WriteTo.Console()
            .CreateLogger();
#else
            throw new NotImplementedException()
#endif
        Log.Information("Logger initialized");
    }
}