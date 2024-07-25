using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //List of Product IDs and set of product ID's, DO NOT CHANGE
        int productId1 = 12345;
        int productId2 = 67890;
        int productId3 = 12345;
        int productId4 = 54321;
        HashSet<int> productIds = new HashSet<int>();

        // TODO Initial inventory, add all the product IDs
        productIds.Add(productId1);
        productIds.Add(productId2);
        productIds.Add(productId3);
        productIds.Add(productId4);

        //print products, DO NOT CHANGE
        PrintProducts(productIds);

        //Warehouse recieved 3 new kinds of paper DO NOT CHANGE
        int productId5 = 75263;
        int productId6 = 22581;
        int productId7 = 06057;

        // TODO Add the new products to the set
        productIds.Add(productId5);
        productIds.Add(productId6);
        productIds.Add(productId7);
        
        //print products, DO NOT CHANGE
        PrintProducts(productIds);

        //Customer requests if 2 products are in stock DO NOT CHANGE
        int desiredProductId1 = 22581;
        int desiredProductId2 = 67894;
        CheckStock(productIds, desiredProductId1);
        CheckStock(productIds, desiredProductId2);
        
        // TODO Finally, the warehouse sells everything. Remove all products from the set

        productIds.Remove(productId1);
        productIds.Remove(productId2);
        productIds.Remove(productId3);
        productIds.Remove(productId4);
        productIds.Remove(productId5);
        productIds.Remove(productId6);
        productIds.Remove(productId7);

        //print products, DO NOT CHANGE
        PrintProducts(productIds);
    }

    public static void PrintProducts(HashSet<int> productIds)
    {
        // TODO Print out all unique product IDs and the total number of unique IDs
        Console.WriteLine("Unique Product IDs:");
        foreach (int id in productIds)
        {
            Console.WriteLine(id);
        }

        Console.WriteLine($"Total unique IDs: {productIds.Count}");
        Console.WriteLine();
    }

    public static void CheckStock(HashSet<int> productIds, int desiredProductId)
    {
        // TODO print "Product in Stock" if in stock, or else print "Product out of stock"
        if (productIds.Contains(desiredProductId))
            Console.WriteLine("Product in stock");
        else
            Console.WriteLine("Product out of stock");
        Console.WriteLine();
    }
}