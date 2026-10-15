using System;

namespace Task5_console
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Обчислення трьох сум ---");

          
            Console.WriteLine("Введіть ціле число n (більше 0):");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Помилка: n має бути цілим додатним числом.");
                return;
            }

         
            Console.WriteLine("Введіть ціле число k (більше 0):");
            if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0)
            {
                Console.WriteLine("Помилка: k має бути цілим додатним числом.");
                return;
            }
            
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;


            for (int i = 1; i <= k; i++)
            {
            
                sum1 += Math.Pow(i, (double)n / i); 
            }

           
            for (int i = 1; i <= n; i++)
            {
                sum2 += Math.Pow(i, k);
            }

         
            for (int i = 1; i <= k; i++)
            {
                sum3 += i / Math.Pow(n, i);
            }

            Console.WriteLine("\n--- Результати ---");
            Console.WriteLine($"1) Перша сума = {sum1}");
            Console.WriteLine($"2) Друга сума = {sum2}");
            Console.WriteLine($"3) Третя сума = {sum3}");

        }
    }
}
