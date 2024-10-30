namespace _01_LinkedList
{
    public class SNode
    {
        public string Value { get; }
        public SNode Next { get; set; }

        public SNode(string value, SNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }

        public SNode(string value)
        {
            Value = value;
        }
    }
}