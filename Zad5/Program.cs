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
        static long factorial(int a)
        {
            if (a < 2)
            {
                return 1;
            }
            else
            {
                return a * factorial(a - 1);
            }
        }
        static void Main(string[] args)
        {

            ConcurrentBag<int> tmp = new ConcurrentBag<int>();
            Parallel.For(0, 1000000, i => {
                if ((i + factorial(i % 5) + factorial(i % 7)) % 96800 == 0) tmp.Add(i);
            });
            List<int> solution = tmp.ToArray().OrderBy(i => i).ToList();
            foreach (int i in solution) { Console.WriteLine(i); }
        }

    }
}