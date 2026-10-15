using System;

namespace Task4_console
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Розв'язання квадратного рівняння (ax^2 + bx + c = 0) ---");

            Console.WriteLine("Введіть коефіцієнт a:");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Помилка: Некоректно введено 'a'. Потрібно ввести число.");
                return; 
            }

            if (a == 0)
            {
                Console.WriteLine("Помилка: Коефіцієнт 'a' не може бути нулем у квадратному рівнянні.");
                return;
            }

            Console.WriteLine("Введіть коефіцієнт b:");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Помилка: Некоректно введено 'b'. Потрібно ввести число.");
                return;
            }

            Console.WriteLine("Введіть коефіцієнт c:");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Помилка: Некоректно введено 'c'. Потрібно ввести число.");
                return;
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
           
            Console.WriteLine($"\n Дискримінант (D) = {discriminant}");

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                
                Console.WriteLine("Рівняння має ДВА розв'язки:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (discriminant == 0)
            {
              
                double x = -b / (2 * a);
                
                Console.WriteLine("Рівняння має ОДИН розв'язок:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Рівняння НЕ МАЄ дійсних розв'язків (коренів), оскільки дискримінант менше нуля.");
            } 
        }
    }
}