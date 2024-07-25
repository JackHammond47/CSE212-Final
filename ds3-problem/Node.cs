public class Node
{
    public int Value { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int value)
    {
        Value = value;
    }

    public void Insert(int value)
    {
        // TODO Implement the insert function, *hint1 if the value is smaller go left, otherwise go right 
        // **hint2 use recurssion and only insert when values are null
    }

    public int FindMin()
    {
        // TODO Implement this function, hint1* think about how BST's are laid out, where is the minimum value on the tree
        // **hint2, if your really sttuggling use recursion to check all the nodes on the left side 
        // and only return the value once you hit a null
        return 0;
    }

    public int FindMax()
    {
        // TODO Implement this function, hint* its the FindMin function in reverse
        return 0;
    }
        
    public void InOrderTraversal()
    {
        if (Left != null) Left.InOrderTraversal();
        Console.Write(Value + " ");
        if (Right != null) Right.InOrderTraversal();
    }
}