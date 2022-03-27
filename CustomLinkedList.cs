using System.Collections;
public class CustomLinkedList<TypeParameter>
{
    public Node <TypeParameter>? First;
    public Node <TypeParameter>? Current;
    public Node <TypeParameter>? Previous;
    public Node <TypeParameter>? Last;

    public CustomLinkedList()
    {
        Previous = null;
    }
    public void Add(TypeParameter value)
    {
        Last = new Node<TypeParameter>();
        Last.Value = value;
        Last.Next = null;
        Last.Previous = Previous;

        if (Previous==null)
            First = Last;
        else
            setNextNodeBeforeLast(Last);
        Previous = Last;
    }
    void setNextNodeBeforeLast(Node<TypeParameter> last)
    {
        Current = First;
        while (Current.Next!=null)
            Current = Current.Next;
        Current.Next = last;
    }

    public IEnumerator GetEnumerator()
    {
        Current = First;
        while (Current!=null)
        {
            yield return Current.Value;
            Current = Current.Next;
        }
    }
    public IEnumerable GetEnumerableDESC()
    {
        Current = Last;
        while (Current!=null)
        {
            yield return Current.Value;
            Current = Current.Previous;
        }
    }
}