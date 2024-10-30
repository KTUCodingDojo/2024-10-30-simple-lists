
using Microsoft.VisualBasic;

namespace _01_LinkedList
{
    public class SLinkedList 
    {
        private SNode head;
        
        public SLinkedList()
        {
            head = null;
        }

        public void Add(string v)
        {
            var newNode = new SNode(v);
            head = newNode;
        }

        public string[] Values()
        {
            if(head is null)
            {
                return [];
            }

            return [head.Value];
        }
    }
}