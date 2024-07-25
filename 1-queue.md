# Dynamic Data Structures- Queues

Previously when writing code and making a list you probably used an Array. Arrays are static data structures, meaning the size doesn't change (static). There are 2 common ways to make a dynamic data structure, or non-fixed size. These are stacks and queues, the only difference is the order in which elements are added and removed.

- Stacks- the last element added is the first one removed (LIFO, last in, first out). Think of this like a stack of plates, you can only grab the top plate, which is the last plate added to the pile.

- Queues- the first element added to the queue is the first one to be removed (FIFO, first in, first out). Think of queues like a line at the deli, the first people to grab a number are the closest ones to being helped, the last person who grabbed a number will be the last one helped.

One last note, stacks/queues are very efficient, with a Big O notation of O(1). However, they are limited by only being able to remove the last (stacks) or first (queues) element in the list.

While both data structures are important, today we will be focusing on how to use queues.


## When to use Queues

How should you decide when to use a queue? Why not a stack, array, or another data structure? To answer these questions, let's look at some real world examples. 

Queues are quite useful in a number of applications, some commin uses are task scheduling and order processing. For example, a printer gets many tasks, and it takes real world time to proccess each task. How should the printer decide what order to execute each task? The most fair answer is obvious- it should print the task in the order it recieved them, or in other words, the first one in is the first one out. Sound familiar? (Hint- thats a queue!)

So think about what your data is doing. When are you adding elements, when are you taking them away? If you'd like to process elements like a line at the deli, then use a queue.


## How to use Queues

To use queues in C#, there are a 7 common functions that will help to create/use the queue:

- Queue() or Queue&lt;T>()- declares a new queue, either as generic objects with Queue(), or as a specific type T with Queue&lt;T>(). Generally, it is better to declare what object types will be in the queue, but Queue() is fine when first learning.
- Enqueue(value) - adds "value" to the back of the queue
- Dequeue() - removes and returns the front element of the queue (the first element).
- .Count - returns the size of the queue
- Peek() - returns an first item from the queue without removing it.
- Contains(value)- checks if "value" is in the queue, returns a boolean. Efficiency is O(n) instead of O(1) when using Contains().
- Clear()- removes all elements of a queue.

## Example

You can run the code below at [Queue_Example](ds1-example/Program.cs)

```csharp
using System;
using System.Collections.Generic;
//include these libraries to use queues

class Program
{
    static void Main()
    {
        // Create a queue to represent a task scheduler
        Queue<string> taskQueue = new Queue<string>();

        // Enqueue some tasks
        taskQueue.Enqueue("Task 1");
        taskQueue.Enqueue("Task 2");
        taskQueue.Enqueue("Task 3");

        // Process tasks in the order they were added
        while (taskQueue.Count > 0)
        {
            // Get the task at the front of the queue
            string currentTask = taskQueue.Dequeue();

            // Process the task
            Console.WriteLine("Processing " + currentTask);
        }
    }
}
```

## Problem: Processing Orders

Please do your work in this file: [Problem](ds1-problem/Program.cs)

You are writing code for a paper company to send orders from the customers to the warehouse for delivery. You will recieve order as strings in the form of "Product, Quantity, Address". To keep things simple, this will be 1 string and not a dictionary or anything like that. Your task is to create and use a queue to send orders to the warehouse. *Hint, you will only need to use the functions described above.

Requirements:

- Use a queue to add and remove elements.
- Print out elements as they are removed as shown below.
- If any orders say "Invalid Order", print out a seperate message, *hint you could try using Peek().
- Continue removing all elements until the queue is empty.
- Print a finished message when done.

When you are finished, you should see this in the terminal:

```
Sending Order: White Cardstock, 12, 123 Realplace Ave
Sending Order: Yellow Canary, 3, 561 Gable Street
Error: invalid order
Sending Order: Pink Posterboard, 132, 1228 Clearview Blvd
Sending Order: Copier Paper, 500, 236 Offices Lane
No more orders to send.
```

(Please don't look at solution until you have tried on your own first)

You can check your code with the solution here: [Solution](ds1-solution/Program.cs)



[Back to Welcome Page](0-welcome.md)
