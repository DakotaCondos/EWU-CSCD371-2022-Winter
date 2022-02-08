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
        //Throw an error on an attempt to Append a duplicate value.
        if (Exists(value))
            throw new ArgumentException($"Duplicte value {value} not allowed");

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
        while (curentNode.Next != cursor)
        {
            Traverse(curentNode);
        }
        return curentNode;
    }
    /*
     * Add a Clear method that effectively removes all items from a list except the
     * current node. Pay attention as to whether you should be concerned with the following:
     * Whether it is sufficient to only set Next to itself ❌✔
     * Whether to set the removed items to circle back on themselves. In other words, whether 
     * to close the loop of the removed items.  (Provide a test to show why this is required if it is required). ❌✔
     * Given there is a circular list of items, provide a comment to indicate whether you need to worry about 
     * garbage collection because all the items point to each other and therefore may never be garbage collected. ❌✔
     */

    public void Clear()
    {
        // I believe garbage collection picks up objects once they are no loger referenced, so removing the only reference
        // to the next node would delete it, and subsequently delete the node it WAS pointing to because that no longer has
        // a reference and etc...
        if (cursor is not null)
            cursor.Next = cursor;
    }

    public bool Exists(TValue value)
    {
        if (cursor is null || value is null)
        {
            return false;
        }

        Node<TValue> curentNode = cursor;

        do
        {
            if (value.Equals(curentNode.Value))
                return true;
            Traverse(curentNode);
        } while (curentNode.Next != cursor);

        return false;
    }

}

