using System;
using System.Collections.Generic;
using System.Text;

namespace TopPracticeLibrary.Services;

public class ProgramService : IProgramService
{
    /// <inheritdoc />
    public Task RunAsync()
    {
        Console.WriteLine("TODO: реализовать логику программы");

        return Task.CompletedTask;
    }
}
