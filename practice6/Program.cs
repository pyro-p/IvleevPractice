using Serilog;
using Serilog.Events;

namespace practice6;

public class Program
{

    static void Main(string[] args)
    {
        var consoleLogger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
            .CreateLogger();

        var fileLogger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("log-.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        double x = 1;
        double h = 0.05;
        int n = 25;
        double slag = 0;

        while (x <= 1 + h)
        {
            double y = Math.Exp(x * Math.Cos(Math.PI / 4)) * Math.Cos(x * Math.Sin(Math.PI / 4));
            double s = 1;
            for (int i = 1; i <= n; i++)
            {
                int k = 1;
                for (int j = 2; j <= i; j++)
                {
                    k *= j;
                    consoleLogger.Debug($"i={i}\t| s={Math.Round(s, 7)}\t| k={k}\t| slag={Math.Round(slag, 7)}\n");
                    fileLogger.Debug($"i={i}\t| s={Math.Round(s, 7)}\t| k={k}\t| slag={Math.Round(slag, 7)}\n");
                }
                slag = Math.Cos(i * Math.PI / 4) / k * Math.Pow(x, i);
                s += slag;
            }
            consoleLogger.Debug($"{Math.Round(x, 3)}\t| {Math.Round(y, 7)}\t| {Math.Round(s, 7)}\n");
            fileLogger.Debug($"{Math.Round(x, 3)}\t| {Math.Round(y, 7)}\t| {Math.Round(s, 7)}\n");
            x += h;
        }
    }
}