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