using System;

public class GenericListDemo
{
    static void Main()
    {
        Console.WriteLine("Creating GenericList with capacity 1.");
        GenericList<int> list = new GenericList<int>(1);

        Console.WriteLine("Adding some elements.");
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list);

        Console.WriteLine("Now Capacity is: {0}, Count is: {1}", list.Capacity, list.Count);

        Console.WriteLine("Inserting 100 at position 0");
        list.Insert(0, 100);
        Console.WriteLine(list);
        Console.WriteLine("Inserting 200 at position 4");
        list.Insert(4, 200);
        Console.WriteLine(list);

        Console.WriteLine("Removing element at position 0");
        list.RemoveAt(0);
        Console.WriteLine(list);

        Console.WriteLine("Trying to find element with value 200");
        int index = list.IndexOf(200);
        if (index >= 0)
        {
            Console.WriteLine("Element found at position: {0}", index);
        }
        else
        {
            Console.WriteLine("Element was not found.");
        }

        Console.WriteLine("Min element: {0}", list.Min<int>());
        Console.WriteLine("Max element: {0}", list.Max<int>());

        Console.WriteLine("Clearing the list.");
        list.Clear();
        Console.WriteLine("After clearing Capacity is: {0}, Count is: {1}.", list.Capacity,
            list.Count);
    }
}
