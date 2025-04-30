using System;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph test = new Graph();
			// tutaj dodajemy wezly
            test.AddNode(2);
            test.AddNode(5);
			test.AddNode(7);
			// tutaj dodajemy polaczenia miedzy wezlami
            test.AddConnection(1, 2);
			// wizualizacja grafu
            test.Print();
			// tutaj nalezy zmienic sciezke do zapisu
            string sciezkaDoZapisu = @"C:\Users\JCH\Desktop\graph.txt";
            test.Save(sciezkaDoZapisu);
        }
    }
}
