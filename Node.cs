public class Node
{
    public Node? right;
    public Node? left;
    public int value;
    public Node(int value,Node? right=null,Node? left=null)
    {
        this.value=value;
        this.right=right;
        this.left=left;
    }
}