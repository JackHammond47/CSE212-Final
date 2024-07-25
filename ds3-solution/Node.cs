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
        if (value != Value)
        {
            if (value < Value) 
            {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
            }
            else 
            {
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public int FindMin()
    {
        // TODO Implement this function, hint1* think about how BST's are laid out, where is the minimum value on the tree
        // **hint2, if your really sttuggling use recursion to check all the nodes on the left side 
        // and only return the value once you hit a null
        if (Left == null) return Value;
        return Left.FindMin();
    }

    public int FindMax()
    {
        // TODO Implement this function, hint* its the FindMin function in reverse
        if (Right == null) return Value;
        return Right.FindMax();
    }
        
    public void InOrderTraversal()
    {
        if (Left != null) Left.InOrderTraversal();
        Console.Write(Value + " ");
        if (Right != null) Right.InOrderTraversal();
    }
}