for (; ; )
{
    Console.Clear();
    Console.WriteLine("Введите X");
    if (double.TryParse(Console.ReadLine(), out double x))
        { if (Math.Abs(x) < 1)
        {
            double sum = 1,
                func = Math.Cos(x);
            for (int n = 1; n <= 50; n++)
            {
                sum += 1 - (4 * Math.Pow(x, 2) / (Math.Pow(2, 2) * Math.Pow(2, n) + 1)) * Math.PI * Math.PI;
            }
            Console.WriteLine($"Значение расчетной функции равно: \t{Math.Round(sum, 3)}");
            Console.WriteLine($"Значение аналетической функции равно: \t{Math.Round(func, 3)}");
            if (Math.Abs(sum - func) < 0.1)
            { Console.WriteLine("Расчет произведен верно");
            }

        }
        else
        {
            Console.WriteLine("Аргумент задан не верно");
        }
    }
    else
    {
        Console.WriteLine("Не удалось получить x");
    }
    Console.ReadKey();
}

       
    