# Sets

Sets are an abstract concept in programming and mathematics describing a group of unique elements with no particular order. In C#, a set is implemented alongside another programming principle called hashing. Hashing is simply a technique to store and retrieve date very efficiently. It's a little complicated, but basically hashing refers to a function of assigning a random hash code to a object, and storing it in a table where accessing the data is more efficient. Specifically using hashing is O(1), where arrays are O(n). C# combines these 2 priniciples in a single data structure called HashSet. To summarize:

- Sets- a list of only unique values, where order doesn't matter.

- Hashing - A technique to store, access, and modify data in a much more efficient way using hash codes.

- HashSet- A data structure in C#, it is a set of hash codes. It is useful for being efficient and removing duplicates.

## When to use HashSet

Just as with queues, the best way to know when to use a HashSet is to think about your data. Here are some good questions to ask yourself:

- Do I want to include duplicate values?
- Does order matter?
- Is this a large amount of data?

Remembering that HashSets are really efficient and how they work, if you answered yes to those (especially the first 2), you should use a HashSet.

A real world example would be a database of store memberships. Each person with a membership would have a unique membership ID, so if they try to sign up again it shouldn't create a duplicate entry, order does not matter, and lastly, the amount of entries can be very large. A HashSet is perfect because it automatically removes duplicates, is super efficient and we don't care about order.

## HashSet Functions

There are 5 common functions to know when using HashSets:

- HashSet&lt;T>() - used to declare a HashSet of data type T.
- Add(value) - adds "value" to the set.
- Remove(value) - removes "value" from the set.
- Contains(value) - returns a boolean based on if "value" is in the set.
- .Count - returns the size of the set.

## Example

You can run the code below at [HashSet_Example](ds2-example/Program.cs)

```csharp
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
```

## Problem: Processing Orders

Please do your work in this file: [Problem](ds2-problem/Program.cs)

Continuing with the Paper Company story, you are not tasked with created a way to store the product ID's of everything currently in stock. If something comes in that is already in stock, you don't need to duplicate it and order doesn't matter. For this reason you should create a HashSet to store product ID's, and write a program that handles adding new inventory, checking if a product is in stock, and removing inventory.

Requirements:

- Use a HashSet and only use the functions described above.
- Write function to print out the list of products and size of the set after every change to the inventory.
- Write function to print out if a product ID is in the set.
- Whenever there is inventory changes, Add or Remove product ID's from the set.

When you are finished, you should see this in the terminal:

```
Unique Product IDs:
12345
67890
54321
Total unique IDs: 3

Unique Product IDs:
12345
67890
54321
75263
22581
6057
Total unique IDs: 6

Product in stock

Product out of stock

Unique Product IDs:
Total unique IDs: 0
```

(Please don't look at solution until you have tried on your own first)

You can check your code with the solution here: [Solution](ds2-solution/Program.cs)



[Back to Welcome Page](0-welcome.md)