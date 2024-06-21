public class BinaryTree
{
    Node? root;
    public BinaryTree(Node? node = null)
    {
        this.root = node;
    }
    public void InOrderSearch(Node? node = null)
    {
        if (node == null)
            node = root;

        if (node.left != null)
            InOrderSearch(node.left);

        Console.WriteLine(node.value);

        if (node.right != null)
        {
            InOrderSearch(node.right);
        }

    }
    public void insert(int value)
    {
        if (root == null)
        {
            root = new Node(value);
        }
        else
        {
            insert(value, root);
        }
    }
    public void insert(int value, Node node)
    {
        if (value < node.value)
        {
            if (node.left == null)
                node.left = new Node(value);
            else
            {
                insert(value, node.left);
            }

        }
        else
        {
            if (node.right == null)
                node.right = new Node(value);
            else
            {
                insert(value, node.right);
            }

        }


    }

}