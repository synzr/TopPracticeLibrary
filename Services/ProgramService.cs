using TopPracticeLibrary.UI;

namespace TopPracticeLibrary.Services;

public class ProgramService : IProgramService
{
    /// <inheritdoc />
    public Task RunAsync()
    {
        var menu = new Menu(
            title: "Библиотека",
            options: ["Выход"]
        );

        // отображаем меню и обрабатываем выбор пользователя
        var selectedOption = -1;
        while (selectedOption == -1)
        {
            selectedOption = menu.Show();

            switch (selectedOption)
            {
                case 0: // пользователь выбрал "Выход"
                    return Task.CompletedTask;
            }
        }

        return Task.CompletedTask;
    }
}
