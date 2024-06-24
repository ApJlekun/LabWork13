using System.Text;

Console.WriteLine("Введите строку ");
string userText = Console.ReadLine();
Console.WriteLine("Количество символов в строке: " + userText.Length);

int spaces = 0;
foreach (char c in userText)
{
    if (char.IsWhiteSpace(c))
    {
        spaces++;
    }
}
Console.WriteLine("Количество символов без пробелов: " + (userText.Length - spaces));

int letters = 0;
foreach (char c in userText)
{
    if (char.IsLetter(c))
    {
        letters++;
    }
}
Console.WriteLine("Количество букв в строке: " + letters);

Console.WriteLine("Введите символ для поиска:");
char searchChar = Console.ReadKey().KeyChar;
Console.WriteLine();

for (int i = 0; i < userText.Length; i++)
{
    if (userText[i] == searchChar)
    {
        Console.WriteLine("Символ '" + searchChar + "' найден на позиции " + i);
    }
}

if (!userText.Contains(searchChar))
    Console.WriteLine("Совпадений не найдено.");

Console.WriteLine("Выберите регистр букв:");
Console.WriteLine("1. Верхний (ТЕКСТ)");
Console.WriteLine("2. Нижний (текст)");
Console.WriteLine("3. Инвертированный (теКСТ -> ТЕкст)");
int choice = int.Parse(Console.ReadLine());

StringBuilder strBuild = new StringBuilder();
switch (choice)
{
    case 1:
        foreach (char c in userText)
            strBuild.Append(char.ToUpper(c));
        break;
    case 2:
        foreach (char c in userText)
            strBuild.Append(char.ToLower(c));
        break;
    case 3:
        string invertStr = string.Empty;
        foreach (var c in userText)
            invertStr += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        Console.WriteLine(invertStr);


        break;

    default:
        Console.WriteLine("Неверный выбор");
        return;
}

string trimmed = strBuild.ToString().Trim();
trimmed = trimmed.Replace("  ", " ");

Console.WriteLine("Измененная строка:");
Console.WriteLine(trimmed);


