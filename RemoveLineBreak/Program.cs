while (true)
{
    var input = Console.In.ReadToEnd();

    Console.WriteLine(ReadSlideText(input) + "\n\n");
}

static string ReadSlideText(string input)
{
    string cleaned = input.Replace("\n", " ").Replace("\r", "");

    string addNewLines = cleaned.Replace("\a", Environment.NewLine);

    return addNewLines;
}