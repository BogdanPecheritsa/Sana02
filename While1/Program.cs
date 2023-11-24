using System;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a = 0, b = 0, c = 1;

string[] vars = { "a", "b", "c" };
int[] counts = new int[3];

for (int i = 0; i < vars.Length; i++)
{
    Console.WriteLine($"Задайте к-сть ітерацій {vars[i]}");
    while (!int.TryParse(Console.ReadLine(), out counts[i]) || counts[i] < 0)
    {
        Console.WriteLine($"Введіть додатне ціле число для к-сті ітерацій {vars[i]}:");
    }
}

for (int i = 0; i < counts.Length; i++)
{
    switch (vars[i])
    {
        case "a":
            for (int j = 1; j <= counts[i]; j++)
            {
                a += 1.0 / (j * j);
            }
            Console.WriteLine($"a = {a}");
            break;
        case "b":
            for (int j = 1; j <= counts[i]; j++)
            {
                b += 1.0 / (j * j);
            }
            Console.WriteLine($"b = {b}");
            break;
        case "c":
            for (int j = 1; j <= counts[i]; j++)
            {
                c *= j;
            }
            Console.WriteLine($"c = {c}");
            break;
    }
}