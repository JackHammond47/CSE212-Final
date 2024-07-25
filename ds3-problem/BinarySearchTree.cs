public class BinarySearchTree{
    private Node? _root;

    public void Insert(int value) {
        if (_root is null)
            _root = new Node(value);
        else
            _root.Insert(value);
    }
    public int FindMin()
    {
        if (_root == null)
            throw new InvalidOperationException("Tree is empty");
        return _root.FindMin();
    }

    public int FindMax()
    {
        if (_root == null)
            throw new InvalidOperationException("Tree is empty");
        return _root.FindMax();
    }
    public void InOrderTraversal()
    {
        if (_root != null)
        {
            _root.InOrderTraversal();
        }
    }
}