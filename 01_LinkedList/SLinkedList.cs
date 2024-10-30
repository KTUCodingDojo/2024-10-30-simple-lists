
using Microsoft.VisualBasic;

namespace _01_LinkedList
{
    public class SLinkedList 
    {
        private SNode head;
        private SNode tail;
        
        public SLinkedList()
        {
            head = null;
        }

        public void Add(string v)
        {
            var newNode = new SNode(v, null);
            if(head is null)
            {
                head = newNode;
                tail = head;
                return;
            }

            tail.Next = newNode;
            tail = tail.Next;

        }

        public string[] Values()
        {
            if(head is null)
            {
                return [];
            }

            return ValuesInternal().ToArray();
        }

        private IEnumerable<string> ValuesInternal()
        {
            for (var curr = head; curr != null; curr = curr.Next)
            {
                yield return curr.Value;
            }
        }
    }
}