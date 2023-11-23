using System.Text;

double a, b, c, d, x1, x2;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Значення а:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Значення b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Значення c:");
c = double.Parse(Console.ReadLine());

if (a == 0)
{
    x1 = -c / b;
    Console.WriteLine($"x={x1}");
}
else
{
    d = b * b - 4 * a * c;
    if (d < 0)
        Console.WriteLine("Коренів немає");
    else if (d == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"x={x1}");
    }
    else if (d > 0)
    {
        x1 = (-b + System.Math.Sqrt(d)) / (2 * a);
        x2 = (-b - System.Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"x1={x1}, x2={x2}");
    }
}