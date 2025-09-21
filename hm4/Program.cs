using System;

class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        Console.WriteLine("romeli sakitxi ginda:");
        Console.WriteLine("1 - naxevarpiramida fifqebit");
        Console.WriteLine("2 - luwi ricxvebi diapazonshi");
        Console.WriteLine("3 - kalkulatori ");
        Console.Write("sheni archeuili: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Sheiyvante ricxvi: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        else if (choice == 2)
        {
            Console.Write("sheiyvanet piverili ricxvi : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("sheiyvanet meore ricxvi: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine($"luwi ricxvebi diapazonshi {a}–dan {b}–mde:");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        else if (choice == 3)
        {
            try
            {
                Console.Write("sheiyvane pirveli ricxvi: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("sheiyvane moere ricxvi: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("airchie operacia (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = 0;

                switch (op)
                {
                    case '+': result = a + b; break;
                    case '-': result = a - b; break;
                    case '*': result = a * b; break;
                    case '/':
                        if (b == 0)
                            throw new DivideByZeroException("nulze gayofa ar sheidzleba!");
                        result = a / b;
                        break;
                    default:
                        throw new Exception("araswori operacia!");
                }

                Console.WriteLine($"shedegi: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"shecdoma: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Shecdoma:gtxovt Sheiyvanot swori ricxvi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"gautvaliswinebeli shecdoma: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("araswori archevani!");
        }
    }
}
