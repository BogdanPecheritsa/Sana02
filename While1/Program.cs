using System.Text;

double a = 0, b = 0, c = 0;
int n1, n2, n3;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Задайте к-сть ітерацій a");
while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0)
{
    Console.WriteLine("Введіть додатне ціле число для к-сті ітерацій a:");
}

Console.WriteLine("Задайте к-сть ітерацій b");
while (!int.TryParse(Console.ReadLine(), out n2) || n2 < 0)
{
    Console.WriteLine("Введіть додатне ціле число для к-сті ітерацій b:");
}

Console.WriteLine("Задайте к-сть ітерацій с");
while (!int.TryParse(Console.ReadLine(), out n3) || n3 < 0)
{
    Console.WriteLine("Введіть додатне ціле число для к-сті ітерацій c:");
}

for (int i = 0; i <= n1; i++)
{
    a += -1.0 / 3 + 1.0 / 5 + -1.0 * (i % 2 * 2 - 1) / (2 * i + 1);
}
Console.WriteLine($"a = {a}");

for (int i = 1; i <= n2; i++)
{
    b += 1.0 / (i * i);
}
Console.WriteLine($"b = {b}");

for (int i = 1; i <= n3; i++)
{
    int Fact = 1;
    for (int j = 1; j <= i; j++)
    {
        Fact *= j;
    }
    c += Fact;
}
Console.WriteLine($"c = {c}");