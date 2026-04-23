using System;
using System.Collections.Generic;
using System.Text;

namespace TopPracticeLibrary.Services;

public interface IProgramService
{
    /// <summary>
    /// Запускаем программу асинхронно.
    /// </summary>
    Task RunAsync();
}
