public class AVLTree : BinaryTree
{

    private Node AVLPropriety(Node? node = null)
    {
        if (GetBalanceFactor(node) > 1)
        {
            if (GetBalanceFactor(node.left) < 0)
                node.left = rightRotation(node.left);
            node = leftRotation(node);
        }
        if (GetBalanceFactor(node) < -1)
        {
            if (GetBalanceFactor(node.right) > 0)
                node.right = leftRotation(node.right);
            node = rightRotation(node);
        }
        return node;
    }
    private int GetBalanceFactor(Node? node)
    {
        int rightHeight = 0;
        int leftHeight = 0;
        if (node == null)
            return 0;
        if (node.right != null)
        {
            rightHeight = Height(node.right);
        }
        if (node.left != null)
        {
            leftHeight = Height(node.left);
        }
        return rightHeight - leftHeight;
    }
    private Node leftRotation(Node node)
    {
        Node temp1 = node;
        node = node.right;
        temp1.right = node.left;
        node.left = temp1;
        return node;
    }
    private Node rightRotation(Node node)
    {
        Node temp1 = node;
        node = node.left;
        temp1.left = node.right;
        node.right = temp1;
        return node;
    }
    public override void insert(int value)
    {
        if (root == null)
        {
            root = new Node(value);
        }
        else
        {
            root = insert(value, root);
        }
    }
    public Node insert(int value, Node node)
    {
        if (value < node.value)
        {
            if (node.left == null)
                node.left = new Node(value);
            else
            {
                node.left = insert(value, node.left);
            }
        }
        else
        {
            if (node.right == null)
                node.right = new Node(value);
            else
            {
                node.right = insert(value, node.right);
            }
        }
        return AVLPropriety(node);


    }


public override Node remove(int value, Node node = null)
    {
        if (root == null)
            throw new Exception("Arvore vazia");
        if (node == null)
            node = root;
        if (value < node.value)
        {
            if (node.left == null)
            {
                Console.WriteLine("valor nao esta presente na arvore");
                return node;
            }
            node.left = remove(value, node.left);
        }
        else if (value > node.value)
        {
            if (node.right == null)
            {
                Console.WriteLine("valor nao esta presenta na arvore");

                return node;
            }
            node.right = remove(value, node.right);
        }
        else
        {            
            if (node.left == null && node.right == null)
            {
                return null;               
            }
            if (node.right != null && node.left != null)
            {
                int aux = min(node.right);
                node.right = remove(aux, node.right);
                node.value = aux;
            }
            else if (node.right != null)
            {
                return node.right;
            }
            else
            {
                return node.left;
            }
        }
        AVLPropriety(node);
        return node;
    }
}














   