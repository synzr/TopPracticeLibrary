namespace TopPracticeLibrary.UI;

public class Menu
{
    /// <summary>
    /// Название меню
    /// </summary>
    private readonly string _title;

    /// <summary>
    /// Опции меню
    /// </summary>
    private readonly string[] _options;

    public Menu(string title, string[] options)
    {
        _title = title;
        _options = options;
    }

    /// <summary>
    /// Отображает меню и возвращает индекс выбранной опции.
    /// </summary>
    /// <returns>Индекс выбранной опции</returns>
    public int Show()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', _title.Length));
        Console.WriteLine(_title);
        Console.WriteLine(new string('-', _title.Length));

        Console.WriteLine();
        for (int i = 0; i < _options.Length; i++)
        {
            Console.WriteLine($"[{i + 1}] {_options[i]}");
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', _title.Length));
        Console.Write("Выберите опцию: ");

        var userInput = Console.ReadLine();
        Console.WriteLine(new string('-', _title.Length));

        if (!int.TryParse(userInput, out int selectedOption))
        {
            return -1;
        }

        if (selectedOption >= 1 && selectedOption <= _options.Length)
        {
            return selectedOption - 1; // Возвращаем индекс (начинается с 0)
        }
        else
        {
            return -1;
        }
    }
}
