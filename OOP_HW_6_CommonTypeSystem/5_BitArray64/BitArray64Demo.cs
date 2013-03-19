using System;

class BitArray64Demo
{
    static void Main()
    {
        BitArray64 arr1 = new BitArray64(8UL);
        BitArray64 arr2 = new BitArray64(11239872323123421UL);

        Console.WriteLine("arr1 = {0}", arr1);
        Console.WriteLine("arr2 = {0}", arr2);

        Console.WriteLine("arr1 == arr2 -> {0}", arr1 == arr2);
        Console.WriteLine("arr1 != arr2 -> {0}", arr1 != arr2);

        Console.WriteLine("arr1[5] = {0}", arr1[5]);
        Console.WriteLine("Changing arr1[5] to 1:");
        arr1[5] = 1;
        Console.WriteLine("arr1[5] = {0}", arr1[5]);
        Console.WriteLine("arr1 is now {0}", arr1);

        Console.WriteLine("arr1 hash code = {0}", arr1.GetHashCode());
        Console.WriteLine("arr2 hash code = {0}", arr2.GetHashCode());

        Console.WriteLine("Show arr2 bits as '+' and '-' to test the foreach:");
        foreach (var bit in arr2)
        {
            if (bit == 1)
            {
                Console.Write('+');
            }
            else
            {
                Console.Write('-');
            }
        }
        Console.WriteLine();
    }
}

