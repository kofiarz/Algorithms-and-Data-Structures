using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace Lab6
{
    class SearchSortEngine
    {
        private List<int> numbers;
        private int size;

        public SearchSortEngine(int n)
        {
            //constructor
            if (n > 0) size = n;
            else
            {
                Console.WriteLine("List size cannot be negative - defaulting to 10 instead");
                size = 10;
            }
            numbers = new List<int>(size);
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(rnd.Next(10000));
            }
        }

        // utility methods
        public void Reshuffle()
        {
            // shuffle list contents 
            // Fisher-Yates shuffle algorithm
            Random rnd = new Random();
            int j = size;
            while (j > 1)
            {
                int i = rnd.Next(j);
                j--;
                int tmp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = tmp;
            }
        }
        public void SaveList(string filename)
        {
            // save list to "filename.txt"
            // uwaga dla Panstwa - pliki domyslnie zapisuja sie w folderze aplikacji
            // typowo jest to katalog roboczy -> bin -> Debug (-> netcoreappX.Y jesli taki katalog wystepuje)
            try
            {
                List<String> listStr = numbers.ConvertAll<string>(i => i.ToString()); // convert list<int> to list<string>
                File.WriteAllLines(filename + ".txt", listStr.ToArray()); // write the list 
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be opened or a writing error has occurred:");
                Console.WriteLine(e.Message);
            }
        }
        public void BubbleSort()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
        public void InsertionSort()
        {
            for (int i = 1; i < size; i++)
            {
                int current = numbers[i];
                int j = i - 1;
                while (j >= 0 && current < numbers[j])
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = current;
            }
        }
        public void SelectionSort()
        {
            for (int i = 0; i < size - 1; i++)
            {
                int current = numbers[i];
                int index = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[j] < current)
                    {
                        current = numbers[j];
                        index = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = current;
                numbers[index] = temp;
            }
        }
        public bool LinearSearch(int x)
        {
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] == x) return true;
            }
            return false;
        }
        public bool JumpSearch(int x) //inspiracja z https://www.geeksforgeeks.org/jump-search/
        {
            int step = (int)Math.Sqrt(size);
            int indicator = 0;
            while (numbers[Math.Min(step, size)] < x)
            {
                indicator = step;
                step += (int)Math.Sqrt(size);
                if (indicator >= size) return false;
            }
            while (numbers[indicator] < x)
            {
                indicator++;
                if (indicator == Math.Min(step, size)) return false;
            }
            if (numbers[indicator] == x)
                return true;
            return false;
        }

    }
}
