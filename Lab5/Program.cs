using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            int sum = 0;

            var ms1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            for (int i = 0; i < 10000; i++)
            {
                Random rnd = new Random();
                x = rnd.NextDouble();
                y = rnd.NextDouble();
                if (x * x + y * y < 1.0) sum++;
            }
            Console.WriteLine("Przybliżona wartość pi: " + 4.0 * sum / 10000.0);
            var ms2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Czas wykonania: {0:0} milliseconds", (ms2 - ms1));


            sum = 0;

            ms1 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Parallel.For(0, 10000, i => {
                Random rnd = new Random();
                x = rnd.NextDouble();
                y = rnd.NextDouble();
                if (x * x + y * y < 1.0) Interlocked.Add(ref sum, 1);
            });
            Console.WriteLine("Przybliżona wartość pi: " + 4.0 * sum / 10000.0);
            ms2 = (DateTime.UtcNow - DateTime.MinValue).TotalMilliseconds;
            Console.WriteLine("Czas wykonania: {0:0} milliseconds", (ms2 - ms1));

            ConcurrentBag<int> tmp = new ConcurrentBag<int>();
            Parallel.For(0, 1000000, i => {
                if (i % 56789 == 0) tmp.Add(i);
            });
            List<int> solution = tmp.ToArray().OrderBy(i => i).ToList();
            foreach (int i in solution) { Console.WriteLine(i); }
        }

    }
}