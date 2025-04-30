using System;
using System.Collections.Generic;
using System.IO;

namespace Lab4
{
    class ZadanieDomowe
    {
        public static List<string> Read()
        {
            //tutaj nalezy zmienic sciezke do pliku
            string filepath = @"C:\Users\flipk\Pulpit\Algotytmy i Struktury Danych\Lab4\Księga_pierwsza.txt"; 

            // wczytywanie
            try
            {
                StreamReader sr = new StreamReader(filepath);
                List<string> ans = new List<string>();
                string line = sr.ReadLine();
                while (line != null)
                {
                    ans.AddRange(line.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                    line = sr.ReadLine();
                }
                sr.Close();
                return ans;
            }
            catch(Exception e)
            {
                Console.WriteLine("Nie udalo sie wczytac pliku ze sciezki " + filepath + ": " + e.Message);
                return new List<string>();
            } 
        }


    }
}
