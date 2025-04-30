using System;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            //         Graph test = new Graph();
            //// tutaj dodajemy wezly
            //         test.AddNode(2);
            //         test.AddNode(8);
            //test.AddNode(11);
            //         test.AddNode(19);
            //         test.AddNode(27);
            //         test.AddNode(32);
            //         // tutaj dodajemy polaczenia miedzy wezlami
            //         test.AddConnection(0, 1);
            //         test.AddConnection(0, 2);
            //         test.AddConnection(0, 5);
            //         test.AddConnection(1, 2);
            //         test.AddConnection(1, 3);
            //         test.AddConnection(1, 4);
            //         test.AddConnection(1, 5);
            //         test.AddConnection(2, 3);
            //         test.AddConnection(2, 4);

            //         // wizualizacja grafu
            //         test.Print();
            //// tutaj nalezy zmienic sciezke do zapisu
            //         string sciezkaDoZapisu = @"C:\Users\flipk\Pulpit\Algotytmy i Struktury Danych\Program.cs";
            //         test.Save(sciezkaDoZapisu);

            Graph graph = Graph.ZadanieDomowe();
            graph.Print();
            

            

            


        }
    }
}
