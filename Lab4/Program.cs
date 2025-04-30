using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = ZadanieDomowe.Read();

            // A
            List<string> answerA = words.FindAll(strings => strings.Length == 13);
            foreach (string word in answerA) Console.WriteLine(word);
            Console.WriteLine();

            // B
            List<char> answerB = words.Select(strings => strings[0]).ToList();
            for (int i = 0; i < 20; i++) Console.WriteLine(answerB[i]);
            Console.WriteLine();

            // C inspiracja z https://docs.microsoft.com/pl-pl/dotnet/api/system.string.replace?view=net-6.0
            List<string> answerC = words.Select(strings => 
            strings.Replace('ą','e').Replace('e','ę').Replace('ę','i').Replace('i','o').Replace('o','ó').Replace('ó','u').Replace('u','y').Replace('y','a')).ToList();
            for (int i = 0; i < 20; i++) Console.WriteLine(answerC[i]);
            Console.WriteLine();

            // D
            string answerD = words.FindAll(strings => strings.Length > 1).FindAll(strings => strings[1].ToString() == "a")[0];
            Console.WriteLine(answerD);
            Console.WriteLine();

            // E
            //double answerE = ???
            //Console.WriteLine("{0:0.0}", answerE);
            //Console.WriteLine(); 

            // F
            //bool answerF = ???
            //Console.WriteLine(answerF);
            //Console.WriteLine(); 

            // G
            int answerG = words.Aggregate(0, (agg, x) => agg + x.Length);
            Console.WriteLine(answerG);
            Console.WriteLine(); 

            // H
            //string answerH = ???
            //Console.WriteLine(answerH);
            //Console.WriteLine();

            // I
            //List<string> answerI = ???
            //foreach (string word in answerI) Console.WriteLine(word);
            //Console.WriteLine();

            // J
            //List<string> answerJ = ???
            //foreach (string word in answerJ) Console.WriteLine(word);
            //Console.WriteLine();
        }
		
    }
}
