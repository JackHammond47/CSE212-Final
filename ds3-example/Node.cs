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
        if (value != Value)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(1,11);
            if (randNum <= 5)
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

    public void InOrderTraversal()
    {
        if (Left != null) Left.InOrderTraversal();
        Console.Write(Value + " ");
        if (Right != null) Right.InOrderTraversal();
    }
}