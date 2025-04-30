using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace B8
{
    class Graph
    {
        // class representing an undirected graph
        public SquareMatrix AdjacencyMatrix { get; private set; } // not meant to be used directly, but gettable just in case
        public List<int> NodeValues { get; private set; } // same as above
        public Graph()
        {
            // initialize empty matrix and empty list
            AdjacencyMatrix = new SquareMatrix(0);
            NodeValues = new List<int>();
        }
        public void AddNode(int value)
        {
            NodeValues.Add(value); // add new node
            AdjacencyMatrix.Grow(); // increase adjacency matrix size by 1
        }
        public void AddConnection(int x1, int x2)
        {
            if (x1 < 0 || x2 < 0 || x1 >= NodeValues.Count || x2 >= NodeValues.Count)
            {
                Console.WriteLine("Blad: indeksy macierzy musza byc nieujemne i nie moga byc wieksze niz rozmiar macierzy");
                return;
            }
            if (x1 == x2)
            {
                Console.WriteLine("Blad: polaczenia do samego siebie sa niedozwolone");
                return;
            }
            AdjacencyMatrix[x1, x2] = 1; // 1 represents a conection, 0 represents no connection
            AdjacencyMatrix[x2, x1] = 1; // we model an undirected graph, so the matrix is always symmetrical
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Printing graph:");
            Console.WriteLine("--------");
            PrintNodes();
            Console.WriteLine("--------");
            PrintMatrix();
            Console.WriteLine("--------");
            Console.WriteLine();
        }
        public void PrintNodes()
        {
            for (int i = 0; i < NodeValues.Count; i++) Console.WriteLine("node" + i + ": " + NodeValues[i]);
        }
        public void PrintMatrix()
        {
            AdjacencyMatrix.Print();
        }
        public void Save(string filepath)
        {
            // writing to a file
            try
            {
                StreamWriter sr = new StreamWriter(filepath, false);
                sr.WriteLine("Matrix:");
                for (int i = 0; i < NodeValues.Count; i++)
                {
                    for (int j = 0; j < NodeValues.Count - 1; j++)
                    {
                        sr.Write(AdjacencyMatrix[i, j] + ", ");
                    }
                    sr.Write(AdjacencyMatrix[i, NodeValues.Count - 1]);
                    sr.WriteLine();
                }
                sr.WriteLine("\nNodes:");
                for (int i = 0; i < NodeValues.Count; i++) sr.WriteLine(NodeValues[i]);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie udalo sie zapisac pliku " + filepath + ": " + e.Message);
            }
        }


        // na potrzeby zadania domowego
        public static Graph ZadanieDomowe()
        {
            int seed = 1234;
            Graph ans = new Graph();
            Random rng = new Random(15);
            int extraSize = rng.Next(5);
            for (int i = 0; i < 2; i++) ans.AddNode(rng.Next(100));
            ans.AddNode(49);
            for (int i = 0; i < 2 + extraSize; i++) ans.AddNode(rng.Next(100));
            int connections = ans.NodeValues.Count + 5 + rng.Next(5);
            for (int i = 0; i < connections; i++)
            {
                int x1 = rng.Next(ans.NodeValues.Count);
                int x2 = rng.Next(ans.NodeValues.Count);
                if (x1 == x2) continue;
                ans.AddConnection(x1, x2);
            }
            return ans;
        }
    }
}
