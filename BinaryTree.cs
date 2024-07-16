public class BinaryTree
{
    public Node? root;
    public BinaryTree(Node? node = null)
    {
        this.root = node;
    }
    public void LevelOrderTraversal(Node? node = null)
    {
        System.Console.WriteLine("Level Order Traversal");
        Node auxNode;
        if (root == null)
        {
            System.Console.WriteLine("Arvore vazia");
            return;
        }

        if (node == null)
        {
            node = root;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        while (queue.Count != 0)
        {
            auxNode = queue.Dequeue();
            Console.WriteLine(auxNode.value);
            if (auxNode.left != null)
                queue.Enqueue(auxNode.left);
            if (auxNode.right != null)
                queue.Enqueue(auxNode.right);
        }
    }
    public void InOrderTraversal(Node? node = null)
    {
        if (node == null)
            node = root;
        if (node.left != null)
            InOrderTraversal(node.left);
        Console.WriteLine(node.value);

        if (node.right != null)
        {
            InOrderTraversal(node.right);
        }
    }
    public void PreOrderTraversal(Node? node = null)
    {
        if (node == null)
            node = root;
        Console.WriteLine(node.value);
        if (node.left != null)
            PreOrderTraversal(node.left);
        if (node.right != null)
            PreOrderTraversal(node.right);


    }
    public Node? SearchNode(int value)
    {
        if (root == null)
        {
            Console.WriteLine("Arvore Vazia");
            return null;
        }
        return SearchNode(value, root);


    }
    private Node? SearchNode(int value, Node node)
    {
        if (node == null)
        {
            return null;
        }
        else if (value > node.value)
            return SearchNode(value, node.right);
        else if (value < node.value)
            return SearchNode(value, node.left);
        else return node;

    }

    public void postOrderTraversal(Node? node = null)
    {
        if (node == null)
        {
            node = root;
        }
        if (node.left != null)
            postOrderTraversal(node.left);
        if (node.right != null)
            postOrderTraversal(node.right);
        Console.WriteLine(node.value);
    }
    public virtual void insert(int value)
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

    public virtual void insert(int value, Node node)
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
    public int min(Node node = null)
    {
        if (node == null)
            node = root;
        int value = node.value;
        if (node.left != null)
            value = min(node.left);

        return value;
    }
    public int Height(Node node = null)
    {
        int heightLeft = 0, heightRight = 0, height = 0;
        if (node == null)
            node = root;
        if (node.left != null)
            heightLeft = this.Height(node.left);
        if (node.right != null)
            heightRight = this.Height(node.right);
        height += heightLeft > heightRight ? heightLeft : heightRight;
        return height + 1;

    }
    public virtual Node remove(int value, Node node = null)
    {
        if (root == null)
            throw new Exception("Arvore vazia");
        if (node == null)
            node = root;

        if (value < node.value)
        {
            //recebe o valor retornado e o liga ao resto da arvore. 
            //Quando nao temos nenhuma alteracao, o valor do n� retornado sera o mesmo que 
            //a celula estava ligada anteriormente.
            //Entretanto, quando encontrarmos o valor buscado e remove-lo, o no retornado ser� a subarvore
            //a qual pertencia mas, agora, sem o elemento.
            if (node.left == null)
            {
                Console.WriteLine("valor nao esta presenta na arvore");
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
            //percorri ate encontrar o no com tal valor, agora, preciso retornar a subarvore
            //que ele pertecia, mas agora com ele removido

            //Temos alguns casos
            //1-Removi uma folha
            if (node.left == null && node.right == null)
            {
                return null;
                //O item nao possui filhos, logo, o lugar que ele ocupava devera ficar vazio
                //Essa condicao, na verdade, nao � necessaria pois a implementacao dos outros casos
                //ja cobrem sua funcao. Entretanto, para fim ditatico, vou deixala aqui em conjunto com 
                //essa explicacao
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
        return node;
    }
}