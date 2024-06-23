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

    private void insert(int value, Node node)
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
        int value=node.value;
        if (node.left != null)
            value = min(node.left);

            return value;
    }
    public int Length(Node node = null)
    {
        int heightLeft = 0, heightRight = 0, height = 0;
        if (node == null)
            node = root;
        if (node.left != null)
            heightLeft = this.Length(node.left);
        if (node.right != null)
            heightRight = this.Length(node.right);
        height += heightLeft > heightRight ? heightLeft : heightRight;
        return height + 1;

    }
    public Node remove(int value, Node node = null)
    {
        if (root == null)
            throw new Exception("Arvore vazia");
        if (node == null)
            node = root;

        if (value < node.value)
        {
            //recebe o valor retornado e o liga ao resto da arvore. 
            //Quando nao temos nenhuma alteracao, o valor do nó retornado sera o mesmo que 
            //a celula estava ligada anteriormente.
            //Entretanto, quando encontrarmos o valor buscado e remove-lo, o no retornado será a subarvore
            //a qual pertencia mas, agora, sem o elemento.
            if (node.left == null)
            {
                Console.WriteLine("valor nao esta presenta na arvore");
                return node;
            }
            node.left = remove(value, node.left);
        }
        else if (value > node.value){
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
                //Essa condicao, na verdade, nao é necessaria pois a implementacao dos outros casos
                //ja cobrem sua funcao. Entretanto, para fim ditatico, vou deixala aqui em conjunto com 
                //essa explicacao
            }
            if (node.right != null && node.left != null)
            {
                int aux = min(node.right);
              node.right=remove(aux, node.right);
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