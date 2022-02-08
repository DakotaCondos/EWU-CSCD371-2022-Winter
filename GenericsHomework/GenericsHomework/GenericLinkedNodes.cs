namespace GenericsHomework;

public class GenericLinkedNodes<TValue>
{
    Node<TValue>? cursor;

    GenericLinkedNodes()
    {
        cursor = null;
    }

    public void Append(TValue value)
    {
        Node<TValue> newNode = new(value);
        //starting at cursor, walk to end (until node.next is cursor again,) then add
        if (cursor is null)
        {
            cursor = newNode;
        }
        else
        {
            Node<TValue> lastInLine = GenericLinkedNodes<TValue>.Traverse(cursor);
            lastInLine.Next = newNode;
        }
    }

    private static Node<TValue> Traverse(Node<TValue> cursor)
    {
        Node<TValue> curentNode = cursor;
        while (curentNode.Next != cursor)
        {
            curentNode = curentNode.Next;
        }
        return curentNode;
    }
}

