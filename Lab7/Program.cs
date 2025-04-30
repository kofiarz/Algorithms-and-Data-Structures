using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            List<int> integers = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                n = rnd.Next(0, 100000);
                integers.Add(n);
            }
            
            for (int i = 0; i < 100000; i++)
            {
                integers.Find(n => n == i);
            }

            Tree drzewo = Tree.ZadanieDomowe();
            drzewo.Print();

            //A
            Console.WriteLine(drzewo.MinValue());
            Console.WriteLine(drzewo.MaxValue());

            //B
            Console.WriteLine(drzewo.SumValues());

            //D
            Console.WriteLine(drzewo.CountAllLinks());

            //E
            Console.WriteLine(drzewo.Depth(49));

        }

    }
}