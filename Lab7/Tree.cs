using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab7
{
    partial class Tree
    {
        private TreeNode root; // korzen drzewa
        public Tree() // konstruktor
        {
            root = null;
        }
        public void Add(int v) // dodawanie nowych elementow
        {
            if (root == null) root = new TreeNode(v); // jesli drzewo jest puste, to stworz korzen
            else root.Add(v); // jesli drzewo nie jest puste, wywolaj odpowiednia metode z klasy TreeNode
        }
        public bool Search(int v)
        {
            if (root == null) return false; // jesli drzewo jest puste, to nic nie znajdziemy
            else return root.Search(v); // jesli drzewo nie jest puste, wywolaj odpowiednia metode z klasy TreeNode
        }

        // ponizej znajduje sie kod pomocniczy dla zadania 3 i zadania domowego
        public void Print()
        {
            TreePrint.Print(root);
        }
        public static Tree ZadanieDomowe()
        {
            Tree ans = new Tree();
            Random rng = new Random();
            int extraSize = rng.Next(10);
            for (int i = 0; i < 10; i++) ans.Add(rng.Next(100));
            ans.Add(49);
            for (int i = 0; i < 10 + extraSize; i++) ans.Add(rng.Next(100));
            return ans;
        }
        public static Tree Zadanie3()
        {
            Tree drzewo3 = new Tree();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) drzewo3.Add(rnd.Next(50));
            return drzewo3;
        }
        public int MinValue()
        {
            if (root == null) return -1; // jesli drzewo jest puste, to nic nie znajdziemy
            return root.Min();
        }
        public int MaxValue()
        {
            if (root == null) return -1; // jesli drzewo jest puste, to nic nie znajdziemy
            return root.Max(); // jesli drzewo nie jest puste, wywolaj odpowiednia metode z klasy TreeNode
        }
        public int SumValues()
        {
            if (root == null) return 0;
            return root.Sum();
        }
        public int CountAllLinks()
        {
            if (root == null) return 0;
            return root.Links();
        }
        public int Depth(int value)
        {
            if (root == null) return -1;
            return root.Dep(value);
        }
    }
}
