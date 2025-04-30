using System;

namespace Hello_world
{
    class Program
    {
        static double Pythagoras(double a, double b)
        {
            double result; //zmienna pomocnicza
            result = Math.Sqrt(a * a + b * b);
            return result;
            // także poprawnie wykona się return Math.Sqrt(a*a + b*b)
        }
        static bool IsPrime(int a)
        {
            if (a < 2)
            {
                return false;
            }
            int k = 2;
            while (k * k <= a)
            {
                if (a % k == 0)
                {
                    return false;
                }
                k++;
            }
            return true;
        }
        static long silnia(int a)
        {
            if (a < 2)
            {
                return 1;
            }
            else
            {
                return a * silnia(a - 1);
            }
        }
        static void PrintFactorial(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Nie można tak");
            }
            else
            {
                Console.WriteLine("Factorial of " + a + " is equal to " + silnia(a));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Inna wiadomość"); // nie ma na koniec endline'a
            Console.WriteLine("Hello World!");
            Console.Write("Inna wiadomość"); //i tu też
            //Console.ReadKey(); //pozwala wprowadzić dokładnie jeden znak

            int number1 = 3;
            int number2 = 4;
            int sum = number1 + number2;
            Console.WriteLine("\nResult: " + sum);

            number1 = 7;
            number1 = number1 - number2;
            double pi = 3.14159;
            char s = 'S'; // do pojedynczych znaków w charze pojedynczy nawias
            string university = "AGH";
            Console.WriteLine("Variables: " + number1 + "\n" + pi + "\n" + s + "\n" + university);

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i + "*" + j + "=" + j * i + " ");
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < 101; i++)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            double result1 = Pythagoras(3, 4);
            Console.WriteLine("\n" + result1);
            for (int i = 2; i < 101; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n" + silnia(5));
            PrintFactorial(6);

            RightTriangle triangle1 = new RightTriangle();
            triangle1.Color = "green";
            triangle1.A = 5;
            triangle1.B = 6;
            Console.WriteLine(triangle1.ComputeTangent());
            Console.WriteLine(triangle1.Color);

        }

    }
}