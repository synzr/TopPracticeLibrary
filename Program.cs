using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TopPracticeLibrary.Services;

namespace TopPracticeLibrary;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHost(args);

        // запускаем программу
        var programService = host.Services.GetRequiredService<IProgramService>();
        await programService.RunAsync();
    }

    private static IHost CreateHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddScoped<IProgramService, ProgramService>();
            })
            .Build();
    }
}
