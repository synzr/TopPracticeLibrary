using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TopPracticeLibrary.Contexts;
using TopPracticeLibrary.Services;

namespace TopPracticeLibrary;

public class Program
{
    public static async Task Main(string[] args)
    {
        // устанавливаем кодировку UTF-8 для корректного отображения символов в консоли
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var host = CreateHost(args);

        // создаем базу данных, если ее нет
        using (var scope = host.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<LibraryDbContext>();
            dbContext.Database.EnsureCreated();
        }

        // запускаем программу
        var programService = host.Services.GetRequiredService<IProgramService>();
        await programService.RunAsync();
    }

    private static IHost CreateHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                // 1. регистрируем DbContext
                services.AddDbContext<LibraryDbContext>(options =>
                {
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DefaultConnection"));
                });

                // 2. регистрируем сервисы
                services.AddScoped<IProgramService, ProgramService>();
            })
            .Build();
    }
}
