Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("COPY MACHINE :: INSERT YOUR TEXT HERE\n");

Console.ResetColor();

while (true)
{
    var input = Console.In.ReadToEnd();

    Console.WriteLine(ReadSlideText(input) + "\n\n");
}

static string ReadSlideText(string input)
{
    string cleaned = input.Replace(" \n", " ").Replace("\n", " ").Replace("\r", "");

    string addNewLines = cleaned.Replace("\a", Environment.NewLine + "- ");

    return addNewLines;
}