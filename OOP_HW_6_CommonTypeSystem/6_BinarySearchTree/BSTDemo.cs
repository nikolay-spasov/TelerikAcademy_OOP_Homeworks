using System;
using _6_BinarySearchTree.BST;
using System.Collections.Generic;

class BSTDemo
{
    static void Main()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>(new int[]
        {
            3, 1, 5, 2, 4
        });

        var cloning = tree.Clone() as BinarySearchTree<int>;

        Console.WriteLine("The tree: \n{0}", tree);
        Console.WriteLine("The cloning: \n{0}", cloning);

        Console.WriteLine("tree == cloning -> {0}", tree == cloning);
        Console.WriteLine("tree != cloning -> {0}", tree != cloning);

        Console.WriteLine("Deleting 3 and 4 from the cloning and Inserting 20 and -3.");
        cloning.Remove(3);
        cloning.Remove(4);
        Console.WriteLine("After deleting 3 and 4 from the cloning the cloning is: \n{0}", cloning);

        cloning.Insert(20);
        cloning.Insert(-3);
        Console.WriteLine("Now inserting 20 and -3 to the cloning. \nThe cloning is now: \n{0}", cloning);
        Console.WriteLine("tree == cloning -> {0}", tree == cloning);
        Console.WriteLine("tree != cloning -> {0}", tree != cloning);

        Console.WriteLine("\nHash codes:");
        Console.WriteLine("tree -> {0} \ncloning -> {1}", tree.GetHashCode(), cloning.GetHashCode());

        Console.WriteLine("\ncloning Min = {0} \ncloning Max = {1}", cloning.Min, cloning.Max);

        Console.WriteLine("\ncloning.ContainsKey(100) -> {0}", cloning.ContainsKey(100));
        Console.WriteLine("cloning.ContainsKey(20) -> {0}", cloning.ContainsKey(20));

        Console.WriteLine();
    }
}

