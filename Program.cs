// See https://aka.ms/new-console-template for more information
// программа с беконечным циклом
// Когда пользователь вводит exit программа заканчивается
string stringOut = "exit";
string? test = String.Empty;

Console.WriteLine($"Сложите ваши яблоки по одному, когда яблоки закончатся введите {stringOut}");
Console.WriteLine("В конце мы подведем итог");
while(test != stringOut)
{
    test = Console.ReadLine();
}

Console.WriteLine("Hello, World!");
