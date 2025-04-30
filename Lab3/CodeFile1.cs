using System;
using System.Collections.Generic; 
namespace Laby3
{
    class Zadanie_3
    {
        static void Main(string[] args)
        {
            List<HighestPeak> country_peaks = Homework.CreateList();
  
            int sum = 0;
            int counter = 0;
            for (int j = 0; j < country_peaks.Count; j++)
            {
                sum += country_peaks[j].Elevation;
                counter++;
                if (country_peaks[j].Country == "Austria")
                {
                    Console.Write("A: ");
                    country_peaks[j].ShowInfo();
                }
                if (j == country_peaks.Count - 2)
                {
                    Console.Write("B: ");
                    country_peaks[j].ShowInfo();
                }
            }
            Console.WriteLine("C: ");
            for (int j = 0; j < country_peaks.Count; j++)
                {
                    if (country_peaks[j].Elevation > 4000 & country_peaks[j].Elevation < 5000)
                    {
                        country_peaks[j].ShowInfo();
                    }
                }
            Console.WriteLine("D: " + sum/counter);
            Console.WriteLine("E: ");

            int max = country_peaks[0].Elevation;
            int min = country_peaks[0].Elevation;
            HighestPeak maxpeak = country_peaks[0];
            HighestPeak minpeak = country_peaks[0];
            for (int j = 1; j < country_peaks.Count; j++)
            {
                if (country_peaks[j].Elevation > max)
                {
                    max = country_peaks[j].Elevation;
                    maxpeak = country_peaks[j];
                }
                if (country_peaks[j].Elevation < min)
                {
                    min = country_peaks[j].Elevation;
                    minpeak = country_peaks[j];
                }
            }
            int len = max - min + 1;
            List<int> sorted_values = new List<int>();
            for (int i = 0; i < len; i++)
            {
                sorted_values.Add(min + i);
            }
            List<HighestPeak> sorted = new List<HighestPeak>();
            for (int i = min; i < sorted_values.Count; i++)
            {
                for (int j = 0; j < country_peaks.Count; j++)
                {
                    if (i == country_peaks[j].Elevation )
                    {
                        sorted.Add(country_peaks[j]);
                    }
                }
            }
            for (int i = 0; i < 10; i ++)
            {
                sorted[i].ShowInfo();
            }

            Dictionary<string, double> country_population = Homework.CreateDictionary();
            foreach (KeyValuePair<string, double> i in country_population)
            {
                if (i.Value == 5.5)
                {
                    Console.WriteLine("F: " + i);
                }
            }

        }
    }
}