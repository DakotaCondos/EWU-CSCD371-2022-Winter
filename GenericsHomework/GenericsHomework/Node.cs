namespace GenericsHomework;

public class Node<TValue>
{
    public TValue Value { get; set; }
    public Node<TValue> Next;
    //public Node<TValue> Next { get; set }

    public Node(TValue value)
    {
        Value = value;
        Next = this;
    }

    public override string ToString()
    {
        string? returnString = null;
        if (Value is not null)
            returnString = Value.ToString();

        if(returnString is null)
            return "";
        return returnString;// check on what to do for this
    }

    //public void SetNext(Node<TValue> newNode)// move later
    //{
    //    Next = newNode;
    //}
    //public static Node<TValue> GetNext(Node<TValue> cursor)// move later
    //{
    //    return cursor.Next;
    //}
}


//use cursor to hold a node as reference