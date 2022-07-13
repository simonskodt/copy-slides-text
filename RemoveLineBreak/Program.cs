using System.Windows;

// Read slide text
var input = Console.In.ReadToEnd();

string cleaned = input.Replace("\n", " ").Replace("\r", "");

string addNewLines = cleaned.Replace("\a", System.Environment.NewLine);

Clipboard.SetDataObject(addNewLines);

Console.WriteLine(addNewLines);