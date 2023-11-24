using System;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть 5 оцінок студента(0-100)");
int mark;
int result = 0;
for (int i = 0; i < 5; i++)
{
    while (!int.TryParse(Console.ReadLine(), out mark))
    {
        Console.WriteLine("Будь ласка, введіть коректне число.");
    }
    result += mark / 5;
}
if (result >= 50)
    Console.WriteLine("Студента допущено до екзамену");
else
{
    Console.WriteLine("Студента не допущено до екзамену");
}