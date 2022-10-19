// See https://aka.ms/new-console-template for more information
// программа с беконечным циклом
// Когда пользователь вводит exit программа заканчивается
string stringOut = "exit";
string? test = String.Empty;
int count = 0;
int sumTotal = 0;

Console.WriteLine($"Сложите ваши яблоки, когда яблоки закончатся введите {stringOut}");
Console.WriteLine("В конце мы подведем итог");

while(test != stringOut)
{
    test = Console.ReadLine();

    if (Int32.TryParse(test, out count))
        sumTotal = sumTotal + count;
    else
    {
        if (test != stringOut)
            Console.WriteLine("Вводите цифры, пожалуйста!");
    }
}

Console.WriteLine($"Всего {sumTotal} яблок");
