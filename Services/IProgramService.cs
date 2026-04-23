namespace TopPracticeLibrary.Services;

public interface IProgramService
{
    /// <summary>
    /// Запускаем программу асинхронно.
    /// </summary>
    Task RunAsync();
}
