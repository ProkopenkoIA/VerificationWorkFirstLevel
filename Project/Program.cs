Console.Clear();

string[] CheckElement(string[] array)
{
    string[] result = new string[] { };

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = array[i];
        }
    }

    if (result.Length == 1)
    {
        result[result.Length - 1] = "Нет рузультата!";
    }
    return result;
}


string consoleString = string.Empty;
string[] consoleArray;
string[] resultArray;
Console.WriteLine("Введите исходную строку через пробел и нажмите Enter...");
consoleString = Console.ReadLine();

if (consoleString != null)
{
    consoleArray = consoleString.Split(new Char[] { ' ' });
    resultArray = CheckElement(consoleArray);
    Console.WriteLine($"Результат: [{string.Join(", ", resultArray)}]");
}


