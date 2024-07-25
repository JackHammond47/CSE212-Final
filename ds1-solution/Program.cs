    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            //List of Orders, DO NOT CHANGE
            string order1 = "White Cardstock, 12, 123 Realplace Ave";
            string order2 = "Yellow Canary, 3, 561 Gable Street";
            string order3 = "Invalid Order";
            string order4 = "Pink Posterboard, 132, 1228 Clearview Blvd";
            string order5 = "Copier Paper, 500, 236 Offices Lane";

            //Declare a new Queue, and add all the orders
            Queue<string> orders = new Queue<string>();

            orders.Enqueue(order1);
            orders.Enqueue(order2);
            orders.Enqueue(order3);
            orders.Enqueue(order4);
            orders.Enqueue(order5);

            //remove and print out all elements of the queue until empty, handle any orders that say "Invalid Order"
            while (orders.Count > 0)
            {
                if (orders.Peek() == "Invalid Order")
                {
                    Console.WriteLine("Error: invalid order");
                    orders.Dequeue();
                }
                else
                {
                    string currentOrder = orders.Dequeue();
                    Console.WriteLine($"Sending Order: {currentOrder}");
                }
            }

            //print out closing message when done
            Console.WriteLine("No more orders to send.");
        }
    }