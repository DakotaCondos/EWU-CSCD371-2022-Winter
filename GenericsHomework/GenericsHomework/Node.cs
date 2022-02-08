namespace GenericsHomework
{
    public class Node<TValue> where TValue : notnull
    {
        public Node(TValue value)
        {
            Value = value;
        }
        public TValue Value { get; set; }
        public Node<TValue> Next { get; private set; }
        public void Append(TValue value)
        {
            Node<TValue> newNode = Next;
        }
        public void Clear()
        {

        }
        
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}