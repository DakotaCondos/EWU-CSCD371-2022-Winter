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
        if (cursor is null)
        {
            cursor = newNode;
        }
        else
        {
            Node<TValue> lastInLine = GenericLinkedNodes<TValue>.TraverseToLast(cursor);
            lastInLine.Next = newNode;
            newNode.Next = cursor;
        }
    }
    private static Node<TValue> Traverse(Node<TValue> curentNode)
    {
        return curentNode.Next;
    }

    private static Node<TValue> TraverseToLast(Node<TValue> cursor)
    {
        Node<TValue> curentNode = cursor;
        while (curentNode != cursor)
        {
            Traverse(curentNode);
        }
        return curentNode;
    }
    public void Clear()
    {
        if (cursor is not null)
            cursor.Next = cursor;
    }

}

