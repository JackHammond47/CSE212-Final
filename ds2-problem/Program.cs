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
        


        //print products, DO NOT CHANGE
        PrintProducts(productIds);

        //Warehouse recieved 3 new kinds of paper DO NOT CHANGE
        int productId5 = 75263;
        int productId6 = 22581;
        int productId7 = 06057;

        // TODO Add the new products to the set
        

        
        //print products, DO NOT CHANGE
        PrintProducts(productIds);

        //Customer requests if 2 products are in stock DO NOT CHANGE
        int desiredProductId1 = 22581;
        int desiredProductId2 = 67894;
        CheckStock(productIds, desiredProductId1);
        CheckStock(productIds, desiredProductId2);
        
        // TODO Finally, the warehouse sells everything. Remove all products from the set

        

        //print products, DO NOT CHANGE
        PrintProducts(productIds);
    }

    public static void PrintProducts(HashSet<int> productIds)
    {
        // TODO Print out all unique product IDs and the total number of unique IDs
        
    }

    public static void CheckStock(HashSet<int> productIds, int desiredProductId)
    {
        // TODO print "Product in Stock" if in stock, or else print "Product out of stock"
        
    }
}