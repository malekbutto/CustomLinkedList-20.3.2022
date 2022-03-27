public class Node<TypeParameter>
{
    public TypeParameter Value { get; set; }
    public Node<TypeParameter> Next;
    public Node<TypeParameter> Previous;
}