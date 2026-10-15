using System;

namespace task3_console{
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double x, y, z;

        Console.Write("Введіть число x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Помилка! Введіть дійсне число для x: ");
        }

        Console.Write("Введіть число y: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Помилка! Введіть дійсне число для y: ");
        }

        Console.Write("Введіть число z: ");
        while (!double.TryParse(Console.ReadLine(), out z))
        {
            Console.Write("Помилка! Введіть дійсне число для z: ");
        }

        if (z <= 0)
            {
            Console.WriteLine("Помилка: z має бути більше за 0, бо з нуля чи від'ємного числа не можна взяти логарифм (ln)!");
            return;
        }

        if (x - y == 0)
        {
            Console.WriteLine("Помилка: різниця (x - y) дорівнює нулю, а на нуль ділити не можна!");
            return;
        }

    
        double term1 = y - x;
        double cosY = Math.Cos(y);
        double lnZ = Math.Log(z); 

        double innerFraction = lnZ / (x - y);
        double numerator = cosY - innerFraction;
        double denominator = 1 + Math.Pow(x - z, 2);
        double s = term1 * (numerator / denominator);
        Console.WriteLine($"\n Результати обчислення: s = {s:F3}");
    }
}
}