class Program
{
    static void Main()
    {
        Console.WriteLine("Binary Search Tree (smart placement)");

        BinarySearchTree tree = new BinarySearchTree();

        tree.Insert(8);
        tree.Insert(3);
        tree.Insert(4);
        tree.Insert(7);
        tree.Insert(4);

        Console.WriteLine("In-order Traversal:");
        tree.InOrderTraversal();

        Console.WriteLine("");
        Console.WriteLine("Minimum value in the tree: " + tree.FindMin());
        Console.WriteLine("Maximum value in the tree: " + tree.FindMax());
    }
}
