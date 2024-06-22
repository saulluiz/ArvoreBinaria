public class BinaryTree
{
    Node? root;
    public BinaryTree(Node? node = null)
    {
        this.root = node;
    }
    public void OrderLevelTraversal(Node? node = null)
    {
        Node auxNode;
        if (node == null)
            node = root;

        Queue <Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        while(queue.Count!=0)
        {
            auxNode= queue.Dequeue();
            Console.WriteLine(auxNode.value);
            if(auxNode.left!=null)
            queue.Enqueue(auxNode.left);
            if (auxNode.right != null)

                queue.Enqueue(auxNode.right);


        }

    }
    public void InOrder(Node? node = null)
    {
        if (node == null)
            node = root;

        if (node.left != null)
            InOrder(node.left);

        Console.WriteLine(node.value);

        if (node.right != null)
        {
            InOrder(node.right);
        }

    }  

    public void postOrder(Node? node = null)
    {
        if (node == null)
        {
            node = root;
        }
        if (node.left != null)
            postOrder(node.left);
        if (node.right != null)
            postOrder(node.right);
        Console.WriteLine(node.value);


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