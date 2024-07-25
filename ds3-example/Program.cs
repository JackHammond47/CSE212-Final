class Program
{
    static void Main()
    {
        Console.WriteLine("Binary Tree (random node placement)");

        BinaryTree tree = new BinaryTree();

        tree.Insert(8);
        tree.Insert(3);
        tree.Insert(4);
        tree.Insert(7);
        tree.Insert(4);

        Console.WriteLine("In-order Traversal:");
        tree.InOrderTraversal();
    }
}
