public class BinaryTree{
    private Node? _root;

    public void Insert(int value) {
        if (_root is null)
            _root = new Node(value);
        else
            _root.Insert(value);
    }
    public void InOrderTraversal()
    {
        if (_root != null)
        {
            _root.InOrderTraversal();
        }
    }
}