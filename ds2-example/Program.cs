using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new HashSet
        HashSet<int> mySet = new HashSet<int>();

        // Add elements to the HashSet
        mySet.Add(1);
        mySet.Add(2);
        mySet.Add(3);

        Console.WriteLine("Elements after adding 1, 2, 3:");
        foreach (int item in mySet)
        {
            Console.WriteLine(item);
        }

        // Check if an element is in the HashSet
        bool containsTwo = mySet.Contains(2);
        Console.WriteLine($"Set contains 2: {containsTwo}");

        // Remove an element from the HashSet
        mySet.Remove(2);
        Console.WriteLine("Elements after removing 2:");
        foreach (int item in mySet)
        {
            Console.WriteLine(item);
        }

        // Get the number of elements in the HashSet
        int size = mySet.Count;
        Console.WriteLine($"Size of the set: {size}");
    }
}