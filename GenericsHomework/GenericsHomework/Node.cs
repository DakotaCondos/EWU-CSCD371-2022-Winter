namespace GenericsHomework
{
    public class Node<TValue>
    {
        public TValue Value { get; set; }
        public Node<TValue> Next { get; private set; } //check on the private set
        
        public Node(TValue value)
        {
            Value = value;
            Next = this;
        }
        public void Append(TValue value)
        {
            Node<TValue> newNode = Next;
        }
        public void Clear()
        {
            Next = this;
        }
        
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}